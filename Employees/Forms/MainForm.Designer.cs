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
            this.companyNoteField = new System.Windows.Forms.TextBox();
            this.iinLabel = new System.Windows.Forms.Label();
            this.iinField = new System.Windows.Forms.Label();
            this.midnameLabel = new System.Windows.Forms.Label();
            this.companyAddressField = new System.Windows.Forms.Label();
            this.midnameField = new System.Windows.Forms.Label();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.companyAddressLabel = new System.Windows.Forms.Label();
            this.companyIinLabel = new System.Windows.Forms.Label();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.companyInnField = new System.Windows.Forms.Label();
            this.lastnameField = new System.Windows.Forms.Label();
            this.companyNameField = new System.Windows.Forms.Label();
            this.firstnameField = new System.Windows.Forms.Label();
            this.employeePhoto = new System.Windows.Forms.PictureBox();
            this.employeeCompanyLabel = new System.Windows.Forms.Label();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.listBoxEmployees = new System.Windows.Forms.ListBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.companiesLabel = new System.Windows.Forms.Label();
            this.addEmployee = new System.Windows.Forms.Button();
            this.listBoxCompanies = new System.Windows.Forms.ListBox();
            this.companyPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeePhoto)).BeginInit();
            this.companyPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.AutoSize = true;
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Controls.Add(this.companyPanel);
            this.MainPanel.Controls.Add(this.exitButton);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1063, 471);
            this.MainPanel.TabIndex = 0;
            // 
            // companyNoteField
            // 
            this.companyNoteField.BackColor = System.Drawing.Color.PeachPuff;
            this.companyNoteField.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.companyNoteField.Location = new System.Drawing.Point(36, 321);
            this.companyNoteField.Multiline = true;
            this.companyNoteField.Name = "companyNoteField";
            this.companyNoteField.ReadOnly = true;
            this.companyNoteField.Size = new System.Drawing.Size(294, 94);
            this.companyNoteField.TabIndex = 8;
            this.companyNoteField.Text = "Примечание";
            // 
            // iinLabel
            // 
            this.iinLabel.AutoSize = true;
            this.iinLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iinLabel.Location = new System.Drawing.Point(42, 277);
            this.iinLabel.Name = "iinLabel";
            this.iinLabel.Size = new System.Drawing.Size(48, 22);
            this.iinLabel.TabIndex = 7;
            this.iinLabel.Text = "ИИН:";
            // 
            // iinField
            // 
            this.iinField.AutoSize = true;
            this.iinField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.iinField.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iinField.Location = new System.Drawing.Point(96, 276);
            this.iinField.MinimumSize = new System.Drawing.Size(180, 0);
            this.iinField.Name = "iinField";
            this.iinField.Padding = new System.Windows.Forms.Padding(3);
            this.iinField.Size = new System.Drawing.Size(180, 30);
            this.iinField.TabIndex = 7;
            // 
            // midnameLabel
            // 
            this.midnameLabel.AutoSize = true;
            this.midnameLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.midnameLabel.Location = new System.Drawing.Point(6, 245);
            this.midnameLabel.Name = "midnameLabel";
            this.midnameLabel.Size = new System.Drawing.Size(84, 22);
            this.midnameLabel.TabIndex = 7;
            this.midnameLabel.Text = "Отчество:";
            // 
            // companyAddressField
            // 
            this.companyAddressField.AutoSize = true;
            this.companyAddressField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.companyAddressField.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.companyAddressField.Location = new System.Drawing.Point(110, 272);
            this.companyAddressField.MaximumSize = new System.Drawing.Size(220, 0);
            this.companyAddressField.MinimumSize = new System.Drawing.Size(220, 0);
            this.companyAddressField.Name = "companyAddressField";
            this.companyAddressField.Padding = new System.Windows.Forms.Padding(3);
            this.companyAddressField.Size = new System.Drawing.Size(220, 30);
            this.companyAddressField.TabIndex = 7;
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
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastnameLabel.Location = new System.Drawing.Point(8, 214);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(82, 22);
            this.lastnameLabel.TabIndex = 7;
            this.lastnameLabel.Text = "Фамилия:";
            // 
            // companyAddressLabel
            // 
            this.companyAddressLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.companyAddressLabel.AutoSize = true;
            this.companyAddressLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.companyAddressLabel.Location = new System.Drawing.Point(47, 278);
            this.companyAddressLabel.Name = "companyAddressLabel";
            this.companyAddressLabel.Size = new System.Drawing.Size(61, 22);
            this.companyAddressLabel.TabIndex = 7;
            this.companyAddressLabel.Text = "Адрес:";
            // 
            // companyIinLabel
            // 
            this.companyIinLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.companyIinLabel.AutoSize = true;
            this.companyIinLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.companyIinLabel.Location = new System.Drawing.Point(61, 246);
            this.companyIinLabel.Name = "companyIinLabel";
            this.companyIinLabel.Size = new System.Drawing.Size(47, 22);
            this.companyIinLabel.TabIndex = 7;
            this.companyIinLabel.Text = "ИНН:";
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.companyNameLabel.Location = new System.Drawing.Point(25, 212);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(83, 22);
            this.companyNameLabel.TabIndex = 7;
            this.companyNameLabel.Text = "Название:";
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstnameLabel.Location = new System.Drawing.Point(44, 180);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(46, 22);
            this.firstnameLabel.TabIndex = 7;
            this.firstnameLabel.Text = "Имя:";
            // 
            // companyInnField
            // 
            this.companyInnField.AutoSize = true;
            this.companyInnField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.companyInnField.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.companyInnField.Location = new System.Drawing.Point(110, 241);
            this.companyInnField.MaximumSize = new System.Drawing.Size(220, 0);
            this.companyInnField.MinimumSize = new System.Drawing.Size(220, 0);
            this.companyInnField.Name = "companyInnField";
            this.companyInnField.Padding = new System.Windows.Forms.Padding(3);
            this.companyInnField.Size = new System.Drawing.Size(220, 30);
            this.companyInnField.TabIndex = 7;
            // 
            // lastnameField
            // 
            this.lastnameField.AutoSize = true;
            this.lastnameField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lastnameField.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastnameField.Location = new System.Drawing.Point(96, 213);
            this.lastnameField.MinimumSize = new System.Drawing.Size(180, 0);
            this.lastnameField.Name = "lastnameField";
            this.lastnameField.Padding = new System.Windows.Forms.Padding(3);
            this.lastnameField.Size = new System.Drawing.Size(180, 30);
            this.lastnameField.TabIndex = 7;
            // 
            // companyNameField
            // 
            this.companyNameField.AutoSize = true;
            this.companyNameField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.companyNameField.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.companyNameField.Location = new System.Drawing.Point(110, 207);
            this.companyNameField.MaximumSize = new System.Drawing.Size(220, 0);
            this.companyNameField.MinimumSize = new System.Drawing.Size(220, 0);
            this.companyNameField.Name = "companyNameField";
            this.companyNameField.Padding = new System.Windows.Forms.Padding(3);
            this.companyNameField.Size = new System.Drawing.Size(220, 30);
            this.companyNameField.TabIndex = 7;
            // 
            // firstnameField
            // 
            this.firstnameField.AutoSize = true;
            this.firstnameField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.firstnameField.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstnameField.Location = new System.Drawing.Point(96, 179);
            this.firstnameField.MinimumSize = new System.Drawing.Size(180, 0);
            this.firstnameField.Name = "firstnameField";
            this.firstnameField.Padding = new System.Windows.Forms.Padding(3);
            this.firstnameField.Size = new System.Drawing.Size(180, 30);
            this.firstnameField.TabIndex = 7;
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
            // employeeCompanyLabel
            // 
            this.employeeCompanyLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.employeeCompanyLabel.AutoSize = true;
            this.employeeCompanyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeCompanyLabel.Location = new System.Drawing.Point(50, 10);
            this.employeeCompanyLabel.Name = "employeeCompanyLabel";
            this.employeeCompanyLabel.Size = new System.Drawing.Size(196, 20);
            this.employeeCompanyLabel.TabIndex = 5;
            this.employeeCompanyLabel.Text = "Сотрудники компании";
            this.employeeCompanyLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // employeeLabel
            // 
            this.employeeLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeLabel.Location = new System.Drawing.Point(78, 30);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(143, 20);
            this.employeeLabel.TabIndex = 5;
            this.employeeLabel.Text = "Все сотрудники";
            this.employeeLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // listBoxEmployees
            // 
            this.listBoxEmployees.FormattingEnabled = true;
            this.listBoxEmployees.Location = new System.Drawing.Point(19, 55);
            this.listBoxEmployees.Name = "listBoxEmployees";
            this.listBoxEmployees.Size = new System.Drawing.Size(266, 316);
            this.listBoxEmployees.TabIndex = 4;
            this.listBoxEmployees.SelectedIndexChanged += new System.EventHandler(this.listBoxEmployees_SelectedIndexChanged);
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
            // addEmployee
            // 
            this.addEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee.Location = new System.Drawing.Point(75, 401);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(146, 23);
            this.addEmployee.TabIndex = 1;
            this.addEmployee.Text = "Добавить сотрудника";
            this.addEmployee.UseVisualStyleBackColor = true;
            this.addEmployee.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // listBoxCompanies
            // 
            this.listBoxCompanies.FormattingEnabled = true;
            this.listBoxCompanies.Location = new System.Drawing.Point(36, 43);
            this.listBoxCompanies.Name = "listBoxCompanies";
            this.listBoxCompanies.Size = new System.Drawing.Size(294, 147);
            this.listBoxCompanies.TabIndex = 0;
            this.listBoxCompanies.SelectedIndexChanged += new System.EventHandler(this.listBoxCompanies_SelectedIndexChanged);
            // 
            // companyPanel
            // 
            this.companyPanel.BackColor = System.Drawing.Color.PeachPuff;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.employeeCompanyLabel);
            this.panel1.Controls.Add(this.employeeLabel);
            this.panel1.Controls.Add(this.listBoxEmployees);
            this.panel1.Controls.Add(this.addEmployee);
            this.panel1.Location = new System.Drawing.Point(409, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 436);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.iinField);
            this.panel2.Controls.Add(this.midnameField);
            this.panel2.Controls.Add(this.lastnameField);
            this.panel2.Controls.Add(this.iinLabel);
            this.panel2.Controls.Add(this.firstnameField);
            this.panel2.Controls.Add(this.midnameLabel);
            this.panel2.Controls.Add(this.lastnameLabel);
            this.panel2.Controls.Add(this.employeePhoto);
            this.panel2.Controls.Add(this.firstnameLabel);
            this.panel2.Location = new System.Drawing.Point(728, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 433);
            this.panel2.TabIndex = 11;
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
            ((System.ComponentModel.ISupportInitialize)(this.employeePhoto)).EndInit();
            this.companyPanel.ResumeLayout(false);
            this.companyPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.ListBox listBoxCompanies;
        private System.Windows.Forms.Button addEmployee;
        private System.Windows.Forms.Label companiesLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label employeeLabel;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

