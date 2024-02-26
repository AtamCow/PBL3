using OnlineExamSystem.BusinessServices.TestManagment;
using OnlineExamSystem.DataServicesLayer;
using OnlineExamSystem.DataServicesLayer.Model.School;
using OnlineExamSystem.DataServicesLayer.Model.Tests;
using OnlineExamSystem.Migrations;
using OnlineExamSystem.Presentation.UITest.UITestManagment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace OnlineExamSystem.Presentation.UITest.UIStudentTest.Exam
{
    public partial class UCDoingExam : UserControl
    {
        public event EventHandler? EventShowResultUC;

        private Test Exam;
        private User Examinee;
        private StudentTest ExamManager;

        private int test_index = 0;

        private System.Timers.Timer CountdownTimer;
        private int RemainingSeconds;

        public UCDoingExam(Test RequestedTest)
        {
            Exam = RequestedTest;
            ExamManager = StudentTest.Instance;
            Examinee = UserData.Instance.GetCurrentUser();

            InitializeComponent();

            SetAvatar();
            LoadTestInfoOntoUI();
            AlignCenterLabel();

            LoadTestQuestion();
        }
        public void LoadTestInfoOntoUI()
        {
            LbNameOfTest.Text = Exam.Name;
            LbStudentID.Text = Examinee.NumericIdentification;
            LbStudentName.Text = Examinee.FirstName + " " + Examinee.LastName;

            CreateTimerCountdown(Exam.DurationInMinutes);
        }
        public void LoadTestQuestion()
        {
            List<Question> QuestionList = Exam.Questions.ToList();

            if (Exam.SwapQuestionAndAnswersOrder)
            {
                Helper.Shuffle(QuestionList);
            }

            foreach (Question Q in QuestionList) 
            {
                UCQuestionBox NewBox = new UCQuestionBox(Q, 
                    Q.IsMoreThanOneCorrectAnswer,
                    Exam.SwapQuestionAndAnswersOrder,
                    test_index++);
                FlowPanelQuestionBox.Controls.Add(NewBox);
            }
        }

        private void BtnSubmitTest_Click(object sender, EventArgs e)
        {
            if (CheckSubmitCondition())
            {
                SubmitTest();
            }
        }
        private bool CheckSubmitCondition()
        {
            bool HasUnansweredQuestion = false;

            foreach (Control item in FlowPanelQuestionBox.Controls)
            {
                UCQuestionBox QuestionForm = item as UCQuestionBox;
                if (QuestionForm != null)
                {
                    UCQuestionBox.QuestionResponse Res = QuestionForm.GetResponse();
                    if (Res.SelectedAnswerID.Count() == 0)
                    {
                        HasUnansweredQuestion = true;
                        break;
                    }
                }
            }

            if (HasUnansweredQuestion)
            {
                DialogResult result = MessageBox.Show(
                                                        "Có câu hỏi bạn chưa chọn đáp án. Có muốn tiếp tục nộp bài?", 
                                                        "Xác nhận", 
                                                        MessageBoxButtons.YesNo, 
                                                        MessageBoxIcon.Information
                                                     );
                if (result == DialogResult.No)
                    return false;
            }

            DialogResult FinalConfirmation = MessageBox.Show(
                                                                "Xác nhận nộp và kết thúc làm bài?", 
                                                                "Xác nhận", 
                                                                MessageBoxButtons.YesNo, 
                                                                MessageBoxIcon.Information
                                                            );
            if (FinalConfirmation == DialogResult.Yes)
                return true;

            return false;
        }
        private bool SubmitTest()
        {
            foreach (Control item in FlowPanelQuestionBox.Controls)
            {
                UCQuestionBox QuestionForm = item as UCQuestionBox;
                if (QuestionForm != null)
                {
                    UCQuestionBox.QuestionResponse Res = QuestionForm.GetResponse();
                    StudentTest.Instance.InsertQuestionSelectionToResult(Res);
                }
            }
            int TimeTaken = Exam.DurationInMinutes * 60 - RemainingSeconds;

            StudentTest.Instance.GradeTestAndStoreResult(TimeTaken);

            EventShowResultUC?.Invoke(StudentTest.Instance.GetCurrentResultEntity(), null);
            return true;
        }
        public void AlignCenterLabel()
        {
            LbNameOfTest.Left = (this.Width - LbNameOfTest.Width) / 2;
            label1.Left = (this.Width - label1.Width) / 2;
        }
        private void SetAvatar()
        {
            pictureBox1.NameInitials = Examinee.FirstName.Substring(0, 1) + Examinee.LastName.Substring(0, 1);
            pictureBox1.BackgroundColor = Color.Green;
            pictureBox1.Refresh();
        }
        private void CreateTimerCountdown(int TestMinutes)
        {
            // Set the initial number of minutes for the countdown
            int initialMinutes = TestMinutes;
            RemainingSeconds = initialMinutes * 60;

            RemainingSeconds = initialMinutes * 60;

            // Set up the Timer
            CountdownTimer = new System.Timers.Timer
            {
                Interval = 1000, // 1 second
                Enabled = true,
                AutoReset = true
            };
            CountdownTimer.Elapsed += (sender, e) => CountdownTimer_Elapsed(sender, e, LbTimeLeft);
        }
        private void CountdownTimer_Elapsed(object sender, ElapsedEventArgs e, Label countdownLabel)
        {
            if (RemainingSeconds > 0)
            {
                RemainingSeconds--;

                int minutes = RemainingSeconds / 60;
                int seconds = RemainingSeconds % 60;

                UpdateCountdownLabel($"{minutes:D2}:{seconds:D2}", countdownLabel);
            }
            else
            {
                CountdownTimer.Stop();
                SubmitTest();
            }
        }

        private void UpdateCountdownLabel(string text, Label countdownLabel)
        {
            if (countdownLabel.InvokeRequired)
            {
                countdownLabel.Invoke(new Action(() => countdownLabel.Text = text));
            }
            else
            {
                countdownLabel.Text = text;
            }
        }
    }
}
