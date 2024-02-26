using OnlineExamSystem.BusinessServices.ClassManagment;
using OnlineExamSystem.BusinessServicesLayer;
using OnlineExamSystem.DataServicesLayer.Model.School;
using OnlineExamSystem.DataServicesLayer.Model.Tests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineExamSystem.PresentationLayer
{
    public partial class PopupAddNewClass : UserControl
    {
        private ClassManagment ClassMgr;
        public event EventHandler CreateClassSuccessful;


        public PopupAddNewClass()
        {
            ClassMgr = ClassManagment.Instance;
            InitializeComponent();
        }

        private void CancelAddClass_Click(object sender, EventArgs e)
        {
            Globals.MainForm.GoBack();
        }

        private void SaveNewClass_Click(object sender, EventArgs e)
        {
            if (TxtClassName.Text.Length <= 0 ||
                TxtCourseName.Text.Length <= 0) 
            {
                MessageBox.Show("Vui lòng nhập đủ các trường dữ liệu.");
                return;
            }
            bool success = ClassMgr.AddNewClass(TxtClassName.Text, TxtCourseName.Text);
            if (success)
            {
                CreateClassSuccessful?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
