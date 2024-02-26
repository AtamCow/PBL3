using OnlineExamSystem.DataServicesLayer.Model.Tests;
using OnlineExamSystem.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineExamSystem.Presentation.UITest.UIStudentTest.Exam
{
    public partial class UCQuestionBox : UserControl
    {
        private int QIndex = 0;

        private class UIAnswer
        {
            public int AnswerID { get; set; }

            public bool ReadCheckbox { get; set; }

            public CheckBox CheckboxChecked { get; set; }
            public RadioButton RadioChecked { get; set; }

            public bool IsCorrect { get; set; }
        }
        public class QuestionResponse
        {
            public int QuestionID { get; set; }
            public List<int> SelectedAnswerID { get; set; }
        }

        private List<UIAnswer> AnswersList;

        private int OptionsCount = 0;
        private Question Question;

        public UCQuestionBox(Question Ques,
            bool IsMoreThanOneCorrectAnswer,
            bool NeedSuffleAnswers,
            int QuestionIndex)
        {
            QIndex = QuestionIndex;
            Question = Ques;


            InitializeComponent();

            SetBackgroundColorBasedOnIndex();
            SetQuestionContent(IsMoreThanOneCorrectAnswer, NeedSuffleAnswers);
            AlignForm();
        }
        public QuestionResponse GetResponse()
        {
            QuestionResponse NewRes = new QuestionResponse();
            NewRes.QuestionID = Question.QuestionId;
            NewRes.SelectedAnswerID = new List<int>();

            foreach (UIAnswer UIAns in AnswersList)
            {
                bool IsChecked = false;
                if (UIAns.ReadCheckbox)
                {
                    IsChecked = UIAns.CheckboxChecked.Checked;
                }
                else
                {
                    IsChecked = UIAns.RadioChecked.Checked;
                }
                if (IsChecked)
                {
                    NewRes.SelectedAnswerID.Add(UIAns.AnswerID);
                }
            }

            return NewRes;
        }
        private void SetQuestionContent(bool IsMoreThanOneCorrectAnswer, bool NeedSuffleAnswers)
        {
            LbQuestionIndex.Text = "Câu " + (QIndex + 1).ToString();
            LbQuestionText.Text = Question.Title;


            List<Answer> AnswerList = Question.AnswerOptions.ToList();

            if (NeedSuffleAnswers)
            {
                Helper.Shuffle(AnswerList);
            }
            AnswersList = new List<UIAnswer>();

            if (IsMoreThanOneCorrectAnswer)
            {
                groupBox1.Text = "Chọn một hoặc nhiều phương án";
                // create checkbox
                foreach (Answer A in AnswerList)
                {
                    UIAnswer UANS = new UIAnswer();
                    UANS.AnswerID = A.AnswerId;

                    CreateCheckboxOptions(UANS, A.Text);

                    AnswersList.Add(UANS);
                }
            }
            else
            {
                groupBox1.Text = "Chọn một phương án";
                // create radio
                foreach (Answer A in AnswerList)
                {
                    UIAnswer UANS = new UIAnswer();
                    UANS.AnswerID = A.AnswerId;

                    CreateRadioOptions(UANS, A.Text);

                    AnswersList.Add(UANS);
                }
            }
        }
        public void SetSelectedOptionsAndAnswer(StudentAnswerResponse QuestionResponse)
        {
            if (QuestionResponse == null)
                return;

            Color LightGreen = Color.FromArgb(255, 204, 229, 204);
            Color LightRed = Color.FromArgb(255, 255, 204, 204);

            // @FIXME bi bug o radio button, chua biet fix ntn

            foreach (UIAnswer State in AnswersList)
            {
                if (State.ReadCheckbox)
                    State.CheckboxChecked.Click += Control_Click;
                else
                    State.RadioChecked.Click += Control_Click;
            }

            foreach (Answer A in QuestionResponse.Question.AnswerOptions)
            {
                // Find the corresponding UIAnswer object
                UIAnswer State = AnswersList.Find(ans => ans.AnswerID == A.AnswerId);
                if (A.IsCorrect)
                {
                    if (State.ReadCheckbox)
                        State.CheckboxChecked.BackColor = LightGreen;
                    else
                        State.RadioChecked.BackColor = LightGreen;

                    State.IsCorrect = true;
                }        
            }

            foreach (SelectedAnswer SAnswer in QuestionResponse.SelectedAnswers) 
            {
                int SelectedAnswerID = SAnswer.AnswerId;
                UIAnswer State = AnswersList.Find(A => A.AnswerID == SelectedAnswerID);

                if (State.ReadCheckbox)
                    State.CheckboxChecked.Checked = true;
                else
                    State.RadioChecked.Checked = true;


                if (!State.IsCorrect)
                {
                    if (State.ReadCheckbox)
                        State.CheckboxChecked.BackColor = LightRed;
                    else
                        State.RadioChecked.BackColor = LightRed;
                }
            }
        }
        private void CreateRadioOptions(UIAnswer UANS, string Text)
        {
            System.Windows.Forms.RadioButton NewRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.Controls.Add(NewRadioButton);
            
            UANS.ReadCheckbox = false;
            UANS.RadioChecked = NewRadioButton;

            NewRadioButton.AutoSize = true;
            NewRadioButton.Font = new System.Drawing.Font("Segoe UI", 13F, 
                System.Drawing.FontStyle.Regular, 
                System.Drawing.GraphicsUnit.Point
            );

            int Y_AXIS = 39 + OptionsCount * 45;

            NewRadioButton.Location = new System.Drawing.Point(15, Y_AXIS);
            NewRadioButton.Name = "radioButton1";
            NewRadioButton.Size = new System.Drawing.Size(190, 40);
            NewRadioButton.TabIndex = 0;
            NewRadioButton.TabStop = true;
            NewRadioButton.Text = Text;
            NewRadioButton.UseVisualStyleBackColor = true;

            OptionsCount++;
        }
        private void CreateCheckboxOptions(UIAnswer UANS, string Text)
        {
            System.Windows.Forms.CheckBox NewCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1.Controls.Add(NewCheckbox);

            UANS.ReadCheckbox = true;
            UANS.CheckboxChecked = NewCheckbox;

            NewCheckbox.AutoSize = true;
            NewCheckbox.Font = new System.Drawing.Font("Segoe UI", 13F,
                System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point
            );

            int Y_AXIS = 39 + OptionsCount * 45;

            NewCheckbox.Location = new System.Drawing.Point(15, Y_AXIS);
            NewCheckbox.Name = "Checkboxxx";
            NewCheckbox.Size = new System.Drawing.Size(190, 40);
            NewCheckbox.TabIndex = 0;
            NewCheckbox.TabStop = true;
            NewCheckbox.Text = Text;
            NewCheckbox.UseVisualStyleBackColor = true;

            OptionsCount++;
        }
        private void SetBackgroundColorBasedOnIndex()
        {
            if (QIndex % 2 == 0)
            {
                this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
                this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            }
            else
            {
                this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
                this.BackColor = System.Drawing.Color.WhiteSmoke;
            }
        }
        private void AlignForm()
        {
            Graphics gfx = LbQuestionText.CreateGraphics();
            SizeF textSize = gfx.MeasureString(LbQuestionText.Text,
                LbQuestionText.Font, LbQuestionText.Width);

            // Calculate the new Y position for the GroupBox
            int newY = LbQuestionText.Location.Y + (int)textSize.Height + 10; // Add 10 pixels as a margin between the Label and the GroupBox

            // Set the new location for the GroupBox
            groupBox1.Location = new Point(groupBox1.Location.X, newY);
            groupBox1.Size = new Size(groupBox1.Size.Width, OptionsCount * 57 + 15);
            this.Size = new Size(1880, 70 + (int)textSize.Height + (OptionsCount * 57) + 15 );
        }

        // Single event handler for all controls
        private void Control_Click(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                checkBox.Checked = !checkBox.Checked;
            }
            else if (sender is RadioButton radioButton)
            {
                radioButton.Checked = !radioButton.Checked;
            }
        }
    }
}
