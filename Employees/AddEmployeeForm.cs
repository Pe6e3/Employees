using System;
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
            MessageBox.Show($"Id компании: {companyId}");
        }

        private void createNewEmployee_Click(object sender, EventArgs e)
        {
            // Создаем нового сотрудника с данными из формы
            Employee newEmployee = new Employee
            {
                FirstName = nameField.Text,
                LastName = surnameField.Text,
                MiddleName = midNameField.Text,
                IIN = IINField.Text
            };

            if (_companyId != 0)
                _db.AddEmployee(newEmployee, _companyId);
            else
                _db.AddEmployee(newEmployee);


            MessageBox.Show("Сотрудник успешно добавлен.");

            // Закрываем текущую форму
            Close();
        }
    }
}
