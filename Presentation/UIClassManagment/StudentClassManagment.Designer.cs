namespace OnlineExamSystem.PresentationLayer
{
    partial class StudentClassManagment
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
            this.TxtSearchStudentByName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NewStudentButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbClassName = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.StudentListView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.StudentListView)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtSearchStudentByName
            // 
            this.TxtSearchStudentByName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtSearchStudentByName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TxtSearchStudentByName.Location = new System.Drawing.Point(243, 138);
            this.TxtSearchStudentByName.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.TxtSearchStudentByName.Name = "TxtSearchStudentByName";
            this.TxtSearchStudentByName.Size = new System.Drawing.Size(327, 39);
            this.TxtSearchStudentByName.TabIndex = 6;
            this.TxtSearchStudentByName.TextChanged += new System.EventHandler(this.TxtSearchStudentByName_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tìm kiếm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(89, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên học sinh:";
            // 
            // NewStudentButton
            // 
            this.NewStudentButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.NewStudentButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewStudentButton.ForeColor = System.Drawing.Color.White;
            this.NewStudentButton.Location = new System.Drawing.Point(1032, 165);
            this.NewStudentButton.Name = "NewStudentButton";
            this.NewStudentButton.Size = new System.Drawing.Size(213, 84);
            this.NewStudentButton.TabIndex = 4;
            this.NewStudentButton.Text = "Thêm học sinh";
            this.NewStudentButton.UseVisualStyleBackColor = false;
            this.NewStudentButton.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Danh sách học sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(918, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 45);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lớp học:";
            // 
            // lbClassName
            // 
            this.lbClassName.AutoSize = true;
            this.lbClassName.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbClassName.Location = new System.Drawing.Point(1099, 86);
            this.lbClassName.Name = "lbClassName";
            this.lbClassName.Size = new System.Drawing.Size(117, 45);
            this.lbClassName.TabIndex = 20;
            this.lbClassName.Text = "Class";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SlateGray;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(40, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 50);
            this.button2.TabIndex = 10;
            this.button2.Text = "< Quay lại";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // StudentListView
            // 
            this.StudentListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentListView.Location = new System.Drawing.Point(54, 288);
            this.StudentListView.Name = "StudentListView";
            this.StudentListView.RowHeadersWidth = 62;
            this.StudentListView.RowTemplate.Height = 33;
            this.StudentListView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentListView.Size = new System.Drawing.Size(1236, 901);
            this.StudentListView.TabIndex = 11;
            this.StudentListView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentListView_CellContentClick);
            // 
            // StudentClassManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StudentListView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbClassName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSearchStudentByName);
            this.Controls.Add(this.NewStudentButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "StudentClassManagment";
            this.Size = new System.Drawing.Size(1351, 1222);
            this.Load += new System.EventHandler(this.StudentClassManagment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label label3;
        private Button NewStudentButton;
        private TextBox TxtSearchStudentByName;
        private Label label1;
        private Label label4;
        private Label lbClassName;
        private Button button2;
        private DataGridView StudentListView;
    }
}
