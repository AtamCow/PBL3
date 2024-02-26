#define TEST_LOGIN

using OnlineExamSystem.BusinessServicesLayer;
using OnlineExamSystem.DataServicesLayer;
using OnlineExamSystem.DataServicesLayer.Model.School;


namespace OnlineExamSystem
{
    public partial class LoginForm : Form
    {
        public event EventHandler? LoginSuccessful;

        public LoginForm()
        {
            InitializeComponent();
#if TEST_LOGIN
            TxtUsername.Text = "admin@gmail.com";
            TxtPassword.Text = "12345678";

            TxtUsername.Text = "jane.smith@example.com";
            TxtPassword.Text = "123456";

            //TxtUsername.Text = "102210002";
            //TxtPassword.Text = "102210002";
#endif
        }

        private void OnLoginButtonClicked(object sender, EventArgs e)
        {
            var InMSSV = TxtUsername.Text;
            var InPassword = TxtPassword.Text;
            if (InMSSV.Length < 4 || InPassword.Length < 4)
            {
                MessageBox.Show("Thông tin không hợp lệ. Vui lòng kiểm tra lại.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (UserManagment.Instance.Login(InMSSV, InPassword))
            {
                LoginSuccessful?.Invoke(this, EventArgs.Empty);
            }
            return;
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                OnLoginButtonClicked(null, null);
        }
    }
}