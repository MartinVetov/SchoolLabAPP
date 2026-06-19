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
        private readonly string reportsPath =
            Path.Combine(Application.StartupPath, "Reports");

        public UserReportPanel(LoanService loanService, AssetService assetService, int personId,
                               UserService userService, RoleService roleService, PersonService personService,
                               SchoolLabAppDbContext context)
        {
            InitializeComponent();
            _loanService = loanService;
            _assetService = assetService;
            _personId = personId;
            _userService = userService;
            _roleService = roleService;
            _personService = personService;
            _context = context;
        }

        private void btnUserReportPanelSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserReportPanelReport.Text))
            {
                MessageBox.Show(
                    "Please write a report before sending.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                if (!Directory.Exists(reportsPath))
                    Directory.CreateDirectory(reportsPath);

                string fileName =
                    $"report_{DateTime.Now:yyyyMMdd_HHmmss}.txt";

                string fullPath =
                    Path.Combine(reportsPath, fileName);

                File.WriteAllText(fullPath, txtUserReportPanelReport.Text);

                MessageBox.Show(
                    "Report sent and saved.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnUserReportPanelBackToLoans_Click(object sender, EventArgs e)
        {
            var user = new UserLoanPanel(_loanService, _assetService, _personId, _userService, _roleService, _personService, _context);
            this.Hide();
            user.FormClosed += (s, args) => this.Close();
            user.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnBackarrow_Click(object sender, EventArgs e)
        {
            var user = new UserLoanPanel(_loanService, _assetService, _personId, _userService,_roleService,_personService,_context);
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
            _userService.Logout();
            var login = new Login(_userService, _roleService, _context, _personService);
            this.Hide();
            login.FormClosed += (sender, e) => this.Close();
            login.ShowDialog();
        }
    }
}