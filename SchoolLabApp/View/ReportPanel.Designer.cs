namespace SchoolLabApp.View
{
    partial class ReportPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportPanel));
            listBoxReportPanel = new ListBox();
            txtReportPanelReport = new TextBox();
            btnReportPanelViewReport = new Button();
            btnReportPanelDelete = new Button();
            pictureBox1 = new PictureBox();
            btnMinimize_Click = new Button();
            btnClose = new Button();
            label1 = new Label();
            label2 = new Label();
            btnBackarrow = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBoxReportPanel
            // 
            listBoxReportPanel.BackColor = Color.FromArgb(37, 37, 38);
            listBoxReportPanel.BorderStyle = BorderStyle.None;
            listBoxReportPanel.Font = new Font("Segoe UI", 10F);
            listBoxReportPanel.ForeColor = Color.White;
            listBoxReportPanel.FormattingEnabled = true;
            listBoxReportPanel.Location = new Point(12, 80);
            listBoxReportPanel.Name = "listBoxReportPanel";
            listBoxReportPanel.Size = new Size(299, 238);
            listBoxReportPanel.TabIndex = 0;
            // 
            // txtReportPanelReport
            // 
            txtReportPanelReport.BackColor = Color.FromArgb(37, 37, 38);
            txtReportPanelReport.BorderStyle = BorderStyle.FixedSingle;
            txtReportPanelReport.Font = new Font("Segoe UI", 10F);
            txtReportPanelReport.ForeColor = Color.White;
            txtReportPanelReport.Location = new Point(336, 80);
            txtReportPanelReport.Multiline = true;
            txtReportPanelReport.Name = "txtReportPanelReport";
            txtReportPanelReport.ReadOnly = true;
            txtReportPanelReport.Size = new Size(357, 304);
            txtReportPanelReport.TabIndex = 1;
            // 
            // btnReportPanelViewReport
            // 
            btnReportPanelViewReport.BackColor = Color.FromArgb(0, 122, 204);
            btnReportPanelViewReport.FlatAppearance.BorderSize = 0;
            btnReportPanelViewReport.FlatStyle = FlatStyle.Flat;
            btnReportPanelViewReport.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnReportPanelViewReport.ForeColor = Color.White;
            btnReportPanelViewReport.Location = new Point(12, 349);
            btnReportPanelViewReport.Name = "btnReportPanelViewReport";
            btnReportPanelViewReport.Size = new Size(130, 35);
            btnReportPanelViewReport.TabIndex = 33;
            btnReportPanelViewReport.Text = "View Report";
            btnReportPanelViewReport.UseVisualStyleBackColor = false;
            btnReportPanelViewReport.Click += btnReportPanelViewReport_Click;
            // 
            // btnReportPanelDelete
            // 
            btnReportPanelDelete.BackColor = Color.FromArgb(209, 52, 56);
            btnReportPanelDelete.FlatAppearance.BorderSize = 0;
            btnReportPanelDelete.FlatStyle = FlatStyle.Flat;
            btnReportPanelDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnReportPanelDelete.ForeColor = Color.White;
            btnReportPanelDelete.Location = new Point(181, 349);
            btnReportPanelDelete.Name = "btnReportPanelDelete";
            btnReportPanelDelete.Size = new Size(130, 35);
            btnReportPanelDelete.TabIndex = 36;
            btnReportPanelDelete.Text = "Delete Log";
            btnReportPanelDelete.UseVisualStyleBackColor = false;
            btnReportPanelDelete.Click += btnReportPanelDelete_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.SchoolabLogoSmall;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 52;
            pictureBox1.TabStop = false;
            // 
            // btnMinimize_Click
            // 
            btnMinimize_Click.FlatAppearance.BorderSize = 0;
            btnMinimize_Click.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnMinimize_Click.FlatStyle = FlatStyle.Flat;
            btnMinimize_Click.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btnMinimize_Click.ForeColor = Color.White;
            btnMinimize_Click.Location = new Point(616, 3);
            btnMinimize_Click.Name = "btnMinimize_Click";
            btnMinimize_Click.Size = new Size(45, 45);
            btnMinimize_Click.TabIndex = 51;
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
            btnClose.Location = new Point(658, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(45, 45);
            btnClose.TabIndex = 50;
            btnClose.Text = "x";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(113, 60);
            label1.Name = "label1";
            label1.Size = new Size(78, 17);
            label1.TabIndex = 53;
            label1.Text = "Reports list";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(460, 60);
            label2.Name = "label2";
            label2.Size = new Size(107, 17);
            label2.TabIndex = 54;
            label2.Text = "Reports preview";
            // 
            // btnBackarrow
            // 
            btnBackarrow.FlatAppearance.BorderSize = 0;
            btnBackarrow.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnBackarrow.FlatStyle = FlatStyle.Flat;
            btnBackarrow.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btnBackarrow.ForeColor = Color.White;
            btnBackarrow.Location = new Point(574, 3);
            btnBackarrow.Name = "btnBackarrow";
            btnBackarrow.Size = new Size(45, 45);
            btnBackarrow.TabIndex = 55;
            btnBackarrow.Text = "↶";
            btnBackarrow.UseVisualStyleBackColor = true;
            btnBackarrow.Click += btnBackarrow_Click;
            // 
            // ReportPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(705, 397);
            Controls.Add(btnBackarrow);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnMinimize_Click);
            Controls.Add(btnClose);
            Controls.Add(btnReportPanelDelete);
            Controls.Add(btnReportPanelViewReport);
            Controls.Add(txtReportPanelReport);
            Controls.Add(listBoxReportPanel);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ReportPanel";
            Text = "Incident Reports Administration";
            MouseDown += DragArea_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxReportPanel;
        private TextBox txtReportPanelReport;
        private Button btnReportPanelViewReport;
        private Button btnReportPanelDelete;
        private PictureBox pictureBox1;
        private Button btnMinimize_Click;
        private Button btnClose;
        private Label label1;
        private Label label2;
        private Button btnBackarrow;
    }
}