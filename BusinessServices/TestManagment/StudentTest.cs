using OnlineExamSystem.DataServices.Method.Tests;
using OnlineExamSystem.DataServicesLayer;
using OnlineExamSystem.DataServicesLayer.Model.Tests;
using OnlineExamSystem.Presentation.UITest.UIStudentTest.Exam;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.BusinessServices.TestManagment
{
    public class StudentTest
    {
        private static StudentTest _Instance = null;
        public static StudentTest Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new StudentTest();
                return _Instance;
            }
            private set
            {

            }
        }
        private List<Test> Tests = null;

        public List<Test> GetAllTestAssigned()
        {
            Tests = TestData.Instance.GetAllUpcomingTestFromTakerList();
            return Tests;
        }
        // section: test join + work
        private Test Exam;
        private TestTaker Taker;
        private TestTakerResult CurrentResultEntity;

        public void SetDoTest(Test test)
        {
            Exam = test;
        }
        public TestTakerResult GetCurrentResultEntity()
        {
            return CurrentResultEntity;
        }
        public bool RequestDoTest(string Password, ref string ErrorMessage)
        {
            if (Exam.JoinPassword.Length > 0)
            {
                string EnteredPassword = Password;
                if (EnteredPassword.Length <= 0)
                {
                    ErrorMessage = "Vui lòng nhập mật khẩu.";
                    return false;
                }
                if (EnteredPassword != Exam.JoinPassword)
                {
                    ErrorMessage = "Mật khẩu làm bài không chính xác. Vui lòng thử lại.";
                    return false;
                }
            }
            // @FIXME
            // neu hs chua submit bai, ma out ra => bi chan lam bai => ko co ket qua
            
            if (!CreateTakerResultEntity())
            {
                ErrorMessage = "Bạn chỉ có thể làm bài thi một lần.";
                return false;
            }
            return true;
        }
        public bool CreateTakerResultEntity()
        {
            Taker = TestData.Instance.GetUserTestTakerEntityFromTest(Exam);

            if (Taker.TestTakerResults.Count > 0 && Exam.AllowOnlyOneTry)
                return false;

            TestTakerResult TakerResult = new TestTakerResult();
            TakerResult.TestTaker = Taker;
            TakerResult.BeginExamTime = DateTime.Now;
            Taker.TestTakerResults.Add(TakerResult);
            CurrentResultEntity = TakerResult;

            return OEDB.Instance.Commit();
        }
        public bool InsertQuestionSelectionToResult(UCQuestionBox.QuestionResponse Res)
        {
            if (Taker == null || CurrentResultEntity == null)
                return false;

            if (Res.SelectedAnswerID.Count > 0)
            {
                Question QSelectI = GetQuestionById(Res.QuestionID);

                StudentAnswerResponse NewResponse = new StudentAnswerResponse();
                NewResponse.TestTaker = CurrentResultEntity;
                NewResponse.Question = QSelectI;


                foreach (int SelectedAnswerID in Res.SelectedAnswerID) 
                {
                    SelectedAnswer SAEntity = new SelectedAnswer();
                    SAEntity.StudentAnswerResponse = NewResponse;
                    SAEntity.AnswerId = SelectedAnswerID;
                    NewResponse.SelectedAnswers.Add(SAEntity);
                }
                CurrentResultEntity.AnswerResponses.Add(NewResponse);
            }
            return true;
        }
        public bool GradeTestAndStoreResult(int TimeTaken)
        {
            decimal totalScore = 0;
            int correctAnswerCount = 0;

            foreach (var answerResponse in CurrentResultEntity.AnswerResponses)
            {
                var question = answerResponse.Question;
                var selectedAnswers = answerResponse.SelectedAnswers.Select(sa => sa.AnswerId).ToList();

                if (question.IsMoreThanOneCorrectAnswer)
                {
                    var allCorrectAnswers = question.AnswerOptions.Where(ao => ao.IsCorrect).ToList();
                    int allIncorrectAnswersCount = question.AnswerOptions.Count - allCorrectAnswers.Count;

                    var selectedCorrectAnswers = selectedAnswers.Intersect(allCorrectAnswers.Select(a => a.AnswerId)).ToList();
                    var selectedIncorrectAnswers = selectedAnswers.Except(allCorrectAnswers.Select(a => a.AnswerId)).ToList();

                    // tinh diem
                    // phuong an dung = diem / so cau dung
                    // phuong an san = diem / so cau sai

                    decimal partialScore = 0;
                    decimal pointsPerCorrectAnswer = question.Mark / allCorrectAnswers.Count;
                    decimal pointsDeductedPerIncorrectAnswer = 0;

                    if (allIncorrectAnswersCount > 0)
                        pointsDeductedPerIncorrectAnswer = question.Mark / allIncorrectAnswersCount;
                    
                    partialScore += pointsPerCorrectAnswer * selectedCorrectAnswers.Count;
                    partialScore -= pointsDeductedPerIncorrectAnswer * selectedIncorrectAnswers.Count;
                    partialScore = Math.Max(0, partialScore); // bi am diem thi 0 tru

                    if (selectedCorrectAnswers.Count == allCorrectAnswers.Count && selectedIncorrectAnswers.Count == 0)
                    {
                        correctAnswerCount++;
                    }
                    totalScore += partialScore;
                }
                else // 1 phuong an dung
                {
                    if (selectedAnswers.Count == 1)
                    {
                        var selectedAnswer = question.AnswerOptions.FirstOrDefault(ao => ao.AnswerId == selectedAnswers[0]);
                        if (selectedAnswer != null && selectedAnswer.IsCorrect)
                        {
                            totalScore += question.Mark;
                            correctAnswerCount++;
                        }
                    }
                }
            }

            CurrentResultEntity.FinalScore = totalScore;
            CurrentResultEntity.CorrectAnswerCount = correctAnswerCount;
            CurrentResultEntity.TimeTakenSeconds = TimeTaken;
            CurrentResultEntity.EndExamTime = DateTime.Now;


            return OEDB.Instance.Commit();
        }
        public Question GetQuestionById(int QuestionId)
        {
            return Exam.Questions.FirstOrDefault(T => T.QuestionId == QuestionId);
        }
    }
}
