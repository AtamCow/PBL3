using OnlineExamSystem.BusinessServices.TestManagment;
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

namespace OnlineExamSystem.Presentation.UITest.UIStudentTest
{
    public partial class UCEnterExam : UserControl
    {
        private Test Exam;
        private StudentTest ExamManager;
        public event EventHandler? RequestSpawnTestUI;

        public UCEnterExam(Test RequestedTest)
        {
            Exam = RequestedTest;
            ExamManager = StudentTest.Instance;

            ExamManager.SetDoTest(Exam);

            InitializeComponent();
            SetTestInformation();
            AlignCenterLabel();
        }
        public void AlignCenterLabel()
        {
            label1.Left = (this.Width - label1.Width) / 2;
            LbTestName.Left = (this.Width - LbTestName.Width) / 2;
            LbAllowTime.Left = (this.Width - LbAllowTime.Width) / 2;
            button1.Left = (this.Width - button1.Width) / 2;
            LbStatus.Left = (this.Width - LbStatus.Width) / 2;
            PanelPassword.Left = (this.Width - PanelPassword.Width) / 2;
        }
        public void SetTestInformation()
        {
            PanelPassword.Hide();
            LbTestName.Text = Exam.Name;
            LbAllowTime.Text = "Thời gian: " + Exam.DurationInMinutes.ToString() + " phút";

            if (Exam.JoinPassword.Length > 0) 
            {
                PanelPassword.Show();
            }
            LbStatus.Text = "";
        }
        public void SetStatus(string status)
        {
            LbStatus.Text = status;
            AlignCenterLabel();
        }

        private void BtnRequestStartExam_Click(object sender, EventArgs e)
        {
            string ErrorMessage = "";
            bool CanJoin = ExamManager.RequestDoTest(TxtPassword.Text, ref ErrorMessage);
            if (CanJoin)
            {
                RequestSpawnTestUI?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                SetStatus(ErrorMessage);
            }        
        }
    }
}
