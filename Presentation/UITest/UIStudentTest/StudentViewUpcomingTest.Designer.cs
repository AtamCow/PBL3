namespace OnlineExamSystem.PresentationLayer
{
    partial class StudentViewUpcomingTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.ListViewUpcomingTest = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ListViewUpcomingTest)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(45, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách bài kiểm tra";
            // 
            // ListViewUpcomingTest
            // 
            this.ListViewUpcomingTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListViewUpcomingTest.Location = new System.Drawing.Point(45, 137);
            this.ListViewUpcomingTest.Name = "ListViewUpcomingTest";
            this.ListViewUpcomingTest.RowHeadersWidth = 62;
            this.ListViewUpcomingTest.RowTemplate.Height = 33;
            this.ListViewUpcomingTest.Size = new System.Drawing.Size(1270, 1016);
            this.ListViewUpcomingTest.TabIndex = 1;
            this.ListViewUpcomingTest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentTest_CellClick);
            this.ListViewUpcomingTest.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ListViewUpcomingTest_CellFormatting);
            // 
            // StudentViewUpcomingTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ListViewUpcomingTest);
            this.Controls.Add(this.label1);
            this.Name = "StudentViewUpcomingTest";
            this.Size = new System.Drawing.Size(1352, 1221);
            ((System.ComponentModel.ISupportInitialize)(this.ListViewUpcomingTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView ListViewUpcomingTest;
    }
}
