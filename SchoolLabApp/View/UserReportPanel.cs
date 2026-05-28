using System;
using System.IO;
using System.Windows.Forms;

namespace SchoolLabApp.View
{
    public partial class UserReportPanel : Form
    {
        private readonly string reportsPath =
            Path.Combine(Application.StartupPath, "Reports");

        public UserReportPanel()
        {
            InitializeComponent();
        }

        private void btnUserReportPanelSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserReportPanelReport.Text))
            {
                MessageBox.Show(
                    "Please write a report before sending.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                if (!Directory.Exists(reportsPath))
                    Directory.CreateDirectory(reportsPath);

                string fileName =
                    $"report_{DateTime.Now:yyyyMMdd_HHmmss}.txt";

                string fullPath =
                    Path.Combine(reportsPath, fileName);

                File.WriteAllText(fullPath, txtUserReportPanelReport.Text);

                MessageBox.Show(
                    "Report sent and saved.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnUserReportPanelBackToLoans_Click(object sender, EventArgs e)
            => this.Close();
    }
}