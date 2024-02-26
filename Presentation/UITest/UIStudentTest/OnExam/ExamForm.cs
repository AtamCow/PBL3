using OnlineExamSystem.BusinessServicesLayer;
using OnlineExamSystem.DataServices.Method.Tests;
using OnlineExamSystem.DataServicesLayer.Model.Tests;
using OnlineExamSystem.Presentation.UITest.UIStudentTest.Exam;
using OnlineExamSystem.Presentation.UITest.UIStudentTest.OnExam;
using OnlineExamSystem.Presentation.UITest.UIStudentTest.OnExam.AfterExam;
using OnlineExamSystem.PresentationLayer;
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
    public partial class ExamForm : Form
    {
        Test Exam;
        bool ShowResultOnly = false;
        public ExamForm(Test RequestedTest)
        {
            Exam = RequestedTest;

            InitializeComponent();
            if (!ShowResultOnly)
                ShowEnterExamUC();
        }
        public bool SetShowResultOnly()
        {
            UCExamScore demo = new UCExamScore(this);

            TestTaker Taker = TestData.Instance.GetUserTestTakerEntityFromTest(Exam);

            if (Taker.TestTakerResults.Count > 0)
            {
                ShowResultOnly = true;

                TestTakerResult Result = Taker.TestTakerResults.First();
                demo.SetScore(Result.FinalScore, Result.TestTaker.Test.MaxScore);
                if (Exam.StudentCanSeeAnswersAfterDone)
                {
                    demo.ShowSeeDetailsButton(Result);
                }
                BringUp(demo);
                return true;
            }
            return false;
        }
        public bool SetShowResultMulti()
        {
            UCExamResultList demo = new UCExamResultList(this);
            demo.SetExamEntity(Exam);
            if (!demo.IsSubmissionAvailable())
                return false;
            
            demo.Load();

            BringUp(demo);
            return true;
        }
        public void ShowEnterExamUC()
        {
            UCEnterExam enter_dialog = new UCEnterExam(Exam);
            enter_dialog.RequestSpawnTestUI += OnRequestSpawnTestUI;
            BringUp(enter_dialog);
        }

        private void OnRequestSpawnTestUI(object sender, EventArgs e)
        {
            UCDoingExam exam_uc = new UCDoingExam(Exam);
            exam_uc.EventShowResultUC += OnRequestSpawnTestResult;
            BringUp(exam_uc);           
        }
        private void OnRequestSpawnTestResult(object sender, EventArgs e)
        {
            UCExamScore demo = new UCExamScore(this);

            TestTakerResult Result = sender as TestTakerResult;
            if (Result.TestTaker.Test.StudentCanSeeFinalScore)
            {
                demo.SetScore(Result.FinalScore, Result.TestTaker.Test.MaxScore);
            }
            if (Result.TestTaker.Test.StudentCanSeeAnswersAfterDone)
            {
                demo.ShowSeeDetailsButton(Result);
            }
            BringUp(demo);
        }
        public void BringUp(object sender)
        {
            ViewPanel.Controls.Clear();
            ViewPanel.Controls.Add((Control)sender);
        }
        public void AddNewPanelToQueue(object sender)
        {
            ViewPanel.Controls.Add((Control)sender);
            ViewPanel.Controls[ViewPanel.Controls.Count - 1].BringToFront();
        }
        public void GoBack()
        {
            ViewPanel.Controls.RemoveAt(0);
        }
    }
}
