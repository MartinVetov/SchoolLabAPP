namespace SchoolLabApp.View
{
    partial class UserReturnPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserReturnPanel));
            btnUserReturnePanelBackToLoans = new Button();
            btnUserReturnePanelReturn = new Button();
            listBoxUserReturnPanel = new ListBox();
            pbLogo = new PictureBox();
            btnBackarrow = new Button();
            btnMinimize_Click = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // btnUserReturnePanelBackToLoans
            // 
            btnUserReturnePanelBackToLoans.BackColor = Color.FromArgb(63, 63, 70);
            btnUserReturnePanelBackToLoans.FlatAppearance.BorderSize = 0;
            btnUserReturnePanelBackToLoans.FlatStyle = FlatStyle.Flat;
            btnUserReturnePanelBackToLoans.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnUserReturnePanelBackToLoans.ForeColor = Color.White;
            btnUserReturnePanelBackToLoans.Location = new Point(386, 347);
            btnUserReturnePanelBackToLoans.Name = "btnUserReturnePanelBackToLoans";
            btnUserReturnePanelBackToLoans.Size = new Size(130, 35);
            btnUserReturnePanelBackToLoans.TabIndex = 30;
            btnUserReturnePanelBackToLoans.Text = "Back to loans";
            btnUserReturnePanelBackToLoans.UseVisualStyleBackColor = false;
            btnUserReturnePanelBackToLoans.Click += btnUserReturnePanelBackToLoans_Click;
            // 
            // btnUserReturnePanelReturn
            // 
            btnUserReturnePanelReturn.BackColor = Color.FromArgb(0, 122, 204);
            btnUserReturnePanelReturn.FlatAppearance.BorderSize = 0;
            btnUserReturnePanelReturn.FlatStyle = FlatStyle.Flat;
            btnUserReturnePanelReturn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnUserReturnePanelReturn.ForeColor = Color.White;
            btnUserReturnePanelReturn.Location = new Point(57, 347);
            btnUserReturnePanelReturn.Name = "btnUserReturnePanelReturn";
            btnUserReturnePanelReturn.Size = new Size(130, 35);
            btnUserReturnePanelReturn.TabIndex = 31;
            btnUserReturnePanelReturn.Text = "Return Item";
            btnUserReturnePanelReturn.UseVisualStyleBackColor = false;
            btnUserReturnePanelReturn.Click += btnUserReturnePanelReturn_Click;
            // 
            // listBoxUserReturnPanel
            // 
            listBoxUserReturnPanel.BackColor = Color.FromArgb(37, 37, 38);
            listBoxUserReturnPanel.BorderStyle = BorderStyle.None;
            listBoxUserReturnPanel.Font = new Font("Segoe UI", 10F);
            listBoxUserReturnPanel.ForeColor = Color.White;
            listBoxUserReturnPanel.FormattingEnabled = true;
            listBoxUserReturnPanel.Location = new Point(13, 73);
            listBoxUserReturnPanel.Name = "listBoxUserReturnPanel";
            listBoxUserReturnPanel.Size = new Size(543, 255);
            listBoxUserReturnPanel.TabIndex = 32;
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.SchoolabLogoSmall;
            pbLogo.Location = new Point(13, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(59, 45);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 63;
            pbLogo.TabStop = false;
            pbLogo.Click += pbLogo_Click;
            // 
            // btnBackarrow
            // 
            btnBackarrow.FlatAppearance.BorderSize = 0;
            btnBackarrow.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnBackarrow.FlatStyle = FlatStyle.Flat;
            btnBackarrow.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btnBackarrow.ForeColor = Color.White;
            btnBackarrow.Location = new Point(439, 0);
            btnBackarrow.Name = "btnBackarrow";
            btnBackarrow.Size = new Size(45, 45);
            btnBackarrow.TabIndex = 62;
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
            btnMinimize_Click.Location = new Point(481, 0);
            btnMinimize_Click.Name = "btnMinimize_Click";
            btnMinimize_Click.Size = new Size(45, 45);
            btnMinimize_Click.TabIndex = 61;
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
            btnClose.Location = new Point(523, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(45, 45);
            btnClose.TabIndex = 60;
            btnClose.Text = "x";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // UserReturnPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(568, 407);
            Controls.Add(pbLogo);
            Controls.Add(btnBackarrow);
            Controls.Add(btnMinimize_Click);
            Controls.Add(btnClose);
            Controls.Add(listBoxUserReturnPanel);
            Controls.Add(btnUserReturnePanelReturn);
            Controls.Add(btnUserReturnePanelBackToLoans);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UserReturnPanel";
            Text = "Return Panel";
            Load += UserReturnPanel_Load;
            MouseDown += DragArea_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnUserReturnePanelBackToLoans;
        private Button btnUserReturnePanelReturn;
        private ListBox listBoxUserReturnPanel;
        private PictureBox pbLogo;
        private Button btnBackarrow;
        private Button btnMinimize_Click;
        private Button btnClose;
    }
}