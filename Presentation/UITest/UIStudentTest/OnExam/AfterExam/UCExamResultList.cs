using OnlineExamSystem.BusinessServices.ClassManagment;
using OnlineExamSystem.BusinessServicesLayer;
using OnlineExamSystem.DataServicesLayer.Model.Tests;
using OnlineExamSystem.Presentation.UITest.UIStudentTest.Exam;
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
using static System.Net.Mime.MediaTypeNames;

namespace OnlineExamSystem.Presentation.UITest.UIStudentTest.OnExam.AfterExam
{
    public partial class UCExamResultList : UserControl
    {
        private ExamForm MainControl;
        private Test ExamEntity;


        public class TestTakerResultForDisplay
        {
            public int TestTakerResultId { get; set; }
            public int STT { get; set; }
            public string MSSV { get; set; }
            public string StudentName { get; set; }
            public DateTime BeginExamTime { get; set; }
            public DateTime EndExamTime { get; set; }

            public decimal FinalScore { get; set; }
            public int CorrectAnswerCount { get; set; }
        }
        private List<TestTakerResultForDisplay> ResultDtos;

        public UCExamResultList(ExamForm Forms)
        {
            MainControl = Forms;
            InitializeComponent();
            InitTestListDGV();

            label1.Left = (this.Width - label1.Width) / 2;
        }

        private void InitTestListDGV()
        {
            ExamResultListView.AutoGenerateColumns = false;
            ExamResultListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //ListViewUpcomingTest.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "STT", DataPropertyName = "TestId", ReadOnly = true });
            ExamResultListView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "STT", DataPropertyName = "STT", ReadOnly = true });
            ExamResultListView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "MSSV", DataPropertyName = "MSSV", ReadOnly = true });

            ExamResultListView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Họ và tên", Name = "TenHocSinh", DataPropertyName = "StudentName", ReadOnly = true });

            ExamResultListView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Thời gian bắt đầu", DataPropertyName = "BeginExamTime", ReadOnly = true });
            ExamResultListView.Columns[ExamResultListView.Columns.Count - 1].DefaultCellStyle.Format = "HH:mm dd-MM-yyyy";

            ExamResultListView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Thời gian nộp bài", DataPropertyName = "EndExamTime", ReadOnly = true });
            ExamResultListView.Columns[ExamResultListView.Columns.Count - 1].DefaultCellStyle.Format = "HH:mm dd-MM-yyyy";

            ExamResultListView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Số câu đúng", Name = "SoCauDung", DataPropertyName = "CorrectAnswerCount", ReadOnly = true });
            ExamResultListView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Điểm", Name = "Score", DataPropertyName = "FinalScore", ReadOnly = true });

            DataGridViewButtonColumn JoinTestBtn = new DataGridViewButtonColumn();
            JoinTestBtn.HeaderText = "Hành động";
            JoinTestBtn.Name = "Action";
            JoinTestBtn.Text = "Chi tiết";
            JoinTestBtn.UseColumnTextForButtonValue = true;
            ExamResultListView.Columns.Add(JoinTestBtn);
        }

        public void SetExamEntity(Test Entity)
        {
            ExamEntity = Entity;
            LbNameOfTest.Text = Entity.Name;
            LbNameOfTest.Left = (this.Width - LbNameOfTest.Width) / 2;
        }
        public bool IsSubmissionAvailable()
        {
            bool hasTestTakerResults = ExamEntity?.TestTakers?.Any(tt => tt.TestTakerResults.Any()) ?? false;
            return hasTestTakerResults;
        }
        public void Load()
        {
            int index = 1;
            ResultDtos = ExamEntity.TestTakers
                            .SelectMany(tt => tt.TestTakerResults)
                            .Select(r => new TestTakerResultForDisplay
                            {
                                STT = index++,
                                TestTakerResultId = r.TestTakerResultId,
                                MSSV = r.TestTaker.Student.NumericIdentification,
                                StudentName = r.TestTaker.Student.FirstName + " " + r.TestTaker.Student.LastName,
                                BeginExamTime = r.BeginExamTime,
                                EndExamTime = r.EndExamTime,                               
                                CorrectAnswerCount = r.CorrectAnswerCount,
                                FinalScore = r.FinalScore
                            })
                            .ToList();
            label2.Text = "Tổng số bài: " + ResultDtos.Count;
            // Bind the resultDtos list to the DataGridView
            ExamResultListView.DataSource = ResultDtos;
        }

        private void ExamResultList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ExamResultListView.Columns["Action"].Index && e.RowIndex >= 0)
            {
                // xac dinh du lieu can truyen vao form Quan ly lop
                // ID lop
                DataGridViewRow row = ExamResultListView.Rows[e.RowIndex];
                string STT = row.Cells[0].Value.ToString();
                int STT_INT = Convert.ToInt32(STT);
                TestTakerResultForDisplay ElementSelected = ResultDtos.Find(R => R.STT == STT_INT);
               
                TestTakerResult SelectedTakerResult = ExamEntity?.TestTakers?
                    .SelectMany(tt => tt.TestTakerResults)
                    .Where(TT => TT.TestTakerResultId == ElementSelected.TestTakerResultId)
                    .FirstOrDefault();

                UCWorkDetails ExamResultUI = new UCWorkDetails(MainControl, SelectedTakerResult);
                ExamResultUI.ShowNagivationBackButton();
                MainControl.AddNewPanelToQueue(ExamResultUI);

                // Button clicked in row e.RowIndex
            }           
        }
    }
}
