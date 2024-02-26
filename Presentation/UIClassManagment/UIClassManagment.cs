using OnlineExamSystem.BusinessServices.ClassManagment;
using OnlineExamSystem.BusinessServices.TestManagment;
using OnlineExamSystem.BusinessServicesLayer;
using OnlineExamSystem.DataServicesLayer.Model.School;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OnlineExamSystem.PresentationLayer.UIClassManagment;
using static OnlineExamSystem.PresentationLayer.UITestManagmentList;

namespace OnlineExamSystem.PresentationLayer
{
    public partial class UIClassManagment : UserControl
    {
        public class ClassListDTO
        {
            public int ID { get; set; }
            public int STT { get; set; }
            public string ClassName { get; set; }
            public string SubjectName { get; set; }
            public int StudentCount { get; set; }
        }
        private List<ClassListDTO> ClassListDtos;

        private ClassManagment ClassMgr;

        public UIClassManagment()
        {
            ClassMgr = ClassManagment.Instance;
            InitializeComponent();
        }


        private void ClassManagment_Load(object sender, EventArgs e)
        {
            InitClassListDGV();
            SetClassListSource();
        }
        private void InitClassListDGV()
        {
            ClassListview.AutoGenerateColumns = false;
            ClassListview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ClassListview.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "STT", DataPropertyName = "STT", ReadOnly = true });
            ClassListview.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Lớp", DataPropertyName = "ClassName", ReadOnly = true });
            ClassListview.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Môn học", DataPropertyName = "SubjectName", ReadOnly = true });
            ClassListview.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Sĩ số", DataPropertyName = "StudentCount", ReadOnly = true });

            DataGridViewButtonColumn ManagmentStudentBtn = new DataGridViewButtonColumn();
            ManagmentStudentBtn.HeaderText = "Quản lý";
            ManagmentStudentBtn.Name = "ManageStudents";
            ManagmentStudentBtn.Text = "Học sinh";
            ManagmentStudentBtn.UseColumnTextForButtonValue = true;
            ClassListview.Columns.Add(ManagmentStudentBtn);

            DataGridViewButtonColumn DeleteClass = new DataGridViewButtonColumn();
            DeleteClass.HeaderText = "Xóa";
            DeleteClass.Name = "DeleteClass";
            DeleteClass.Text = "Xóa";
            DeleteClass.UseColumnTextForButtonValue = true;
            ClassListview.Columns.Add(DeleteClass);        
        }
        private void SetClassListSource()
        {
            int index = 1;

            ClassListDtos = ClassMgr.GetAllClassByCurrentTeacher()
                            .Select(r => new ClassListDTO
                            {
                                STT = index++,
                                ID = r.ClassId,
                                ClassName = r.Name,
                                SubjectName = r.CourseName,
                                StudentCount = r.StudentsCount,
                            })
                            .ToList();

            ClassListview.DataSource = ClassListDtos;
        }
        private void NewClassBtn_Click(object sender, EventArgs e)
        {
            PopupAddNewClass AddClassForm = new PopupAddNewClass();
            AddClassForm.Dock = DockStyle.Fill;
            AddClassForm.CreateClassSuccessful += OnAddClassSuccessful;
            Globals.MainForm.AddNewPanelToQueue(AddClassForm);
        }

        private void OnAddClassSuccessful(object sender, EventArgs e)
        {
            SetClassListSource();
            Globals.MainForm.GoBack();
        }
        private void ClassListview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ClassListview.Columns["ManageStudents"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = ClassListview.Rows[e.RowIndex];
                string STT = row.Cells[0].Value.ToString();
                int STT_INT = Convert.ToInt32(STT);
                ClassListDTO ElementSelected = ClassListDtos.Find(R => R.STT == STT_INT);


                StudentClassManagment MenuStudentMgr = new StudentClassManagment();
                MenuStudentMgr.Dock = DockStyle.Fill;
                MenuStudentMgr.SetClassId(ElementSelected.ID);
                Globals.MainForm.AddNewPanelToQueue(MenuStudentMgr);
                // Button clicked in row e.RowIndex
            }
            if (e.ColumnIndex == ClassListview.Columns["DeleteClass"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = ClassListview.Rows[e.RowIndex];
                string STT = row.Cells[0].Value.ToString();
                int STT_INT = Convert.ToInt32(STT);
                ClassListDTO ElementSelected = ClassListDtos.Find(R => R.STT == STT_INT);


                string Message = String.Format("Xóa lớp {0} ({1}) khỏi hệ thống?", row.Cells[2].Value.ToString(), row.Cells[1].Value.ToString());

                DialogResult result = MessageBox.Show(Message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (ClassManagment.Instance.RemoveClassByIndex(ElementSelected.ID) == true)
                    {
                        SetClassListSource();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thực hiện xóa lớp #" + ElementSelected.ID);
                        SetClassListSource();
                    }
                }              
            }
        }
    }
}
