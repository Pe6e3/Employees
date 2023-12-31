﻿namespace Employees
{
    partial class AddEmployeeForm
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
            this.newEmployeeButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.surnameField = new System.Windows.Forms.TextBox();
            this.midNameField = new System.Windows.Forms.TextBox();
            this.IINField = new System.Windows.Forms.TextBox();
            this.midNameLabel = new System.Windows.Forms.Label();
            this.IINLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.comboBoxCompany = new System.Windows.Forms.ComboBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.companyLabel = new System.Windows.Forms.Label();
            this.backToMainForm = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // newEmployeeButton
            // 
            this.newEmployeeButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.newEmployeeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newEmployeeButton.Location = new System.Drawing.Point(164, 245);
            this.newEmployeeButton.Name = "newEmployeeButton";
            this.newEmployeeButton.Size = new System.Drawing.Size(134, 33);
            this.newEmployeeButton.TabIndex = 6;
            this.newEmployeeButton.Text = "Добавить сотрудника";
            this.newEmployeeButton.UseVisualStyleBackColor = false;
            this.newEmployeeButton.Click += new System.EventHandler(this.createNewEmployee_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(57, 122);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(112, 25);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Имя";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(175, 122);
            this.nameField.Multiline = true;
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(173, 25);
            this.nameField.TabIndex = 3;
            this.nameField.TextChanged += new System.EventHandler(this.nameField_TextChanged);
            // 
            // surnameField
            // 
            this.surnameField.Location = new System.Drawing.Point(175, 91);
            this.surnameField.Multiline = true;
            this.surnameField.Name = "surnameField";
            this.surnameField.Size = new System.Drawing.Size(173, 25);
            this.surnameField.TabIndex = 2;
            this.surnameField.TextChanged += new System.EventHandler(this.surnameField_TextChanged);
            // 
            // midNameField
            // 
            this.midNameField.Location = new System.Drawing.Point(175, 156);
            this.midNameField.Multiline = true;
            this.midNameField.Name = "midNameField";
            this.midNameField.Size = new System.Drawing.Size(173, 25);
            this.midNameField.TabIndex = 4;
            this.midNameField.TextChanged += new System.EventHandler(this.midNameField_TextChanged);
            // 
            // IINField
            // 
            this.IINField.Location = new System.Drawing.Point(175, 187);
            this.IINField.Multiline = true;
            this.IINField.Name = "IINField";
            this.IINField.Size = new System.Drawing.Size(173, 25);
            this.IINField.TabIndex = 5;
            this.IINField.TextChanged += new System.EventHandler(this.IINField_TextChanged);
            // 
            // midNameLabel
            // 
            this.midNameLabel.Location = new System.Drawing.Point(57, 156);
            this.midNameLabel.Name = "midNameLabel";
            this.midNameLabel.Size = new System.Drawing.Size(112, 25);
            this.midNameLabel.TabIndex = 3;
            this.midNameLabel.Text = "Отчество";
            this.midNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IINLabel
            // 
            this.IINLabel.Location = new System.Drawing.Point(57, 187);
            this.IINLabel.Name = "IINLabel";
            this.IINLabel.Size = new System.Drawing.Size(112, 25);
            this.IINLabel.TabIndex = 3;
            this.IINLabel.Text = "ИИН";
            this.IINLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // surnameLabel
            // 
            this.surnameLabel.Location = new System.Drawing.Point(57, 91);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(112, 25);
            this.surnameLabel.TabIndex = 3;
            this.surnameLabel.Text = "Фамилия";
            this.surnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxCompany
            // 
            this.comboBoxCompany.FormattingEnabled = true;
            this.comboBoxCompany.Location = new System.Drawing.Point(175, 44);
            this.comboBoxCompany.Name = "comboBoxCompany";
            this.comboBoxCompany.Size = new System.Drawing.Size(173, 21);
            this.comboBoxCompany.TabIndex = 7;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(406, 14);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(27, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "X";
            this.exitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.exitButton.UseCompatibleTextRendering = true;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // companyLabel
            // 
            this.companyLabel.Location = new System.Drawing.Point(57, 41);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(112, 25);
            this.companyLabel.TabIndex = 3;
            this.companyLabel.Text = "Компания";
            this.companyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // backToMainForm
            // 
            this.backToMainForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backToMainForm.Location = new System.Drawing.Point(10, 14);
            this.backToMainForm.Name = "backToMainForm";
            this.backToMainForm.Size = new System.Drawing.Size(27, 23);
            this.backToMainForm.TabIndex = 7;
            this.backToMainForm.Text = "←";
            this.backToMainForm.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.backToMainForm.UseCompatibleTextRendering = true;
            this.backToMainForm.UseVisualStyleBackColor = true;
            this.backToMainForm.Click += new System.EventHandler(this.backToMainForm_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.backToMainForm);
            this.MainPanel.Controls.Add(this.exitButton);
            this.MainPanel.Controls.Add(this.comboBoxCompany);
            this.MainPanel.Controls.Add(this.companyLabel);
            this.MainPanel.Controls.Add(this.surnameLabel);
            this.MainPanel.Controls.Add(this.IINLabel);
            this.MainPanel.Controls.Add(this.midNameLabel);
            this.MainPanel.Controls.Add(this.nameLabel);
            this.MainPanel.Controls.Add(this.IINField);
            this.MainPanel.Controls.Add(this.midNameField);
            this.MainPanel.Controls.Add(this.surnameField);
            this.MainPanel.Controls.Add(this.nameField);
            this.MainPanel.Controls.Add(this.newEmployeeButton);
            this.MainPanel.Location = new System.Drawing.Point(0, -2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(446, 299);
            this.MainPanel.TabIndex = 8;
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(445, 302);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEmployeeForm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newEmployeeButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.TextBox surnameField;
        private System.Windows.Forms.TextBox midNameField;
        private System.Windows.Forms.TextBox IINField;
        private System.Windows.Forms.Label midNameLabel;
        private System.Windows.Forms.Label IINLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.ComboBox comboBoxCompany;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Button backToMainForm;
        private System.Windows.Forms.Panel MainPanel;
    }
}