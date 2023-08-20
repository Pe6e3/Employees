using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Employees.Entities;

namespace Employees
{
    public partial class AddEmployeeForm : Form
    {
        private int _companyId;
        private readonly Db _db = new Db();

        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        public AddEmployeeForm(int companyId)
        {
            InitializeComponent();
            _companyId = companyId;

            // Заполнение выпадающего списка компаниями
            FillCompanyComboBox();

            // Выбор компании, в которую будет добавляться сотрудник
            if (_companyId != 0)
                comboBoxCompany.SelectedValue = _companyId;
        }

        private void FillCompanyComboBox()
        {
            // Получаем список всех компаний
            List<Company> companies = _db.GetAllCompanies();

            // Привязываем список компаний к ComboBox
            comboBoxCompany.DataSource = companies;
            comboBoxCompany.DisplayMember = "Name";
            comboBoxCompany.ValueMember = "Id";
        }

        private void createNewEmployee_Click(object sender, EventArgs e)
        {
            Employee newEmployee = new Employee();
            try
            {
                int selectedCompanyId = Convert.ToInt32(comboBoxCompany.SelectedValue); // Получаем выбранную компанию из ComboBox
                newEmployee.FirstName = nameField.Text;
                newEmployee.LastName = surnameField.Text;
                newEmployee.MiddleName = midNameField.Text;
                newEmployee.IIN = IINField.Text;
                newEmployee.Fullname = $"{newEmployee.LastName} {newEmployee.FirstName} {newEmployee.MiddleName}";

                _db.AddEmployee(newEmployee, selectedCompanyId); // Добавляем сотрудника с указанием компании
                MessageBox.Show($"Сотрудник {newEmployee.Fullname} успешно добавлен.");
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            _db.CloseConnection();
            Application.Exit();
        }
    }
}
