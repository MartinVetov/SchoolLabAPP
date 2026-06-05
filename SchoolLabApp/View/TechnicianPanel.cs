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

                var oldAsset = _assetService.GetById(id);

                string status = radioButtonTechnicianPanelStatusAvelible.Checked ? "Available"
                              : radioButtonTechnicianPanelStatusUnavelible.Checked ? "Unavailable"
                              : "Broken";

                _assets.Add(await oldAsset);

                var asset = new Models.Asset
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
            var report = new ReportPanel();
            this.Hide();
            report.FormClosed += (sender, e) => this.Close();
            report.ShowDialog();
        }

        private void ClearForm()
        {
            txtTechnicianPanelName.Clear();
            comboBoxTechnicianPanelCategory.SelectedIndex = -1;
            radioButtonTechnicianPanelStatusAvelible.Checked = false;
            radioButtonTechnicianPanelStatusUnavelible.Checked = false;
            radioButtonTechnicianPanelStatusBroken.Checked = false;
        }




        private void listBoxTechnicianPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTechnicianPanel.SelectedItem is ListBoxItem selectedItem)
            {
                var oldAsset = _assetService.GetById(selectedItem.Id);

                if (oldAsset?.Result == null)
                {
                    MessageBox.Show($"Asset with ID {selectedItem.Id} not found!", "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                comboBoxTechnicianPanelCategory.SelectedIndex = oldAsset.Result.CategoryId;
                txtTechnicianPanelName.Text = oldAsset.Result.Name;
                SetStatusRadioButtons(oldAsset.Result.Status);
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

                // Update logic here
                MessageBox.Show($"Status changed to: {newStatus}", "Status Updated",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("Please select an item first", "Warning",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
