using SchoolLabApp.Services;
using System;
using System.Windows.Forms;

namespace SchoolLabApp.View
{
    public partial class TechnicianPasswordPanel : Form
    {
        private readonly UserService _userService;
        private readonly RoleService _roleService;
        private readonly PersonService _personService;

        // The Technician password is stored in app config / set by admin.
        // For now it defaults to "tech1234" — change this as needed.
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
    }
}
