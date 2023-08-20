using Employees.Entities;
using Employees.Helpers;
using System;
using System.Windows.Forms;

namespace Employees.Forms
{
    public partial class AddCompanyForm2 : Form
    {
        private readonly Db _db = new Db();
        public AddCompanyForm2()
        {
            InitializeComponent();
            FormHelper.MakeFormMovable(form: this, panel: MainPanel);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            FormHelper.ExitProgramm(_db);
        }

        private void newCompanyButton_Click(object sender, EventArgs e)
        {
            try
            {
                Company newCompany = new Company// Создаем новую компанию с данными из формы
                {
                    Name = nameField.Text,
                    INN = innField.Text,
                    Address = addressField.Text,
                    Note = noteField.Text
                };
                _db.AddCompany(newCompany);
                MessageBox.Show($"Компания {newCompany.Name} успешно добавлена.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
                _db.CloseConnection();
            }
            finally
            {
                _db.CloseConnection();  // Закрываем соединение, даже если произошла ошибка
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
        }

        private void nameField_TextChanged(object sender, EventArgs e)
        {
            FormHelper.CheckTextFieldLength(nameField, 40);
        }

        private void innField_TextChanged(object sender, EventArgs e)
        {
            FormHelper.CheckTextFieldLength(innField, 12);
        }

        private void addressField_TextChanged(object sender, EventArgs e)
        {
            FormHelper.CheckTextFieldLength(addressField, 100);
        }

        private void backToMainForm_Click(object sender, EventArgs e)
        {
            FormHelper.OpenMainForm(currentForm: this);
        }
    }
}
