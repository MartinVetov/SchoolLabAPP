using Microsoft.EntityFrameworkCore;
using SchoolLabApp.Data;
using SchoolLabApp.Services;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SchoolLabApp.View
{
    public partial class UserReportPanel : Form
    {
        private readonly LoanService _loanService;
        private readonly AssetService _assetService;
        private readonly UserService _userService;
        private readonly RoleService _roleService;
        private readonly PersonService _personService;
        private readonly SchoolLabAppDbContext _context;
        private readonly int _personId;
        private readonly Logger.Logger _logger;
        private readonly string reportsPath =
            Path.Combine(Application.StartupPath, "Reports");

        public UserReportPanel(LoanService loanService, AssetService assetService, int personId,
                               UserService userService, RoleService roleService, PersonService personService,
                               SchoolLabAppDbContext context,Logger.Logger logger)
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

        private void btnUserReportPanelSend_Click(object sender, EventArgs e)
        {
            _logger.Info($"User {_userService.GetCurrentUser()?.Username} is creating report.");

            if (string.IsNullOrWhiteSpace(txtUserReportPanelReport.Text))
            {
                _logger.Warn("Report creation failed: Empty report text.");

                MessageBox.Show("Please write a report before sending.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                if (!Directory.Exists(reportsPath))
                {
                    _logger.Info($"Reports directory created: {reportsPath}");
                    Directory.CreateDirectory(reportsPath);
                }

                string fileName =
                    $"report_{DateTime.Now:yyyyMMdd_HHmmss}.txt";

                string fullPath =
                    Path.Combine(reportsPath, fileName);

                File.WriteAllText(fullPath, txtUserReportPanelReport.Text);

                _logger.Info($"Report saved successfully: {fileName}");

                MessageBox.Show("Report sent and saved.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                _logger.Error(ex);

                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnUserReportPanelBackToLoans_Click(object sender, EventArgs e)
        {
            _logger.Info($"User {_userService.GetCurrentUser()?.Username} navigated back to UserLoanPanel.");

            var user = new UserLoanPanel(_loanService, _assetService, _personId, _userService, _roleService, _personService, _context, _logger);
            this.Hide();
            user.FormClosed += (s, args) => this.Close();
            user.ShowDialog();
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
            _logger.Info("Opening user loan panel.");

            var user = new UserLoanPanel(_loanService, _assetService, _personId, _userService,_roleService,_personService,_context, _logger);
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