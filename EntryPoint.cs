using OnlineExamSystem.BusinessServicesLayer;
using OnlineExamSystem.DataServicesLayer;
using OnlineExamSystem.PresentationLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem
{
    class EntryPoint : ApplicationContext
    {
        private LoginForm LoginForm;

        public EntryPoint()
        {
            OEDB.Instance.Dummy();

            LoginForm = new LoginForm();
            LoginForm.FormClosed += OnFormClosed;
            LoginForm.LoginSuccessful += OnLoginSuccessful;

            LoginForm.Show();
        }
        private void OnLoginSuccessful(object sender, EventArgs e)
        {
            //MessageBox.Show("Login successful");
            LoginForm.Hide();

            MainPage mainForm = new MainPage();
            Globals.MainForm = mainForm;

            mainForm.Show();
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            ExitThread();
        }
    }
}
