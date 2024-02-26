using OnlineExamSystem.BusinessServices.TestManagment;
using OnlineExamSystem.BusinessServicesLayer;
using OnlineExamSystem.DataServicesLayer;
using OnlineExamSystem.DataServicesLayer.Model.School;
using OnlineExamSystem.DataServicesLayer.Model.Tests;
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

namespace OnlineExamSystem.Presentation.UITest.UITestManagment
{
    public partial class AddNewTest : UserControl
    {
        private List<Class> TeachingClasses;
        private List<Class> CanDoExamClass;
        public event EventHandler OnFormLeave;

        private Test ModifyingTestObj;

        public AddNewTest()
        {
            InitializeComponent();
            SetDateTimeFormat();
            LoadFormInformation();
            LoadDataFromExistTest();
        }
        private void SetDateTimeFormat()
        {
            DTPBeginTime.Format = DateTimePickerFormat.Custom;
            DTPBeginTime.CustomFormat = "dd-MM-yyyy HH:mm";

            DTPEndTime.Format = DateTimePickerFormat.Custom;
            DTPEndTime.CustomFormat = "dd-MM-yyyy HH:mm";
        }
        private void LoadFormInformation()
        {
            if (UserData.Instance.GetCurrentUser() == null)
                return;

            TeachingClasses = ClassData.Instance.GetAllClassByCurrentTeacher().ToList();
            CanDoExamClass = new List<Class>();

            CbClassSelection.Items.Clear();
            if (TeachingClasses.Count() > 0)
            {
                foreach (Class c in TeachingClasses)
                {
                    CbClassSelection.Items.Add(c.Name);
                }
                CbClassSelection.SelectedIndex = 0;
            }

        }

        private void BtnAddClassToLV_Click(object sender, EventArgs e)
        {
            int index = CbClassSelection.SelectedIndex;
            if (index != -1)
            {
                Class SelectedClass = TeachingClasses[index];

                // Check if the ListView already contains the class name
                var existingItem = ListViewCanDoExamClass.Items.Cast<ListViewItem>().FirstOrDefault(item => item.Text == SelectedClass.Name);

                if (existingItem == null)
                {
                    ListViewCanDoExamClass.Items.Add(new ListViewItem(SelectedClass.Name));
                    CanDoExamClass.Add(SelectedClass);
                    BtnAddClassToLV.Text = "Xóa lớp";
                }
                else
                {
                    ListViewCanDoExamClass.Items.Remove(existingItem);
                    CanDoExamClass.Remove(SelectedClass);
                    BtnAddClassToLV.Text = "Thêm lớp";
                }
            }
        }

        private bool ValidateFormInformation()
        {
            bool AllGood = true;
            if (TxtTestName.Text.Length <= 0)
            {
                LabelTestName.ForeColor = Color.Red;
                AllGood = false;
            }
            else
                LabelTestName.ForeColor = Color.Black;

            int requiredDurationInMinutes = 0;

            if (TxtTestDurationInMinutes.Text.Length <= 0)
            {
                LabelDuration.ForeColor = Color.Red;
                AllGood = false;
            }
            else
            {
                if (!int.TryParse(TxtTestDurationInMinutes.Text, out requiredDurationInMinutes) || requiredDurationInMinutes <= 0)
                {
                    LabelDuration.ForeColor = Color.Red;
                    AllGood = false;
                }
                else
                    LabelDuration.ForeColor = Color.Black;
            }

            DateTime beginTime = DTPBeginTime.Value;
            DateTime endTime = DTPEndTime.Value;


            // Check that BeginTime is less than EndTime
            if (beginTime >= endTime)
            {
                LabelTestAllowTime.ForeColor = Color.Red;
                AllGood = false;
            }

            TimeSpan duration = endTime - beginTime;
            if (duration.TotalMinutes <= requiredDurationInMinutes)
            {
                LabelTestAllowTime.ForeColor = Color.Red;
                AllGood = false;
            }
            else
                LabelTestAllowTime.ForeColor = Color.Black;

            if (ListViewCanDoExamClass.Items.Count == 0)
            {
                AllGood = false;
                LbWhoCanTakeEx.ForeColor = Color.Red;
            }
            else
                LbWhoCanTakeEx.ForeColor = Color.Black;

            if (flowLayoutPanel1.Controls.Count <= 1)
            {
                MessageBox.Show("Vui lòng thêm ít nhất một câu hỏi!");
                return false;
            }
            foreach (Control item in flowLayoutPanel1.Controls)
            {
                UCAddNewQuestion QuestionForm = item as UCAddNewQuestion;
                if (QuestionForm != null)
                {
                    if (!QuestionForm.IsValidQuestion())
                        return false;
                }
            }
            return AllGood;
        }
        private void BtnSaveInformation_Click(object sender, EventArgs e)
        {
            if (ValidateFormInformation())
            {
                Test NewTest = null;
                if (ModifyingTestObj != null)
                    NewTest = ModifyingTestObj;
                else
                {
                    NewTest = new Test();
                    NewTest.CreateTime = DateTime.Now;
                }

                NewTest.Name = TxtTestName.Text;

                int requiredDurationInMinutes = 0;
                int.TryParse(TxtTestDurationInMinutes.Text, out requiredDurationInMinutes);
                NewTest.DurationInMinutes = requiredDurationInMinutes;

                NewTest.BeginTime = DTPBeginTime.Value;
                NewTest.EndTime = DTPEndTime.Value;
                NewTest.LastModifyTime = DateTime.Now;

                NewTest.JoinPassword = TxtJoinPassword.Text;
                NewTest.AllowOnlyOneTry = CheckboxCanOnlyTakeOneTime.Checked;
                NewTest.SwapQuestionAndAnswersOrder = CheckBoxSwapQandA.Checked;
                NewTest.StudentCanSeeAnswersAfterDone = CheckBoxAllowSeeQandA.Checked;
                NewTest.StudentCanSeeFinalScore = CheckBoxAllowSeeFinalScore.Checked;
                NewTest.Subject = "";

                decimal MaxScore = ProcessQuestions(NewTest);
                NewTest.MaxScore = MaxScore;
                // process TestTaker
                ProcessTestTakers(NewTest);
                /*
                NewTest.TestTakers.Clear();
                foreach (Class AllowedClass in CanDoExamClass)
                {
                    foreach (ClassStudent CStudent in AllowedClass.Students)
                    {
                        User Student = CStudent.Student;

                        TestTaker NewTaker = new TestTaker();
                        NewTaker.Test = NewTest;
                        NewTaker.Student = Student;
                        NewTaker.Class = AllowedClass;
                       
                        NewTest.TestTakers.Add(NewTaker);
                    }
                }
                */
                // end

                if (ModifyingTestObj != null)
                {
                    if (TestManagment.Instance.UpdateTest(NewTest))
                    {
                        MessageBox.Show("Đã lưu thông tin.");
                        OnFormLeave?.Invoke(this, EventArgs.Empty);
                    }
                    else
                    {
                        MessageBox.Show("Co loi xay ra.");
                    }
                }
                else
                {
                    if (TestManagment.Instance.CreateNewTestFromUI(NewTest))
                    {
                        MessageBox.Show("Tạo bài kiểm tra mới thành công.");
                        OnFormLeave?.Invoke(this, EventArgs.Empty);
                    }
                    else
                    {
                        MessageBox.Show("Co loi xay ra.");
                    }
                }
            }
        }

        // stupid function, don't ask me why
        private void ProcessTestTakers(Test NewTest)
        {
            // Retrieve existing TestTakers associated with the test
            var existingTestTakers = NewTest.TestTakers.ToList();

            // Process TestTakers
            foreach (Class allowedClass in CanDoExamClass)
            {
                foreach (ClassStudent cStudent in allowedClass.Students)
                {
                    User student = cStudent.Student;

                    // Check if a TestTaker instance already exists for the student
                    var existingTestTaker = existingTestTakers.FirstOrDefault(tt => tt.Student.UserId == student.UserId);

                    if (existingTestTaker != null)
                    {
                        // Update the existing TestTaker instance
                        existingTestTaker.Class = allowedClass;
                        existingTestTaker.Test = NewTest;
                    }
                    else
                    {
                        // Create a new TestTaker instance
                        TestTaker newTaker = new TestTaker
                        {
                            Test = NewTest,
                            Student = student,
                            Class = allowedClass
                        };

                        NewTest.TestTakers.Add(newTaker);
                    }
                }
            }

            // Remove TestTaker instances that are no longer associated with allowed classes
            var testTakersToRemove = existingTestTakers
                .Where(tt => !CanDoExamClass.Any(c => c.ClassId == tt.ClassId))
                .ToList();

            foreach (var testTakerToRemove in testTakersToRemove)
            {
                NewTest.TestTakers.Remove(testTakerToRemove);
            }
        }
        private decimal ProcessQuestions(Test Test)
        {
            decimal MaxScore = 0;
            int NewQuestionPlaceholderId = -1;
            if (ModifyingTestObj != null)
            {
                foreach (Control item in flowLayoutPanel1.Controls)
                {
                    UCAddNewQuestion QuestionForm = item as UCAddNewQuestion;
                    if (QuestionForm != null)
                    {
                        Question NewQues = QuestionForm.BuildQuestion();
                        if (NewQues.QuestionId != 0)
                        {
                            Question ExistingQuestion = Test.Questions.FirstOrDefault(q => q.QuestionId == NewQues.QuestionId);

                            if (ExistingQuestion != null)
                            {
                                ExistingQuestion.Title = NewQues.Title;
                                ExistingQuestion.Mark = NewQues.Mark;
                                MaxScore += NewQues.Mark;
                                ExistingQuestion.Hint = NewQues.Hint;
                                ExistingQuestion.IsMoreThanOneCorrectAnswer = NewQues.IsMoreThanOneCorrectAnswer;

                                foreach (var NewAnswer in NewQues.AnswerOptions)
                                {
                                    if (NewAnswer.AnswerId != 0)
                                    {
                                        Answer existingAnswer = ExistingQuestion.AnswerOptions.FirstOrDefault(a => a.AnswerId == NewAnswer.AnswerId);

                                        if (existingAnswer != null)
                                        {
                                            existingAnswer.Text = NewAnswer.Text;
                                            existingAnswer.IsCorrect = NewAnswer.IsCorrect;
                                        }
                                    }
                                    else
                                    {
                                        // Add new answers to the existing question
                                        ExistingQuestion.AnswerOptions.Add(NewAnswer);
                                    }
                                }

                                var deletedAnswers = ExistingQuestion.AnswerOptions
                                                     .Where(a => !NewQues.AnswerOptions.Any(na => na.AnswerId == a.AnswerId))
                                                     .ToList();

                                foreach (var deletedAnswer in deletedAnswers)
                                {
                                    ExistingQuestion.AnswerOptions.Remove(deletedAnswer);
                                }

                            }
                        }
                        else
                        {
                            NewQues.QuestionId = NewQuestionPlaceholderId;
                            NewQuestionPlaceholderId--;

                            Test.Questions.Add(NewQues);
                        }
                    }
                }
                // Remove deleted questions
                var UpdatedQuestionIDs = flowLayoutPanel1.Controls
                                                        .OfType<UCAddNewQuestion>()
                                                        .Select(qf => qf.BuildQuestion().QuestionId)
                                                        .Where(id => id != 0)
                                                        .ToList();

                var DeletedQuestions = Test.Questions
                                .Where(q => !UpdatedQuestionIDs.Contains(q.QuestionId) && q.QuestionId > 0)
                                .ToList();

                foreach (var DeletedQuestion in DeletedQuestions)
                {
                    Test.Questions.Remove(DeletedQuestion);
                }

                foreach (Question Q in Test.Questions)
                {
                    if (Q.QuestionId < 0)
                        Q.QuestionId = 0; // mark for creation
                }
            }
            else
            {
                Test.Questions.Clear();

                foreach (Control item in flowLayoutPanel1.Controls)
                {
                    UCAddNewQuestion QuestionForm = item as UCAddNewQuestion;
                    if (QuestionForm != null)
                    {
                        Question NewQues = QuestionForm.BuildQuestion();
                        MaxScore += NewQues.Mark;
                        Test.Questions.Add(NewQues);
                    }
                }
            }
            return MaxScore;
        }

        private void NewQuestionBtn(object sender, EventArgs e)
        {
            NewQuestionForm();
        }
        private UCAddNewQuestion NewQuestionForm()
        {
            UCAddNewQuestion userControl = new UCAddNewQuestion();
            flowLayoutPanel1.Controls.Add(userControl);

            // dem button len cuoi ds
            SwapLastTwoControls(flowLayoutPanel1);

            return userControl;
        }
        private void SwapLastTwoControls(FlowLayoutPanel flowLayoutPanel)
        {
            // Get the last two controls
            int lastIndex = flowLayoutPanel.Controls.Count - 1;
            int secondLastIndex = flowLayoutPanel.Controls.Count - 2;
            Control lastControl = flowLayoutPanel.Controls[lastIndex];
            Control secondLastControl = flowLayoutPanel.Controls[secondLastIndex];

            // Temporarily remove the controls from the FlowLayoutPanel
            flowLayoutPanel.Controls.RemoveAt(lastIndex);
            flowLayoutPanel.Controls.RemoveAt(secondLastIndex);

            // Re-add the controls in the swapped order
            flowLayoutPanel.Controls.Add(lastControl);
            flowLayoutPanel.Controls.Add(secondLastControl);

            flowLayoutPanel.AutoScrollPosition = new Point(0, flowLayoutPanel.DisplayRectangle.Height);

        }

        private void label9_Click(object sender, EventArgs e)
        {
            OnFormLeave?.Invoke(this, EventArgs.Empty);
        }
        ////////////////////////////////////// EDIT EXIST TEST ///////////////////////////////////////////

        public void SetModifyingTest(Test TestObject)
        {
            ModifyingTestObj = TestObject;
            LoadDataFromExistTest();
            label5.Text = "Chỉnh sửa bài test";
        }
        public void LoadDataFromExistTest()
        {
            if (ModifyingTestObj == null)
                return;

            Test T = ModifyingTestObj;

            TxtTestName.Text = T.Name;
            TxtTestDurationInMinutes.Text = T.DurationInMinutes.ToString();

            DTPBeginTime.Value = T.BeginTime;
            DTPEndTime.Value = T.EndTime;

            TxtJoinPassword.Text = T.JoinPassword;
            CheckboxCanOnlyTakeOneTime.Checked = T.AllowOnlyOneTry;
            CheckBoxSwapQandA.Checked = T.SwapQuestionAndAnswersOrder;
            CheckBoxAllowSeeQandA.Checked = T.StudentCanSeeAnswersAfterDone;
            CheckBoxAllowSeeFinalScore.Checked = T.StudentCanSeeFinalScore;


            foreach (Question Q in T.Questions)
            {
                UCAddNewQuestion UCQues = NewQuestionForm();
                UCQues.LoadQuestionAndAnswers(Q);
            }
            var distinctClasses = T.TestTakers
                    .Where(tt => tt.Test == T) // Filter by TestId
                    .Select(tt => tt.Class) // Select the Class property
                    .GroupBy(c => c.ClassId) // Group by ClassId
                    .Select(g => g.First()) // Select the first Class object from each group
                    .ToList(); // Convert to List<Class>

            foreach (Class C in distinctClasses)
            {
                ListViewCanDoExamClass.Items.Add(new ListViewItem(C.Name));
                CanDoExamClass.Add(C);
            }
        }

        private void CbClassSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = CbClassSelection.SelectedIndex;
            if (index != -1)
            {
                Class SelectedClass = TeachingClasses[index];

                // Check if the ListView already contains the class name
                var existingItem = ListViewCanDoExamClass.Items.Cast<ListViewItem>().FirstOrDefault(item => item.Text == SelectedClass.Name);

                if (existingItem == null) // If the class name does not exist in the ListView
                {
                    BtnAddClassToLV.Text = "Thêm lớp";
                }
                else // If the class name already exists in the ListView
                {
                    BtnAddClassToLV.Text = "Xóa lớp";
                }
            }
        }
    }
}
