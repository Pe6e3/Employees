using System.Windows.Forms;

namespace Employees.Helpers
{
    public static class FormHelper
    {
        public static void OpenMainForm(Form currentForm)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            currentForm.Hide();
        }
    }
}
