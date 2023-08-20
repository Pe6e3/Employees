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
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            _db.CloseConnection();
            Application.Exit();
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
            if (nameField.Text.Length > 30)
                MessageBox.Show("Длина поля не должна превышать 30 символов");
        }

        private void innField_TextChanged(object sender, EventArgs e)
        {
            if (innField.Text.Length > 12)
                MessageBox.Show("Длина поля не должна превышать 12 символов");
        }

        private void addressField_TextChanged(object sender, EventArgs e)
        {
           if (addressField.Text.Length > 100)
                MessageBox.Show("Длина поля не должна превышать 100 символов");
        }

        private void backToMainForm_Click(object sender, EventArgs e)
        {
            FormHelper.OpenMainForm(currentForm: this);
        }
    }
}
