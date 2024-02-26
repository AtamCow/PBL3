using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OnlineExamSystem.BusinessServices.ClassManagment;
using OnlineExamSystem.BusinessServices.TestManagment;
using OnlineExamSystem.BusinessServicesLayer;
using OnlineExamSystem.DataServicesLayer.Model.Tests;
using OnlineExamSystem.Presentation.UITest.UIStudentTest;
using OnlineExamSystem.Presentation.UITest.UITestManagment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static OnlineExamSystem.Presentation.UITest.UIStudentTest.OnExam.AfterExam.UCExamResultList;
using static OnlineExamSystem.PresentationLayer.UITestManagmentList;

namespace OnlineExamSystem.PresentationLayer
{
    public partial class UITestManagmentList : UserControl
    {
        public class TestListDTO
        {
            public int ID { get; set; }
            public int STT { get; set; }
            public string TestName { get; set; }
            public int SubmissionCount { get; set; }
            public DateTime LastModifyTime { get; set; }         
        }
        private List<TestListDTO> TestListDtos;


        public UITestManagmentList()
        {
            InitializeComponent();
            InitTestListDGV();
            BindDataToGridView();
        }
        private void BindDataToGridView()
        {
            int index = 1;

            TestListDtos = TestManagment.Instance.GetAllTestCreatedByCurrentTeacher()
                            .Select(r => new TestListDTO
                            {
                                STT = index++,
                                ID = r.TestId,
                                TestName = r.Name,
                                SubmissionCount = r.SubmissionCount,
                                LastModifyTime = r.LastModifyTime,                               
                            })
                            .ToList();
            dataGridView1.DataSource = TestListDtos;
        }
        private void UpdateDataGV()
        {
            BindDataToGridView();
        }
        private void InitTestListDGV()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "STT", DataPropertyName = "STT", ReadOnly = true });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Tên", DataPropertyName = "TestName", ReadOnly = true });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Số bài đã nộp", DataPropertyName = "SubmissionCount", ReadOnly = true });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Sửa lần cuối", DataPropertyName = "LastModifyTime", ReadOnly = true });

            dataGridView1.Columns[dataGridView1.Columns.Count - 1].DefaultCellStyle.Format = "dd-MM-yyyy HH:mm:ss";

            DataGridViewButtonColumn ViewResultBtn = new DataGridViewButtonColumn();
            ViewResultBtn.HeaderText = "Kết quả";
            ViewResultBtn.Name = "TestSubmissionResult";
            ViewResultBtn.Text = "Kết quả";
            ViewResultBtn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(ViewResultBtn);

            DataGridViewButtonColumn EditTestBtn = new DataGridViewButtonColumn();
            EditTestBtn.HeaderText = "Quản lý";
            EditTestBtn.Name = "ModifyTest";
            EditTestBtn.Text = "Chỉnh sửa";
            EditTestBtn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(EditTestBtn);

            DataGridViewButtonColumn DeleteTestBtn = new DataGridViewButtonColumn();
            DeleteTestBtn.HeaderText = "";
            DeleteTestBtn.Name = "RemoveTest";
            DeleteTestBtn.Text = "Xóa";
            DeleteTestBtn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(DeleteTestBtn);
        }
        private void BtnAddNewTest_Click(object sender, EventArgs e)
        {
            AddNewTest NewTestForm = new AddNewTest();
            NewTestForm.OnFormLeave += OnNewTestFormLeaved;
            Globals.MainForm.AddNewPanelToQueue(NewTestForm);
        }
        private void OnNewTestFormLeaved(object sender, EventArgs e)
        {
            UpdateDataGV();
            Globals.MainForm.GoBack();
        }

        private void TestListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["TestSubmissionResult"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string STT = row.Cells[0].Value.ToString();
                int STT_INT = Convert.ToInt32(STT);
                TestListDTO ElementSelected = TestListDtos.Find(R => R.STT == STT_INT);

                Test TestObject = TestManagment.Instance.GetTestByTestID(ElementSelected.ID);

                ExamForm ViewExamResult = new ExamForm(TestObject);
                if (!ViewExamResult.SetShowResultMulti())
                    MessageBox.Show("Không có bài làm nào đối với bài kiểm tra này.");
                else
                    ViewExamResult.Show();
            }
            if (e.ColumnIndex == dataGridView1.Columns["ModifyTest"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string STT = row.Cells[0].Value.ToString();
                int STT_INT = Convert.ToInt32(STT);
                TestListDTO ElementSelected = TestListDtos.Find(R => R.STT == STT_INT);

                Test TestObject = TestManagment.Instance.GetTestByTestID(ElementSelected.ID);

                AddNewTest ModifyForm = new AddNewTest();
                ModifyForm.OnFormLeave += OnNewTestFormLeaved;
                ModifyForm.SetModifyingTest(TestObject);
                Globals.MainForm.AddNewPanelToQueue(ModifyForm);              
            }
            if (e.ColumnIndex == dataGridView1.Columns["RemoveTest"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string STT = row.Cells[0].Value.ToString();
                int STT_INT = Convert.ToInt32(STT);
                TestListDTO ElementSelected = TestListDtos.Find(R => R.STT == STT_INT);


                Test TestObject = TestManagment.Instance.GetTestByTestID(ElementSelected.ID);

                string Message = String.Format("Xóa bài kiểm tra \"{0}\" khỏi hệ thống?", row.Cells[1].Value.ToString());

                DialogResult result = MessageBox.Show(Message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (TestManagment.Instance.DeleteTest(ElementSelected.ID) == true)
                    {
                        BindDataToGridView();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thực hiện xóa bài kiểm tra ID " + ElementSelected.ID);
                        BindDataToGridView();
                    }
                }
            }
        }
    }
}
