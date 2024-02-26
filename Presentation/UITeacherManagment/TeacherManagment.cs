using OnlineExamSystem.BusinessServicesLayer;
using OnlineExamSystem.DataServicesLayer.Method;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OnlineExamSystem.PresentationLayer
{
    public partial class TeacherManagment : UserControl
    {
        public TeacherManagment()
        {
            InitializeComponent();
            InitTeacherListDGV();
            LoadDataToDgv();
        }
        private void LoadDataToDgv()
        {
            dgvListTeacher.DataSource = TeacherListManagment.Instance.GetAllTeacherForDisplay();
        }
        private void InitTeacherListDGV()
        {
            dgvListTeacher.AutoGenerateColumns = false;
            dgvListTeacher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListTeacher.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "STT", DataPropertyName = "Index", ReadOnly = true });
            dgvListTeacher.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Họ và tên", DataPropertyName = "Name", ReadOnly = true });
            dgvListTeacher.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Mã số cán bộ", DataPropertyName = "EmployeeID", ReadOnly = true });
            var DateTimeColumn = new DataGridViewTextBoxColumn() { HeaderText = "Ngày sinh", DataPropertyName = "Birthday", ReadOnly = true };
            DateTimeColumn.DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvListTeacher.Columns.Add(DateTimeColumn);
            dgvListTeacher.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Giới tính", DataPropertyName = "GenderText", ReadOnly = true });
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {

            string SearchContext = tbSearchTeacher.Text;

            List<TeacherListForDisplay> TeacherList = TeacherListManagment.Instance.GetAllTeacherForDisplay();

            if (SearchContext.Length > 0)
            {
                string Needle = Helper.RemoveVietnameseAccents(SearchContext);

                var FilteredList = TeacherList.Where(
                    p => Helper.RemoveVietnameseAccents(p.Name).Contains(Needle) ||
                         p.EmployeeID.Contains(Needle)
                ).ToList();

                dgvListTeacher.DataSource = FilteredList;
            }
            else
                dgvListTeacher.DataSource = TeacherList;

            //.Instance.SearchByNum(search);
            //dgvListTeacher.DataSource = CRUD.Instance.Search(search);
        }

        private void tbSearchTeacher_Click(object sender, EventArgs e)
        {
            tbSearchTeacher.PlaceholderText = "Nhập nội dung tìm kiếm";
        }
        private void BtnNewTeacher_Click(object sender, EventArgs e)
        {
            UserDetail NewTeacherDetailForm = new UserDetail();
            NewTeacherDetailForm.Dock = DockStyle.Fill;
            NewTeacherDetailForm.OnFormUsageCompleted += OnUserLeaveForm;
            Globals.MainForm.AddNewPanelToQueue(NewTeacherDetailForm);
        }
        private void BtnModifyTeacherInfo_Click(object sender, EventArgs e)
        {
            // determine the account
            string SelectedEmployeeID = "";
            if (dgvListTeacher.SelectedRows.Count == 1)
            {
                //SelectedEmployeeID = dgvListTeacher.SelectedRows[0].Cells["EmployeeID"].Value.ToString();
                SelectedEmployeeID = dgvListTeacher.SelectedRows[0].Cells[2].Value.ToString();
            
                UserDetail NewTeacherDetailForm = new UserDetail();
                NewTeacherDetailForm.Dock = DockStyle.Fill;
                NewTeacherDetailForm.OnFormUsageCompleted += OnUserLeaveForm;
                NewTeacherDetailForm.SetModifyAccount(SelectedEmployeeID);
                Globals.MainForm.AddNewPanelToQueue(NewTeacherDetailForm);
            }
        }

        private void BtnDeleteTeacher_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            if (dgvListTeacher.SelectedRows.Count > 0)
            {
                MessageBox.Show("Xác nhận xóa các giáo viên này khỏi hệ thống?");
                foreach (DataGridViewRow i in dgvListTeacher.SelectedRows)
                {
                    //list.Add(i.Cells["EmployeeID"].Value.ToString());
                    list.Add(i.Cells[2].Value.ToString());
                }
                TeacherListManagment.Instance.RequestDisableListAccount(list);
                LoadDataToDgv(); // update
            }
        }
        private void OnUserLeaveForm(object sender, EventArgs e)
        {
            LoadDataToDgv();
            Globals.MainForm.GoBack();
        }
    }
}
