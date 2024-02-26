using OnlineExamSystem.DataServicesLayer.Model.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineExamSystem.DataServicesLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OnlineExamSystem.BusinessServicesLayer
{
    public class UserManagment
    {
        private static UserManagment _Instance = null;
        public static UserManagment Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new UserManagment();
                return _Instance;
            }
            private set
            {

            }
        }

        public bool Login(string username, string password)
        {
            if (!UserData.Instance.IsLoggedIn())
            {
                var Account = UserData.Instance.GetUserByIDOrEmail(username);
                if (Account == null)
                {
                    MessageBox.Show("Tài khoản không tồn tại trên hệ thống.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else
                {
                    if (Account.IsDeleted)
                    {
                        MessageBox.Show("Tài khoản đã bị xóa khỏi hệ thống.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                    if (Helper.VerifyPassword(password, Account.HashedPassword))
                    {
                        if (Account.IsBlocked)
                        {
                            MessageBox.Show("Tài khoản đang bị khóa.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                        UserData.Instance.SetUser(Account);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Sai mật khẩu. Vui lòng kiểm tra lại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return false;
        }
        public bool ChangePassword(string OldPassword, string NewPassword) 
        {
            if (!UserData.Instance.IsLoggedIn())
                return false;

            if (!Helper.VerifyPassword(OldPassword, UserData.Instance.GetCurrentUser().HashedPassword))
                return false;

            string NewPasswordHash = Helper.HashPassword(NewPassword);
            UserData.Instance.ChangePasswordHash(NewPasswordHash);
            return true;
        }
        public bool IsUserExist(string EmailOrID)
        {
            return UserData.Instance.GetUserByIDOrEmail(EmailOrID) != null;
        }
    }
}
