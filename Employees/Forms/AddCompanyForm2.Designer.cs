namespace Employees.Forms
{
    partial class AddCompanyForm2
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
            this.exitButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.noteLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.innLabel = new System.Windows.Forms.Label();
            this.noteField = new System.Windows.Forms.TextBox();
            this.addressField = new System.Windows.Forms.TextBox();
            this.nameField = new System.Windows.Forms.TextBox();
            this.innField = new System.Windows.Forms.TextBox();
            this.newCompanyButton = new System.Windows.Forms.Button();
            this.backToMainForm = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(428, 10);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(27, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "X";
            this.exitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.exitButton.UseCompatibleTextRendering = true;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(12, 40);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(112, 25);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "Название";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // noteLabel
            // 
            this.noteLabel.Location = new System.Drawing.Point(12, 163);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(112, 25);
            this.noteLabel.TabIndex = 12;
            this.noteLabel.Text = "Примечание";
            this.noteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addressLabel
            // 
            this.addressLabel.Location = new System.Drawing.Point(12, 105);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(112, 25);
            this.addressLabel.TabIndex = 13;
            this.addressLabel.Text = "Адрес";
            this.addressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // innLabel
            // 
            this.innLabel.Location = new System.Drawing.Point(12, 71);
            this.innLabel.Name = "innLabel";
            this.innLabel.Size = new System.Drawing.Size(112, 25);
            this.innLabel.TabIndex = 9;
            this.innLabel.Text = "ИНН";
            this.innLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // noteField
            // 
            this.noteField.Location = new System.Drawing.Point(130, 163);
            this.noteField.Multiline = true;
            this.noteField.Name = "noteField";
            this.noteField.Size = new System.Drawing.Size(269, 103);
            this.noteField.TabIndex = 16;
            // 
            // addressField
            // 
            this.addressField.Location = new System.Drawing.Point(130, 105);
            this.addressField.Multiline = true;
            this.addressField.Name = "addressField";
            this.addressField.Size = new System.Drawing.Size(269, 52);
            this.addressField.TabIndex = 15;
            this.addressField.TextChanged += new System.EventHandler(this.addressField_TextChanged);
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(130, 40);
            this.nameField.Multiline = true;
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(269, 25);
            this.nameField.TabIndex = 10;
            this.nameField.TextChanged += new System.EventHandler(this.nameField_TextChanged);
            // 
            // innField
            // 
            this.innField.Location = new System.Drawing.Point(130, 71);
            this.innField.Multiline = true;
            this.innField.Name = "innField";
            this.innField.Size = new System.Drawing.Size(269, 25);
            this.innField.TabIndex = 14;
            this.innField.TextChanged += new System.EventHandler(this.innField_TextChanged);
            // 
            // newCompanyButton
            // 
            this.newCompanyButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.newCompanyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newCompanyButton.Location = new System.Drawing.Point(195, 272);
            this.newCompanyButton.Name = "newCompanyButton";
            this.newCompanyButton.Size = new System.Drawing.Size(134, 33);
            this.newCompanyButton.TabIndex = 17;
            this.newCompanyButton.Text = "Добавить компанию";
            this.newCompanyButton.UseVisualStyleBackColor = false;
            this.newCompanyButton.Click += new System.EventHandler(this.newCompanyButton_Click);
            // 
            // backToMainForm
            // 
            this.backToMainForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backToMainForm.Location = new System.Drawing.Point(10, 9);
            this.backToMainForm.Name = "backToMainForm";
            this.backToMainForm.Size = new System.Drawing.Size(27, 23);
            this.backToMainForm.TabIndex = 18;
            this.backToMainForm.Text = "←";
            this.backToMainForm.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.backToMainForm.UseCompatibleTextRendering = true;
            this.backToMainForm.UseVisualStyleBackColor = true;
            this.backToMainForm.Click += new System.EventHandler(this.backToMainForm_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.backToMainForm);
            this.MainPanel.Controls.Add(this.nameLabel);
            this.MainPanel.Controls.Add(this.noteLabel);
            this.MainPanel.Controls.Add(this.addressLabel);
            this.MainPanel.Controls.Add(this.innLabel);
            this.MainPanel.Controls.Add(this.noteField);
            this.MainPanel.Controls.Add(this.addressField);
            this.MainPanel.Controls.Add(this.nameField);
            this.MainPanel.Controls.Add(this.innField);
            this.MainPanel.Controls.Add(this.newCompanyButton);
            this.MainPanel.Controls.Add(this.exitButton);
            this.MainPanel.Location = new System.Drawing.Point(2, 2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(468, 328);
            this.MainPanel.TabIndex = 19;
            // 
            // AddCompanyForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(469, 330);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCompanyForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCompanyForm2";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label innLabel;
        private System.Windows.Forms.TextBox noteField;
        private System.Windows.Forms.TextBox addressField;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.TextBox innField;
        private System.Windows.Forms.Button newCompanyButton;
        private System.Windows.Forms.Button backToMainForm;
        private System.Windows.Forms.Panel MainPanel;
    }
}