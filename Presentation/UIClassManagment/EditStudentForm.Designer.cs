namespace OnlineExamSystem.PresentationLayer.UIClass
{
    partial class EditStudentForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.CbStudentGender = new System.Windows.Forms.ComboBox();
            this.TxtStudentLastName = new System.Windows.Forms.TextBox();
            this.TxtStudentBirthday = new System.Windows.Forms.DateTimePicker();
            this.TxtStudentMSSV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.TxtStudentFirstName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(472, 637);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 48;
            this.label5.Text = "Giới tính:";
            // 
            // CbStudentGender
            // 
            this.CbStudentGender.FormattingEnabled = true;
            this.CbStudentGender.Items.AddRange(new object[] {
            "Không",
            "Nam ",
            "Nữ"});
            this.CbStudentGender.Location = new System.Drawing.Point(593, 629);
            this.CbStudentGender.Name = "CbStudentGender";
            this.CbStudentGender.Size = new System.Drawing.Size(296, 33);
            this.CbStudentGender.TabIndex = 47;
            // 
            // TxtStudentLastName
            // 
            this.TxtStudentLastName.Location = new System.Drawing.Point(688, 512);
            this.TxtStudentLastName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtStudentLastName.Name = "TxtStudentLastName";
            this.TxtStudentLastName.Size = new System.Drawing.Size(201, 31);
            this.TxtStudentLastName.TabIndex = 46;
            // 
            // TxtStudentBirthday
            // 
            this.TxtStudentBirthday.Location = new System.Drawing.Point(593, 576);
            this.TxtStudentBirthday.Name = "TxtStudentBirthday";
            this.TxtStudentBirthday.Size = new System.Drawing.Size(296, 31);
            this.TxtStudentBirthday.TabIndex = 45;
            // 
            // TxtStudentMSSV
            // 
            this.TxtStudentMSSV.Enabled = false;
            this.TxtStudentMSSV.Location = new System.Drawing.Point(593, 454);
            this.TxtStudentMSSV.Margin = new System.Windows.Forms.Padding(4);
            this.TxtStudentMSSV.Name = "TxtStudentMSSV";
            this.TxtStudentMSSV.Size = new System.Drawing.Size(296, 31);
            this.TxtStudentMSSV.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(474, 460);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 43;
            this.label4.Text = "MSSV:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(771, 702);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 63);
            this.button2.TabIndex = 42;
            this.button2.Text = "Lưu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnSaveStudentInfo_Click);
            // 
            // TxtStudentFirstName
            // 
            this.TxtStudentFirstName.Location = new System.Drawing.Point(593, 512);
            this.TxtStudentFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtStudentFirstName.Name = "TxtStudentFirstName";
            this.TxtStudentFirstName.Size = new System.Drawing.Size(87, 31);
            this.TxtStudentFirstName.TabIndex = 41;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(621, 702);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 63);
            this.button1.TabIndex = 40;
            this.button1.Text = "Hủy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnCancelModifyStudentInfo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(474, 579);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "Ngày sinh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(474, 518);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Họ và tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(457, 373);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(444, 55);
            this.label2.TabIndex = 37;
            this.label2.Text = "Chỉnh sửa thông tin";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(474, 702);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 63);
            this.button3.TabIndex = 49;
            this.button3.Text = "Reset mật khẩu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BtnRequestResetPass_Click);
            // 
            // EditStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
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
            this.Name = "EditStudentForm";
            this.Size = new System.Drawing.Size(1352, 1221);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label5;
        private ComboBox CbStudentGender;
        private TextBox TxtStudentLastName;
        private DateTimePicker TxtStudentBirthday;
        private TextBox TxtStudentMSSV;
        private Label label4;
        private Button button2;
        private TextBox TxtStudentFirstName;
        private Button button1;
        private Label label3;
        private Label label1;
        private Label label2;
        private Button button3;
    }
}
