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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineExamSystem.PresentationLayer
{
    public partial class UserInformation : UserControl
    {
        public UserInformation()
        {
            InitializeComponent();
        }

        private void UserInformation_Load(object sender, EventArgs e)
        {
            if (UserData.Instance.IsLoggedIn()) 
            { 
                User CurrentLoggedUserInfo = UserData.Instance.GetCurrentUser();

                TxtAccountID.Text = CurrentLoggedUserInfo.NumericIdentification;
                TxtAccountID.Enabled = false;

                TxtFirstName.Text = CurrentLoggedUserInfo.FirstName;
                TxtLastName.Text = CurrentLoggedUserInfo.LastName;
                DTPBirthday.Value = CurrentLoggedUserInfo.Birthday;

                TxtEmailAddress.Text = CurrentLoggedUserInfo.Email;

                // TODO: select class implement
                CbClass.Items.Clear();
                CbClass.Enabled = false;
                CbClass.Items.Add(CurrentLoggedUserInfo.GetFirstClassName());
                CbClass.SelectedIndex = 0;

                CbGender.SelectedIndex = (int)CurrentLoggedUserInfo.Gender;
                TxtPhoneNum.Text = CurrentLoggedUserInfo.PhoneNumber;

                // hmm
                switch (CurrentLoggedUserInfo.AccRole)
                {
                    case AccRole.Student:
                        LbNumericText.Text = "MSSV:";
                        break;
                    case AccRole.Teacher:
                    case AccRole.Administrator:
                        LbNumericText.Text = "MSCB:";
                        break;
                }
            }
        }

        private void ChangePasswordOK_Click(object sender, EventArgs e)
        {
            if (InputOldPassword.Text.Length < 4 ||
                InputNewPassword.Text.Length < 4 ||
                InputRetypeNewPassword.Text.Length < 4
                )
            {
                MessageBox.Show("Mật khẩu nhập không hợp lệ.");
                return;
            }
            if ( InputNewPassword.Text != InputRetypeNewPassword.Text)
            {
                MessageBox.Show("Nhập lại mật khẩu không khớp.");
                return;
            }
            if (!UserManagment.Instance.ChangePassword(InputOldPassword.Text, InputNewPassword.Text))
            {
                MessageBox.Show("Mật khẩu cũ không đúng.");
                return;
            }
            MessageBox.Show("Đổi mật khẩu thành công.");
        }

        private void ChangePasswordResetAll_Click(object sender, EventArgs e)
        {
            InputOldPassword.Text = "";
            InputNewPassword.Text = "";
            InputRetypeNewPassword.Text = "";
        }

        private void BtnUpdateInfo_Click(object sender, EventArgs e)
        {
            if (!ValidateInformationData())
            {
                MessageBox.Show("Thông tin điền trên form không hợp lệ. Vui lòng kiểm tra lại");
                return;
            }
            User CurrentLoggedUserInfo = UserData.Instance.GetCurrentUser();
            CurrentLoggedUserInfo.FirstName = TxtFirstName.Text;
            CurrentLoggedUserInfo.LastName = TxtLastName.Text;
            CurrentLoggedUserInfo.Birthday = DTPBirthday.Value;
            CurrentLoggedUserInfo.Gender = (Gender)CbGender.SelectedIndex;
            CurrentLoggedUserInfo.Email = TxtEmailAddress.Text;
            CurrentLoggedUserInfo.PhoneNumber = TxtPhoneNum.Text;

            UserData.Instance.UpdateUserInformation();

            Globals.MainForm.ReloadUserInfo();

            MessageBox.Show("Lưu thông tin hoàn tất.");
        }

        private bool ValidateInformationData()
        {
            // Validate first name
            if (string.IsNullOrEmpty(TxtFirstName.Text) || !Regex.IsMatch(TxtFirstName.Text, "^[a-zA-Z]+$"))
                return false;

            // Validate last name
            if (string.IsNullOrEmpty(TxtLastName.Text) || !Regex.IsMatch(TxtLastName.Text, "^[a-zA-Z]+$"))
                return false;

            // Validate gender
            if (CbGender.SelectedIndex == -1)
                return false;

            // Validate birthday
            if (DTPBirthday == null)
                return false;

            DateTime Birthday = DTPBirthday.Value;
            if (Birthday.CompareTo(DateTime.Now) > 0)
                return false;

            // Validate email
            if (string.IsNullOrEmpty(TxtEmailAddress.Text) || !Regex.IsMatch(TxtEmailAddress.Text, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"))
                return false;

            bool ValidPhoneNumber = TxtPhoneNum.Text.All(char.IsDigit);
            if (!ValidPhoneNumber)
                return false;

            // All validations passed
            return true;
        }
    }
}
