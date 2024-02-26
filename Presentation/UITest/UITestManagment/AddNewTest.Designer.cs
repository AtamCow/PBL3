using OnlineExamSystem.Presentation.Components;

namespace OnlineExamSystem.Presentation.UITest.UITestManagment
{
    partial class AddNewTest
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
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            label5 = new Label();
            label9 = new Label();
            button3 = new Button();
            label8 = new Label();
            label7 = new Label();
            TxtTestDurationInMinutes = new CustomTextBox();
            LabelDuration = new Label();
            groupBox2 = new GroupBox();
            CheckBoxAllowSeeFinalScore = new CheckBox();
            CheckBoxAllowSeeQandA = new CheckBox();
            CheckBoxSwapQandA = new CheckBox();
            CheckboxCanOnlyTakeOneTime = new CheckBox();
            TxtJoinPassword = new CustomTextBox();
            label4 = new Label();
            BtnAddClassToLV = new Button();
            CbClassSelection = new ComboBox();
            ListViewCanDoExamClass = new ListView();
            LbWhoCanTakeEx = new Label();
            DTPEndTime = new DateTimePicker();
            DTPBeginTime = new DateTimePicker();
            LabelTestAllowTime = new Label();
            TxtTestName = new CustomTextBox();
            LabelTestName = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button4 = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(TxtTestDurationInMinutes);
            groupBox1.Controls.Add(LabelDuration);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(BtnAddClassToLV);
            groupBox1.Controls.Add(CbClassSelection);
            groupBox1.Controls.Add(ListViewCanDoExamClass);
            groupBox1.Controls.Add(LbWhoCanTakeEx);
            groupBox1.Controls.Add(DTPEndTime);
            groupBox1.Controls.Add(DTPBeginTime);
            groupBox1.Controls.Add(LabelTestAllowTime);
            groupBox1.Controls.Add(TxtTestName);
            groupBox1.Controls.Add(LabelTestName);
            groupBox1.Location = new Point(0, -13);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(0);
            groupBox1.Size = new Size(395, 1234);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(0, 0);
            groupBox3.Margin = new Padding(0);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(0);
            groupBox3.Size = new Size(395, 85);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(53, 24);
            label5.Name = "label5";
            label5.Size = new Size(289, 54);
            label5.TabIndex = 12;
            label5.Text = "Tạo bài thi mới";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(8, 28);
            label9.Name = "label9";
            label9.Size = new Size(39, 41);
            label9.TabIndex = 18;
            label9.Text = "<";
            label9.Click += label9_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(53, 1019);
            button3.Name = "button3";
            button3.Size = new Size(285, 118);
            button3.TabIndex = 17;
            button3.Text = "Lưu thông tin";
            button3.UseVisualStyleBackColor = true;
            button3.Click += BtnSaveInformation_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(164, 374);
            label8.Name = "label8";
            label8.Size = new Size(45, 28);
            label8.TabIndex = 16;
            label8.Text = "đến";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(66, 253);
            label7.Name = "label7";
            label7.Size = new Size(257, 21);
            label7.TabIndex = 15;
            label7.Text = "Nhập 0 để không giới hạn thời gian";
            // 
            // TxtTestDurationInMinutes
            // 
            TxtTestDurationInMinutes.BorderColor = Color.Empty;
            TxtTestDurationInMinutes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTestDurationInMinutes.Location = new Point(26, 214);
            TxtTestDurationInMinutes.Name = "TxtTestDurationInMinutes";
            TxtTestDurationInMinutes.Size = new Size(342, 39);
            TxtTestDurationInMinutes.TabIndex = 14;
            // 
            // LabelDuration
            // 
            LabelDuration.AutoSize = true;
            LabelDuration.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelDuration.Location = new Point(20, 176);
            LabelDuration.Name = "LabelDuration";
            LabelDuration.Size = new Size(275, 32);
            LabelDuration.TabIndex = 13;
            LabelDuration.Text = "Thời gian làm bài (phút):";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(CheckBoxAllowSeeFinalScore);
            groupBox2.Controls.Add(CheckBoxAllowSeeQandA);
            groupBox2.Controls.Add(CheckBoxSwapQandA);
            groupBox2.Controls.Add(CheckboxCanOnlyTakeOneTime);
            groupBox2.Controls.Add(TxtJoinPassword);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(19, 667);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(349, 308);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cài đặt nâng cao";
            // 
            // CheckBoxAllowSeeFinalScore
            // 
            CheckBoxAllowSeeFinalScore.AutoSize = true;
            CheckBoxAllowSeeFinalScore.Location = new Point(18, 237);
            CheckBoxAllowSeeFinalScore.Name = "CheckBoxAllowSeeFinalScore";
            CheckBoxAllowSeeFinalScore.Size = new Size(180, 34);
            CheckBoxAllowSeeFinalScore.TabIndex = 14;
            CheckBoxAllowSeeFinalScore.Text = "Cho xem điểm";
            CheckBoxAllowSeeFinalScore.UseVisualStyleBackColor = true;
            // 
            // CheckBoxAllowSeeQandA
            // 
            CheckBoxAllowSeeQandA.AutoSize = true;
            CheckBoxAllowSeeQandA.Location = new Point(18, 202);
            CheckBoxAllowSeeQandA.Name = "CheckBoxAllowSeeQandA";
            CheckBoxAllowSeeQandA.Size = new Size(286, 34);
            CheckBoxAllowSeeQandA.TabIndex = 13;
            CheckBoxAllowSeeQandA.Text = "Cho xem đề thi và đáp án";
            CheckBoxAllowSeeQandA.UseVisualStyleBackColor = true;
            // 
            // CheckBoxSwapQandA
            // 
            CheckBoxSwapQandA.AutoSize = true;
            CheckBoxSwapQandA.Location = new Point(18, 167);
            CheckBoxSwapQandA.Name = "CheckBoxSwapQandA";
            CheckBoxSwapQandA.Size = new Size(253, 34);
            CheckBoxSwapQandA.TabIndex = 12;
            CheckBoxSwapQandA.Text = "Đảo câu hỏi và đáp án";
            CheckBoxSwapQandA.UseVisualStyleBackColor = true;
            // 
            // CheckboxCanOnlyTakeOneTime
            // 
            CheckboxCanOnlyTakeOneTime.AutoSize = true;
            CheckboxCanOnlyTakeOneTime.Checked = true;
            CheckboxCanOnlyTakeOneTime.CheckState = CheckState.Checked;
            CheckboxCanOnlyTakeOneTime.Enabled = false;
            CheckboxCanOnlyTakeOneTime.Location = new Point(18, 132);
            CheckboxCanOnlyTakeOneTime.Name = "CheckboxCanOnlyTakeOneTime";
            CheckboxCanOnlyTakeOneTime.Size = new Size(276, 34);
            CheckboxCanOnlyTakeOneTime.TabIndex = 11;
            CheckboxCanOnlyTakeOneTime.Text = "Chỉ cho phép thi một lần";
            CheckboxCanOnlyTakeOneTime.UseVisualStyleBackColor = true;
            // 
            // TxtJoinPassword
            // 
            TxtJoinPassword.BorderColor = Color.Empty;
            TxtJoinPassword.Location = new Point(7, 72);
            TxtJoinPassword.Name = "TxtJoinPassword";
            TxtJoinPassword.Size = new Size(336, 37);
            TxtJoinPassword.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(7, 37);
            label4.Name = "label4";
            label4.Size = new Size(205, 32);
            label4.TabIndex = 10;
            label4.Text = "Mật khẩu làm bài:";
            // 
            // BtnAddClassToLV
            // 
            BtnAddClassToLV.Location = new Point(230, 590);
            BtnAddClassToLV.Name = "BtnAddClassToLV";
            BtnAddClassToLV.Size = new Size(138, 34);
            BtnAddClassToLV.TabIndex = 8;
            BtnAddClassToLV.Text = "Thêm lớp";
            BtnAddClassToLV.UseVisualStyleBackColor = true;
            BtnAddClassToLV.Click += BtnAddClassToLV_Click;
            // 
            // CbClassSelection
            // 
            CbClassSelection.FormattingEnabled = true;
            CbClassSelection.Location = new Point(26, 590);
            CbClassSelection.Name = "CbClassSelection";
            CbClassSelection.Size = new Size(182, 33);
            CbClassSelection.TabIndex = 7;
            CbClassSelection.SelectedIndexChanged += CbClassSelection_SelectedIndexChanged;
            // 
            // ListViewCanDoExamClass
            // 
            ListViewCanDoExamClass.Location = new Point(26, 500);
            ListViewCanDoExamClass.Name = "ListViewCanDoExamClass";
            ListViewCanDoExamClass.Size = new Size(342, 71);
            ListViewCanDoExamClass.TabIndex = 6;
            ListViewCanDoExamClass.UseCompatibleStateImageBehavior = false;
            // 
            // LbWhoCanTakeEx
            // 
            LbWhoCanTakeEx.AutoSize = true;
            LbWhoCanTakeEx.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbWhoCanTakeEx.Location = new Point(20, 462);
            LbWhoCanTakeEx.Name = "LbWhoCanTakeEx";
            LbWhoCanTakeEx.Size = new Size(197, 32);
            LbWhoCanTakeEx.TabIndex = 5;
            LbWhoCanTakeEx.Text = "Ai được phép thi:";
            // 
            // DTPEndTime
            // 
            DTPEndTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DTPEndTime.Location = new Point(26, 406);
            DTPEndTime.Name = "DTPEndTime";
            DTPEndTime.Size = new Size(342, 39);
            DTPEndTime.TabIndex = 4;
            // 
            // DTPBeginTime
            // 
            DTPBeginTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DTPBeginTime.Location = new Point(26, 335);
            DTPBeginTime.Name = "DTPBeginTime";
            DTPBeginTime.Size = new Size(342, 39);
            DTPBeginTime.TabIndex = 3;
            // 
            // LabelTestAllowTime
            // 
            LabelTestAllowTime.AutoSize = true;
            LabelTestAllowTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelTestAllowTime.Location = new Point(20, 297);
            LabelTestAllowTime.Name = "LabelTestAllowTime";
            LabelTestAllowTime.Size = new Size(127, 32);
            LabelTestAllowTime.TabIndex = 2;
            LabelTestAllowTime.Text = "Mở đề lúc:";
            // 
            // TxtTestName
            // 
            TxtTestName.BorderColor = Color.Empty;
            TxtTestName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTestName.ForeColor = Color.Black;
            TxtTestName.Location = new Point(26, 133);
            TxtTestName.Name = "TxtTestName";
            TxtTestName.Size = new Size(342, 39);
            TxtTestName.TabIndex = 1;
            // 
            // LabelTestName
            // 
            LabelTestName.AutoSize = true;
            LabelTestName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelTestName.Location = new Point(20, 95);
            LabelTestName.Name = "LabelTestName";
            LabelTestName.Size = new Size(131, 32);
            LabelTestName.TabIndex = 0;
            LabelTestName.Text = "Tên bài thi:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Location = new Point(398, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(931, 1221);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // button4
            // 
            button4.Location = new Point(3, 3);
            button4.Name = "button4";
            button4.Size = new Size(896, 69);
            button4.TabIndex = 1;
            button4.Text = "Câu hỏi mới";
            button4.UseVisualStyleBackColor = true;
            button4.Click += NewQuestionBtn;
            // 
            // AddNewTest
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(groupBox1);
            Name = "AddNewTest";
            Size = new Size(1352, 1221);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckBox CheckBoxAllowSeeFinalScore;
        private CheckBox CheckBoxAllowSeeQandA;
        private CheckBox CheckBoxSwapQandA;
        private CheckBox CheckboxCanOnlyTakeOneTime;
        private CustomTextBox TxtJoinPassword;
        private Label label4;
        private Button BtnAddClassToLV;
        private ComboBox CbClassSelection;
        private ListView ListViewCanDoExamClass;
        private Label LbWhoCanTakeEx;
        private DateTimePicker DTPEndTime;
        private DateTimePicker DTPBeginTime;
        private Label LabelTestAllowTime;
        private CustomTextBox TxtTestName;
        private Label LabelTestName;
        private CustomTextBox TxtTestDurationInMinutes;
        private Label LabelDuration;
        private Label label8;
        private Label label7;
        private Button button3;
        private Label label5;
        private Label label9;
        private GroupBox groupBox3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button4;
    }
}
