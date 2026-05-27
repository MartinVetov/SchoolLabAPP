using SchoolLabApp.Models;
using SchoolLabApp.Services;
using System;
using System.Windows.Forms;

namespace SchoolLabApp.View
{
    public partial class TechnicianPanel : Form
    {
        private List<Asset> _assets = new List<Asset>();
        private readonly AssetService _assetService;

        public TechnicianPanel(AssetService assetService)
        {
            InitializeComponent();
            _assetService = assetService;
        }

        private async void TechnicianPanel_Load(object sender, EventArgs e)
            => await LoadAssets();

        private async Task LoadAssets()
        {
            try
            {
                var assets = await _assetService.GetAll();
                _assets = assets.ToList();
                listBoxTechnicianPanel.Items.Clear();
                
                foreach (var a in assets)
                {
                    listBoxTechnicianPanel.Items.Add($"{a.Id} | {a.Name} | {a.Status} | {a.Category?.Name}");
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

                MessageBox.Show("Asset added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show(id + " ");
                //var oldAsset = _assetService.GetById(id);
                string status = radioButtonTechnicianPanelStatusAvelible.Checked ? "Available"
                              : radioButtonTechnicianPanelStatusUnavelible.Checked ? "Unavailable"
                              : "Broken";
                //_assets.Add(OldAsset);
                var asset = new Models.Asset
                {
                    Id = id,
                    Name = txtTechnicianPanelName.Text.Trim(),
                    Status = status,
                    CategoryId = comboBoxTechnicianPanelCategory.SelectedIndex + 1,
                };
                txtTechnicianPanelDescription.Text = oldAsset.Description;
                
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
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            var panel = new ReportPanel();
            panel.ShowDialog();
        }

        private void ClearForm()
        {
            txtTechnicianPanelName.Clear();
            txtTechnicianPanelDescription.Clear();
            comboBoxTechnicianPanelCategory.SelectedIndex = -1;
            radioButtonTechnicianPanelStatusAvelible.Checked = false;
            radioButtonTechnicianPanelStatusUnavelible.Checked = false;
            radioButtonTechnicianPanelStatusBroken.Checked = false;
        }

        private void listBoxTechnicianPanel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
