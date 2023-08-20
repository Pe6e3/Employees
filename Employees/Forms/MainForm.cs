using Employees.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Employees
{
    public partial class MainForm : Form
    {
        private readonly Db _db = new Db();

        public MainForm()
        {
            InitializeComponent();
            Load += MainForm_Load;
            employeeCompanyLabel.Text = "";

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshCompanyList();
            RefreshEmployeeList();
        }
        private void RefreshCompanyList()
        {
            listBoxCompanies.Items.Clear();
            listBoxCompanies.DisplayMember = "Name";
            var companies = _db.GetAllCompanies();

            foreach (var company in companies)
                listBoxCompanies.Items.Add(company);
        }


        public void RefreshEmployeeList(int companyId = 0)
        {
            listBoxEmployees.Items.Clear();
            listBoxEmployees.DisplayMember = "Fullname";
            List<Employee> employees = new List<Employee>();

            if (companyId != 0)
                employees = _db.GetEmployeesOfCompany(companyId);
            else
                employees = _db.GetAllEmployees();

            foreach (var employee in employees)
                listBoxEmployees.Items.Add(employee);
        }


        private void addEmployee_Click(object sender, EventArgs e)
        {
            // Проверяем, что какая-либо компания выбрана
            if (listBoxCompanies.SelectedItem == null)
            {
                MessageBox.Show("Сначала выберите компанию");
                return;
            }

            // Получаем выбранный объект Company
            Company selectedCompany = (Company)listBoxCompanies.SelectedItem;

            // Получаем Id выбранной компании
            int selectedCompanyId = selectedCompany.Id;

            // Создаем форму для добавления сотрудника и передаем ей Id компании
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm(selectedCompanyId);
            this.Hide();
            addEmployeeForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            _db.CloseConnection();
            Application.Exit();
        }

        private void listBoxCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
            Company selectedCompany = (Company)listBoxCompanies.SelectedItem;
            RefreshEmployeeList(selectedCompany.Id);
            employeeLabel.Text = "";
            employeeCompanyLabel.Text = $"Сотрудники компании\n{selectedCompany.Name}";
        }

        private void listBoxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee selectedEmployee = (Employee)listBoxEmployees.SelectedItem;
            RefreshEmployeeCard(selectedEmployee);
        }

        private void RefreshEmployeeCard(Employee selectedEmployee)
        {
            firstnameLabel.Text = selectedEmployee.FirstName;
            lastnameLabel.Text = selectedEmployee.LastName;
            midnameLabel.Text = selectedEmployee.MiddleName;
            iinLabel.Text = selectedEmployee.IIN;
        }
    }
}
