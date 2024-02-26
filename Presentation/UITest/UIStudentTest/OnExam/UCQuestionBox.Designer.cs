namespace OnlineExamSystem.Presentation.UITest.UIStudentTest.Exam
{
    partial class UCQuestionBox
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
            this.LbQuestionIndex = new System.Windows.Forms.Label();
            this.LbQuestionText = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // LbQuestionIndex
            // 
            this.LbQuestionIndex.AutoSize = true;
            this.LbQuestionIndex.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.LbQuestionIndex.Location = new System.Drawing.Point(49, 10);
            this.LbQuestionIndex.Name = "LbQuestionIndex";
            this.LbQuestionIndex.Size = new System.Drawing.Size(90, 38);
            this.LbQuestionIndex.TabIndex = 0;
            this.LbQuestionIndex.Text = "Câu 1";
            // 
            // LbQuestionText
            // 
            this.LbQuestionText.AutoSize = true;
            this.LbQuestionText.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbQuestionText.Location = new System.Drawing.Point(49, 52);
            this.LbQuestionText.MaximumSize = new System.Drawing.Size(1786, 0);
            this.LbQuestionText.Name = "LbQuestionText";
            this.LbQuestionText.Size = new System.Drawing.Size(171, 36);
            this.LbQuestionText.TabIndex = 1;
            this.LbQuestionText.Text = "Question text";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(49, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1786, 228);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn 1 phương án";
            // 
            // UCQuestionBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LbQuestionText);
            this.Controls.Add(this.LbQuestionIndex);
            this.Name = "UCQuestionBox";
            this.Size = new System.Drawing.Size(1880, 357);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LbQuestionIndex;
        private Label LbQuestionText;
        private GroupBox groupBox1;
    }
}
