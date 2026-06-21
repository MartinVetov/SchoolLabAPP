using SchoolLabApp.Data;
using SchoolLabApp.Services;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SchoolLabApp.View
{
    public partial class ReportPanel : Form
    {
        private readonly AssetService _assetService;
        private readonly UserService _userService;
        private readonly RoleService _roleService;
        private readonly PersonService _personService;
        private readonly SchoolLabAppDbContext _context;
        private readonly Logger.Logger _logger;
        private readonly string reportsPath =
            Path.Combine(Application.StartupPath, "Reports");

        public ReportPanel(AssetService assetService, UserService userService, RoleService roleService, PersonService personService, SchoolLabAppDbContext context, Logger.Logger logger)
        {
            _assetService = assetService;
            _userService = userService;
            _roleService = roleService;
            _personService = personService;
            _context = context;

            InitializeComponent();

            LoadReports();
            _logger = logger;
        }

        private void LoadReports()
        {
            try
            {
                _logger.Info("Loading reports.");

                listBoxReportPanel.Items.Clear();

                if (!Directory.Exists(reportsPath))
                {
                    Directory.CreateDirectory(reportsPath);
                    _logger.Info($"Created Reports directory: {reportsPath}");
                }

                string[] files = Directory.GetFiles(reportsPath, "*.txt");

                foreach (string file in files)
                {
                    listBoxReportPanel.Items.Add(Path.GetFileName(file));
                }

                _logger.Info($"Loaded {files.Length} reports.");
            }
            catch (DirectoryNotFoundException ex)
            {
                _logger.Error(ex);

                MessageBox.Show(
                    ex.Message,
                    "Folder Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException ex)
            {
                _logger.Error(ex);

                MessageBox.Show(
                    ex.Message,
                    "Access Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                _logger.Error(ex);

                string fullError =
                    ex.InnerException?.Message ?? ex.Message;

                MessageBox.Show(
                    fullError,
                    "Unexpected Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnReportPanelViewReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxReportPanel.SelectedItem == null)
                {
                    MessageBox.Show(
                        "Select a report first.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                string fileName =
                    listBoxReportPanel.SelectedItem.ToString();

                string fullPath =
                    Path.Combine(reportsPath, fileName);

                txtReportPanelReport.Text =
                    File.ReadAllText(fullPath);

                _logger.Info($"Opening report: {fileName}");
            }
            catch (FileNotFoundException ex)
            {
                _logger.Error(ex);

                MessageBox.Show(
                    ex.Message,
                    "File Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                _logger.Error(ex);

                MessageBox.Show(
                    ex.Message,
                    "Read Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                _logger.Error(ex);

                string fullError =
                    ex.InnerException?.Message ?? ex.Message;

                MessageBox.Show(
                    fullError,
                    "Unexpected Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnReportPanelDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _logger.Info("Attempting to delete report.");

                if (listBoxReportPanel.SelectedItem == null)
                {
                    MessageBox.Show(
                        "Select a report first.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Delete this report?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string fileName =
                        listBoxReportPanel.SelectedItem.ToString();

                    string fullPath =
                        Path.Combine(reportsPath, fileName);

                    if (File.Exists(fullPath))
                    {
                        File.Delete(fullPath);
                    }

                    LoadReports();

                    txtReportPanelReport.Clear();

                    MessageBox.Show(
                        "Report deleted successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    _logger.Info($"Report deleted successfully: {fileName}");
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                _logger.Error(ex);

                MessageBox.Show(
                    ex.Message,
                    "Access Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                _logger.Error(ex);

                MessageBox.Show(
                    ex.Message,
                    "Delete Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                _logger.Error(ex);

                string fullError =
                    ex.InnerException?.Message ?? ex.Message;

                MessageBox.Show(
                    fullError,
                    "Unexpected Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
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

            var currentUser = _userService.GetCurrentUser();

            if (currentUser != null && currentUser.RoleId == 1)
            {
                var admin = new AdminPanel(_userService, _roleService, _assetService, _personService,_logger, _context);
                this.Hide();
                admin.FormClosed += (s, args) => this.Close();
                admin.ShowDialog();

                _logger.Info("Opening AdminPanel.");
            }
            else
            {
                var technician = new TechnicianPanel(_assetService, _userService, _roleService, _personService, _context, _logger);
                this.Hide();
                technician.FormClosed += (s, args) => this.Close();
                technician.ShowDialog();

                _logger.Info("Opening TechnicianPanel.");
            }
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