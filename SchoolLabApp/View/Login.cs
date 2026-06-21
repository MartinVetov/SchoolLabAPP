using SchoolLabApp.Data;
using SchoolLabApp.Repositories.Implementations;
using SchoolLabApp.Services;
using System.Runtime.InteropServices;

namespace SchoolLabApp.View
{
    public partial class Login : Form
    {

        private readonly UserService _userService;
        private readonly RoleService _roleService;
        private readonly PersonService _personService;
        private readonly SchoolLabAppDbContext _context;
        private readonly Logger.Logger _logger;

        public Login(UserService userService, RoleService roleService, SchoolLabAppDbContext context, PersonService personService, Logger.Logger logger)
        {
            InitializeComponent();
            _userService = userService;
            _roleService = roleService;
            _context = context;
            _personService = personService;
            _logger = logger;
        }

        private void checkBoxLogin_CheckedChanged(object sender, EventArgs e)
            => txtLoginPassword.UseSystemPasswordChar = !checkBoxLogin.Checked;

        private async void btnLoginLogin_Click(object sender, EventArgs e)
        {
            try
            {
                _logger.Info($"Login attempt | Username {txtLoginUsername}");

                var user = await _userService.Login(
                    txtLoginUsername.Text.Trim(),
                    txtLoginPassword.Text);

                _logger.Info($"Login attempt successfull | Username {user.Username}");

                this.Hide();

                string role = user.Role?.Name ?? "";

                if (role == "Student" || role == "Teacher")
                {
                    _logger.Info($"Opening UserLoanPanel for {user.Username}");

                    var loanRepo = new LoanRepository(_context);
                    var loanService = new LoanService(loanRepo, _logger);
                    var assetRepo = new AssetRepository(_context);
                    var assetService = new AssetService(assetRepo,_logger);

                    var panel = new UserLoanPanel(loanService, assetService, user.Id,_userService,_roleService,_personService,_context,_logger);
                    this.Hide();
                    panel.FormClosed += (sender, e) => this.Close();
                    panel.ShowDialog();
                }
                else if (role == "Technician")
                {
                    _logger.Info($"Opening TechnicianPanel for {user.Username}");

                    var assetRepo = new AssetRepository(_context);
                    var assetService = new AssetService(assetRepo,_logger);

                    var panel = new TechnicianPanel(assetService, _userService, _roleService,_personService,_context, _logger);
                    this.Hide();
                    panel.FormClosed += (sender, e) => this.Close();
                    panel.ShowDialog();
                }
                else
                {
                    _logger.Info($"Opening AdminPanel for {user.Username}");

                    var assetRepo = new AssetRepository(_context);
                    var assetService = new AssetService(assetRepo,_logger);

                    var panel = new AdminPanel(_userService, _roleService, assetService, _personService, _logger, _context);
                    this.Hide();
                    panel.FormClosed += (sender, e) => this.Close();
                    panel.ShowDialog();
                }

                this.Show();
            }
            catch (ArgumentNullException ex)
            {
                _logger.Error($"Login failed: {ex.Message}");

                MessageBox.Show("All fields must not be empty!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                _logger.Error($"Login failed: {ex.Message}");

                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ex)
            {
                _logger.Error($"Login failed: {ex.Message}");

                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                _logger.Error($"Login failed: {ex.Message}");

                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            _logger.Info("Closing application");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLoginRegister_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _logger.Info("Opening Register form.");

            var register = new Register(_userService, _roleService, _personService, _context, _logger);
            this.Hide();
            register.FormClosed += (sender, e) => this.Close();
            register.ShowDialog();
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

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
