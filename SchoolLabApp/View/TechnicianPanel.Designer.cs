namespace SchoolLabApp.View
{
    partial class TechnicianPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TechnicianPanel));
            comboBoxTechnicianPanelCategory = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            listBoxTechnicianPanel = new ListBox();
            txtTechnicianPanelName = new TextBox();
            radioButtonTechnicianPanelStatusAvelible = new RadioButton();
            radioButtonTechnicianPanelStatusUnavelible = new RadioButton();
            radioButtonTechnicianPanelStatusBroken = new RadioButton();
            btnTechnicianPanelDelete = new Button();
            btnTechnicianPanelEdit = new Button();
            btnTechnicianPanelAdd = new Button();
            btnTechnicianPanelReportPanel = new Button();
            pictureBox1 = new PictureBox();
            btnMinimize = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBoxTechnicianPanelCategory
            // 
            comboBoxTechnicianPanelCategory.BackColor = Color.FromArgb(37, 37, 38);
            comboBoxTechnicianPanelCategory.FlatStyle = FlatStyle.Flat;
            comboBoxTechnicianPanelCategory.Font = new Font("Segoe UI", 10F);
            comboBoxTechnicianPanelCategory.ForeColor = Color.White;
            comboBoxTechnicianPanelCategory.FormattingEnabled = true;
            comboBoxTechnicianPanelCategory.Items.AddRange(new object[] { "Computers", "Lab equipment", "Books" });
            comboBoxTechnicianPanelCategory.Location = new Point(24, 121);
            comboBoxTechnicianPanelCategory.Name = "comboBoxTechnicianPanelCategory";
            comboBoxTechnicianPanelCategory.Size = new Size(199, 25);
            comboBoxTechnicianPanelCategory.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label4.Location = new Point(25, 252);
            label4.Name = "label4";
            label4.Size = new Size(46, 17);
            label4.TabIndex = 27;
            label4.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.Location = new Point(24, 163);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 25;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label1.Location = new Point(24, 103);
            label1.Name = "label1";
            label1.Size = new Size(64, 17);
            label1.TabIndex = 24;
            label1.Text = "Category";
            // 
            // listBoxTechnicianPanel
            // 
            listBoxTechnicianPanel.BackColor = Color.FromArgb(37, 37, 38);
            listBoxTechnicianPanel.BorderStyle = BorderStyle.None;
            listBoxTechnicianPanel.Font = new Font("Segoe UI", 10F);
            listBoxTechnicianPanel.ForeColor = Color.White;
            listBoxTechnicianPanel.FormattingEnabled = true;
            listBoxTechnicianPanel.Location = new Point(270, 49);
            listBoxTechnicianPanel.Name = "listBoxTechnicianPanel";
            listBoxTechnicianPanel.Size = new Size(502, 340);
            listBoxTechnicianPanel.TabIndex = 20;
            listBoxTechnicianPanel.SelectedIndexChanged += listBoxTechnicianPanel_SelectedIndexChanged;
            // 
            // txtTechnicianPanelName
            // 
            txtTechnicianPanelName.BackColor = Color.FromArgb(37, 37, 38);
            txtTechnicianPanelName.BorderStyle = BorderStyle.FixedSingle;
            txtTechnicianPanelName.Font = new Font("Segoe UI", 10F);
            txtTechnicianPanelName.ForeColor = Color.White;
            txtTechnicianPanelName.Location = new Point(24, 181);
            txtTechnicianPanelName.Name = "txtTechnicianPanelName";
            txtTechnicianPanelName.Size = new Size(199, 25);
            txtTechnicianPanelName.TabIndex = 16;
            // 
            // radioButtonTechnicianPanelStatusAvelible
            // 
            radioButtonTechnicianPanelStatusAvelible.AutoSize = true;
            radioButtonTechnicianPanelStatusAvelible.Font = new Font("Segoe UI", 9.75F);
            radioButtonTechnicianPanelStatusAvelible.Location = new Point(34, 279);
            radioButtonTechnicianPanelStatusAvelible.Name = "radioButtonTechnicianPanelStatusAvelible";
            radioButtonTechnicianPanelStatusAvelible.Size = new Size(78, 21);
            radioButtonTechnicianPanelStatusAvelible.TabIndex = 29;
            radioButtonTechnicianPanelStatusAvelible.TabStop = true;
            radioButtonTechnicianPanelStatusAvelible.Text = "Available";
            radioButtonTechnicianPanelStatusAvelible.UseVisualStyleBackColor = true;
            // 
            // radioButtonTechnicianPanelStatusUnavelible
            // 
            radioButtonTechnicianPanelStatusUnavelible.AutoSize = true;
            radioButtonTechnicianPanelStatusUnavelible.Font = new Font("Segoe UI", 9.75F);
            radioButtonTechnicianPanelStatusUnavelible.Location = new Point(34, 304);
            radioButtonTechnicianPanelStatusUnavelible.Name = "radioButtonTechnicianPanelStatusUnavelible";
            radioButtonTechnicianPanelStatusUnavelible.Size = new Size(93, 21);
            radioButtonTechnicianPanelStatusUnavelible.TabIndex = 30;
            radioButtonTechnicianPanelStatusUnavelible.TabStop = true;
            radioButtonTechnicianPanelStatusUnavelible.Text = "Unavailable";
            radioButtonTechnicianPanelStatusUnavelible.UseVisualStyleBackColor = true;
            // 
            // radioButtonTechnicianPanelStatusBroken
            // 
            radioButtonTechnicianPanelStatusBroken.AutoSize = true;
            radioButtonTechnicianPanelStatusBroken.Font = new Font("Segoe UI", 9.75F);
            radioButtonTechnicianPanelStatusBroken.Location = new Point(34, 329);
            radioButtonTechnicianPanelStatusBroken.Name = "radioButtonTechnicianPanelStatusBroken";
            radioButtonTechnicianPanelStatusBroken.Size = new Size(66, 21);
            radioButtonTechnicianPanelStatusBroken.TabIndex = 31;
            radioButtonTechnicianPanelStatusBroken.TabStop = true;
            radioButtonTechnicianPanelStatusBroken.Text = "Broken";
            radioButtonTechnicianPanelStatusBroken.UseVisualStyleBackColor = true;
            // 
            // btnTechnicianPanelDelete
            // 
            btnTechnicianPanelDelete.BackColor = Color.FromArgb(209, 52, 56);
            btnTechnicianPanelDelete.FlatAppearance.BorderSize = 0;
            btnTechnicianPanelDelete.FlatStyle = FlatStyle.Flat;
            btnTechnicianPanelDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnTechnicianPanelDelete.ForeColor = Color.White;
            btnTechnicianPanelDelete.Location = new Point(641, 417);
            btnTechnicianPanelDelete.Name = "btnTechnicianPanelDelete";
            btnTechnicianPanelDelete.Size = new Size(112, 32);
            btnTechnicianPanelDelete.TabIndex = 35;
            btnTechnicianPanelDelete.Text = "Delete";
            btnTechnicianPanelDelete.UseVisualStyleBackColor = false;
            btnTechnicianPanelDelete.Click += btnTechnicianPanelDelete_Click;
            // 
            // btnTechnicianPanelEdit
            // 
            btnTechnicianPanelEdit.BackColor = Color.FromArgb(0, 122, 204);
            btnTechnicianPanelEdit.FlatAppearance.BorderSize = 0;
            btnTechnicianPanelEdit.FlatStyle = FlatStyle.Flat;
            btnTechnicianPanelEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnTechnicianPanelEdit.ForeColor = Color.White;
            btnTechnicianPanelEdit.Location = new Point(467, 417);
            btnTechnicianPanelEdit.Name = "btnTechnicianPanelEdit";
            btnTechnicianPanelEdit.Size = new Size(112, 32);
            btnTechnicianPanelEdit.TabIndex = 34;
            btnTechnicianPanelEdit.Text = "Edit";
            btnTechnicianPanelEdit.UseVisualStyleBackColor = false;
            btnTechnicianPanelEdit.Click += btnTechnicianPanelEdit_Click;
            // 
            // btnTechnicianPanelAdd
            // 
            btnTechnicianPanelAdd.BackColor = Color.FromArgb(16, 124, 65);
            btnTechnicianPanelAdd.FlatAppearance.BorderSize = 0;
            btnTechnicianPanelAdd.FlatStyle = FlatStyle.Flat;
            btnTechnicianPanelAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnTechnicianPanelAdd.ForeColor = Color.White;
            btnTechnicianPanelAdd.Location = new Point(295, 417);
            btnTechnicianPanelAdd.Name = "btnTechnicianPanelAdd";
            btnTechnicianPanelAdd.Size = new Size(112, 32);
            btnTechnicianPanelAdd.TabIndex = 33;
            btnTechnicianPanelAdd.Text = "Add";
            btnTechnicianPanelAdd.UseVisualStyleBackColor = false;
            btnTechnicianPanelAdd.Click += btnTechnicianPanelAdd_Click;
            // 
            // btnTechnicianPanelReportPanel
            // 
            btnTechnicianPanelReportPanel.BackColor = Color.FromArgb(63, 63, 70);
            btnTechnicianPanelReportPanel.FlatAppearance.BorderSize = 0;
            btnTechnicianPanelReportPanel.FlatStyle = FlatStyle.Flat;
            btnTechnicianPanelReportPanel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnTechnicianPanelReportPanel.ForeColor = Color.White;
            btnTechnicianPanelReportPanel.Location = new Point(61, 417);
            btnTechnicianPanelReportPanel.Name = "btnTechnicianPanelReportPanel";
            btnTechnicianPanelReportPanel.Size = new Size(125, 32);
            btnTechnicianPanelReportPanel.TabIndex = 32;
            btnTechnicianPanelReportPanel.Text = "Report Log";
            btnTechnicianPanelReportPanel.UseVisualStyleBackColor = false;
            btnTechnicianPanelReportPanel.Click += btnTechnicianPanelReportPanel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.SchoolabLogoSmall;
            pictureBox1.Location = new Point(8, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 55;
            pictureBox1.TabStop = false;
            // 
            // btnMinimize
            // 
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(709, -2);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(45, 45);
            btnMinimize.TabIndex = 54;
            btnMinimize.Text = "–";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            btnMinimize.MouseDown += DragArea_MouseDown;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 52, 56);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(751, -2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(45, 45);
            btnClose.TabIndex = 53;
            btnClose.Text = "x";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // TechnicianPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(796, 483);
            Controls.Add(pictureBox1);
            Controls.Add(btnMinimize);
            Controls.Add(btnClose);
            Controls.Add(btnTechnicianPanelDelete);
            Controls.Add(btnTechnicianPanelEdit);
            Controls.Add(btnTechnicianPanelAdd);
            Controls.Add(btnTechnicianPanelReportPanel);
            Controls.Add(radioButtonTechnicianPanelStatusBroken);
            Controls.Add(radioButtonTechnicianPanelStatusUnavelible);
            Controls.Add(radioButtonTechnicianPanelStatusAvelible);
            Controls.Add(comboBoxTechnicianPanelCategory);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxTechnicianPanel);
            Controls.Add(txtTechnicianPanelName);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TechnicianPanel";
            Text = "Technician Management Dashboard";
            Load += TechnicianPanel_Load;
            MouseDown += DragArea_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxTechnicianPanelCategory;
        private Label label4;
        private Label label2;
        private Label label1;
        private ListBox listBoxTechnicianPanel;
        private TextBox txtTechnicianPanelName;
        private RadioButton radioButtonTechnicianPanelStatusAvelible;
        private RadioButton radioButtonTechnicianPanelStatusUnavelible;
        private RadioButton radioButtonTechnicianPanelStatusBroken;
        private Button btnTechnicianPanelDelete;
        private Button btnTechnicianPanelEdit;
        private Button btnTechnicianPanelAdd;
        private Button btnTechnicianPanelReportPanel;
        private PictureBox pictureBox1;
        private Button btnMinimize;
        private Button btnClose;
    }
}