using Employees.Entities;
using Employees.Forms;
using Employees.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Windows.Forms;

namespace Employees
{
    public partial class MainForm : Form
    {
        private readonly Db _db = new Db();
        private int _tempEmployeeId;
        private int _tempCompanyId; // Эти две переменные нужны для того, чтобы обновлять информацию с учетом того, какая компания или сотрудник были выбраны до удаления/импорта/созания объектов

        public MainForm()
        {
            InitializeComponent();
            Load += MainForm_Load;
            FormHelper.MakeFormMovable(form: this, panel: MainPanel);
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
            try
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
                _tempCompanyId = companyId;
            }
            catch
            {
                MessageBox.Show("Ошибка при попытке обновить список сотрудников");
            }
        }




        private void listBoxCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearEmployeeCard();
            Company selectedCompany = (Company)listBoxCompanies.SelectedItem;
            if (selectedCompany == null) return;
            RefreshEmployeeList(selectedCompany.Id);
            RefreshCompanyCard(selectedCompany);
            employeeCompanyLabel.Text = $"Сотрудники компании\n{selectedCompany.Name}";

            CheckCompanySelection();
        }

        private void CheckCompanySelection()
        {
            // Проверяем, есть ли выбранная компания
            bool itemSelected = listBoxCompanies.SelectedItems.Count > 0;
            // Включаем или отключаем кнопки "importCSV" и "Добавить сотрудника" в зависимости от наличия выбранного пункта
            importCSV.Enabled = itemSelected;
            addEmployee.Enabled = itemSelected;
        }

        private void CheckEmployeeSelection()
        {
            // Проверяем, есть ли выбранный Сотрудник
            bool itemSelected = listBoxEmployees.SelectedItems.Count > 0;
            // Включаем или отключаем кнопку "Удалить выбранного сотрудника" в зависимости от наличия выбранного пункта
            deleteEmployee.Enabled = itemSelected;
        }

        private void listBoxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee selectedEmployee = (Employee)listBoxEmployees.SelectedItem;
            RefreshEmployeeCard(selectedEmployee);
            CheckEmployeeSelection();
        }

        private void RefreshEmployeeCard(Employee selectedEmployee)
        {
            if (selectedEmployee == null) return;
            firstnameField.Text = selectedEmployee.FirstName;
            lastnameField.Text = selectedEmployee.LastName;
            midnameField.Text = selectedEmployee.MiddleName;
            iinField.Text = selectedEmployee.IIN;
            _tempEmployeeId = selectedEmployee.Id;

        }

        private void RefreshCompanyCard(Company selectedCompany)
        {
            companyNameField.Text = selectedCompany.Name;
            companyInnField.Text = selectedCompany.INN;
            companyAddressField.Text = selectedCompany.Address;
            companyNoteField.Text = selectedCompany.Note;
        }

        private void ClearEmployeeCard()
        {
            firstnameField.Text = "";
            lastnameField.Text = "";
            midnameField.Text = "";
            iinField.Text = "";
            CheckEmployeeSelection();
        }
        private void ClearCompanyCard()
        {
            companyNameField.Text = "";
            companyInnField.Text = "";
            companyAddressField.Text = "";
            companyNoteField.Text = "";
            listBoxCompanies.SelectedIndex = -1;

        }

        private void newCompanyButton_Click(object sender, EventArgs e)
        {
            AddCompanyForm2 addCompanyForm = new AddCompanyForm2();
            this.Hide();
            addCompanyForm.Show();
        }

        private void addEmployee_Click(object sender, EventArgs e)
        {
            if (listBoxCompanies.SelectedItem == null)   // Проверяем, что какая-либо компания выбрана
            {
                MessageBox.Show("Сначала выберите компанию");
                return;
            }

            Company selectedCompany = (Company)listBoxCompanies.SelectedItem;
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm(selectedCompany.Id); // Создаем форму для добавления сотрудника и передаем ей Id компании
            this.Hide();
            addEmployeeForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            FormHelper.ExitProgramm(_db);
        }

        private void exportCSV_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                saveFileDialog.Title = "Выберите место для сохранения CSV файла";
                Company selectedCompany = (Company)listBoxCompanies.SelectedItem;
                if (selectedCompany != null)  // задаем имя для сохранения файла
                    saveFileDialog.FileName = selectedCompany.Name;
                else
                    saveFileDialog.FileName = "Все сотрудники";


                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string csvContent = "Fullname,FirstName,LastName,MiddleName,IIN\n";
                    int rowCounter = 0;
                    foreach (var item in listBoxEmployees.Items)
                    {
                        var employee = (Employee)item;

                        string employeeCsvLine = $"{employee.Fullname},{employee.FirstName},{employee.LastName},{employee.MiddleName},{employee.IIN}";
                        csvContent += employeeCsvLine + "\n";
                        rowCounter++;
                    }

                    string csvFilePath = saveFileDialog.FileName;
                    System.IO.File.WriteAllText(csvFilePath, csvContent);

                    MessageBox.Show($"Список сотрудников успешно экспортирован в CSV файл\n ({rowCounter} строк).");
                }
            }
        }

        private void importCSV_Click(object sender, EventArgs e)
        {
            Company company = (Company)listBoxCompanies.SelectedItem;
            int companyId = company == null ? 0 : company.Id;  // если была выбрана компания, то передаем ее Id ниже. Если нет, передаем 0
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.Title = "Выберите CSV файл для импорта";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string csvFilePath = openFileDialog.FileName;
                    List<Employee> importedEmployees = ReadEmployeesFromCSV(csvFilePath);


                    if (importedEmployees.Count > 0)
                    {
                        foreach (var employee in importedEmployees)
                            _db.AddEmployee(employee, companyId);
                        MessageBox.Show($"Импортировано {importedEmployees.Count} сотрудников.");
                    }
                    else
                        MessageBox.Show("CSV файл не содержит данных о сотрудниках.");
                }
            }
            RefreshEmployeeList(companyId);
        }

        private List<Employee> ReadEmployeesFromCSV(string filePath)
        {
            List<Employee> employees = new List<Employee>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line = reader.ReadLine(); // Пропускаем заголовок
                int countWrongLines = 0;
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    string[] values = line.Split(',');

                    if (values.Length >= 5) // Проверяем наличие всех полей
                    {
                        Employee employee = new Employee
                        {
                            Fullname = values[0],
                            FirstName = values[1],
                            LastName = values[2],
                            MiddleName = values[3],
                            IIN = values[4]
                        };
                        employees.Add(employee);
                    }
                    else countWrongLines++;  // считаем сколько необработанных полей
                }
                if (countWrongLines > 0)
                    MessageBox.Show($"Не было обработано {countWrongLines} строк (в них не хватает данных)");
            }

            return employees;
        }

        private void deleteEmployeees_Click(object sender, EventArgs e)
        {
            _db.ClearCompanyEmployees(_tempCompanyId);
            RefreshEmployeeList(_tempCompanyId);
        }

        private void deleteEmployee_Click(object sender, EventArgs e)
        {
            _db.DeleteEmployee(_tempEmployeeId);
            RefreshEmployeeList(_tempCompanyId);
        }

        private void resetCompany_Click(object sender, EventArgs e)
        {
            RefreshEmployeeList();
            ClearCompanyCard();
            ClearEmployeeCard();
            employeeCompanyLabel.Text = "Все Сотрудники";
            CheckCompanySelection();
        }
    }
}
