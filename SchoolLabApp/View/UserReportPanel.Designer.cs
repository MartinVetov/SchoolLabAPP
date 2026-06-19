namespace SchoolLabApp.View
{
    partial class UserReportPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserReportPanel));
            txtUserReportPanelReport = new TextBox();
            btnUserReportPanelBackToLoans = new Button();
            btnUserReportPanelSend = new Button();
            btnBackarrow = new Button();
            btnMinimize_Click = new Button();
            btnClose = new Button();
            pbLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // txtUserReportPanelReport
            // 
            txtUserReportPanelReport.BackColor = Color.FromArgb(37, 37, 38);
            txtUserReportPanelReport.BorderStyle = BorderStyle.FixedSingle;
            txtUserReportPanelReport.Font = new Font("Segoe UI", 10F);
            txtUserReportPanelReport.ForeColor = Color.White;
            txtUserReportPanelReport.Location = new Point(12, 63);
            txtUserReportPanelReport.Multiline = true;
            txtUserReportPanelReport.Name = "txtUserReportPanelReport";
            txtUserReportPanelReport.Size = new Size(481, 203);
            txtUserReportPanelReport.TabIndex = 0;
            // 
            // btnUserReportPanelBackToLoans
            // 
            btnUserReportPanelBackToLoans.BackColor = Color.FromArgb(63, 63, 70);
            btnUserReportPanelBackToLoans.FlatAppearance.BorderSize = 0;
            btnUserReportPanelBackToLoans.FlatStyle = FlatStyle.Flat;
            btnUserReportPanelBackToLoans.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnUserReportPanelBackToLoans.ForeColor = Color.White;
            btnUserReportPanelBackToLoans.Location = new Point(333, 286);
            btnUserReportPanelBackToLoans.Name = "btnUserReportPanelBackToLoans";
            btnUserReportPanelBackToLoans.Size = new Size(130, 35);
            btnUserReportPanelBackToLoans.TabIndex = 31;
            btnUserReportPanelBackToLoans.Text = "Back to loans";
            btnUserReportPanelBackToLoans.UseVisualStyleBackColor = false;
            btnUserReportPanelBackToLoans.Click += btnUserReportPanelBackToLoans_Click;
            // 
            // btnUserReportPanelSend
            // 
            btnUserReportPanelSend.BackColor = Color.FromArgb(219, 79, 62);
            btnUserReportPanelSend.FlatAppearance.BorderSize = 0;
            btnUserReportPanelSend.FlatStyle = FlatStyle.Flat;
            btnUserReportPanelSend.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnUserReportPanelSend.ForeColor = Color.White;
            btnUserReportPanelSend.Location = new Point(41, 286);
            btnUserReportPanelSend.Name = "btnUserReportPanelSend";
            btnUserReportPanelSend.Size = new Size(130, 35);
            btnUserReportPanelSend.TabIndex = 32;
            btnUserReportPanelSend.Text = "Send Report";
            btnUserReportPanelSend.UseVisualStyleBackColor = false;
            btnUserReportPanelSend.Click += btnUserReportPanelSend_Click;
            // 
            // btnBackarrow
            // 
            btnBackarrow.FlatAppearance.BorderSize = 0;
            btnBackarrow.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnBackarrow.FlatStyle = FlatStyle.Flat;
            btnBackarrow.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btnBackarrow.ForeColor = Color.White;
            btnBackarrow.Location = new Point(376, 1);
            btnBackarrow.Name = "btnBackarrow";
            btnBackarrow.Size = new Size(45, 45);
            btnBackarrow.TabIndex = 58;
            btnBackarrow.Text = "↶";
            btnBackarrow.UseVisualStyleBackColor = true;
            btnBackarrow.Click += btnBackarrow_Click;
            // 
            // btnMinimize_Click
            // 
            btnMinimize_Click.FlatAppearance.BorderSize = 0;
            btnMinimize_Click.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnMinimize_Click.FlatStyle = FlatStyle.Flat;
            btnMinimize_Click.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btnMinimize_Click.ForeColor = Color.White;
            btnMinimize_Click.Location = new Point(418, 1);
            btnMinimize_Click.Name = "btnMinimize_Click";
            btnMinimize_Click.Size = new Size(45, 45);
            btnMinimize_Click.TabIndex = 57;
            btnMinimize_Click.Text = "–";
            btnMinimize_Click.UseVisualStyleBackColor = true;
            btnMinimize_Click.Click += btnMinimize_Click_Click;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 52, 56);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(460, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(45, 45);
            btnClose.TabIndex = 56;
            btnClose.Text = "x";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.SchoolabLogoSmall;
            pbLogo.Location = new Point(12, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(59, 45);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 59;
            pbLogo.TabStop = false;
            pbLogo.Click += pbLogo_Click;
            // 
            // UserReportPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(505, 344);
            Controls.Add(pbLogo);
            Controls.Add(btnBackarrow);
            Controls.Add(btnMinimize_Click);
            Controls.Add(btnClose);
            Controls.Add(btnUserReportPanelSend);
            Controls.Add(btnUserReportPanelBackToLoans);
            Controls.Add(txtUserReportPanelReport);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UserReportPanel";
            Text = "File a Report";
            MouseDown += DragArea_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserReportPanelReport;
        private Button btnUserReportPanelBackToLoans;
        private Button btnUserReportPanelSend;
        private Button btnBackarrow;
        private Button btnMinimize_Click;
        private Button btnClose;
        private PictureBox pbLogo;
    }
}