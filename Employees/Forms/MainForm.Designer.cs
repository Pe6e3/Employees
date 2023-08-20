namespace Employees
{
    partial class MainForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.employeeCardPanel = new System.Windows.Forms.Panel();
            this.iinField = new System.Windows.Forms.Label();
            this.midnameField = new System.Windows.Forms.Label();
            this.lastnameField = new System.Windows.Forms.Label();
            this.iinLabel = new System.Windows.Forms.Label();
            this.firstnameField = new System.Windows.Forms.Label();
            this.midnameLabel = new System.Windows.Forms.Label();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.employeePanel = new System.Windows.Forms.Panel();
            this.employeeCompanyLabel = new System.Windows.Forms.Label();
            this.listBoxEmployees = new System.Windows.Forms.ListBox();
            this.addEmployee = new System.Windows.Forms.Button();
            this.companyPanel = new System.Windows.Forms.Panel();
            this.companiesLabel = new System.Windows.Forms.Label();
            this.companyNoteField = new System.Windows.Forms.TextBox();
            this.listBoxCompanies = new System.Windows.Forms.ListBox();
            this.companyNameField = new System.Windows.Forms.Label();
            this.companyInnField = new System.Windows.Forms.Label();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.companyAddressField = new System.Windows.Forms.Label();
            this.companyIinLabel = new System.Windows.Forms.Label();
            this.companyAddressLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.employeePhoto = new System.Windows.Forms.PictureBox();
            this.newCompanyButton = new System.Windows.Forms.Button();
            this.employeeLabelsPanel = new System.Windows.Forms.Panel();
            this.exportCSV = new System.Windows.Forms.Button();
            this.importCSV = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.employeeCardPanel.SuspendLayout();
            this.employeePanel.SuspendLayout();
            this.companyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeePhoto)).BeginInit();
            this.employeeLabelsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.AutoSize = true;
            this.MainPanel.Controls.Add(this.employeeCardPanel);
            this.MainPanel.Controls.Add(this.employeePanel);
            this.MainPanel.Controls.Add(this.companyPanel);
            this.MainPanel.Controls.Add(this.exitButton);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1063, 471);
            this.MainPanel.TabIndex = 0;
            // 
            // employeeCardPanel
            // 
            this.employeeCardPanel.BackColor = System.Drawing.Color.PeachPuff;
            this.employeeCardPanel.Controls.Add(this.iinField);
            this.employeeCardPanel.Controls.Add(this.midnameField);
            this.employeeCardPanel.Controls.Add(this.lastnameField);
            this.employeeCardPanel.Controls.Add(this.iinLabel);
            this.employeeCardPanel.Controls.Add(this.firstnameField);
            this.employeeCardPanel.Controls.Add(this.midnameLabel);
            this.employeeCardPanel.Controls.Add(this.lastnameLabel);
            this.employeeCardPanel.Controls.Add(this.employeePhoto);
            this.employeeCardPanel.Controls.Add(this.firstnameLabel);
            this.employeeCardPanel.Location = new System.Drawing.Point(728, 23);
            this.employeeCardPanel.Name = "employeeCardPanel";
            this.employeeCardPanel.Size = new System.Drawing.Size(290, 433);
            this.employeeCardPanel.TabIndex = 11;
            // 
            // iinField
            // 
            this.iinField.AutoSize = true;
            this.iinField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.iinField.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iinField.Location = new System.Drawing.Point(96, 282);
            this.iinField.MinimumSize = new System.Drawing.Size(180, 0);
            this.iinField.Name = "iinField";
            this.iinField.Padding = new System.Windows.Forms.Padding(3);
            this.iinField.Size = new System.Drawing.Size(180, 30);
            this.iinField.TabIndex = 7;
            // 
            // midnameField
            // 
            this.midnameField.AutoSize = true;
            this.midnameField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.midnameField.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.midnameField.Location = new System.Drawing.Point(96, 244);
            this.midnameField.MinimumSize = new System.Drawing.Size(180, 0);
            this.midnameField.Name = "midnameField";
            this.midnameField.Padding = new System.Windows.Forms.Padding(3);
            this.midnameField.Size = new System.Drawing.Size(180, 30);
            this.midnameField.TabIndex = 7;
            // 
            // lastnameField
            // 
            this.lastnameField.AutoSize = true;
            this.lastnameField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lastnameField.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastnameField.Location = new System.Drawing.Point(96, 164);
            this.lastnameField.MinimumSize = new System.Drawing.Size(180, 0);
            this.lastnameField.Name = "lastnameField";
            this.lastnameField.Padding = new System.Windows.Forms.Padding(3);
            this.lastnameField.Size = new System.Drawing.Size(180, 30);
            this.lastnameField.TabIndex = 7;
            // 
            // iinLabel
            // 
            this.iinLabel.AutoSize = true;
            this.iinLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iinLabel.Location = new System.Drawing.Point(42, 286);
            this.iinLabel.Name = "iinLabel";
            this.iinLabel.Size = new System.Drawing.Size(48, 22);
            this.iinLabel.TabIndex = 7;
            this.iinLabel.Text = "ИИН:";
            // 
            // firstnameField
            // 
            this.firstnameField.AutoSize = true;
            this.firstnameField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.firstnameField.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstnameField.Location = new System.Drawing.Point(96, 204);
            this.firstnameField.MinimumSize = new System.Drawing.Size(180, 0);
            this.firstnameField.Name = "firstnameField";
            this.firstnameField.Padding = new System.Windows.Forms.Padding(3);
            this.firstnameField.Size = new System.Drawing.Size(180, 30);
            this.firstnameField.TabIndex = 7;
            // 
            // midnameLabel
            // 
            this.midnameLabel.AutoSize = true;
            this.midnameLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.midnameLabel.Location = new System.Drawing.Point(6, 247);
            this.midnameLabel.Name = "midnameLabel";
            this.midnameLabel.Size = new System.Drawing.Size(84, 22);
            this.midnameLabel.TabIndex = 7;
            this.midnameLabel.Text = "Отчество:";
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastnameLabel.Location = new System.Drawing.Point(8, 165);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(82, 22);
            this.lastnameLabel.TabIndex = 7;
            this.lastnameLabel.Text = "Фамилия:";
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstnameLabel.Location = new System.Drawing.Point(44, 208);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(46, 22);
            this.firstnameLabel.TabIndex = 7;
            this.firstnameLabel.Text = "Имя:";
            // 
            // employeePanel
            // 
            this.employeePanel.BackColor = System.Drawing.Color.PeachPuff;
            this.employeePanel.Controls.Add(this.importCSV);
            this.employeePanel.Controls.Add(this.exportCSV);
            this.employeePanel.Controls.Add(this.employeeLabelsPanel);
            this.employeePanel.Controls.Add(this.listBoxEmployees);
            this.employeePanel.Controls.Add(this.addEmployee);
            this.employeePanel.Location = new System.Drawing.Point(409, 23);
            this.employeePanel.Name = "employeePanel";
            this.employeePanel.Size = new System.Drawing.Size(301, 436);
            this.employeePanel.TabIndex = 10;
            // 
            // employeeCompanyLabel
            // 
            this.employeeCompanyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeCompanyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeCompanyLabel.Location = new System.Drawing.Point(0, 0);
            this.employeeCompanyLabel.Name = "employeeCompanyLabel";
            this.employeeCompanyLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.employeeCompanyLabel.Size = new System.Drawing.Size(300, 54);
            this.employeeCompanyLabel.TabIndex = 5;
            this.employeeCompanyLabel.Text = "Все сотрудники";
            this.employeeCompanyLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // listBoxEmployees
            // 
            this.listBoxEmployees.FormattingEnabled = true;
            this.listBoxEmployees.Location = new System.Drawing.Point(19, 55);
            this.listBoxEmployees.Name = "listBoxEmployees";
            this.listBoxEmployees.Size = new System.Drawing.Size(266, 277);
            this.listBoxEmployees.TabIndex = 4;
            this.listBoxEmployees.SelectedIndexChanged += new System.EventHandler(this.listBoxEmployees_SelectedIndexChanged);
            // 
            // addEmployee
            // 
            this.addEmployee.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.addEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee.Location = new System.Drawing.Point(19, 379);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(83, 50);
            this.addEmployee.TabIndex = 1;
            this.addEmployee.Text = "Добавить сотрудника";
            this.addEmployee.UseVisualStyleBackColor = false;
            this.addEmployee.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // companyPanel
            // 
            this.companyPanel.BackColor = System.Drawing.Color.PeachPuff;
            this.companyPanel.Controls.Add(this.newCompanyButton);
            this.companyPanel.Controls.Add(this.companiesLabel);
            this.companyPanel.Controls.Add(this.companyNoteField);
            this.companyPanel.Controls.Add(this.listBoxCompanies);
            this.companyPanel.Controls.Add(this.companyNameField);
            this.companyPanel.Controls.Add(this.companyInnField);
            this.companyPanel.Controls.Add(this.companyNameLabel);
            this.companyPanel.Controls.Add(this.companyAddressField);
            this.companyPanel.Controls.Add(this.companyIinLabel);
            this.companyPanel.Controls.Add(this.companyAddressLabel);
            this.companyPanel.Location = new System.Drawing.Point(39, 23);
            this.companyPanel.Name = "companyPanel";
            this.companyPanel.Size = new System.Drawing.Size(348, 436);
            this.companyPanel.TabIndex = 9;
            // 
            // companiesLabel
            // 
            this.companiesLabel.AutoSize = true;
            this.companiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.companiesLabel.Location = new System.Drawing.Point(107, 20);
            this.companiesLabel.Name = "companiesLabel";
            this.companiesLabel.Size = new System.Drawing.Size(126, 20);
            this.companiesLabel.TabIndex = 2;
            this.companiesLabel.Text = "Все компании";
            // 
            // companyNoteField
            // 
            this.companyNoteField.BackColor = System.Drawing.Color.PeachPuff;
            this.companyNoteField.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.companyNoteField.Location = new System.Drawing.Point(36, 286);
            this.companyNoteField.Multiline = true;
            this.companyNoteField.Name = "companyNoteField";
            this.companyNoteField.ReadOnly = true;
            this.companyNoteField.Size = new System.Drawing.Size(294, 104);
            this.companyNoteField.TabIndex = 8;
            this.companyNoteField.Text = "Примечание";
            // 
            // listBoxCompanies
            // 
            this.listBoxCompanies.FormattingEnabled = true;
            this.listBoxCompanies.Location = new System.Drawing.Point(36, 43);
            this.listBoxCompanies.Name = "listBoxCompanies";
            this.listBoxCompanies.Size = new System.Drawing.Size(294, 82);
            this.listBoxCompanies.TabIndex = 0;
            this.listBoxCompanies.SelectedIndexChanged += new System.EventHandler(this.listBoxCompanies_SelectedIndexChanged);
            // 
            // companyNameField
            // 
            this.companyNameField.AutoSize = true;
            this.companyNameField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.companyNameField.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.companyNameField.Location = new System.Drawing.Point(110, 134);
            this.companyNameField.MaximumSize = new System.Drawing.Size(220, 0);
            this.companyNameField.MinimumSize = new System.Drawing.Size(220, 0);
            this.companyNameField.Name = "companyNameField";
            this.companyNameField.Padding = new System.Windows.Forms.Padding(3);
            this.companyNameField.Size = new System.Drawing.Size(220, 30);
            this.companyNameField.TabIndex = 7;
            // 
            // companyInnField
            // 
            this.companyInnField.AutoSize = true;
            this.companyInnField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.companyInnField.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.companyInnField.Location = new System.Drawing.Point(110, 189);
            this.companyInnField.MaximumSize = new System.Drawing.Size(220, 0);
            this.companyInnField.MinimumSize = new System.Drawing.Size(220, 0);
            this.companyInnField.Name = "companyInnField";
            this.companyInnField.Padding = new System.Windows.Forms.Padding(3);
            this.companyInnField.Size = new System.Drawing.Size(220, 30);
            this.companyInnField.TabIndex = 7;
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.companyNameLabel.Location = new System.Drawing.Point(25, 139);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(83, 22);
            this.companyNameLabel.TabIndex = 7;
            this.companyNameLabel.Text = "Название:";
            // 
            // companyAddressField
            // 
            this.companyAddressField.AutoSize = true;
            this.companyAddressField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.companyAddressField.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.companyAddressField.Location = new System.Drawing.Point(110, 220);
            this.companyAddressField.MaximumSize = new System.Drawing.Size(220, 60);
            this.companyAddressField.MinimumSize = new System.Drawing.Size(220, 0);
            this.companyAddressField.Name = "companyAddressField";
            this.companyAddressField.Padding = new System.Windows.Forms.Padding(3);
            this.companyAddressField.Size = new System.Drawing.Size(220, 30);
            this.companyAddressField.TabIndex = 7;
            // 
            // companyIinLabel
            // 
            this.companyIinLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.companyIinLabel.AutoSize = true;
            this.companyIinLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.companyIinLabel.Location = new System.Drawing.Point(61, 194);
            this.companyIinLabel.Name = "companyIinLabel";
            this.companyIinLabel.Size = new System.Drawing.Size(47, 22);
            this.companyIinLabel.TabIndex = 7;
            this.companyIinLabel.Text = "ИНН:";
            // 
            // companyAddressLabel
            // 
            this.companyAddressLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.companyAddressLabel.AutoSize = true;
            this.companyAddressLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.companyAddressLabel.Location = new System.Drawing.Point(47, 226);
            this.companyAddressLabel.Name = "companyAddressLabel";
            this.companyAddressLabel.Size = new System.Drawing.Size(61, 22);
            this.companyAddressLabel.TabIndex = 7;
            this.companyAddressLabel.Text = "Адрес:";
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(1024, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(27, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "X";
            this.exitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.exitButton.UseCompatibleTextRendering = true;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // employeePhoto
            // 
            this.employeePhoto.Image = global::Employees.Properties.Resources.user;
            this.employeePhoto.InitialImage = null;
            this.employeePhoto.Location = new System.Drawing.Point(87, 30);
            this.employeePhoto.Name = "employeePhoto";
            this.employeePhoto.Size = new System.Drawing.Size(125, 119);
            this.employeePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.employeePhoto.TabIndex = 6;
            this.employeePhoto.TabStop = false;
            // 
            // newCompanyButton
            // 
            this.newCompanyButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.newCompanyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newCompanyButton.Location = new System.Drawing.Point(99, 396);
            this.newCompanyButton.Name = "newCompanyButton";
            this.newCompanyButton.Size = new System.Drawing.Size(134, 33);
            this.newCompanyButton.TabIndex = 18;
            this.newCompanyButton.Text = "Добавить компанию";
            this.newCompanyButton.UseVisualStyleBackColor = false;
            this.newCompanyButton.Click += new System.EventHandler(this.newCompanyButton_Click);
            // 
            // employeeLabelsPanel
            // 
            this.employeeLabelsPanel.Controls.Add(this.employeeCompanyLabel);
            this.employeeLabelsPanel.Location = new System.Drawing.Point(1, 0);
            this.employeeLabelsPanel.Name = "employeeLabelsPanel";
            this.employeeLabelsPanel.Size = new System.Drawing.Size(300, 54);
            this.employeeLabelsPanel.TabIndex = 6;
            // 
            // exportCSV
            // 
            this.exportCSV.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.exportCSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportCSV.Location = new System.Drawing.Point(202, 379);
            this.exportCSV.Name = "exportCSV";
            this.exportCSV.Size = new System.Drawing.Size(83, 50);
            this.exportCSV.TabIndex = 7;
            this.exportCSV.Text = "экспорт в CSV";
            this.exportCSV.UseVisualStyleBackColor = false;
            this.exportCSV.Click += new System.EventHandler(this.exportCSV_Click);
            // 
            // importCSV
            // 
            this.importCSV.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.importCSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importCSV.Location = new System.Drawing.Point(113, 379);
            this.importCSV.Name = "importCSV";
            this.importCSV.Size = new System.Drawing.Size(83, 50);
            this.importCSV.TabIndex = 7;
            this.importCSV.Text = "импорт из CSV";
            this.importCSV.UseVisualStyleBackColor = false;
            this.importCSV.Click += new System.EventHandler(this.importCSV_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1063, 471);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сотрудники компаний";
            this.TopMost = true;
            this.MainPanel.ResumeLayout(false);
            this.employeeCardPanel.ResumeLayout(false);
            this.employeeCardPanel.PerformLayout();
            this.employeePanel.ResumeLayout(false);
            this.companyPanel.ResumeLayout(false);
            this.companyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeePhoto)).EndInit();
            this.employeeLabelsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.ListBox listBoxCompanies;
        private System.Windows.Forms.Button addEmployee;
        private System.Windows.Forms.Label companiesLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox listBoxEmployees;
        private System.Windows.Forms.Label employeeCompanyLabel;
        private System.Windows.Forms.Label iinField;
        private System.Windows.Forms.Label midnameField;
        private System.Windows.Forms.Label lastnameField;
        private System.Windows.Forms.Label firstnameField;
        private System.Windows.Forms.PictureBox employeePhoto;
        private System.Windows.Forms.Label iinLabel;
        private System.Windows.Forms.Label midnameLabel;
        private System.Windows.Forms.Label lastnameLabel;
        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.Label companyAddressField;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.Label companyInnField;
        private System.Windows.Forms.Label companyNameField;
        private System.Windows.Forms.Label companyAddressLabel;
        private System.Windows.Forms.Label companyIinLabel;
        private System.Windows.Forms.TextBox companyNoteField;
        private System.Windows.Forms.Panel companyPanel;
        private System.Windows.Forms.Panel employeePanel;
        private System.Windows.Forms.Panel employeeCardPanel;
        private System.Windows.Forms.Button newCompanyButton;
        private System.Windows.Forms.Panel employeeLabelsPanel;
        private System.Windows.Forms.Button exportCSV;
        private System.Windows.Forms.Button importCSV;
    }
}

