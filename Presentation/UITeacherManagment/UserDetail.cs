using OnlineExamSystem.BusinessServicesLayer;
using OnlineExamSystem.DataServicesLayer;
using OnlineExamSystem.DataServicesLayer.Method;
using OnlineExamSystem.DataServicesLayer.Model.School;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineExamSystem.PresentationLayer
{
    public partial class UserDetail : UserControl
    {
        public enum WorkingMode
        {
            CreateNew,
            Modify
        }

        public event EventHandler OnFormUsageCompleted;
        private WorkingMode Mode;
        private User AccountToModify;

        public UserDetail()
        {
            InitializeComponent();
            CbStudentGender.SelectedIndex = 0;
            BirthdayPicker.Format = DateTimePickerFormat.Custom;
            BirthdayPicker.CustomFormat = "dd-MM-yyyy";

            Mode = WorkingMode.CreateNew;
        }
        public void SetModifyAccount(string RequestedModifyEmployeeID)
        {
            Mode = WorkingMode.Modify;
            AccountToModify = TeacherListManagment.Instance.FindTeacher(RequestedModifyEmployeeID);
            LoadUserInformationToForm();
        }
        public void LoadUserInformationToForm()
        {
            if (AccountToModify == null)
                return;

            TxtFirstName.Text = AccountToModify.FirstName;
            TxtLastName.Text = AccountToModify.LastName;
            TxtEmail.Text = AccountToModify.Email;
            TxtEmployeeID.Text = AccountToModify.NumericIdentification;
            TxtPhoneNumber.Text = AccountToModify.PhoneNumber;
            BirthdayPicker.Value = AccountToModify.Birthday;
            CbStudentGender.SelectedIndex = (int)AccountToModify.Gender;
            LbAccountCreation.Text = AccountToModify.CreatedAt.ToString("dd-MM-yyyy");
            LbLastModifyTime.Text = AccountToModify.InfoUpdatedAt.ToString("dd-MM-yyyy");

            TxtPassword.Enabled = false;
            TxtPassword.Text = "********";
            ResetPass.Visible = true;
            TxtEmployeeID.Enabled = false;
        }
        private void TeacherDetail_Load(object sender, EventArgs e)
        {
            if (Mode == WorkingMode.Modify) 
            {
                // some text needs to be modified
                LbFormHeader.Text = "Chỉnh sửa thông tin cá nhân";
                BtnCreateOrModify.Text = "Cập nhật";
            }
            else
            {
                LbAccountCreation.Text = "N/A";
                LbLastModifyTime.Text = "N/A";
            }    
        }

        private void CbStudentGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            OnFormUsageCompleted?.Invoke(this, EventArgs.Empty);
        }

        private void BtnCreateOrModify_Click(object sender, EventArgs e)
        {
            if (!ValidateInputData())
            {
                MessageBox.Show("Một hoặc nhiều trường dữ liệu không hợp lệ. Vui lòng kiểm tra lại");
                return;
            }
            if (Mode == WorkingMode.CreateNew)
            {
                bool success = CreateNewTeacherAccount();
                if (success)
                {
                    OnFormUsageCompleted?.Invoke(this, EventArgs.Empty);
                }
            }
            if (Mode == WorkingMode.Modify)
            {
                if (SaveUserData())
                {
                    OnFormUsageCompleted?.Invoke(this, EventArgs.Empty);
                }
            }
        }
        private void ResetPass_Click(object sender, EventArgs e)
        {
            TxtPassword.Text = AccountToModify.NumericIdentification;
            TxtPassword.Enabled = true;
        }
        private bool SaveUserData()
        {
            string HashedPassword = "";
            bool DataModified = false;

            if (TxtPassword.Enabled)
            {
                if (TxtPassword.Text.Length <= 0)
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu!");
                    return false;
                }
                HashedPassword = Helper.HashPassword(TxtPassword.Text);
                DataModified = true;
            }

            if (TxtFirstName.Text != AccountToModify.FirstName)
                DataModified = true;
            if (TxtLastName.Text != AccountToModify.FirstName)
                DataModified = true;
            if (TxtEmail.Text != AccountToModify.FirstName)
                DataModified = true;

            if (BirthdayPicker.Value != AccountToModify.Birthday)
                DataModified = true;

            if (CbStudentGender.SelectedIndex != (int)AccountToModify.Gender)
                DataModified = true;

            if (TxtPhoneNumber.Text != AccountToModify.PhoneNumber)
                DataModified = true;

            if (DataModified)
            {
                // commit changes to the object, and call save changes
                AccountToModify.FirstName = TxtFirstName.Text;
                AccountToModify.LastName = TxtLastName.Text;
                AccountToModify.Email = TxtEmail.Text;
                AccountToModify.PhoneNumber = TxtPhoneNumber.Text;
                AccountToModify.Birthday = BirthdayPicker.Value;
                AccountToModify.Gender = (Gender)CbStudentGender.SelectedIndex;
                if (HashedPassword.Length > 0)
                    AccountToModify.HashedPassword = HashedPassword;

                AccountToModify.InfoUpdatedAt = DateTime.Now;

                OEDB.Instance.Commit();
            }
            return true;
        }
        private bool CreateNewTeacherAccount()
        {
            string firstName = TxtFirstName.Text;
            string lastName = TxtLastName.Text;
            string email = TxtEmail.Text;
            string employeeNumber = TxtEmployeeID.Text;
            string phonenum = TxtPhoneNumber.Text;
            string password = TxtPassword.Text;
            if (password.Length <= 0)
                password = employeeNumber;

            DateTime birthday = BirthdayPicker.Value;
            Gender gender = (Gender)CbStudentGender.SelectedIndex;

            // check if employee id account already exist
            if (UserManagment.Instance.IsUserExist(employeeNumber))
            {
                MessageBox.Show("Da co tai khoan ton tai voi ma so can bo nay!");
                return false;
            }

            // Create new teacher account
            User newTeacher = TeacherListManagment.Instance.CreateNewTeacherAccount(
                firstName,
                lastName,
                phonenum,
                email,
                employeeNumber,
                password,
                birthday,
                gender
            );

            if (newTeacher != null)
            {
                MessageBox.Show("Created");
                return true;
            }
            else
            {
                MessageBox.Show("An error occured");
            }
            return false;
        }
        private bool ValidateInputData()
        {
            // Validate first name
            if (string.IsNullOrEmpty(TxtFirstName.Text) || !Regex.IsMatch(TxtFirstName.Text, "^[a-zA-Z]+$"))
                return false;

            // Validate last name
            if (string.IsNullOrEmpty(TxtLastName.Text) || !Regex.IsMatch(TxtLastName.Text, "^[a-zA-Z]+$"))
                return false;

            // Validate employee ID
            if (string.IsNullOrEmpty(TxtEmployeeID.Text) || !Regex.IsMatch(TxtEmployeeID.Text, "^[0-9]+$"))
                return false;

            // Validate gender
            if (CbStudentGender.SelectedIndex == -1)
                return false;

            // Validate birthday
            if (BirthdayPicker == null)
                return false;

            DateTime Birthday = BirthdayPicker.Value;
            if (Birthday.CompareTo(DateTime.Now) > 0)
                return false;

            // Validate email
            if (string.IsNullOrEmpty(TxtEmail.Text) || !Regex.IsMatch(TxtEmail.Text, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"))
                return false;

            bool ValidPhoneNumber = TxtPhoneNumber.Text.All(char.IsDigit);
            if (!ValidPhoneNumber)
                return false;

            // All validations passed
            return true;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
