namespace SchoolLabApp.View
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            comboBoxAdminPanelRole = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnAdminPanelDelete = new Button();
            btnAdminPanelEdit = new Button();
            btnAdminPanelAdd = new Button();
            listBoxAdminPanel = new ListBox();
            btnAdminPanelReportPanel = new Button();
            btnAdminPanelTechnicianPanel = new Button();
            txtAdminPanelPassword = new TextBox();
            txtAdminPanelUsername = new TextBox();
            btnMinimize_Click = new Button();
            btnClose = new Button();
            pbLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // comboBoxAdminPanelRole
            // 
            comboBoxAdminPanelRole.BackColor = Color.FromArgb(37, 37, 38);
            comboBoxAdminPanelRole.FlatStyle = FlatStyle.Flat;
            comboBoxAdminPanelRole.Font = new Font("Segoe UI", 10F);
            comboBoxAdminPanelRole.ForeColor = Color.White;
            comboBoxAdminPanelRole.FormattingEnabled = true;
            comboBoxAdminPanelRole.Items.AddRange(new object[] { "Student", "Teacher", "Technician" });
            comboBoxAdminPanelRole.Location = new Point(25, 234);
            comboBoxAdminPanelRole.Name = "comboBoxAdminPanelRole";
            comboBoxAdminPanelRole.Size = new Size(199, 25);
            comboBoxAdminPanelRole.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label4.Location = new Point(25, 214);
            label4.Name = "label4";
            label4.Size = new Size(34, 17);
            label4.TabIndex = 27;
            label4.Text = "Role";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label3.Location = new Point(25, 151);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 26;
            label3.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label1.Location = new Point(25, 89);
            label1.Name = "label1";
            label1.Size = new Size(69, 17);
            label1.TabIndex = 24;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // btnAdminPanelDelete
            // 
            btnAdminPanelDelete.BackColor = Color.FromArgb(209, 52, 56);
            btnAdminPanelDelete.FlatAppearance.BorderSize = 0;
            btnAdminPanelDelete.FlatStyle = FlatStyle.Flat;
            btnAdminPanelDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnAdminPanelDelete.ForeColor = Color.White;
            btnAdminPanelDelete.Location = new Point(639, 354);
            btnAdminPanelDelete.Name = "btnAdminPanelDelete";
            btnAdminPanelDelete.Size = new Size(134, 32);
            btnAdminPanelDelete.TabIndex = 23;
            btnAdminPanelDelete.Text = "Delete";
            btnAdminPanelDelete.UseVisualStyleBackColor = false;
            btnAdminPanelDelete.Click += btnAdminPanelDelete_Click;
            // 
            // btnAdminPanelEdit
            // 
            btnAdminPanelEdit.BackColor = Color.FromArgb(63, 63, 70);
            btnAdminPanelEdit.FlatAppearance.BorderSize = 0;
            btnAdminPanelEdit.FlatStyle = FlatStyle.Flat;
            btnAdminPanelEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnAdminPanelEdit.ForeColor = Color.White;
            btnAdminPanelEdit.Location = new Point(465, 354);
            btnAdminPanelEdit.Name = "btnAdminPanelEdit";
            btnAdminPanelEdit.Size = new Size(134, 32);
            btnAdminPanelEdit.TabIndex = 22;
            btnAdminPanelEdit.Text = "Edit User";
            btnAdminPanelEdit.UseVisualStyleBackColor = false;
            btnAdminPanelEdit.Click += btnAdminPanelEdit_Click;
            // 
            // btnAdminPanelAdd
            // 
            btnAdminPanelAdd.BackColor = Color.FromArgb(16, 124, 65);
            btnAdminPanelAdd.FlatAppearance.BorderSize = 0;
            btnAdminPanelAdd.FlatStyle = FlatStyle.Flat;
            btnAdminPanelAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnAdminPanelAdd.ForeColor = Color.White;
            btnAdminPanelAdd.Location = new Point(293, 354);
            btnAdminPanelAdd.Name = "btnAdminPanelAdd";
            btnAdminPanelAdd.Size = new Size(134, 32);
            btnAdminPanelAdd.TabIndex = 21;
            btnAdminPanelAdd.Text = "Add User";
            btnAdminPanelAdd.UseVisualStyleBackColor = false;
            btnAdminPanelAdd.Click += btnAdminPanelAdd_Click;
            // 
            // listBoxAdminPanel
            // 
            listBoxAdminPanel.BackColor = Color.FromArgb(37, 37, 38);
            listBoxAdminPanel.BorderStyle = BorderStyle.None;
            listBoxAdminPanel.Font = new Font("Segoe UI", 10F);
            listBoxAdminPanel.ForeColor = Color.White;
            listBoxAdminPanel.FormattingEnabled = true;
            listBoxAdminPanel.Location = new Point(271, 52);
            listBoxAdminPanel.Name = "listBoxAdminPanel";
            listBoxAdminPanel.Size = new Size(502, 272);
            listBoxAdminPanel.TabIndex = 20;
            // 
            // btnAdminPanelReportPanel
            // 
            btnAdminPanelReportPanel.BackColor = Color.FromArgb(0, 122, 204);
            btnAdminPanelReportPanel.FlatAppearance.BorderSize = 0;
            btnAdminPanelReportPanel.FlatStyle = FlatStyle.Flat;
            btnAdminPanelReportPanel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnAdminPanelReportPanel.ForeColor = Color.White;
            btnAdminPanelReportPanel.Location = new Point(25, 354);
            btnAdminPanelReportPanel.Name = "btnAdminPanelReportPanel";
            btnAdminPanelReportPanel.Size = new Size(199, 32);
            btnAdminPanelReportPanel.TabIndex = 19;
            btnAdminPanelReportPanel.Text = "Go to Report Panel";
            btnAdminPanelReportPanel.UseVisualStyleBackColor = false;
            btnAdminPanelReportPanel.Click += btnAdminPanelReportPanel_Click;
            // 
            // btnAdminPanelTechnicianPanel
            // 
            btnAdminPanelTechnicianPanel.BackColor = Color.FromArgb(0, 122, 204);
            btnAdminPanelTechnicianPanel.FlatAppearance.BorderSize = 0;
            btnAdminPanelTechnicianPanel.FlatStyle = FlatStyle.Flat;
            btnAdminPanelTechnicianPanel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnAdminPanelTechnicianPanel.ForeColor = Color.White;
            btnAdminPanelTechnicianPanel.Location = new Point(25, 305);
            btnAdminPanelTechnicianPanel.Name = "btnAdminPanelTechnicianPanel";
            btnAdminPanelTechnicianPanel.Size = new Size(199, 32);
            btnAdminPanelTechnicianPanel.TabIndex = 18;
            btnAdminPanelTechnicianPanel.Text = "Go to Technician Panel";
            btnAdminPanelTechnicianPanel.UseVisualStyleBackColor = false;
            btnAdminPanelTechnicianPanel.Click += btnAdminPanelTechnicianPanel_Click;
            // 
            // txtAdminPanelPassword
            // 
            txtAdminPanelPassword.BackColor = Color.FromArgb(37, 37, 38);
            txtAdminPanelPassword.BorderStyle = BorderStyle.FixedSingle;
            txtAdminPanelPassword.Font = new Font("Segoe UI", 10F);
            txtAdminPanelPassword.ForeColor = Color.White;
            txtAdminPanelPassword.Location = new Point(25, 171);
            txtAdminPanelPassword.Name = "txtAdminPanelPassword";
            txtAdminPanelPassword.Size = new Size(199, 25);
            txtAdminPanelPassword.TabIndex = 17;
            txtAdminPanelPassword.UseSystemPasswordChar = true;
            // 
            // txtAdminPanelUsername
            // 
            txtAdminPanelUsername.BackColor = Color.FromArgb(37, 37, 38);
            txtAdminPanelUsername.BorderStyle = BorderStyle.FixedSingle;
            txtAdminPanelUsername.Font = new Font("Segoe UI", 10F);
            txtAdminPanelUsername.ForeColor = Color.White;
            txtAdminPanelUsername.Location = new Point(25, 109);
            txtAdminPanelUsername.Name = "txtAdminPanelUsername";
            txtAdminPanelUsername.Size = new Size(199, 25);
            txtAdminPanelUsername.TabIndex = 15;
            // 
            // btnMinimize_Click
            // 
            btnMinimize_Click.FlatAppearance.BorderSize = 0;
            btnMinimize_Click.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnMinimize_Click.FlatStyle = FlatStyle.Flat;
            btnMinimize_Click.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btnMinimize_Click.ForeColor = Color.White;
            btnMinimize_Click.Location = new Point(713, 1);
            btnMinimize_Click.Name = "btnMinimize_Click";
            btnMinimize_Click.Size = new Size(45, 45);
            btnMinimize_Click.TabIndex = 48;
            btnMinimize_Click.Text = "–";
            btnMinimize_Click.UseVisualStyleBackColor = true;
            btnMinimize_Click.Click += btnMinimize_Click_Click;
            btnMinimize_Click.MouseDown += DragArea_MouseDown;
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
            btnClose.TabIndex = 47;
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
            pbLogo.TabIndex = 49;
            pbLogo.TabStop = false;
            pbLogo.Click += pbLogo_Click;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(800, 405);
            Controls.Add(pbLogo);
            Controls.Add(btnMinimize_Click);
            Controls.Add(btnClose);
            Controls.Add(comboBoxAdminPanelRole);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnAdminPanelDelete);
            Controls.Add(btnAdminPanelEdit);
            Controls.Add(btnAdminPanelAdd);
            Controls.Add(listBoxAdminPanel);
            Controls.Add(btnAdminPanelReportPanel);
            Controls.Add(btnAdminPanelTechnicianPanel);
            Controls.Add(txtAdminPanelPassword);
            Controls.Add(txtAdminPanelUsername);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "System Administration Panel";
            Load += AdminPanel_Load;
            MouseDown += DragArea_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxAdminPanelRole;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button btnAdminPanelDelete;
        private Button btnAdminPanelEdit;
        private Button btnAdminPanelAdd;
        private ListBox listBoxAdminPanel;
        private Button btnAdminPanelReportPanel;
        private Button btnAdminPanelTechnicianPanel;
        private TextBox txtAdminPanelPassword;
        private TextBox txtAdminPanelUsername;
        private Button btnMinimize_Click;
        private Button btnClose;
        private PictureBox pbLogo;
    }
}