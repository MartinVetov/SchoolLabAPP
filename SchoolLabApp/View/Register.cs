using SchoolLabApp.Data;
using SchoolLabApp.Models;
using SchoolLabApp.Services;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SchoolLabApp.View;

public partial class Register : Form
{
    private readonly UserService _userService;
    private readonly RoleService _roleService;
    private readonly PersonService _personService;
    private readonly SchoolLabAppDbContext _context;
    private readonly Dictionary<string, int> _roleMap = new();
    int counter = 0;
    private readonly Logger.Logger _logger;
    public Register(UserService userService, RoleService roleService, PersonService personService, SchoolLabAppDbContext context, Logger.Logger logger)
    {
        InitializeComponent();
        _userService = userService;
        _roleService = roleService;
        _personService = personService;
        _context = context;
        _logger = logger;
    }
    
    private async void Register_Load(object sender, EventArgs e)
    {
        try
        {
            var roles = await _roleService.GetAll();
            comboBoxRegisterRole.Items.Clear();
            _roleMap.Clear();
            foreach (var r in roles.Skip(1))
            {
                comboBoxRegisterRole.Items.Add(r.Name);
                _roleMap[r.Name] = r.Id;
            }
            if (comboBoxRegisterRole.Items.Count > 0)
            {
                comboBoxRegisterRole.SelectedIndex = 0;
            }
        }
        catch (Exception ex)
        {
            _logger.Error($"Register failed: {ex.Message}");

            MessageBox.Show(ex.Message,
                "Error loading roles",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private void checkBoxRegister_CheckedChanged(object sender, EventArgs e)
    {
        bool show = checkBoxRegister.Checked;
        txtRegisterPassword.UseSystemPasswordChar = !show;
        txtRegisterPasswordConfirm.UseSystemPasswordChar = !show;
    }

    private async void btnRegisterRegister_Click(object sender, EventArgs e)
    {
        _logger.Info($"Register attempt | Username {txtRegisterUsername}");

        if (txtRegisterPassword.Text != txtRegisterPasswordConfirm.Text)
        {
            MessageBox.Show(
                "Passwords do not match!",
                "Registrer Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            return;
        }

        if (comboBoxRegisterRole.SelectedItem == null)
        {
            _logger.Warn($"Register fail no role was selected");
            throw new ArgumentException("Please select a role.");
        }

        if (!_roleMap.TryGetValue(comboBoxRegisterRole.SelectedItem.ToString()!, out int roleId))
        {
            _logger.Warn($"Register fail no role was found in database");
            throw new InvalidOperationException("Selected role not found in database.");
        }

        if (comboBoxRegisterRole.SelectedItem.ToString() == "Technician")
        {
            _logger.Info($"Register attempt as technician | Username {txtRegisterUsername}");

            var technicianPassword = new TechnicianPasswordPanel(_userService, _roleService, _personService,_logger,_context);
            technicianPassword.ShowDialog();
        }

        try
        {
            var user = new User
            {
                Username = txtRegisterUsername.Text.Trim(),
                Password = txtRegisterPassword.Text.Trim(),
                RoleId = roleId
            };

            await _userService.Register(user);

            var person = new Person
            {
                Name = user.Username,
                Type = user.Role.Name
            };


            await _personService.AddPerson(person);

            _logger.Info($"Register successfull | Username {txtRegisterUsername}");

            MessageBox.Show(
                "Registration successful!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            _logger.Info($"Opening login panel");
            var login = new Login(_userService, _roleService, _context, _personService,_logger);
            this.Hide();
            login.FormClosed += (sender, e) => this.Close();
            login.ShowDialog();
        }
        catch (ArgumentNullException ex)
        {
            _logger.Error($"Register failed: {ex.Message}");

            MessageBox.Show(
                ex.Message,
                "Registration fail",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        catch (ArgumentException ex)
        {
            _logger.Error($"Register failed: {ex.Message}");

            MessageBox.Show(
                ex.Message,
                "Registration fail",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        catch (InvalidOperationException ex)
        {
            _logger.Error($"Register failed: {ex.Message}");

            MessageBox.Show(
                ex.Message,
                "Registration fail",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            _logger.Error($"Register failed: {ex.Message}");

            MessageBox.Show(
                ex.Message,
                "Registration fail",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private void comboBoxRegisterRole_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void txtRegisterPasswordConfirm_TextChanged(object sender, EventArgs e)
    {

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


    private void btnMinimize_Click_Click(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Minimized;
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        _logger.Info("Closing application");
        Application.Exit();
    }
}
