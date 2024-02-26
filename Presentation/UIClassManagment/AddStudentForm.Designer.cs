namespace OnlineExamSystem.PresentationLayer
{
    partial class AddStudentForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.TxtStudentFirstName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtStudentMSSV = new System.Windows.Forms.TextBox();
            this.TxtStudentBirthday = new System.Windows.Forms.DateTimePicker();
            this.TxtStudentLastName = new System.Windows.Forms.TextBox();
            this.CbStudentGender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(705, 719);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 36);
            this.button2.TabIndex = 30;
            this.button2.Text = "Lưu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SaveNewStudent_Click);
            // 
            // TxtStudentFirstName
            // 
            this.TxtStudentFirstName.Location = new System.Drawing.Point(581, 529);
            this.TxtStudentFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtStudentFirstName.Name = "TxtStudentFirstName";
            this.TxtStudentFirstName.Size = new System.Drawing.Size(87, 31);
            this.TxtStudentFirstName.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 719);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 36);
            this.button1.TabIndex = 27;
            this.button1.Text = "Hủy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CancelAddStudent_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(462, 596);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ngày sinh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(462, 535);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Họ và tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(445, 390);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 55);
            this.label2.TabIndex = 24;
            this.label2.Text = "Thêm học sinh mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(462, 477);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "MSSV:";
            // 
            // TxtStudentMSSV
            // 
            this.TxtStudentMSSV.Location = new System.Drawing.Point(581, 471);
            this.TxtStudentMSSV.Margin = new System.Windows.Forms.Padding(4);
            this.TxtStudentMSSV.Name = "TxtStudentMSSV";
            this.TxtStudentMSSV.Size = new System.Drawing.Size(296, 31);
            this.TxtStudentMSSV.TabIndex = 32;
            this.TxtStudentMSSV.Leave += new System.EventHandler(this.TxtStudentMSSV_Leave);
            // 
            // TxtStudentBirthday
            // 
            this.TxtStudentBirthday.Location = new System.Drawing.Point(581, 593);
            this.TxtStudentBirthday.Name = "TxtStudentBirthday";
            this.TxtStudentBirthday.Size = new System.Drawing.Size(296, 31);
            this.TxtStudentBirthday.TabIndex = 33;
            // 
            // TxtStudentLastName
            // 
            this.TxtStudentLastName.Location = new System.Drawing.Point(676, 529);
            this.TxtStudentLastName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtStudentLastName.Name = "TxtStudentLastName";
            this.TxtStudentLastName.Size = new System.Drawing.Size(201, 31);
            this.TxtStudentLastName.TabIndex = 34;
            // 
            // CbStudentGender
            // 
            this.CbStudentGender.FormattingEnabled = true;
            this.CbStudentGender.Items.AddRange(new object[] {
            "Không",
            "Nam ",
            "Nữ"});
            this.CbStudentGender.Location = new System.Drawing.Point(581, 646);
            this.CbStudentGender.Name = "CbStudentGender";
            this.CbStudentGender.Size = new System.Drawing.Size(296, 33);
            this.CbStudentGender.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(460, 654);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 36;
            this.label5.Text = "Giới tính:";
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CbStudentGender);
            this.Controls.Add(this.TxtStudentLastName);
            this.Controls.Add(this.TxtStudentBirthday);
            this.Controls.Add(this.TxtStudentMSSV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TxtStudentFirstName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "AddStudentForm";
            this.Size = new System.Drawing.Size(1352, 1221);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button2;
        private TextBox TxtStudentFirstName;
        private Button button1;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox TxtStudentMSSV;
        private DateTimePicker TxtStudentBirthday;
        private TextBox TxtStudentLastName;
        private ComboBox CbStudentGender;
        private Label label5;
    }
}
