namespace Employees
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
            this.createNewEmployee = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // createNewEmployee
            // 
            this.createNewEmployee.Location = new System.Drawing.Point(150, 216);
            this.createNewEmployee.Name = "createNewEmployee";
            this.createNewEmployee.Size = new System.Drawing.Size(134, 23);
            this.createNewEmployee.TabIndex = 6;
            this.createNewEmployee.Text = "Добавить сотрудника";
            this.createNewEmployee.UseVisualStyleBackColor = true;
            this.createNewEmployee.Click += new System.EventHandler(this.createNewEmployee_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(43, 91);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(112, 25);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Имя";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(161, 94);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(173, 20);
            this.nameField.TabIndex = 3;
            // 
            // surnameField
            // 
            this.surnameField.Location = new System.Drawing.Point(161, 69);
            this.surnameField.Name = "surnameField";
            this.surnameField.Size = new System.Drawing.Size(173, 20);
            this.surnameField.TabIndex = 2;
            // 
            // midNameField
            // 
            this.midNameField.Location = new System.Drawing.Point(161, 121);
            this.midNameField.Name = "midNameField";
            this.midNameField.Size = new System.Drawing.Size(173, 20);
            this.midNameField.TabIndex = 4;
            // 
            // IINField
            // 
            this.IINField.Location = new System.Drawing.Point(161, 149);
            this.IINField.Name = "IINField";
            this.IINField.Size = new System.Drawing.Size(173, 20);
            this.IINField.TabIndex = 5;
            // 
            // midNameLabel
            // 
            this.midNameLabel.Location = new System.Drawing.Point(43, 119);
            this.midNameLabel.Name = "midNameLabel";
            this.midNameLabel.Size = new System.Drawing.Size(112, 25);
            this.midNameLabel.TabIndex = 3;
            this.midNameLabel.Text = "Отчество";
            this.midNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IINLabel
            // 
            this.IINLabel.Location = new System.Drawing.Point(43, 146);
            this.IINLabel.Name = "IINLabel";
            this.IINLabel.Size = new System.Drawing.Size(112, 25);
            this.IINLabel.TabIndex = 3;
            this.IINLabel.Text = "ИИН";
            this.IINLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // surnameLabel
            // 
            this.surnameLabel.Location = new System.Drawing.Point(43, 66);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(112, 25);
            this.surnameLabel.TabIndex = 3;
            this.surnameLabel.Text = "Фамилия";
            this.surnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxCompany
            // 
            this.comboBoxCompany.FormattingEnabled = true;
            this.comboBoxCompany.Location = new System.Drawing.Point(123, 22);
            this.comboBoxCompany.Name = "comboBoxCompany";
            this.comboBoxCompany.Size = new System.Drawing.Size(211, 21);
            this.comboBoxCompany.TabIndex = 1;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(416, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(27, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "X";
            this.exitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.exitButton.UseCompatibleTextRendering = true;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(445, 302);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.comboBoxCompany);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.IINLabel);
            this.Controls.Add(this.midNameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.IINField);
            this.Controls.Add(this.midNameField);
            this.Controls.Add(this.surnameField);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.createNewEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createNewEmployee;
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
    }
}