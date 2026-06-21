namespace SchoolLabApp.View
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            label1 = new Label();
            checkBoxRegister = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            txtRegisterPasswordConfirm = new TextBox();
            txtRegisterPassword = new TextBox();
            label6 = new Label();
            txtRegisterUsername = new TextBox();
            label4 = new Label();
            btnRegisterRegister = new Button();
            comboBoxRegisterRole = new ComboBox();
            btnMinimize_Click = new Button();
            pictureBox1 = new PictureBox();
            btnClose = new Button();
            label5 = new Label();
            linkLabel1 = new LinkLabel();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(196, 392);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 44;
            label1.Text = "Show Password";
            // 
            // checkBoxRegister
            // 
            checkBoxRegister.AutoSize = true;
            checkBoxRegister.Location = new Point(291, 392);
            checkBoxRegister.Name = "checkBoxRegister";
            checkBoxRegister.Size = new Size(15, 14);
            checkBoxRegister.TabIndex = 43;
            checkBoxRegister.UseVisualStyleBackColor = true;
            checkBoxRegister.CheckedChanged += checkBoxRegister_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label3.Location = new Point(107, 334);
            label3.Name = "label3";
            label3.Size = new Size(118, 17);
            label3.TabIndex = 42;
            label3.Text = "Confirm Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.Location = new Point(107, 273);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 41;
            label2.Text = "Password";
            // 
            // txtRegisterPasswordConfirm
            // 
            txtRegisterPasswordConfirm.BackColor = Color.FromArgb(37, 37, 38);
            txtRegisterPasswordConfirm.BorderStyle = BorderStyle.FixedSingle;
            txtRegisterPasswordConfirm.Font = new Font("Segoe UI", 10F);
            txtRegisterPasswordConfirm.ForeColor = Color.White;
            txtRegisterPasswordConfirm.Location = new Point(107, 354);
            txtRegisterPasswordConfirm.Name = "txtRegisterPasswordConfirm";
            txtRegisterPasswordConfirm.Size = new Size(205, 25);
            txtRegisterPasswordConfirm.TabIndex = 40;
            txtRegisterPasswordConfirm.UseSystemPasswordChar = true;
            txtRegisterPasswordConfirm.TextChanged += txtRegisterPasswordConfirm_TextChanged;
            // 
            // txtRegisterPassword
            // 
            txtRegisterPassword.BackColor = Color.FromArgb(37, 37, 38);
            txtRegisterPassword.BorderStyle = BorderStyle.FixedSingle;
            txtRegisterPassword.Font = new Font("Segoe UI", 10F);
            txtRegisterPassword.ForeColor = Color.White;
            txtRegisterPassword.Location = new Point(107, 293);
            txtRegisterPassword.Name = "txtRegisterPassword";
            txtRegisterPassword.Size = new Size(205, 25);
            txtRegisterPassword.TabIndex = 39;
            txtRegisterPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label6.Location = new Point(107, 214);
            label6.Name = "label6";
            label6.Size = new Size(69, 17);
            label6.TabIndex = 47;
            label6.Text = "Username";
            // 
            // txtRegisterUsername
            // 
            txtRegisterUsername.BackColor = Color.FromArgb(37, 37, 38);
            txtRegisterUsername.BorderStyle = BorderStyle.FixedSingle;
            txtRegisterUsername.Font = new Font("Segoe UI", 10F);
            txtRegisterUsername.ForeColor = Color.White;
            txtRegisterUsername.Location = new Point(107, 234);
            txtRegisterUsername.Name = "txtRegisterUsername";
            txtRegisterUsername.Size = new Size(205, 25);
            txtRegisterUsername.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label4.Location = new Point(107, 421);
            label4.Name = "label4";
            label4.Size = new Size(34, 17);
            label4.TabIndex = 49;
            label4.Text = "Role";
            // 
            // btnRegisterRegister
            // 
            btnRegisterRegister.BackColor = Color.FromArgb(16, 124, 65);
            btnRegisterRegister.FlatAppearance.BorderSize = 0;
            btnRegisterRegister.FlatStyle = FlatStyle.Flat;
            btnRegisterRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegisterRegister.ForeColor = Color.White;
            btnRegisterRegister.Location = new Point(107, 501);
            btnRegisterRegister.Name = "btnRegisterRegister";
            btnRegisterRegister.Size = new Size(205, 38);
            btnRegisterRegister.TabIndex = 51;
            btnRegisterRegister.Text = "Register Account";
            btnRegisterRegister.UseVisualStyleBackColor = false;
            btnRegisterRegister.Click += btnRegisterRegister_Click;
            // 
            // comboBoxRegisterRole
            // 
            comboBoxRegisterRole.BackColor = Color.FromArgb(37, 37, 38);
            comboBoxRegisterRole.FlatStyle = FlatStyle.Flat;
            comboBoxRegisterRole.Font = new Font("Segoe UI", 10F);
            comboBoxRegisterRole.ForeColor = Color.White;
            comboBoxRegisterRole.FormattingEnabled = true;
            comboBoxRegisterRole.Items.AddRange(new object[] { "Teacher" });
            comboBoxRegisterRole.Location = new Point(107, 441);
            comboBoxRegisterRole.Name = "comboBoxRegisterRole";
            comboBoxRegisterRole.Size = new Size(205, 25);
            comboBoxRegisterRole.TabIndex = 52;
            // 
            // btnMinimize_Click
            // 
            btnMinimize_Click.FlatAppearance.BorderSize = 0;
            btnMinimize_Click.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnMinimize_Click.FlatStyle = FlatStyle.Flat;
            btnMinimize_Click.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btnMinimize_Click.ForeColor = Color.White;
            btnMinimize_Click.Location = new Point(330, -8);
            btnMinimize_Click.Name = "btnMinimize_Click";
            btnMinimize_Click.Size = new Size(45, 45);
            btnMinimize_Click.TabIndex = 55;
            btnMinimize_Click.Text = "–";
            btnMinimize_Click.UseVisualStyleBackColor = true;
            btnMinimize_Click.Click += btnMinimize_Click_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.SchoolabLogo_1_;
            pictureBox1.Location = new Point(52, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(314, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 54;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 52, 56);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(372, -8);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(45, 45);
            btnClose.TabIndex = 53;
            btnClose.Text = "x";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(271, 558);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 58;
            label5.Text = "here.";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.SkyBlue;
            linkLabel1.Location = new Point(239, 558);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(37, 15);
            linkLabel1.TabIndex = 57;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "log in";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(116, 558);
            label7.Name = "label7";
            label7.Size = new Size(127, 15);
            label7.TabIndex = 56;
            label7.Text = "If you have an account";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(419, 642);
            Controls.Add(label5);
            Controls.Add(linkLabel1);
            Controls.Add(label7);
            Controls.Add(btnMinimize_Click);
            Controls.Add(pictureBox1);
            Controls.Add(btnClose);
            Controls.Add(comboBoxRegisterRole);
            Controls.Add(btnRegisterRegister);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(txtRegisterUsername);
            Controls.Add(label1);
            Controls.Add(checkBoxRegister);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtRegisterPasswordConfirm);
            Controls.Add(txtRegisterPassword);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Account";
            Load += Register_Load;
            MouseDown += DragArea_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox checkBoxRegister;
        private Label label3;
        private Label label2;
        private TextBox txtRegisterPasswordConfirm;
        private TextBox txtRegisterPassword;
        private Label label6;
        private TextBox txtRegisterUsername;
        private Label label4;
        private Button btnRegisterRegister;
        private ComboBox comboBoxRegisterRole;
        private Button btnMinimize_Click;
        private PictureBox pictureBox1;
        private Button btnClose;
        private Label label5;
        private LinkLabel linkLabel1;
        private Label label7;
    }
}