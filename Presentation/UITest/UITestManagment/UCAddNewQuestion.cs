using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Options;
using Microsoft.VisualBasic.FileIO;
using OnlineExamSystem.DataServicesLayer.Model.Tests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineExamSystem.Presentation.UITest.UITestManagment
{

    public partial class UCAddNewQuestion : UserControl
    {
        private class UIOptions
        {
            public CheckBox TrueFalse { get; set; }
            public TextBox OptionsText { get; set; }
            public Label RemoveOptions { get; set; }
            public int AnswerID { get; set; }
        }
        private int QuestionID = 0;

        private List<UIOptions> UIOptionsList;

        public UCAddNewQuestion()
        {
            InitializeComponent();
            UIOptionsList = new List<UIOptions>();  
            AddOptionToList(checkBox1, textBox1, label4);
            AlignForm();
        }
        private void AddOptionToList(CheckBox TF, TextBox NewTxt, Label NewLabel)
        {
            UIOptions NewOption = new UIOptions();
            NewOption.OptionsText = NewTxt;
            NewOption.TrueFalse = TF;
            NewOption.RemoveOptions = NewLabel;
            UIOptionsList.Add(NewOption);
        }
        public void RemoveOptionsAtIndex(int index)
        {
            UIOptions OptToRemove = UIOptionsList[index];

            Controls.Remove(OptToRemove.TrueFalse);
            Controls.Remove(OptToRemove.OptionsText);
            Controls.Remove(OptToRemove.RemoveOptions);

            UIOptionsList.RemoveAt(index);

            AlignForm();
        }
        private void AddNewOptions()
        {

            TextBox NewTxtOptions = new TextBox();          
            NewTxtOptions.Name = "TxtOptions";
            NewTxtOptions.Size = new System.Drawing.Size(783, 31);
            NewTxtOptions.TabIndex = 1;

            // 
            // checkBox1
            // 
            CheckBox NewIsCorrectCheckbox = new CheckBox();
            NewIsCorrectCheckbox.AutoSize = true;
            NewIsCorrectCheckbox.Name = "checkBox";
            NewIsCorrectCheckbox.Size = new System.Drawing.Size(22, 21);
            NewIsCorrectCheckbox.TabIndex = 7;
            NewIsCorrectCheckbox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            Label LB = new Label();
            LB.AutoSize = true;
            LB.Name = "label4";
            LB.Size = new System.Drawing.Size(23, 25);
            LB.TabIndex = 13;
            LB.Text = "X";
            LB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            LB.ForeColor = System.Drawing.Color.Red;
            LB.Click += new System.EventHandler(RemoveOptionsClick);

            Controls.Add(NewTxtOptions);
            Controls.Add(NewIsCorrectCheckbox);
            Controls.Add(LB);

            AddOptionToList(NewIsCorrectCheckbox, NewTxtOptions, LB);
            AlignForm();
        }
        private void AlignForm()
        {
            // base: 58, 107
            // size = 35;
            int indx = UIOptionsList.Count - 1;

            for (int i = 0; i < UIOptionsList.Count; i++)
            {
                UIOptions UIO = UIOptionsList[i];

                UIO.OptionsText.Location = new System.Drawing.Point(58, 107 + 47 * i);
                UIO.TrueFalse.Location = new System.Drawing.Point(23, 113 + 47 * i);
                UIO.RemoveOptions.Location = new System.Drawing.Point(847, 109 + 47 * i);
            }

            // move the AddNewOption text, and Del button
            label1.Location = new System.Drawing.Point(58, 153 + 47 * indx);
            button1.Location = new System.Drawing.Point(740, 153 + 47 * indx);
            SetSize(this.Size.Width, 207 + 47*indx);
        }

        private void RemoveOptionsClick(object sender, EventArgs e)
        {
            int ClickedIndex = UIOptionsList.FindIndex(Options => Options.RemoveOptions == sender);
            if (ClickedIndex != -1)
            {
                RemoveOptionsAtIndex(ClickedIndex);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            AddNewOptions();
        }

        public bool IsValidQuestion()
        {
            if (TxtQuestion.Text.Length == 0)
                return false;
            if (TxtScore.Text.Length == 0)
                return false;

            decimal Score;
            if (!decimal.TryParse(TxtScore.Text, out Score))
            {
                LbScore.ForeColor = Color.Red;
                return false;
            }
            LbScore.ForeColor = Color.Black;
            // for each option
            bool ThereIsCheckedOptions = false;
            foreach (UIOptions Opt in UIOptionsList)
            {
                if (Opt.OptionsText.Text.Length == 0)
                    return false;

                if (Opt.TrueFalse.Checked)
                    ThereIsCheckedOptions = true;
            }
            if (!ThereIsCheckedOptions)
            {
                MessageBox.Show("Vui long chon it nhat 1 phuong an dung!");
                return false;
            }
            return true;
        }
        public Question BuildQuestion()
        {
            Question NewQues = new Question();


            NewQues.QuestionId = QuestionID;
            NewQues.Title = TxtQuestion.Text;

            decimal Score;
            decimal.TryParse(TxtScore.Text, out Score);
            NewQues.Mark = Score;

            NewQues.Hint = "";

            int CorrectCount = 0;
            foreach (UIOptions Opt in UIOptionsList)
            {
                Answer NewAnswerOption = new Answer();
                NewAnswerOption.Question = NewQues;
                NewAnswerOption.Text = Opt.OptionsText.Text;
                NewAnswerOption.IsCorrect = Opt.TrueFalse.Checked;

                if (NewAnswerOption.IsCorrect)
                    CorrectCount++;

                NewAnswerOption.AnswerId = Opt.AnswerID;
                NewQues.AnswerOptions.Add(NewAnswerOption);
            }

            if (CorrectCount > 1)
                NewQues.IsMoreThanOneCorrectAnswer = true;
            else
                NewQues.IsMoreThanOneCorrectAnswer = false;

            return NewQues;
        }
        public void LoadQuestionAndAnswers(Question question)
        {
            QuestionID = question.QuestionId;

            TxtQuestion.Text = question.Title;
            TxtScore.Text = question.Mark.ToString();

            int index = 0;
            foreach (Answer A in question.AnswerOptions)
            {
                LoadOptionsToUC(A.IsCorrect, A.Text, A.AnswerId, index);
                index++;
            }
        }
        public void LoadOptionsToUC(bool IsCorrect, String Content, int AnswerID, int index)
        {
            if (index != 0)
                AddNewOptions();

            // track
            UIOptions LastOpt = UIOptionsList.LastOrDefault();
            LastOpt.TrueFalse.Checked = IsCorrect;
            LastOpt.OptionsText.Text = Content;
            LastOpt.AnswerID = AnswerID;
        }
        private void AddNewQuestion_Load(object sender, EventArgs e)
        {

        }
        public void SetSize(int width, int height)
        {
            Size = new System.Drawing.Size(width, height);
        }
    }
}
