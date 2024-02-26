using OnlineExamSystem.BusinessServices.ClassManagment;
using OnlineExamSystem.BusinessServicesLayer;
using OnlineExamSystem.DataServicesLayer.Model.School;
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
    public partial class AddStudentForm : UserControl 
    {
        private StudentListManagment? StudentMgr;

        public AddStudentForm()
        {
            InitializeComponent();
            CbStudentGender.SelectedIndex = 0;
        }
        public void SetStudentMgr(StudentListManagment studentMgr)
        {
            StudentMgr = studentMgr;
        }
        public event EventHandler? CreateStudentSuccessful;


        private void CancelAddStudent_Click(object sender, EventArgs e)
        {
            Globals.MainForm.GoBack();
        }

        private void SaveNewStudent_Click(object sender, EventArgs e)
        {
            DateTime StudentBirthday = TxtStudentBirthday.Value;

            if (TxtStudentFirstName.Text.Length <= 0 ||
                TxtStudentLastName.Text.Length <=0 ||
                StudentBirthday.CompareTo(DateTime.Now) > 0 ||
                TxtStudentMSSV.Text.Length <= 4)
            {
                MessageBox.Show("Vui lòng nhập đủ các trường dữ liệu.");
                return;
            }

            int num;
            if (int.TryParse(TxtStudentMSSV.Text, out num) == false)
            {
                MessageBox.Show("Vui lòng nhập đúng MSSV.");
                return;
            }

            if(StudentMgr.IsStudentInClass(TxtStudentMSSV.Text) == true)
            {
                MessageBox.Show("Hoc sinh da ton tai trong lop!");
                return;
            }

            // code here
            bool success = StudentMgr.AddStudentToCurrentClass(TxtStudentFirstName.Text,
                TxtStudentLastName.Text,
                TxtStudentMSSV.Text,
                StudentBirthday,
                (Gender)CbStudentGender.SelectedIndex
                );
            if (success)
            {
                CreateStudentSuccessful?.Invoke(this, EventArgs.Empty);
            }

        }

        private void TxtStudentMSSV_Leave(object sender, EventArgs e)
        {
            int num;
            if (TxtStudentMSSV.Text.Length <= 0 || int.TryParse(TxtStudentMSSV.Text, out num) == false)
                return;

            User Student = StudentMgr.GetUserByNumericID(TxtStudentMSSV.Text);

            if (Student != null)
            {
                TxtStudentFirstName.Enabled = false;
                TxtStudentLastName.Enabled = false;
                TxtStudentBirthday.Enabled = false;
                CbStudentGender.Enabled = false;

                TxtStudentFirstName.Text = Student.FirstName;
                TxtStudentLastName.Text = Student.LastName;
                TxtStudentBirthday.Text = Student.Birthday.ToString();
                CbStudentGender.SelectedIndex = (int)Student.Gender;
            }
            else
            {
                TxtStudentFirstName.Enabled = true;
                TxtStudentLastName.Enabled = true;
                TxtStudentBirthday.Enabled = true;
                CbStudentGender.Enabled = true;
            }


        }
    }
}
