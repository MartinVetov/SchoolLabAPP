using Microsoft.EntityFrameworkCore;
using SchoolLabApp.Data;
using SchoolLabApp.Services;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SchoolLabApp.View
{
    public partial class UserReturnPanel : Form
    {
        private readonly LoanService _loanService;
        private readonly AssetService _assetService; 
        private readonly UserService _userService;
        private readonly RoleService _roleService;
        private readonly PersonService _personService;
        private readonly SchoolLabAppDbContext _context;
        private readonly int _personId;
        private readonly Logger.Logger _logger;

        public UserReturnPanel(LoanService loanService, AssetService assetService, int personId,
                               UserService userService, RoleService roleService, PersonService personService,
                               SchoolLabAppDbContext context, Logger.Logger logger)
        {
            InitializeComponent();
            _loanService = loanService;
            _assetService = assetService;
            _personId = personId;
            _userService = userService;
            _roleService = roleService;
            _personService = personService;
            _context = context;
            _logger = logger;
        }

        private async void UserReturnPanel_Load(object sender, EventArgs e)
        {
            try
            {
                _logger.Info($"Loading loans for person {_personId}");

                var loans = await _loanService.GetLoansByPerson(_personId);
                listBoxUserReturnPanel.Items.Clear();
                foreach (var l in loans)
                {
                    var returnDate = l.StartDate.AddDays(l.DurationDays);
                    if (returnDate == DateTime.Today)
                    {
                        listBoxUserReturnPanel.Items.Add($"{l.Id} | {l.Asset?.Name} | {l.Status} | Started: {l.StartDate:d} | YOU HAVE TO RETURN THIS ITEM TODAY");
                    }
                    else if (returnDate < DateTime.Today)
                    {
                        listBoxUserReturnPanel.Items.Add($"{l.Id} | {l.Asset?.Name} | {l.Status} | Started: {l.StartDate:d} | Your tax for not returnig the item is 10€");
                    }
                    else
                    {
                        listBoxUserReturnPanel.Items.Add($"{l.Id} | {l.Asset?.Name} | {l.Status} | Started: {l.StartDate:d} | Return date:{returnDate:d}");
                    }
                }

                _logger.Info($"Loaded {loans.Count()} loans for person {_personId}");
            }
            catch (InvalidOperationException ex)
            {
                _logger.Error($"Fail to loan | {ex.Message}");

                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                _logger.Error($"Fail to loan | {ex.Message}");

                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void btnUserReturnePanelReturn_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxUserReturnPanel.SelectedItem == null)
                {
                    _logger.Warn("Return failed: no loan selected.");
                    throw new ArgumentException("Select a loan to return.");
                }
                if (listBoxUserReturnPanel.SelectedItem.ToString()!.Split('|')[2].Trim().Contains("Returned"))
                {
                    _logger.Warn("Return failed: loan already returned.");

                    MessageBox.Show("You already returend this item",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                int loanId = int.Parse(listBoxUserReturnPanel.SelectedItem.ToString()!.Split('|')[0].Trim());

                _logger.Info($"Returning loan {loanId}");

                await _loanService.ReturnLoan(loanId);

                int assetId = await _loanService.GetAssetId(loanId);

                await _assetService.UpdateStatus(assetId, "Available");

                _logger.Info($"Loan {loanId} returned successfully. Asset {assetId} marked Available.");

                MessageBox.Show("Asset returned.", 
                    "Success", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                LoadLoans();
            }
            catch (InvalidOperationException ex)
            {
                _logger.Error($"Fail to return | {ex.Message}");

                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                _logger.Error($"Fail to return | {ex.Message}");

                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        public async Task LoadLoans()
        {
            try
            {
                _logger.Info($"Refreshing loans list for person {_personId}");

                var loans = await _loanService.GetLoansByPerson(_personId);
                listBoxUserReturnPanel.Items.Clear();
                foreach (var l in loans)
                {
                    var returnDate = l.StartDate.AddDays(l.DurationDays);
                    if (returnDate == DateTime.Today )
                    {
                        listBoxUserReturnPanel.Items.Add($"{l.Id} | {l.Asset?.Name} | {l.Status} | Started: {l.StartDate:d} | YOU HAVE TO RETURN THIS ITEM TODAY");
                    }
                    else if(returnDate < DateTime.Today)
                    {
                        listBoxUserReturnPanel.Items.Add($"{l.Id} | {l.Asset?.Name} | {l.Status} | Started: {l.StartDate:d} | Your tax for not returnig the item is 10€");
                    }
                    else
                    {
                        listBoxUserReturnPanel.Items.Add($"{l.Id} | {l.Asset?.Name} | {l.Status} | Started: {l.StartDate:d} | {returnDate:d}");
                    }
                }

                _logger.Info($"Loans list refreshed successfully");
            }
            catch (InvalidOperationException ex)
            {
                _logger.Error($"Fail to load loans | {ex.Message}");

                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                _logger.Error($"Fail to load loans | {ex.Message}");

                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void btnUserReturnePanelBackToLoans_Click(object sender, EventArgs e)
        {
            _logger.Info("Opening user loan panel");

            var loan = new UserLoanPanel(_loanService, _assetService, _personId,_userService,_roleService,_personService,_context, _logger);
            this.Hide();
            loan.FormClosed += (sender, e) => this.Close();
            loan.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _logger.Info("Closing application");
            Application.Exit();
        }

        private void btnMinimize_Click_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnBackarrow_Click(object sender, EventArgs e)
        {
            _logger.Info("Opening user loan panel");

            var user = new UserLoanPanel(_loanService, _assetService, _personId, _userService, _roleService, _personService, _context,_logger);
            this.Hide();
            user.FormClosed += (s, args) => this.Close();
            user.ShowDialog();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void DragArea_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            _logger.Info("User logging out");

            _userService.Logout();
            var login = new Login(_userService, _roleService, _context, _personService,_logger);
            this.Hide();
            login.FormClosed += (sender, e) => this.Close();
            login.ShowDialog();
        }
    }
}
