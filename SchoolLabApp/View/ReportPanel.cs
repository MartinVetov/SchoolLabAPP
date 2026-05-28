using System;
using System.IO;
using System.Windows.Forms;

namespace SchoolLabApp.View
{
    public partial class ReportPanel : Form
    {
        private readonly string reportsPath =
            Path.Combine(Application.StartupPath, "Reports");

        public ReportPanel()
        {
            InitializeComponent();

            LoadReports();
        }

        private void LoadReports()
        {
            try
            {
                listBoxReportPanel.Items.Clear();

                if (!Directory.Exists(reportsPath))
                {
                    Directory.CreateDirectory(reportsPath);
                }

                string[] files = Directory.GetFiles(reportsPath, "*.txt");

                foreach (string file in files)
                {
                    listBoxReportPanel.Items.Add(Path.GetFileName(file));
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Folder Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Access Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
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
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "File Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Read Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
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
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Access Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Delete Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                string fullError =
                    ex.InnerException?.Message ?? ex.Message;

                MessageBox.Show(
                    fullError,
                    "Unexpected Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}