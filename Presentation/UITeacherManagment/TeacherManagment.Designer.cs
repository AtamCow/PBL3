namespace OnlineExamSystem.PresentationLayer
{
    partial class TeacherManagment
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherManagment));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvListTeacher = new System.Windows.Forms.DataGridView();
            this.tbSearchTeacher = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnDeleteTeacher = new System.Windows.Forms.Button();
            this.BtnModifyTeacherInfo = new System.Windows.Forms.Button();
            this.BtnNewTeacher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTeacher)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(542, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quản lý giáo viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(22, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "Danh sách giáo viên";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 805);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 73);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thêm giáo viên mới";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvListTeacher
            // 
            this.dgvListTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListTeacher.Location = new System.Drawing.Point(2, 266);
            this.dgvListTeacher.Name = "dgvListTeacher";
            this.dgvListTeacher.RowHeadersWidth = 62;
            this.dgvListTeacher.RowTemplate.Height = 33;
            this.dgvListTeacher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListTeacher.Size = new System.Drawing.Size(1350, 695);
            this.dgvListTeacher.TabIndex = 5;
            // 
            // tbSearchTeacher
            // 
            this.tbSearchTeacher.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSearchTeacher.ForeColor = System.Drawing.Color.Gray;
            this.tbSearchTeacher.Location = new System.Drawing.Point(838, 194);
            this.tbSearchTeacher.Margin = new System.Windows.Forms.Padding(2);
            this.tbSearchTeacher.Name = "tbSearchTeacher";
            this.tbSearchTeacher.Size = new System.Drawing.Size(370, 44);
            this.tbSearchTeacher.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.BtnSearch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbSearchTeacher);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 266);
            this.panel1.TabIndex = 9;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(1219, 194);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(121, 45);
            this.BtnSearch.TabIndex = 8;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.BtnDeleteTeacher);
            this.panel2.Controls.Add(this.BtnModifyTeacherInfo);
            this.panel2.Controls.Add(this.BtnNewTeacher);
            this.panel2.Location = new System.Drawing.Point(2, 954);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1350, 267);
            this.panel2.TabIndex = 10;
            // 
            // BtnDeleteTeacher
            // 
            this.BtnDeleteTeacher.Image = ((System.Drawing.Image)(resources.GetObject("BtnDeleteTeacher.Image")));
            this.BtnDeleteTeacher.Location = new System.Drawing.Point(975, -88);
            this.BtnDeleteTeacher.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDeleteTeacher.Name = "BtnDeleteTeacher";
            this.BtnDeleteTeacher.Size = new System.Drawing.Size(375, 416);
            this.BtnDeleteTeacher.TabIndex = 14;
            this.BtnDeleteTeacher.UseVisualStyleBackColor = true;
            this.BtnDeleteTeacher.Click += new System.EventHandler(this.BtnDeleteTeacher_Click);
            // 
            // BtnModifyTeacherInfo
            // 
            this.BtnModifyTeacherInfo.Image = ((System.Drawing.Image)(resources.GetObject("BtnModifyTeacherInfo.Image")));
            this.BtnModifyTeacherInfo.Location = new System.Drawing.Point(582, -44);
            this.BtnModifyTeacherInfo.Margin = new System.Windows.Forms.Padding(2);
            this.BtnModifyTeacherInfo.Name = "BtnModifyTeacherInfo";
            this.BtnModifyTeacherInfo.Size = new System.Drawing.Size(301, 328);
            this.BtnModifyTeacherInfo.TabIndex = 13;
            this.BtnModifyTeacherInfo.UseVisualStyleBackColor = true;
            this.BtnModifyTeacherInfo.Click += new System.EventHandler(this.BtnModifyTeacherInfo_Click);
            // 
            // BtnNewTeacher
            // 
            this.BtnNewTeacher.Image = ((System.Drawing.Image)(resources.GetObject("BtnNewTeacher.Image")));
            this.BtnNewTeacher.Location = new System.Drawing.Point(184, -44);
            this.BtnNewTeacher.Margin = new System.Windows.Forms.Padding(2);
            this.BtnNewTeacher.Name = "BtnNewTeacher";
            this.BtnNewTeacher.Size = new System.Drawing.Size(240, 292);
            this.BtnNewTeacher.TabIndex = 11;
            this.BtnNewTeacher.UseVisualStyleBackColor = true;
            this.BtnNewTeacher.Click += new System.EventHandler(this.BtnNewTeacher_Click);
            // 
            // TeacherManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvListTeacher);
            this.Controls.Add(this.button1);
            this.Name = "TeacherManagment";
            this.Size = new System.Drawing.Size(1352, 1221);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTeacher)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Label label3;
        private Label label4;
        private Button button1;
        private DataGridView dgvListTeacher;
        private TextBox tbSearchTeacher;
        private Panel panel1;
        private Panel panel2;
        private Button BtnNewTeacher;
        private Button BtnDeleteTeacher;
        private Button BtnModifyTeacherInfo;
        private Button BtnSearch;
    }
}
