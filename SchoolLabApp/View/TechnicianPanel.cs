using Microsoft.EntityFrameworkCore;
using SchoolLabApp.Data;
using SchoolLabApp.Models;
using SchoolLabApp.Services;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SchoolLabApp.View
{
    public partial class TechnicianPanel : Form
    {
        private List<Asset> _assets = new List<Asset>();
        private readonly AssetService _assetService;
        private readonly UserService _userService;
        private readonly RoleService _roleService;
        private readonly PersonService _personService;
        private readonly SchoolLabAppDbContext _context;

        public TechnicianPanel(AssetService assetService, UserService userService, RoleService roleService, PersonService personService, SchoolLabAppDbContext context)
        {
            InitializeComponent();
            _assetService = assetService;
            _userService = userService;
            _roleService = roleService;
            _personService = personService;
            _context = context;
        }

        private async void TechnicianPanel_Load(object sender, EventArgs e)
            => await LoadAssets();

        private async Task LoadAssets()
        {
            try
            {
                int categoryId = comboBoxTechnicianPanelCategory.SelectedIndex + 1;
                var assets = await _assetService.GetAll();
                if (categoryId > 0)
                {
                    assets = await _assetService.GetByCategory(categoryId);
                }
                else
                {
                    assets = await _assetService.GetAll();
                }
                _assets = assets.ToList();
                listBoxTechnicianPanel.Items.Clear();

                foreach (var a in assets)
                {
                    listBoxTechnicianPanel.Items.Add(new ListBoxItem
                    {
                        Id = a.Id,
                        Text = $"{a.Id} | {a.Name} | {a.Status} | {a.Category?.Name}"
                    });
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void btnTechnicianPanelAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTechnicianPanelCategory.SelectedItem == null)
                {
                    throw new ArgumentException("Please select a category.");
                }

                string status = radioButtonTechnicianPanelStatusAvelible.Checked ? "Available"
                              : radioButtonTechnicianPanelStatusUnavelible.Checked ? "Unavailable"
                              : "Broken";

                await _assetService.AddAssets(
                    txtTechnicianPanelName.Text.Trim(),
                    status,
                    comboBoxTechnicianPanelCategory.SelectedIndex + 1);

                MessageBox.Show("Asset added.", 
                    "Success", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);

                await LoadAssets();

                ClearForm();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void btnTechnicianPanelEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxTechnicianPanel.SelectedItem == null)
                {
                    throw new ArgumentException("Select an asset from the list first.");
                }

                int id = int.Parse(listBoxTechnicianPanel.SelectedItem.ToString()!.Split('|')[0].Trim());


                var oldAsset = _assetService.GetById(id);

                string status = radioButtonTechnicianPanelStatusAvelible.Checked ? "Available"
                              : radioButtonTechnicianPanelStatusUnavelible.Checked ? "Unavailable"
                              : "Broken";

                _assets.Add(await oldAsset);

                var asset = new Asset
                {
                    Id = id,
                    Name = txtTechnicianPanelName.Text.Trim(),
                    Status = status,
                    CategoryId = comboBoxTechnicianPanelCategory.SelectedIndex + 1,
                };



                await _assetService.UpdateAsset(asset);
                MessageBox.Show("Asset updated.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                await LoadAssets();
                ClearForm();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void btnTechnicianPanelDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxTechnicianPanel.SelectedItem == null)
                {
                    throw new ArgumentException("Select an asset from the list first.");
                }

                int id = int.Parse(listBoxTechnicianPanel.SelectedItem.ToString()!.Split('|')[0].Trim());

                if (MessageBox.Show("Delete this asset?", "Confirm",
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    await _assetService.DeleteAsset(id);
                    await LoadAssets();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnTechnicianPanelReportPanel_Click(object sender, EventArgs e)
        {
            var report = new ReportPanel(_assetService, _userService, _roleService, _personService, _context);

            this.Hide();

            report.ShowDialog();

            this.Show();
        }

        private void ClearForm()
        {
            txtTechnicianPanelName.Clear();
            comboBoxTechnicianPanelCategory.SelectedIndex = -1;
            radioButtonTechnicianPanelStatusAvelible.Checked = false;
            radioButtonTechnicianPanelStatusUnavelible.Checked = false;
            radioButtonTechnicianPanelStatusBroken.Checked = false;
        }




        private async void listBoxTechnicianPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTechnicianPanel.SelectedItem is ListBoxItem selectedItem)
            {
                var oldAsset = await _assetService.GetById(selectedItem.Id);

                if (oldAsset == null)
                {
                    MessageBox.Show(
                        $"Asset with ID {selectedItem.Id} not found!",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                comboBoxTechnicianPanelCategory.SelectedIndex = oldAsset.CategoryId - 1;
                txtTechnicianPanelName.Text = oldAsset.Name;
                SetStatusRadioButtons(oldAsset.Status);
            }
        }

        private void SetStatusRadioButtons(string status)
        {
            switch (status?.ToLower())
            {
                case "available":
                    radioButtonTechnicianPanelStatusAvelible.Checked = true;
                    break;
                case "unavailable":
                    radioButtonTechnicianPanelStatusUnavelible.Checked = true;
                    break;
                case "broken":
                    radioButtonTechnicianPanelStatusBroken.Checked = true;
                    break;
                default:
                    radioButtonTechnicianPanelStatusAvelible.Checked = true;
                    break;
            }
        }

        private string GetSelectedStatus()
        {
            string status = radioButtonTechnicianPanelStatusAvelible.Checked ? "Available"
                          : radioButtonTechnicianPanelStatusUnavelible.Checked ? "Unavailable"
                          : "Broken";
            return status;
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (listBoxTechnicianPanel.SelectedItem is ListBoxItem selectedItem)
            {
                string newStatus = GetSelectedStatus();

                MessageBox.Show($"Status changed to: {newStatus}", 
                    "Status Updated",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("Please select an item first", 
                    "Warning",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
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

        private void comboBoxTechnicianPanelCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAssets();
        }
    }

    public class ListBoxItem
    {
        public string Text { get; set; } = "";
        public int Id { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
