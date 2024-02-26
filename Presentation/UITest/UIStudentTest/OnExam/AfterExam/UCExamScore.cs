using OnlineExamSystem.DataServicesLayer.Model.Tests;
using OnlineExamSystem.Presentation.UITest.UIStudentTest.Exam;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineExamSystem.Presentation.UITest.UIStudentTest.OnExam
{
    public partial class UCExamScore : UserControl
    {
        private ExamForm MainControl;
        private TestTakerResult WorkResult;

        public UCExamScore(ExamForm Forms)
        {
            MainControl = Forms;

            InitializeComponent();
            AlignCenter();
            BtnViewDetails.Visible = false;
        }

        public void SetScore(decimal Score, decimal MaxScore)
        {
            LbScore.Text = "Điểm số: " + Score + "/" + MaxScore;
            AlignCenter();
        }
        public void ShowSeeDetailsButton(TestTakerResult result)
        {
            WorkResult = result;
            BtnViewDetails.Visible = true;
        }
        private void AlignCenter()
        {
            label1.Left = (this.panel1.Width - label1.Width) / 2;
            label2.Left = (this.panel1.Width - label2.Width) / 2;
            LbScore.Left = (this.panel1.Width - LbScore.Width) / 2;
            BtnViewDetails.Left = (this.panel1.Width - BtnViewDetails.Width) / 2;
            BtnExit.Left = (this.panel1.Width - BtnExit.Width) / 2;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            MainControl.Close();
        }

        private void BtnViewDetails_Click(object sender, EventArgs e)
        {
            UCWorkDetails ExamResultUI = new UCWorkDetails(MainControl, WorkResult);
            MainControl.AddNewPanelToQueue(ExamResultUI);
        }
    }
}
