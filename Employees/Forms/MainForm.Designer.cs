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
            this.employeeCompanyLabel = new System.Windows.Forms.Label();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.listBoxEmployees = new System.Windows.Forms.ListBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.companiesLabel = new System.Windows.Forms.Label();
            this.addEmployee = new System.Windows.Forms.Button();
            this.listBoxCompanies = new System.Windows.Forms.ListBox();
            this.employeePhoto = new System.Windows.Forms.PictureBox();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.midnameLabel = new System.Windows.Forms.Label();
            this.iinLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.AutoSize = true;
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.iinLabel);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.midnameLabel);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.lastnameLabel);
            this.MainPanel.Controls.Add(this.firstnameLabel);
            this.MainPanel.Controls.Add(this.employeePhoto);
            this.MainPanel.Controls.Add(this.employeeCompanyLabel);
            this.MainPanel.Controls.Add(this.employeeLabel);
            this.MainPanel.Controls.Add(this.listBoxEmployees);
            this.MainPanel.Controls.Add(this.exitButton);
            this.MainPanel.Controls.Add(this.companiesLabel);
            this.MainPanel.Controls.Add(this.addEmployee);
            this.MainPanel.Controls.Add(this.listBoxCompanies);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(999, 450);
            this.MainPanel.TabIndex = 0;
            // 
            // employeeCompanyLabel
            // 
            this.employeeCompanyLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.employeeCompanyLabel.AutoSize = true;
            this.employeeCompanyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeCompanyLabel.Location = new System.Drawing.Point(402, 23);
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
            this.employeeLabel.Location = new System.Drawing.Point(423, 43);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(143, 20);
            this.employeeLabel.TabIndex = 5;
            this.employeeLabel.Text = "Все сотрудники";
            this.employeeLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // listBoxEmployees
            // 
            this.listBoxEmployees.FormattingEnabled = true;
            this.listBoxEmployees.Location = new System.Drawing.Point(365, 66);
            this.listBoxEmployees.Name = "listBoxEmployees";
            this.listBoxEmployees.Size = new System.Drawing.Size(266, 290);
            this.listBoxEmployees.TabIndex = 4;
            this.listBoxEmployees.SelectedIndexChanged += new System.EventHandler(this.listBoxEmployees_SelectedIndexChanged);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(960, 3);
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
            this.companiesLabel.Location = new System.Drawing.Point(128, 43);
            this.companiesLabel.Name = "companiesLabel";
            this.companiesLabel.Size = new System.Drawing.Size(126, 20);
            this.companiesLabel.TabIndex = 2;
            this.companiesLabel.Text = "Все компании";
            // 
            // addEmployee
            // 
            this.addEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee.Location = new System.Drawing.Point(427, 362);
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
            this.listBoxCompanies.Location = new System.Drawing.Point(72, 66);
            this.listBoxCompanies.Name = "listBoxCompanies";
            this.listBoxCompanies.Size = new System.Drawing.Size(247, 290);
            this.listBoxCompanies.TabIndex = 0;
            this.listBoxCompanies.SelectedIndexChanged += new System.EventHandler(this.listBoxCompanies_SelectedIndexChanged);
            // 
            // employeePhoto
            // 
            this.employeePhoto.Image = global::Employees.Properties.Resources.user;
            this.employeePhoto.InitialImage = null;
            this.employeePhoto.Location = new System.Drawing.Point(787, 66);
            this.employeePhoto.Name = "employeePhoto";
            this.employeePhoto.Size = new System.Drawing.Size(125, 119);
            this.employeePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.employeePhoto.TabIndex = 6;
            this.employeePhoto.TabStop = false;
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.firstnameLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstnameLabel.Location = new System.Drawing.Point(771, 200);
            this.firstnameLabel.MinimumSize = new System.Drawing.Size(180, 0);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Padding = new System.Windows.Forms.Padding(3);
            this.firstnameLabel.Size = new System.Drawing.Size(180, 30);
            this.firstnameLabel.TabIndex = 7;
            this.firstnameLabel.Text = "Имя";
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lastnameLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastnameLabel.Location = new System.Drawing.Point(771, 234);
            this.lastnameLabel.MinimumSize = new System.Drawing.Size(180, 0);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Padding = new System.Windows.Forms.Padding(3);
            this.lastnameLabel.Size = new System.Drawing.Size(180, 30);
            this.lastnameLabel.TabIndex = 7;
            this.lastnameLabel.Text = "Фамилия";
            // 
            // midnameLabel
            // 
            this.midnameLabel.AutoSize = true;
            this.midnameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.midnameLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.midnameLabel.Location = new System.Drawing.Point(771, 265);
            this.midnameLabel.MinimumSize = new System.Drawing.Size(180, 0);
            this.midnameLabel.Name = "midnameLabel";
            this.midnameLabel.Padding = new System.Windows.Forms.Padding(3);
            this.midnameLabel.Size = new System.Drawing.Size(180, 30);
            this.midnameLabel.TabIndex = 7;
            this.midnameLabel.Text = "Отчество";
            // 
            // iinLabel
            // 
            this.iinLabel.AutoSize = true;
            this.iinLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.iinLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iinLabel.Location = new System.Drawing.Point(771, 297);
            this.iinLabel.MinimumSize = new System.Drawing.Size(180, 0);
            this.iinLabel.Name = "iinLabel";
            this.iinLabel.Padding = new System.Windows.Forms.Padding(3);
            this.iinLabel.Size = new System.Drawing.Size(180, 30);
            this.iinLabel.TabIndex = 7;
            this.iinLabel.Text = "ИИН";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(714, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Имя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(678, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Фамилия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(674, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Отчество:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(710, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "ИИН:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(999, 450);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сотрудники компаний";
            this.TopMost = true;
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeePhoto)).EndInit();
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
        private System.Windows.Forms.Label iinLabel;
        private System.Windows.Forms.Label midnameLabel;
        private System.Windows.Forms.Label lastnameLabel;
        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.PictureBox employeePhoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

