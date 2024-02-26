using OnlineExamSystem.Presentation.Components;

namespace OnlineExamSystem.Presentation.UITest.UIStudentTest.Exam
{
    partial class UCDoingExam
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
            this.LbNameOfTest = new System.Windows.Forms.Label();
            this.LbTimeLeft = new System.Windows.Forms.Label();
            this.pictureBox1 = new OnlineExamSystem.Presentation.Components.CircularNamePictureBox();
            this.BtnSubmitTest = new System.Windows.Forms.Button();
            this.FlowPanelQuestionBox = new System.Windows.Forms.FlowLayoutPanel();
            this.LbStudentName = new System.Windows.Forms.Label();
            this.LbStudentID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(960, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bài kiểm tra";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbNameOfTest
            // 
            this.LbNameOfTest.AutoSize = true;
            this.LbNameOfTest.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbNameOfTest.Location = new System.Drawing.Point(960, 64);
            this.LbNameOfTest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbNameOfTest.Name = "LbNameOfTest";
            this.LbNameOfTest.Size = new System.Drawing.Size(225, 48);
            this.LbNameOfTest.TabIndex = 1;
            this.LbNameOfTest.Text = "Name of test";
            this.LbNameOfTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbTimeLeft
            // 
            this.LbTimeLeft.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbTimeLeft.Location = new System.Drawing.Point(1750, 31);
            this.LbTimeLeft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbTimeLeft.Name = "LbTimeLeft";
            this.LbTimeLeft.Size = new System.Drawing.Size(107, 38);
            this.LbTimeLeft.TabIndex = 2;
            this.LbTimeLeft.Text = "00:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundColor = System.Drawing.Color.Red;
            this.pictureBox1.FontColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(26, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.NameInitials = null;
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // BtnSubmitTest
            // 
            this.BtnSubmitTest.Location = new System.Drawing.Point(1742, 77);
            this.BtnSubmitTest.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSubmitTest.Name = "BtnSubmitTest";
            this.BtnSubmitTest.Size = new System.Drawing.Size(115, 36);
            this.BtnSubmitTest.TabIndex = 4;
            this.BtnSubmitTest.Text = "Nộp bài";
            this.BtnSubmitTest.UseVisualStyleBackColor = true;
            this.BtnSubmitTest.Click += new System.EventHandler(this.BtnSubmitTest_Click);
            // 
            // FlowPanelQuestionBox
            // 
            this.FlowPanelQuestionBox.AutoScroll = true;
            this.FlowPanelQuestionBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FlowPanelQuestionBox.Location = new System.Drawing.Point(0, 148);
            this.FlowPanelQuestionBox.Margin = new System.Windows.Forms.Padding(2);
            this.FlowPanelQuestionBox.Name = "FlowPanelQuestionBox";
            this.FlowPanelQuestionBox.Size = new System.Drawing.Size(1918, 932);
            this.FlowPanelQuestionBox.TabIndex = 1;
            // 
            // LbStudentName
            // 
            this.LbStudentName.AutoSize = true;
            this.LbStudentName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbStudentName.Location = new System.Drawing.Point(159, 33);
            this.LbStudentName.Name = "LbStudentName";
            this.LbStudentName.Size = new System.Drawing.Size(173, 36);
            this.LbStudentName.TabIndex = 6;
            this.LbStudentName.Text = "StudentName";
            // 
            // LbStudentID
            // 
            this.LbStudentID.AutoSize = true;
            this.LbStudentID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbStudentID.Location = new System.Drawing.Point(159, 79);
            this.LbStudentID.Name = "LbStudentID";
            this.LbStudentID.Size = new System.Drawing.Size(99, 28);
            this.LbStudentID.TabIndex = 7;
            this.LbStudentID.Text = "StudentID";
            // 
            // UCDoingExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.LbStudentID);
            this.Controls.Add(this.LbStudentName);
            this.Controls.Add(this.FlowPanelQuestionBox);
            this.Controls.Add(this.BtnSubmitTest);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LbTimeLeft);
            this.Controls.Add(this.LbNameOfTest);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCDoingExam";
            this.Size = new System.Drawing.Size(1920, 1080);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label LbNameOfTest;
        private Label LbTimeLeft;
        private CircularNamePictureBox pictureBox1;
        private Button BtnSubmitTest;
        private FlowLayoutPanel FlowPanelQuestionBox;
        private Label LbStudentName;
        private Label LbStudentID;
    }
}
