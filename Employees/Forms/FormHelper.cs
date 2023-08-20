using System;
using System.Drawing;
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

        public static void CheckTextFieldLength(TextBox textBox, int maxLength)
        {
            if (textBox.Text.Length > maxLength)
                MessageBox.Show($"Длина поля не должна превышать {maxLength} символов");
        }

        public static void ExitProgramm(Db _db)
        {
            _db.CloseConnection();
            Application.Exit();
        }


       
        public static void MakeFormMovable(Form form, Panel panel)  // Этот метод писал не сам, вставил для удобства пользования программой
        {
            Point lastPoint = Point.Empty;

            panel.MouseMove += (sender, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    form.Left += e.X - lastPoint.X;
                    form.Top += e.Y - lastPoint.Y;
                }
            };

            panel.MouseDown += (sender, e) =>
            {
                lastPoint = new Point(e.X, e.Y);
            };
        }

 
    }
}
