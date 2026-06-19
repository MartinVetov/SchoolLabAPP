namespace SchoolLabApp.View
{
    partial class TechnicianPasswordPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TechnicianPasswordPanel));
            txtTechnicianPasswordPanelPassword = new TextBox();
            btnTechnicianPasswordPanelRegister = new Button();
            checkBoxTechnicianPasswordPanel = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            btnMinimize = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // txtTechnicianPasswordPanelPassword
            // 
            txtTechnicianPasswordPanelPassword.BackColor = Color.FromArgb(37, 37, 38);
            txtTechnicianPasswordPanelPassword.BorderStyle = BorderStyle.FixedSingle;
            txtTechnicianPasswordPanelPassword.Font = new Font("Segoe UI", 10F);
            txtTechnicianPasswordPanelPassword.ForeColor = Color.White;
            txtTechnicianPasswordPanelPassword.Location = new Point(21, 86);
            txtTechnicianPasswordPanelPassword.Name = "txtTechnicianPasswordPanelPassword";
            txtTechnicianPasswordPanelPassword.PasswordChar = '●';
            txtTechnicianPasswordPanelPassword.Size = new Size(234, 25);
            txtTechnicianPasswordPanelPassword.TabIndex = 16;
            // 
            // btnTechnicianPasswordPanelRegister
            // 
            btnTechnicianPasswordPanelRegister.BackColor = Color.FromArgb(0, 122, 204);
            btnTechnicianPasswordPanelRegister.FlatAppearance.BorderSize = 0;
            btnTechnicianPasswordPanelRegister.FlatStyle = FlatStyle.Flat;
            btnTechnicianPasswordPanelRegister.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnTechnicianPasswordPanelRegister.ForeColor = Color.White;
            btnTechnicianPasswordPanelRegister.Location = new Point(73, 164);
            btnTechnicianPasswordPanelRegister.Name = "btnTechnicianPasswordPanelRegister";
            btnTechnicianPasswordPanelRegister.Size = new Size(130, 35);
            btnTechnicianPasswordPanelRegister.TabIndex = 33;
            btnTechnicianPasswordPanelRegister.Text = "Register";
            btnTechnicianPasswordPanelRegister.UseVisualStyleBackColor = false;
            btnTechnicianPasswordPanelRegister.Click += btnTechnicianPasswordPanelRegister_Click;
            // 
            // checkBoxTechnicianPasswordPanel
            // 
            checkBoxTechnicianPasswordPanel.AutoSize = true;
            checkBoxTechnicianPasswordPanel.Location = new Point(240, 125);
            checkBoxTechnicianPasswordPanel.Name = "checkBoxTechnicianPasswordPanel";
            checkBoxTechnicianPasswordPanel.Size = new Size(15, 14);
            checkBoxTechnicianPasswordPanel.TabIndex = 34;
            checkBoxTechnicianPasswordPanel.UseVisualStyleBackColor = true;
            checkBoxTechnicianPasswordPanel.CheckedChanged += checkBoxTechnicianPasswordPanel_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label1.Location = new Point(12, 66);
            label1.Name = "label1";
            label1.Size = new Size(252, 17);
            label1.TabIndex = 35;
            label1.Text = "Technician Password (contact an Admin)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(143, 124);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 36;
            label2.Text = "Show Password";
            // 
            // btnMinimize
            // 
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(198, 1);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(38, 45);
            btnMinimize.TabIndex = 50;
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
            btnClose.Location = new Point(240, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(38, 45);
            btnClose.TabIndex = 49;
            btnClose.Text = "x";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // TechnicianPasswordPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(278, 219);
            Controls.Add(btnMinimize);
            Controls.Add(btnClose);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBoxTechnicianPasswordPanel);
            Controls.Add(btnTechnicianPasswordPanelRegister);
            Controls.Add(txtTechnicianPasswordPanelPassword);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TechnicianPasswordPanel";
            Text = "Verification";
            MouseDown += DragArea_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTechnicianPasswordPanelPassword;
        private Button btnTechnicianPasswordPanelRegister;
        private CheckBox checkBoxTechnicianPasswordPanel;
        private Label label1;
        private Label label2;
        private Button btnMinimize;
        private Button btnClose;
    }
}