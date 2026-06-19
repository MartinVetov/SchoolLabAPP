using Microsoft.VisualBasic;
using SchoolLabApp.Services;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SchoolLabApp.View
{
    public partial class TechnicianPasswordPanel : Form
    {
        private readonly UserService _userService;
        private readonly RoleService _roleService;
        private readonly PersonService _personService;

        private const string TechnicianPassword = "tech1234";

        public TechnicianPasswordPanel(UserService userService, RoleService roleService, PersonService personService)
        {
            InitializeComponent();
            _userService = userService;
            _roleService = roleService;
            _personService = personService;
        }

        private void checkBoxTechnicianPasswordPanel_CheckedChanged(object sender, EventArgs e)
            => txtTechnicianPasswordPanelPassword.UseSystemPasswordChar = !checkBoxTechnicianPasswordPanel.Checked;

        private void btnTechnicianPasswordPanelRegister_Click(object sender, EventArgs e)
        {
            if (txtTechnicianPasswordPanelPassword.Text != TechnicianPassword)
            {
                MessageBox.Show("Incorrect technician password.",
                    "Access denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            this.Close();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


    }
}
