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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label3 = new Label();
            label2 = new Label();
            txtLoginPassword = new TextBox();
            txtLoginUsername = new TextBox();
            checkBoxLogin = new CheckBox();
            btnLoginLogin = new Button();
            btnClose = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            btnMinimize_Click = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(80, 314);
            label3.Name = "label3";
            label3.Size = new Size(68, 19);
            label3.TabIndex = 30;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.Location = new Point(80, 234);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 29;
            label2.Text = "Username";
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.BackColor = Color.FromArgb(37, 37, 38);
            txtLoginPassword.BorderStyle = BorderStyle.FixedSingle;
            txtLoginPassword.Font = new Font("Segoe UI", 11F);
            txtLoginPassword.ForeColor = Color.White;
            txtLoginPassword.Location = new Point(80, 337);
            txtLoginPassword.Margin = new Padding(3, 4, 3, 4);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.Size = new Size(247, 27);
            txtLoginPassword.TabIndex = 28;
            txtLoginPassword.UseSystemPasswordChar = true;
            // 
            // txtLoginUsername
            // 
            txtLoginUsername.BackColor = Color.FromArgb(37, 37, 38);
            txtLoginUsername.BorderStyle = BorderStyle.FixedSingle;
            txtLoginUsername.Font = new Font("Segoe UI", 11F);
            txtLoginUsername.ForeColor = Color.White;
            txtLoginUsername.Location = new Point(80, 257);
            txtLoginUsername.Margin = new Padding(3, 4, 3, 4);
            txtLoginUsername.Name = "txtLoginUsername";
            txtLoginUsername.Size = new Size(247, 27);
            txtLoginUsername.TabIndex = 27;
            // 
            // checkBoxLogin
            // 
            checkBoxLogin.AutoSize = true;
            checkBoxLogin.Font = new Font("Segoe UI", 9F);
            checkBoxLogin.Location = new Point(220, 372);
            checkBoxLogin.Margin = new Padding(3, 4, 3, 4);
            checkBoxLogin.Name = "checkBoxLogin";
            checkBoxLogin.Size = new Size(108, 19);
            checkBoxLogin.TabIndex = 37;
            checkBoxLogin.Text = "Show Password";
            checkBoxLogin.UseVisualStyleBackColor = true;
            checkBoxLogin.CheckedChanged += checkBoxLogin_CheckedChanged;
            // 
            // btnLoginLogin
            // 
            btnLoginLogin.BackColor = Color.FromArgb(0, 122, 204);
            btnLoginLogin.FlatAppearance.BorderSize = 0;
            btnLoginLogin.FlatStyle = FlatStyle.Flat;
            btnLoginLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLoginLogin.ForeColor = Color.White;
            btnLoginLogin.Location = new Point(80, 429);
            btnLoginLogin.Margin = new Padding(3, 4, 3, 4);
            btnLoginLogin.Name = "btnLoginLogin";
            btnLoginLogin.Size = new Size(247, 45);
            btnLoginLogin.TabIndex = 39;
            btnLoginLogin.Text = "Log In";
            btnLoginLogin.UseVisualStyleBackColor = false;
            btnLoginLogin.Click += btnLoginLogin_Click;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 52, 56);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(363, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(45, 45);
            btnClose.TabIndex = 41;
            btnClose.Text = "x";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.SchoolabLogo_1_;
            pictureBox1.Location = new Point(43, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(314, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 514);
            label1.Name = "label1";
            label1.Size = new Size(184, 19);
            label1.TabIndex = 43;
            label1.Text = "If you don't have an account";
            label1.Click += label1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.SkyBlue;
            linkLabel1.Location = new Point(245, 514);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(55, 19);
            linkLabel1.TabIndex = 44;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "register";
            linkLabel1.LinkClicked += btnLoginRegister_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(297, 514);
            label4.Name = "label4";
            label4.Size = new Size(39, 19);
            label4.TabIndex = 45;
            label4.Text = "here.";
            // 
            // btnMinimize_Click
            // 
            btnMinimize_Click.FlatAppearance.BorderSize = 0;
            btnMinimize_Click.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnMinimize_Click.FlatStyle = FlatStyle.Flat;
            btnMinimize_Click.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btnMinimize_Click.ForeColor = Color.White;
            btnMinimize_Click.Location = new Point(321, 0);
            btnMinimize_Click.Name = "btnMinimize_Click";
            btnMinimize_Click.Size = new Size(45, 45);
            btnMinimize_Click.TabIndex = 46;
            btnMinimize_Click.Text = "–";
            btnMinimize_Click.UseVisualStyleBackColor = true;
            btnMinimize_Click.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(408, 600);
            Controls.Add(btnMinimize_Click);
            Controls.Add(label4);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnClose);
            Controls.Add(btnLoginLogin);
            Controls.Add(checkBoxLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtLoginPassword);
            Controls.Add(txtLoginUsername);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            MouseDown += DragArea_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Button btnClose;
        private PictureBox pictureBox1;
        private Label label1;
        private LinkLabel linkLabel1;
        private Label label4;
        private Button btnMinimize_Click;
    }
}