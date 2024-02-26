namespace OnlineExamSystem.Presentation.UITest.UIStudentTest.OnExam.AfterExam
{
    partial class UCExamResultList
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
            this.ExamResultListView = new System.Windows.Forms.DataGridView();
            this.LbNameOfTest = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ExamResultListView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.ExamResultListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExamResultListView.Location = new System.Drawing.Point(38, 127);
            this.ExamResultListView.Name = "dataGridView1";
            this.ExamResultListView.RowHeadersWidth = 62;
            this.ExamResultListView.RowTemplate.Height = 33;
            this.ExamResultListView.Size = new System.Drawing.Size(1831, 905);
            this.ExamResultListView.TabIndex = 0;
            this.ExamResultListView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExamResultList_CellContentClick);
            // 
            // LbNameOfTest
            // 
            this.LbNameOfTest.AutoSize = true;
            this.LbNameOfTest.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbNameOfTest.Location = new System.Drawing.Point(960, 52);
            this.LbNameOfTest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbNameOfTest.Name = "LbNameOfTest";
            this.LbNameOfTest.Size = new System.Drawing.Size(225, 48);
            this.LbNameOfTest.TabIndex = 12;
            this.LbNameOfTest.Text = "Name of test";
            this.LbNameOfTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(960, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 38);
            this.label1.TabIndex = 11;
            this.label1.Text = "Bảng kết quả";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(38, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 36);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tổng số bài: 100";
            // 
            // UCExamResultList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LbNameOfTest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExamResultListView);
            this.Name = "UCExamResultList";
            this.Size = new System.Drawing.Size(1920, 1080);
            ((System.ComponentModel.ISupportInitialize)(this.ExamResultListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView ExamResultListView;
        private Label LbNameOfTest;
        private Label label1;
        private Label label2;
    }
}
