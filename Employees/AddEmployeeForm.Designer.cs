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
            this.surnameLabel = new System.Windows.Forms.Label();
            this.midNameLabel = new System.Windows.Forms.Label();
            this.midNameField = new System.Windows.Forms.TextBox();
            this.IINLabel = new System.Windows.Forms.Label();
            this.IINField = new System.Windows.Forms.TextBox();
            this.labelPanel = new System.Windows.Forms.Panel();
            this.labelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // createNewEmployee
            // 
            this.createNewEmployee.Location = new System.Drawing.Point(348, 388);
            this.createNewEmployee.Name = "createNewEmployee";
            this.createNewEmployee.Size = new System.Drawing.Size(134, 23);
            this.createNewEmployee.TabIndex = 0;
            this.createNewEmployee.Text = "Добавить сотрудника";
            this.createNewEmployee.UseVisualStyleBackColor = true;
            this.createNewEmployee.Click += new System.EventHandler(this.createNewEmployee_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameLabel.Location = new System.Drawing.Point(0, 50);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(112, 25);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Имя";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(388, 160);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(173, 20);
            this.nameField.TabIndex = 2;
            // 
            // surnameField
            // 
            this.surnameField.Location = new System.Drawing.Point(388, 185);
            this.surnameField.Name = "surnameField";
            this.surnameField.Size = new System.Drawing.Size(173, 20);
            this.surnameField.TabIndex = 4;
            // 
            // surnameLabel
            // 
            this.surnameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.surnameLabel.Location = new System.Drawing.Point(0, 75);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(112, 25);
            this.surnameLabel.TabIndex = 3;
            this.surnameLabel.Text = "Фамилия";
            this.surnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // midNameLabel
            // 
            this.midNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.midNameLabel.Location = new System.Drawing.Point(0, 0);
            this.midNameLabel.Name = "midNameLabel";
            this.midNameLabel.Size = new System.Drawing.Size(112, 25);
            this.midNameLabel.TabIndex = 3;
            this.midNameLabel.Text = "Отчество";
            this.midNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // midNameField
            // 
            this.midNameField.Location = new System.Drawing.Point(388, 110);
            this.midNameField.Name = "midNameField";
            this.midNameField.Size = new System.Drawing.Size(173, 20);
            this.midNameField.TabIndex = 4;
            // 
            // IINLabel
            // 
            this.IINLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.IINLabel.Location = new System.Drawing.Point(0, 25);
            this.IINLabel.Name = "IINLabel";
            this.IINLabel.Size = new System.Drawing.Size(112, 25);
            this.IINLabel.TabIndex = 3;
            this.IINLabel.Text = "ИИН";
            this.IINLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IINField
            // 
            this.IINField.Location = new System.Drawing.Point(388, 134);
            this.IINField.Name = "IINField";
            this.IINField.Size = new System.Drawing.Size(173, 20);
            this.IINField.TabIndex = 4;
            // 
            // labelPanel
            // 
            this.labelPanel.Controls.Add(this.surnameLabel);
            this.labelPanel.Controls.Add(this.nameLabel);
            this.labelPanel.Controls.Add(this.IINLabel);
            this.labelPanel.Controls.Add(this.midNameLabel);
            this.labelPanel.Location = new System.Drawing.Point(270, 107);
            this.labelPanel.Name = "labelPanel";
            this.labelPanel.Size = new System.Drawing.Size(112, 105);
            this.labelPanel.TabIndex = 5;
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPanel);
            this.Controls.Add(this.IINField);
            this.Controls.Add(this.midNameField);
            this.Controls.Add(this.surnameField);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.createNewEmployee);
            this.Name = "AddEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEmployeeForm";
            this.labelPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createNewEmployee;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.TextBox surnameField;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label midNameLabel;
        private System.Windows.Forms.TextBox midNameField;
        private System.Windows.Forms.Label IINLabel;
        private System.Windows.Forms.TextBox IINField;
        private System.Windows.Forms.Panel labelPanel;
    }
}