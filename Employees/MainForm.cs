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
            MessageBox.Show("Loaded");
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
    }
}
