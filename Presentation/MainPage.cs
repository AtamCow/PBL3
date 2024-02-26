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

delegate void ButtonFunction();

namespace OnlineExamSystem.PresentationLayer
{
    public partial class MainPage : Form
    {
        private UserInformation? UserInfoDock;
        private UITestManagmentList? TestManagmentDock;
        private TeacherManagment? TeacherManagerDock;
        private UIClassManagment? ClassManagerDock;
        private StudentViewUpcomingTest? StudentViewTestDock;

        ButtonFunction[] ButtonFunctions = new ButtonFunction[5];

        public MainPage()
        {
            InitializeComponent();
        }
        private void HideAllButton()
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
        }
        private void AdminCreateDockForm()
        {
            UserInfoDock = new UserInformation();
            UserInfoDock.Dock = DockStyle.Fill;
            button1.Text = "Thông tin cá nhân";
            button1.Visible = true;

            TeacherManagerDock = new TeacherManagment();
            TeacherManagerDock.Dock = DockStyle.Fill;
            button2.Text = "Quản lý giáo viên";
            button2.Visible = true;

            button3.Text = "Đăng xuất";
            button3.Visible = true;


            ButtonFunctions[0] = ShowAccountInformation;
            ButtonFunctions[1] = ShowTeacherManagerMenu;
            ButtonFunctions[2] = RequestExit;
        }
        private void TeacherCreateDockForm()
        {
            UserInfoDock = new UserInformation();
            UserInfoDock.Dock = DockStyle.Fill;
            button1.Text = "Thông tin cá nhân";
            button1.Visible = true;

            TestManagmentDock = new UITestManagmentList();
            TestManagmentDock.Dock = DockStyle.Fill;
            button2.Text = "Bài kiểm tra";
            button2.Visible = true;

            ClassManagerDock = new UIClassManagment();
            ClassManagerDock.Dock = DockStyle.Fill;
            button3.Text = "Quản lý lớp học";
            button3.Visible = true;


            button4.Text = "Đăng xuất";
            button4.Visible = true;

            ButtonFunctions[0] = ShowAccountInformation;
            ButtonFunctions[1] = ShowTestManagmentMenu;
            ButtonFunctions[2] = ShowClassManagmentMenu;
            ButtonFunctions[3] = RequestExit;
        }
        private void StudentCreateDockForm()
        {
            UserInfoDock = new UserInformation();
            UserInfoDock.Dock = DockStyle.Fill;
            button1.Text = "Thông tin cá nhân";
            button1.Visible = true;

            StudentViewTestDock = new StudentViewUpcomingTest();
            StudentViewTestDock.Dock = DockStyle.Fill;
            button2.Text = "Bài kiểm tra";
            button2.Visible = true;


            button3.Text = "Đăng xuất";
            button3.Visible = true;

            ButtonFunctions[0] = ShowAccountInformation;
            ButtonFunctions[1] = ShowStudentDoTestMenu;
            ButtonFunctions[2] = RequestExit;
        }
        private void CreateDockFormBasedOnRole()
        {
            User CurrentLoggedUserInfo = UserData.Instance.GetCurrentUser();
            switch (CurrentLoggedUserInfo.AccRole)
            {
                case AccRole.Administrator:
                    AdminCreateDockForm();
                    break;
                case AccRole.Teacher:
                    TeacherCreateDockForm();
                    break;
                case AccRole.Student:
                    StudentCreateDockForm();
                    break;
                default:
                    break;
            }
        }

        public void ReloadUserInfo()
        {
            LoadUserInformation();
        }
        private void LoadUserInformation()
        {
            if (!UserData.Instance.IsLoggedIn())
                return;

            User CurrentLoggedUserInfo = UserData.Instance.GetCurrentUser();

            txtName.Text = CurrentLoggedUserInfo.FirstName + " " + CurrentLoggedUserInfo.LastName;
            txtRole.Text = CurrentLoggedUserInfo.AccRoleString();
            // set the avatar

            pictureBox1.NameInitials = CurrentLoggedUserInfo.FirstName.Substring(0, 1) + CurrentLoggedUserInfo.LastName.Substring(0, 1);
            switch ((AccRole)CurrentLoggedUserInfo.AccRole)
            {
                case AccRole.Teacher:
                    pictureBox1.BackgroundColor = Color.Blue;
                    break;
                case AccRole.Student:
                    pictureBox1.BackgroundColor = Color.Green;
                    break;
                case AccRole.Administrator:
                    pictureBox1.BackgroundColor = Color.LightYellow;
                    pictureBox1.FontColor = Color.Black;
                    break;
            }
            pictureBox1.Refresh();
        }

        private void ShowAccountInformation()
        {
            BringUpFrontDock(UserInfoDock);
        }
        private void ShowTestManagmentMenu()
        {
            BringUpFrontDock(TestManagmentDock);
        }
        private void ShowTeacherManagerMenu()
        {
            BringUpFrontDock(TeacherManagerDock);
        }
        private void ShowClassManagmentMenu()
        {
            BringUpFrontDock(ClassManagerDock);
        }
        private void ShowStudentDoTestMenu()
        {
            BringUpFrontDock(StudentViewTestDock);
        }
        public void BringUpFrontDock(object sender)
        {
            PanelContent.Controls.Clear();
            PanelContent.Controls.Add((Control)sender);
        }
        public void AddNewPanelToQueue(object sender)
        {
            PanelContent.Controls.Add((Control)sender);
            PanelContent.Controls[PanelContent.Controls.Count - 1].BringToFront();
        }
        public void GoBack()
        {
            PanelContent.Controls.RemoveAt(0);
        }
        private void MainPage_Load(object sender, EventArgs e)
        {
            HideAllButton();
            CreateDockFormBasedOnRole();
            LoadUserInformation();

            BringUpFrontDock(UserInfoDock);
            //PanelContent.Controls["UserInformation"].BringToFront();
        }

        private void RequestExit()
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ButtonFunctions[0]();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ButtonFunctions[1]();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ButtonFunctions[2]();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            ButtonFunctions[3]();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            ButtonFunctions[4]();
        }
        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Helper.ExitProcess();
        }

        private void PanelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
