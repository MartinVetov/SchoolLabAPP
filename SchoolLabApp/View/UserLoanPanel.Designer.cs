namespace SchoolLabApp.View
{
    partial class UserLoanPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLoanPanel));
            comboBoxUserLoanPanelCategory = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            listBoxUserLoanPanel = new ListBox();
            btnUserLoanPanelReport = new Button();
            txtUserLoanPanelDuration = new TextBox();
            btnUserLoanPanelTake = new Button();
            btnUserLoanPanelReturn = new Button();
            pbLogo = new PictureBox();
            btnMinimize = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // comboBoxUserLoanPanelCategory
            // 
            comboBoxUserLoanPanelCategory.BackColor = Color.FromArgb(37, 37, 38);
            comboBoxUserLoanPanelCategory.FlatStyle = FlatStyle.Flat;
            comboBoxUserLoanPanelCategory.Font = new Font("Segoe UI", 10F);
            comboBoxUserLoanPanelCategory.ForeColor = Color.White;
            comboBoxUserLoanPanelCategory.FormattingEnabled = true;
            comboBoxUserLoanPanelCategory.Items.AddRange(new object[] { "Computers", "Lab equipment", "Books" });
            comboBoxUserLoanPanelCategory.Location = new Point(22, 91);
            comboBoxUserLoanPanelCategory.Name = "comboBoxUserLoanPanelCategory";
            comboBoxUserLoanPanelCategory.Size = new Size(199, 25);
            comboBoxUserLoanPanelCategory.TabIndex = 28;
            comboBoxUserLoanPanelCategory.SelectedIndexChanged += comboBoxUserLoanPanelCategory_SelectedIndexChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.Location = new Point(22, 138);
            label2.Name = "label2";
            label2.Size = new Size(116, 17);
            label2.TabIndex = 25;
            label2.Text = "Duration (in days)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label1.Location = new Point(22, 71);
            label1.Name = "label1";
            label1.Size = new Size(64, 17);
            label1.TabIndex = 24;
            label1.Text = "Category";
            // 
            // listBoxUserLoanPanel
            // 
            listBoxUserLoanPanel.BackColor = Color.FromArgb(37, 37, 38);
            listBoxUserLoanPanel.BorderStyle = BorderStyle.None;
            listBoxUserLoanPanel.Font = new Font("Segoe UI", 10F);
            listBoxUserLoanPanel.ForeColor = Color.White;
            listBoxUserLoanPanel.FormattingEnabled = true;
            listBoxUserLoanPanel.Location = new Point(268, 62);
            listBoxUserLoanPanel.Name = "listBoxUserLoanPanel";
            listBoxUserLoanPanel.Size = new Size(502, 391);
            listBoxUserLoanPanel.TabIndex = 20;
            // 
            // btnUserLoanPanelReport
            // 
            btnUserLoanPanelReport.BackColor = Color.FromArgb(209, 52, 56);
            btnUserLoanPanelReport.FlatAppearance.BorderSize = 0;
            btnUserLoanPanelReport.FlatStyle = FlatStyle.Flat;
            btnUserLoanPanelReport.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnUserLoanPanelReport.ForeColor = Color.White;
            btnUserLoanPanelReport.Location = new Point(59, 418);
            btnUserLoanPanelReport.Name = "btnUserLoanPanelReport";
            btnUserLoanPanelReport.Size = new Size(125, 35);
            btnUserLoanPanelReport.TabIndex = 19;
            btnUserLoanPanelReport.Text = "Report Issue";
            btnUserLoanPanelReport.UseVisualStyleBackColor = false;
            btnUserLoanPanelReport.Click += btnUserLoanPanelReport_Click;
            // 
            // txtUserLoanPanelDuration
            // 
            txtUserLoanPanelDuration.BackColor = Color.FromArgb(37, 37, 38);
            txtUserLoanPanelDuration.BorderStyle = BorderStyle.FixedSingle;
            txtUserLoanPanelDuration.Font = new Font("Segoe UI", 10F);
            txtUserLoanPanelDuration.ForeColor = Color.White;
            txtUserLoanPanelDuration.Location = new Point(22, 158);
            txtUserLoanPanelDuration.Name = "txtUserLoanPanelDuration";
            txtUserLoanPanelDuration.Size = new Size(199, 25);
            txtUserLoanPanelDuration.TabIndex = 16;
            // 
            // btnUserLoanPanelTake
            // 
            btnUserLoanPanelTake.BackColor = Color.FromArgb(0, 122, 204);
            btnUserLoanPanelTake.FlatAppearance.BorderSize = 0;
            btnUserLoanPanelTake.FlatStyle = FlatStyle.Flat;
            btnUserLoanPanelTake.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnUserLoanPanelTake.ForeColor = Color.White;
            btnUserLoanPanelTake.Location = new Point(59, 209);
            btnUserLoanPanelTake.Name = "btnUserLoanPanelTake";
            btnUserLoanPanelTake.Size = new Size(125, 35);
            btnUserLoanPanelTake.TabIndex = 29;
            btnUserLoanPanelTake.Text = "Rent / Take";
            btnUserLoanPanelTake.UseVisualStyleBackColor = false;
            btnUserLoanPanelTake.Click += btnUserLoanPanelTake_Click;
            // 
            // btnUserLoanPanelReturn
            // 
            btnUserLoanPanelReturn.BackColor = Color.FromArgb(63, 63, 70);
            btnUserLoanPanelReturn.FlatAppearance.BorderSize = 0;
            btnUserLoanPanelReturn.FlatStyle = FlatStyle.Flat;
            btnUserLoanPanelReturn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnUserLoanPanelReturn.ForeColor = Color.White;
            btnUserLoanPanelReturn.Location = new Point(59, 261);
            btnUserLoanPanelReturn.Name = "btnUserLoanPanelReturn";
            btnUserLoanPanelReturn.Size = new Size(125, 35);
            btnUserLoanPanelReturn.TabIndex = 30;
            btnUserLoanPanelReturn.Text = "Return View";
            btnUserLoanPanelReturn.UseVisualStyleBackColor = false;
            btnUserLoanPanelReturn.Click += btnUserLoanPanelReturn_Click;
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.SchoolabLogoSmall;
            pbLogo.Location = new Point(12, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(59, 45);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 52;
            pbLogo.TabStop = false;
            pbLogo.Click += pbLogo_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(713, 1);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(45, 45);
            btnMinimize.TabIndex = 51;
            btnMinimize.Text = "–";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 52, 56);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(755, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(45, 45);
            btnClose.TabIndex = 50;
            btnClose.Text = "x";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // UserLoanPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(800, 479);
            Controls.Add(pbLogo);
            Controls.Add(btnMinimize);
            Controls.Add(btnClose);
            Controls.Add(btnUserLoanPanelReturn);
            Controls.Add(btnUserLoanPanelTake);
            Controls.Add(comboBoxUserLoanPanelCategory);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxUserLoanPanel);
            Controls.Add(btnUserLoanPanelReport);
            Controls.Add(txtUserLoanPanelDuration);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UserLoanPanel";
            Text = "User Loan Management";
            Load += UserLoanPanel_Load;
            MouseDown += DragArea_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxUserLoanPanelCategory;
        private Label label2;
        private Label label1;
        private ListBox listBoxUserLoanPanel;
        private Button btnUserLoanPanelReport;
        private TextBox txtUserLoanPanelDuration;
        private Button btnUserLoanPanelTake;
        private Button btnUserLoanPanelReturn;
        private PictureBox pbLogo;
        private Button btnMinimize;
        private Button btnClose;
    }
}