using OnlineExamSystem.BusinessServicesLayer;
using OnlineExamSystem.DataServicesLayer;
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

namespace OnlineExamSystem.PresentationLayer.UIClass
{
    public partial class EditStudentForm : UserControl
    {
        public EditStudentForm()
        {
            InitializeComponent();
            CbStudentGender.SelectedIndex = 0;
        }
        
        public event EventHandler EditStudentSuccessful;
        private User StudentToEdit;

        public void SetStudentID(string studentID)
        {
            StudentToEdit = UserData.Instance.GetUserByIDOrEmail(studentID);
            if (StudentToEdit == null)
                throw new Exception("Student to edit is being null.");

            TxtStudentMSSV.Text = StudentToEdit.NumericIdentification;
            TxtStudentFirstName.Text = StudentToEdit.FirstName;
            TxtStudentLastName.Text = StudentToEdit.LastName;
            TxtStudentBirthday.Text = StudentToEdit.Birthday.ToString();
            CbStudentGender.SelectedIndex = (int)StudentToEdit.Gender;
        }
        private void BtnCancelModifyStudentInfo_Click(object sender, EventArgs e)
        {
            Globals.MainForm.GoBack();
        }

        private void BtnSaveStudentInfo_Click(object sender, EventArgs e)
        {
            DateTime StudentBirthday = TxtStudentBirthday.Value;

            if (TxtStudentFirstName.Text.Length <= 0 ||
                TxtStudentLastName.Text.Length <= 0 ||
                StudentBirthday.CompareTo(DateTime.Now) > 0)
            {
                MessageBox.Show("Vui lòng nhập đủ các trường dữ liệu.");
                return;
            }
            bool IsDataChanged = false;
            if (StudentToEdit.FirstName != TxtStudentFirstName.Text)
                IsDataChanged = true;
            if (StudentToEdit.LastName != TxtStudentLastName.Text)
                IsDataChanged = true;
            if (StudentToEdit.Birthday != StudentBirthday)
                IsDataChanged = true;
            if (StudentToEdit.Gender != (Gender)CbStudentGender.SelectedIndex)
                IsDataChanged = true;

            StudentToEdit.FirstName = TxtStudentFirstName.Text;
            StudentToEdit.LastName = TxtStudentLastName.Text;
            StudentToEdit.Birthday = StudentBirthday;
            StudentToEdit.Gender = (Gender)CbStudentGender.SelectedIndex;
            StudentToEdit.InfoUpdatedAt = DateTime.Now;

            if (IsDataChanged)
            {
                // violation of 3 layers rule
                if (!OEDB.Instance.Commit())
                {
                    MessageBox.Show("Khong the luu du lieu");
                    return;
                }
            }
            EditStudentSuccessful?.Invoke(this, EventArgs.Empty);
        }

        private void BtnRequestResetPass_Click(object sender, EventArgs e)
        {
            string NewPassword = StudentToEdit.NumericIdentification;
            StudentToEdit.HashedPassword = Helper.HashPassword(NewPassword);
            StudentToEdit.InfoUpdatedAt = DateTime.Now;

            if (!OEDB.Instance.Commit())
            {
                MessageBox.Show("Khong the luu du lieu");
            }
            MessageBox.Show("Đã reset mật khẩu.");
        }
    }
}
