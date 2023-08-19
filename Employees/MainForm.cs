using System;
using System.Windows.Forms;

namespace Employees
{
    public partial class MainForm : Form
    {
        private readonly Db db = new Db();

        public MainForm()
        {
            InitializeComponent();
            Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshCompanyList();
        }
        private void RefreshCompanyList()
        {
            listBoxCompanies.Items.Clear();

            var companies = db.GetCompanyNames();
            foreach (var companyName in companies)
            {
                listBoxCompanies.Items.Add(companyName.Name);
            }
        }

        private void addEmployee_Click(object sender, EventArgs e)
        {
            // Проверяем, что какая-либо компания выбрана
            if (listBoxCompanies.SelectedItem == null)
            {
                MessageBox.Show("Сначала выберите компанию");
                return;
            }

            // Получаем выбранное название компании
            string selectedCompanyName = listBoxCompanies.SelectedItem.ToString();

            // Создаем форму для добавления сотрудника и передаем ей название компании
            using (AddEmployeeForm addEmployeeForm = new AddEmployeeForm(selectedCompanyName))
            {
                DialogResult result = addEmployeeForm.ShowDialog();

                // Если сотрудник успешно добавлен, обновляем список компаний
                if (result == DialogResult.OK)
                    RefreshCompanyList();
            }
        }

    }
}
