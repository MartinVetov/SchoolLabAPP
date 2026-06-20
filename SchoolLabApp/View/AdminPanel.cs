using SchoolLabApp.Data;
using SchoolLabApp.Models;
using SchoolLabApp.Services;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolLabApp.View
{
    public partial class AdminPanel : Form
    {
        private readonly UserService _userService;
        private readonly RoleService _roleService;
        private readonly AssetService _assetService;
        private readonly PersonService _personService;
        private readonly SchoolLabAppDbContext _context;
        public readonly List<User> _OldUsers = new List<User>();

        public AdminPanel(UserService userService, RoleService roleService, AssetService assetService, PersonService personService, SchoolLabAppDbContext context)
        {
            InitializeComponent();
            _userService = userService;
            _roleService = roleService;
            _assetService = assetService;
            _personService = personService;
            _context = context;


            listBoxAdminPanel.SelectedIndexChanged += listBoxAdminPanel_SelectedIndexChanged;
        }

        private async void AdminPanel_Load(object sender, EventArgs e)
        {
            txtAdminPanelPassword.UseSystemPasswordChar = false;
            txtAdminPanelPassword.PasswordChar = '\0';

            await LoadUsers();
        }

        private async Task LoadUsers()
        {
            try
            {
                var users = await _userService.GetAllUsers();
                listBoxAdminPanel.Items.Clear();
                foreach (var u in users)
                {
                    listBoxAdminPanel.Items.Add($"{u.Id} | {u.Username} | {u.Password} | {u.Role?.Name ?? "N/A"}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxAdminPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAdminPanel.SelectedItem == null) return;

            try
            {
                string selectedItem = listBoxAdminPanel.SelectedItem.ToString()!;
                string[] parts = selectedItem.Split('|');

                if (parts.Length >= 4)
                {
                    txtAdminPanelUsername.Text = parts[1].Trim();
                    txtAdminPanelPassword.Text = parts[2].Trim();
                    comboBoxAdminPanelRole.Text = parts[3].Trim();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not parse user data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAdminPanelAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxAdminPanelRole.SelectedItem == null)
                {
                    throw new ArgumentException("Please select a role.");
                }

                int roleId = await GetSelectedRoleId();

                var user = new User
                {
                    Username = txtAdminPanelUsername.Text.Trim(),
                    Password = txtAdminPanelPassword.Text,
                    RoleId = roleId
                };

                await _userService.Register(user);
                MessageBox.Show("User added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await LoadUsers();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAdminPanelEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxAdminPanel.SelectedItem == null)
                {
                    throw new ArgumentException("Select a user from the list first.");
                }

                int id = int.Parse(listBoxAdminPanel.SelectedItem.ToString()!.Split('|')[0].Trim());
                int roleId = await GetSelectedRoleId();

                var olduser = _userService.GetById(id);
                _OldUsers.Add(await olduser);

                var user = await _userService.GetById(id);

                user.Username = txtAdminPanelUsername.Text.Trim();
                user.Password = txtAdminPanelPassword.Text.Trim();
                user.RoleId = roleId;

                await _userService.UpdateUser(user);
                MessageBox.Show("User updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadUsers();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAdminPanelDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxAdminPanel.SelectedItem == null)
                {
                    throw new ArgumentException("Select a user from the list first.");
                }

                int id = int.Parse(listBoxAdminPanel.SelectedItem.ToString()!.Split('|')[0].Trim());

                if (MessageBox.Show("Delete this user?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    await _userService.DeleteUser(id);
                    await LoadUsers();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdminPanelTechnicianPanel_Click(object sender, EventArgs e)
        {
            var technician = new TechnicianPanel(_assetService, _userService, _roleService, _personService, _context);
            this.Hide();
            technician.FormClosed += (sender2, e2) => this.Close();
            technician.ShowDialog();
        }

        private void btnAdminPanelReportPanel_Click(object sender, EventArgs e)
        {
            var report = new ReportPanel(_assetService, _userService, _roleService, _personService, _context);
            this.Hide();
            report.ShowDialog();
            this.Show();
        }

        private async Task<int> GetSelectedRoleId()
        {
            if (comboBoxAdminPanelRole.SelectedItem == null)
            {
                throw new ArgumentException("Please select a role.");
            }

            var roles = await _roleService.GetAll();
            string selected = comboBoxAdminPanelRole.SelectedItem.ToString()!;

            foreach (var r in roles)
            {
                if (r.Name == selected) return r.Id;
            }

            throw new InvalidOperationException("Selected role not found in database.");
        }

        private void ClearForm()
        {
            txtAdminPanelUsername.Clear();
            txtAdminPanelPassword.Clear();
            comboBoxAdminPanelRole.SelectedIndex = -1;
            listBoxAdminPanel.ClearSelected();
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click_Click(object sender, EventArgs e)
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
            _userService.Logout();
            var login = new Login(_userService, _roleService, _context, _personService);
            this.Hide();
            login.FormClosed += (sender2, e2) => this.Close();
            login.ShowDialog();
        }
    }
}