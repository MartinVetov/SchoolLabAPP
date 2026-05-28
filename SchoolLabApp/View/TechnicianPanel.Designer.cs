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
            comboBoxTechnicianPanelCategory = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            listBoxTechnicianPanel = new ListBox();
            txtTechnicianPanelDescription = new TextBox();
            txtTechnicianPanelName = new TextBox();
            radioButtonTechnicianPanelStatusAvelible = new RadioButton();
            radioButtonTechnicianPanelStatusUnavelible = new RadioButton();
            radioButtonTechnicianPanelStatusBroken = new RadioButton();
            btnTechnicianPanelDelete = new Button();
            btnTechnicianPanelEdit = new Button();
            btnTechnicianPanelAdd = new Button();
            btnTechnicianPanelReportPanel = new Button();
            SuspendLayout();
            // 
            // comboBoxTechnicianPanelCategory
            // 
            comboBoxTechnicianPanelCategory.FormattingEnabled = true;
            comboBoxTechnicianPanelCategory.Items.AddRange(new object[] { "Computers", "Lab equipment", "Books" });
            comboBoxTechnicianPanelCategory.Location = new Point(30, 73);
            comboBoxTechnicianPanelCategory.Margin = new Padding(3, 4, 3, 4);
            comboBoxTechnicianPanelCategory.Name = "comboBoxTechnicianPanelCategory";
            comboBoxTechnicianPanelCategory.Size = new Size(227, 28);
            comboBoxTechnicianPanelCategory.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 305);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 27;
            label4.Text = "Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 217);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 26;
            label3.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 136);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 25;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 49);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 24;
            label1.Text = "Category";
            // 
            // listBoxTechnicianPanel
            // 
            listBoxTechnicianPanel.ForeColor = SystemColors.MenuText;
            listBoxTechnicianPanel.FormattingEnabled = true;
            listBoxTechnicianPanel.Location = new Point(311, 35);
            listBoxTechnicianPanel.Margin = new Padding(3, 4, 3, 4);
            listBoxTechnicianPanel.Name = "listBoxTechnicianPanel";
            listBoxTechnicianPanel.Size = new Size(573, 464);
            listBoxTechnicianPanel.TabIndex = 20;
            listBoxTechnicianPanel.SelectedIndexChanged += listBoxTechnicianPanel_SelectedIndexChanged;
            // 
            // txtTechnicianPanelDescription
            // 
            txtTechnicianPanelDescription.Location = new Point(30, 241);
            txtTechnicianPanelDescription.Margin = new Padding(3, 4, 3, 4);
            txtTechnicianPanelDescription.Multiline = true;
            txtTechnicianPanelDescription.Name = "txtTechnicianPanelDescription";
            txtTechnicianPanelDescription.Size = new Size(227, 29);
            txtTechnicianPanelDescription.TabIndex = 17;
            // 
            // txtTechnicianPanelName
            // 
            txtTechnicianPanelName.Location = new Point(30, 160);
            txtTechnicianPanelName.Margin = new Padding(3, 4, 3, 4);
            txtTechnicianPanelName.Name = "txtTechnicianPanelName";
            txtTechnicianPanelName.Size = new Size(227, 27);
            txtTechnicianPanelName.TabIndex = 16;
            // 
            // radioButtonTechnicianPanelStatusAvelible
            // 
            radioButtonTechnicianPanelStatusAvelible.AutoSize = true;
            radioButtonTechnicianPanelStatusAvelible.Location = new Point(41, 341);
            radioButtonTechnicianPanelStatusAvelible.Margin = new Padding(3, 4, 3, 4);
            radioButtonTechnicianPanelStatusAvelible.Name = "radioButtonTechnicianPanelStatusAvelible";
            radioButtonTechnicianPanelStatusAvelible.Size = new Size(84, 24);
            radioButtonTechnicianPanelStatusAvelible.TabIndex = 29;
            radioButtonTechnicianPanelStatusAvelible.TabStop = true;
            radioButtonTechnicianPanelStatusAvelible.Text = "Avelible";
            radioButtonTechnicianPanelStatusAvelible.UseVisualStyleBackColor = true;
            // 
            // radioButtonTechnicianPanelStatusUnavelible
            // 
            radioButtonTechnicianPanelStatusUnavelible.AutoSize = true;
            radioButtonTechnicianPanelStatusUnavelible.Location = new Point(41, 375);
            radioButtonTechnicianPanelStatusUnavelible.Margin = new Padding(3, 4, 3, 4);
            radioButtonTechnicianPanelStatusUnavelible.Name = "radioButtonTechnicianPanelStatusUnavelible";
            radioButtonTechnicianPanelStatusUnavelible.Size = new Size(100, 24);
            radioButtonTechnicianPanelStatusUnavelible.TabIndex = 30;
            radioButtonTechnicianPanelStatusUnavelible.TabStop = true;
            radioButtonTechnicianPanelStatusUnavelible.Text = "Unavelible";
            radioButtonTechnicianPanelStatusUnavelible.UseVisualStyleBackColor = true;
            // 
            // radioButtonTechnicianPanelStatusBroken
            // 
            radioButtonTechnicianPanelStatusBroken.AutoSize = true;
            radioButtonTechnicianPanelStatusBroken.Location = new Point(41, 408);
            radioButtonTechnicianPanelStatusBroken.Margin = new Padding(3, 4, 3, 4);
            radioButtonTechnicianPanelStatusBroken.Name = "radioButtonTechnicianPanelStatusBroken";
            radioButtonTechnicianPanelStatusBroken.Size = new Size(76, 24);
            radioButtonTechnicianPanelStatusBroken.TabIndex = 31;
            radioButtonTechnicianPanelStatusBroken.TabStop = true;
            radioButtonTechnicianPanelStatusBroken.Text = "Broken";
            radioButtonTechnicianPanelStatusBroken.UseVisualStyleBackColor = true;
            // 
            // btnTechnicianPanelDelete
            // 
            btnTechnicianPanelDelete.BackColor = Color.OrangeRed;
            btnTechnicianPanelDelete.FlatStyle = FlatStyle.Popup;
            btnTechnicianPanelDelete.Location = new Point(735, 525);
            btnTechnicianPanelDelete.Margin = new Padding(3, 4, 3, 4);
            btnTechnicianPanelDelete.Name = "btnTechnicianPanelDelete";
            btnTechnicianPanelDelete.Size = new Size(128, 37);
            btnTechnicianPanelDelete.TabIndex = 35;
            btnTechnicianPanelDelete.Text = "Delete";
            btnTechnicianPanelDelete.UseVisualStyleBackColor = false;
            btnTechnicianPanelDelete.Click += btnTechnicianPanelDelete_Click;
            // 
            // btnTechnicianPanelEdit
            // 
            btnTechnicianPanelEdit.BackColor = Color.Aquamarine;
            btnTechnicianPanelEdit.FlatStyle = FlatStyle.Popup;
            btnTechnicianPanelEdit.Location = new Point(536, 525);
            btnTechnicianPanelEdit.Margin = new Padding(3, 4, 3, 4);
            btnTechnicianPanelEdit.Name = "btnTechnicianPanelEdit";
            btnTechnicianPanelEdit.Size = new Size(128, 37);
            btnTechnicianPanelEdit.TabIndex = 34;
            btnTechnicianPanelEdit.Text = "Edit";
            btnTechnicianPanelEdit.UseVisualStyleBackColor = false;
            btnTechnicianPanelEdit.Click += btnTechnicianPanelEdit_Click;
            // 
            // btnTechnicianPanelAdd
            // 
            btnTechnicianPanelAdd.BackColor = Color.YellowGreen;
            btnTechnicianPanelAdd.FlatStyle = FlatStyle.Popup;
            btnTechnicianPanelAdd.Location = new Point(339, 525);
            btnTechnicianPanelAdd.Margin = new Padding(3, 4, 3, 4);
            btnTechnicianPanelAdd.Name = "btnTechnicianPanelAdd";
            btnTechnicianPanelAdd.Size = new Size(128, 37);
            btnTechnicianPanelAdd.TabIndex = 33;
            btnTechnicianPanelAdd.Text = "Add";
            btnTechnicianPanelAdd.UseVisualStyleBackColor = false;
            btnTechnicianPanelAdd.Click += btnTechnicianPanelAdd_Click;
            // 
            // btnTechnicianPanelReportPanel
            // 
            btnTechnicianPanelReportPanel.BackColor = Color.White;
            btnTechnicianPanelReportPanel.FlatAppearance.BorderColor = Color.Black;
            btnTechnicianPanelReportPanel.FlatAppearance.BorderSize = 4;
            btnTechnicianPanelReportPanel.FlatStyle = FlatStyle.Popup;
            btnTechnicianPanelReportPanel.ForeColor = SystemColors.ActiveCaptionText;
            btnTechnicianPanelReportPanel.Location = new Point(86, 525);
            btnTechnicianPanelReportPanel.Margin = new Padding(3, 4, 3, 4);
            btnTechnicianPanelReportPanel.Name = "btnTechnicianPanelReportPanel";
            btnTechnicianPanelReportPanel.Size = new Size(128, 37);
            btnTechnicianPanelReportPanel.TabIndex = 32;
            btnTechnicianPanelReportPanel.Text = "Report Panel";
            btnTechnicianPanelReportPanel.UseVisualStyleBackColor = false;
            btnTechnicianPanelReportPanel.Click += btnTechnicianPanelReportPanel_Click;
            // 
            // TechnicianPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(914, 600);
            Controls.Add(btnTechnicianPanelDelete);
            Controls.Add(btnTechnicianPanelEdit);
            Controls.Add(btnTechnicianPanelAdd);
            Controls.Add(btnTechnicianPanelReportPanel);
            Controls.Add(radioButtonTechnicianPanelStatusBroken);
            Controls.Add(radioButtonTechnicianPanelStatusUnavelible);
            Controls.Add(radioButtonTechnicianPanelStatusAvelible);
            Controls.Add(comboBoxTechnicianPanelCategory);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxTechnicianPanel);
            Controls.Add(txtTechnicianPanelDescription);
            Controls.Add(txtTechnicianPanelName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TechnicianPanel";
            Text = "TechnicianPanel";
            Load += TechnicianPanel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxTechnicianPanelCategory;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListBox listBoxTechnicianPanel;
        private TextBox txtTechnicianPanelDescription;
        private TextBox txtTechnicianPanelName;
        private RadioButton radioButtonTechnicianPanelStatusAvelible;
        private RadioButton radioButtonTechnicianPanelStatusUnavelible;
        private RadioButton radioButtonTechnicianPanelStatusBroken;
        private Button btnTechnicianPanelDelete;
        private Button btnTechnicianPanelEdit;
        private Button btnTechnicianPanelAdd;
        private Button btnTechnicianPanelReportPanel;
    }
}