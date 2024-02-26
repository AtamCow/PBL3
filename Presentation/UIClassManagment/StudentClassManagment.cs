using OnlineExamSystem.BusinessServices.ClassManagment;
using OnlineExamSystem.BusinessServicesLayer;
using OnlineExamSystem.PresentationLayer.UIClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineExamSystem.PresentationLayer
{
    public partial class StudentClassManagment : UserControl
    {
        // lop hoc nguoi dung chon de quan ly
        private StudentListManagment StudentMgr;

        public void SetClassId(int ClassId)
        {
            StudentMgr = new StudentListManagment(ClassId);
        }
        public StudentClassManagment()
        {
            InitializeComponent();
            InitStudentListDGV();
        }
        private void InitStudentListDGV()
        {
            StudentListView.AutoGenerateColumns = false;
            StudentListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StudentListView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "STT", DataPropertyName = "Index", ReadOnly = true });
            StudentListView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Họ và tên", DataPropertyName = "Name", ReadOnly = true });
            StudentListView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Mã số SV", DataPropertyName = "NumericIdentification", ReadOnly = true });

            var DateTimeColumn = new DataGridViewTextBoxColumn() { HeaderText = "Ngày sinh", DataPropertyName = "Birthday", ReadOnly = true };
            DateTimeColumn.DefaultCellStyle.Format = "dd/MM/yyyy";
            StudentListView.Columns.Add(DateTimeColumn);

            StudentListView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Giới tính", DataPropertyName = "GenderText", ReadOnly = true });

            DataGridViewButtonColumn ManagmentStudentBtn = new DataGridViewButtonColumn();
            ManagmentStudentBtn.HeaderText = "Quản lý";
            ManagmentStudentBtn.Name = "ManageStudent";
            ManagmentStudentBtn.Text = "Chỉnh sửa";
            ManagmentStudentBtn.UseColumnTextForButtonValue = true;
            StudentListView.Columns.Add(ManagmentStudentBtn);

            DataGridViewButtonColumn DeleteClass = new DataGridViewButtonColumn();
            DeleteClass.HeaderText = "Xóa";
            DeleteClass.Name = "RemoveStudent";
            DeleteClass.Text = "Xóa khỏi lớp";
            DeleteClass.UseColumnTextForButtonValue = true;
            StudentListView.Columns.Add(DeleteClass);
        }
        public void SetStudentListSource()
        {
            StudentListView.DataSource = StudentMgr.GetStudentListInClass();
        }

        private void StudentClassManagment_Load(object sender, EventArgs e)
        {
            SetStudentListSource();
            lbClassName.Text = StudentMgr.GetClassName();
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm AddStudentForm = new AddStudentForm();
            AddStudentForm.Dock = DockStyle.Fill;
            AddStudentForm.CreateStudentSuccessful += OnAddStudentSuccessful;
            AddStudentForm.SetStudentMgr(StudentMgr);
            Globals.MainForm.AddNewPanelToQueue(AddStudentForm);
        }

        private void OnAddStudentSuccessful(object sender, EventArgs e)
        {
            SetStudentListSource();
            Globals.MainForm.GoBack();
        }
        private void OnEditStudentSuccessful(object sender, EventArgs e)
        {
            SetStudentListSource();
            Globals.MainForm.GoBack();
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            Globals.MainForm.GoBack();
        }

        private void StudentListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == StudentListView.Columns["ManageStudent"].Index && e.RowIndex >= 0)
            {
                // xac dinh du lieu can truyen vao form Quan ly lop
                // ID lop
                DataGridViewRow row = StudentListView.Rows[e.RowIndex];
                string StudentID = row.Cells[2].Value.ToString();

                EditStudentForm EditStudentForm = new EditStudentForm();
                EditStudentForm.Dock = DockStyle.Fill;
                EditStudentForm.EditStudentSuccessful += OnEditStudentSuccessful;
                EditStudentForm.SetStudentID(StudentID);
                Globals.MainForm.AddNewPanelToQueue(EditStudentForm);
                 
            }
            if (e.ColumnIndex == StudentListView.Columns["RemoveStudent"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = StudentListView.Rows[e.RowIndex];
                string StudentID = row.Cells[2].Value.ToString();

                string Message = String.Format("Xóa học sinh \"{0}\" (MSSV: {1}) khỏi lớp học?", row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString());

                DialogResult result = MessageBox.Show(Message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (!StudentMgr.RemoveStudentFromCurrentClass(StudentID))
                        MessageBox.Show("Có lỗi khi thực hiện xóa lớp " + StudentID);
                    else
                        SetStudentListSource();
                }
            }
        }

        private void TxtSearchStudentByName_Enter(object sender, EventArgs e)
        {
            if (TxtSearchStudentByName.Text.Length > 0)
            {
                string Needle = Helper.RemoveVietnameseAccents(TxtSearchStudentByName.Text);
                var FilteredList = StudentMgr.GetStudentListInClass()
                    .Where(p => Helper.RemoveVietnameseAccents(p.Name).Contains(Needle)).ToList();

                StudentListView.DataSource = FilteredList;
            }
            else
                StudentListView.DataSource = StudentMgr.GetStudentListInClass();
        }
    }
}
