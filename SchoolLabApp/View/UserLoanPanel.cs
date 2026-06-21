using Microsoft.EntityFrameworkCore;
using SchoolLabApp.Data;
using SchoolLabApp.Models;
using SchoolLabApp.Services;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SchoolLabApp.View
{
    public partial class UserLoanPanel : Form
    {
        private readonly LoanService _loanService;
        private readonly AssetService _assetService;
        private readonly UserService _userService;
        private readonly RoleService _roleService;
        private readonly PersonService _personService;
        private readonly SchoolLabAppDbContext _context;
        private readonly int _personId;
        private readonly Logger.Logger _logger;

        public UserLoanPanel(LoanService loanService, AssetService assetService, int personId,
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

        private async void UserLoanPanel_Load(object sender, EventArgs e)
        {
            await LoadAssets();
        }

        private async Task LoadAssets()
        {
            try
            {
                _logger.Info("Loading assets");
                int categoryId = comboBoxUserLoanPanelCategory.SelectedIndex + 1;
                IEnumerable<Asset> assets;

                if (categoryId > 0)
                {
                    _logger.Info($"Loading assets for category {categoryId}");
                    assets = await _assetService.GetByCategory(categoryId);
                }
                else
                {
                    _logger.Info("Loading all assets");
                    assets = await _assetService.GetAll();
                }
                listBoxUserLoanPanel.Items.Clear();
                foreach (var a in assets)
                {

                    listBoxUserLoanPanel.Items.Add($"{a.Id} | {a.Name} | {a.Status} | {a.Category.Name}");
                }
                _logger.Info($"Loaded {assets.Count()} assets");
            }
            
            catch (ArgumentException ex)
            {
                _logger.Error(ex.Message);

                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ex)
            {
                _logger.Error(ex.Message);

                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                _logger.Error(ex.Message);

                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void btnUserLoanPanelTake_Click(object sender, EventArgs e)
        {
            try
            {
                _logger.Info($"Loan attempt by user {_personId}");

                if (listBoxUserLoanPanel.SelectedItem == null)
                {
                    _logger.Warn("Loan failed: No asset selected");
                    throw new ArgumentException("Select an asset first.");
                }

                if (!int.TryParse(txtUserLoanPanelDuration.Text, out int days) || days <= 0)
                {
                    _logger.Warn($"Loan failed: Invalid duration entered by user {_personId}");
                    throw new ArgumentException("Enter a valid duration in days.");
                }

                int assetId = int.Parse(listBoxUserLoanPanel.SelectedItem.ToString()!.Split('|')[0].Trim());
                

                var asset = await _assetService.GetById(assetId);

                if (asset.Status == "Available")
                {
                    await _loanService.AddLoan(
                        assetId,
                        _personId,
                        days,
                        "Unavailable");

                    asset.Status = "Unavailable";

                    await _assetService.UpdateAsset(asset);

                    _logger.Info(
                        $"Asset loaned successfully. User={_personId}, Asset={asset.Id}, Name={asset.Name}");

                    MessageBox.Show(
                        "Asset loaned successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    await LoadAssets();
                }
                else
                {
                    _logger.Warn($"Loan denied. Asset {asset.Id} is already unavailable.");

                    MessageBox.Show("Asset canot be loaned.", 
                        "Failure", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);

                    await LoadAssets();
                }
            }
            catch (ArgumentException ex)
            {
                _logger.Error($"Loan fail | {ex.Message}");

                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ex)
            {
                _logger.Error($"Loan fail | {ex.Message}");

                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                _logger.Error($"Loan fail | {ex.Message}");

                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnUserLoanPanelReturn_Click(object sender, EventArgs e)
        {
            _logger.Info($"User {_personId} opened Report Panel");
            var returnPanel = new UserReturnPanel(_loanService, _assetService, _personId, _userService, _roleService, _personService, _context, _logger);
            this.Hide();
            returnPanel.FormClosed += (sender, e) => this.Close();
            returnPanel.ShowDialog();
        }

        private void btnUserLoanPanelReport_Click(object sender, EventArgs e)
        {
            _logger.Info($"User {_personId} logged out");

            var reportPanel = new UserReportPanel(_loanService, _assetService, _personId, _userService, _roleService, _personService, _context, _logger);
            this.Hide();
            reportPanel.FormClosed += (sender, e) => this.Close();
            reportPanel.ShowDialog();
        }

        private async void comboBoxUserLoanPanelCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadAssets();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _logger.Info("Closing application");
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
            var login = new Login(_userService, _roleService, _context, _personService, _logger);
            this.Hide();
            login.FormClosed += (sender, e) => this.Close();
            login.ShowDialog();
        }

        private void comboBoxUserLoanPanelCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadAssets();
        }
    }
}
