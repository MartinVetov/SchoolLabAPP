namespace SchoolLabApp.View
{
    partial class Login
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
            label3 = new Label();
            label2 = new Label();
            txtLoginPassword = new TextBox();
            txtLoginUsername = new TextBox();
            checkBoxLogin = new CheckBox();
            btnLoginLogin = new Button();
            btnLoginRegister = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 300);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 30;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 219);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 29;
            label2.Text = "Username";
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Location = new Point(80, 324);
            txtLoginPassword.Margin = new Padding(3, 4, 3, 4);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.Size = new Size(227, 27);
            txtLoginPassword.TabIndex = 28;
            txtLoginPassword.UseSystemPasswordChar = true;
            // 
            // txtLoginUsername
            // 
            txtLoginUsername.Location = new Point(80, 243);
            txtLoginUsername.Margin = new Padding(3, 4, 3, 4);
            txtLoginUsername.Name = "txtLoginUsername";
            txtLoginUsername.Size = new Size(227, 27);
            txtLoginUsername.TabIndex = 27;
            // 
            // checkBoxLogin
            // 
            checkBoxLogin.AutoSize = true;
            checkBoxLogin.Location = new Point(176, 374);
            checkBoxLogin.Margin = new Padding(3, 4, 3, 4);
            checkBoxLogin.Name = "checkBoxLogin";
            checkBoxLogin.Size = new Size(132, 24);
            checkBoxLogin.TabIndex = 37;
            checkBoxLogin.Text = "Show Password";
            checkBoxLogin.UseVisualStyleBackColor = true;
            checkBoxLogin.CheckedChanged += checkBoxLogin_CheckedChanged;
            // 
            // btnLoginLogin
            // 
            btnLoginLogin.BackColor = Color.DodgerBlue;
            btnLoginLogin.FlatAppearance.BorderColor = Color.Black;
            btnLoginLogin.FlatAppearance.BorderSize = 0;
            btnLoginLogin.FlatStyle = FlatStyle.Flat;
            btnLoginLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnLoginLogin.ForeColor = SystemColors.Control;
            btnLoginLogin.Location = new Point(126, 414);
            btnLoginLogin.Margin = new Padding(3, 4, 3, 4);
            btnLoginLogin.Name = "btnLoginLogin";
            btnLoginLogin.Size = new Size(129, 59);
            btnLoginLogin.TabIndex = 39;
            btnLoginLogin.Text = "Log in";
            btnLoginLogin.UseVisualStyleBackColor = false;
            btnLoginLogin.Click += btnLoginLogin_Click;
            // 
            // btnLoginRegister
            // 
            btnLoginRegister.BackColor = Color.White;
            btnLoginRegister.FlatAppearance.BorderColor = Color.Black;
            btnLoginRegister.FlatAppearance.BorderSize = 4;
            btnLoginRegister.FlatStyle = FlatStyle.System;
            btnLoginRegister.ForeColor = SystemColors.ActiveCaptionText;
            btnLoginRegister.Location = new Point(215, 481);
            btnLoginRegister.Margin = new Padding(3, 4, 3, 4);
            btnLoginRegister.Name = "btnLoginRegister";
            btnLoginRegister.Size = new Size(93, 37);
            btnLoginRegister.TabIndex = 40;
            btnLoginRegister.Text = "Register";
            btnLoginRegister.UseVisualStyleBackColor = false;
            btnLoginRegister.Click += btnLoginRegister_Click;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnClose.Location = new Point(355, -2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(55, 45);
            btnClose.TabIndex = 41;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(408, 604);
            Controls.Add(btnClose);
            Controls.Add(btnLoginRegister);
            Controls.Add(btnLoginLogin);
            Controls.Add(checkBoxLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtLoginPassword);
            Controls.Add(txtLoginUsername);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private TextBox txtLoginPassword;
        private TextBox txtLoginUsername;
        private CheckBox checkBoxLogin;
        private Button btnLoginLogin;
        private Button btnLoginRegister;
        private Button btnClose;
    }
}