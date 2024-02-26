namespace OnlineExamSystem.PresentationLayer
{
    partial class UserInformation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CbGender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPhoneNum = new System.Windows.Forms.TextBox();
            this.TxtEmailAddress = new System.Windows.Forms.TextBox();
            this.TxtAccountID = new System.Windows.Forms.TextBox();
            this.DTPBirthday = new System.Windows.Forms.DateTimePicker();
            this.CbClass = new System.Windows.Forms.ComboBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.BtnUpdateInfo = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LbNumericText = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.ChangePasswordOK = new System.Windows.Forms.Button();
            this.ChangePasswordResetAll = new System.Windows.Forms.Button();
            this.InputOldPassword = new System.Windows.Forms.TextBox();
            this.InputNewPassword = new System.Windows.Forms.TextBox();
            this.InputRetypeNewPassword = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(50, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin tài khoản";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1352, 701);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CbGender);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.TxtPhoneNum);
            this.panel2.Controls.Add(this.TxtEmailAddress);
            this.panel2.Controls.Add(this.TxtAccountID);
            this.panel2.Controls.Add(this.DTPBirthday);
            this.panel2.Controls.Add(this.CbClass);
            this.panel2.Controls.Add(this.TxtLastName);
            this.panel2.Controls.Add(this.TxtFirstName);
            this.panel2.Controls.Add(this.BtnUpdateInfo);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.LbNumericText);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(138, 162);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(958, 493);
            this.panel2.TabIndex = 1;
            // 
            // CbGender
            // 
            this.CbGender.FormattingEnabled = true;
            this.CbGender.Items.AddRange(new object[] {
            "Không",
            "Nam ",
            "Nữ"});
            this.CbGender.Location = new System.Drawing.Point(440, 187);
            this.CbGender.Name = "CbGender";
            this.CbGender.Size = new System.Drawing.Size(461, 33);
            this.CbGender.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(0, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(9, 9, 118, 9);
            this.label3.Size = new System.Drawing.Size(265, 53);
            this.label3.TabIndex = 16;
            this.label3.Text = "Giới tính:";
            // 
            // TxtPhoneNum
            // 
            this.TxtPhoneNum.Location = new System.Drawing.Point(440, 353);
            this.TxtPhoneNum.Name = "TxtPhoneNum";
            this.TxtPhoneNum.Size = new System.Drawing.Size(461, 31);
            this.TxtPhoneNum.TabIndex = 19;
            // 
            // TxtEmailAddress
            // 
            this.TxtEmailAddress.Location = new System.Drawing.Point(440, 300);
            this.TxtEmailAddress.Name = "TxtEmailAddress";
            this.TxtEmailAddress.Size = new System.Drawing.Size(461, 31);
            this.TxtEmailAddress.TabIndex = 18;
            // 
            // TxtAccountID
            // 
            this.TxtAccountID.Location = new System.Drawing.Point(440, 19);
            this.TxtAccountID.Name = "TxtAccountID";
            this.TxtAccountID.Size = new System.Drawing.Size(461, 31);
            this.TxtAccountID.TabIndex = 17;
            // 
            // DTPBirthday
            // 
            this.DTPBirthday.Location = new System.Drawing.Point(440, 131);
            this.DTPBirthday.Name = "DTPBirthday";
            this.DTPBirthday.Size = new System.Drawing.Size(461, 31);
            this.DTPBirthday.TabIndex = 16;
            // 
            // CbClass
            // 
            this.CbClass.FormattingEnabled = true;
            this.CbClass.Location = new System.Drawing.Point(440, 240);
            this.CbClass.Name = "CbClass";
            this.CbClass.Size = new System.Drawing.Size(461, 33);
            this.CbClass.TabIndex = 15;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(643, 73);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(258, 31);
            this.TxtLastName.TabIndex = 14;
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(440, 73);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(176, 31);
            this.TxtFirstName.TabIndex = 13;
            // 
            // BtnUpdateInfo
            // 
            this.BtnUpdateInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnUpdateInfo.Location = new System.Drawing.Point(369, 409);
            this.BtnUpdateInfo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnUpdateInfo.Name = "BtnUpdateInfo";
            this.BtnUpdateInfo.Size = new System.Drawing.Size(188, 62);
            this.BtnUpdateInfo.TabIndex = 12;
            this.BtnUpdateInfo.Text = "Cập nhật thông tin";
            this.BtnUpdateInfo.UseVisualStyleBackColor = false;
            this.BtnUpdateInfo.Click += new System.EventHandler(this.BtnUpdateInfo_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label13.Location = new System.Drawing.Point(0, 340);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(9, 9, 118, 9);
            this.label13.Size = new System.Drawing.Size(208, 53);
            this.label13.TabIndex = 10;
            this.label13.Text = "SĐT:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label11.Location = new System.Drawing.Point(0, 287);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(9, 9, 118, 9);
            this.label11.Size = new System.Drawing.Size(225, 53);
            this.label11.TabIndex = 8;
            this.label11.Text = "Email:";
            // 
            // LbNumericText
            // 
            this.LbNumericText.AutoSize = true;
            this.LbNumericText.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LbNumericText.Location = new System.Drawing.Point(0, 6);
            this.LbNumericText.Margin = new System.Windows.Forms.Padding(0);
            this.LbNumericText.Name = "LbNumericText";
            this.LbNumericText.Padding = new System.Windows.Forms.Padding(9, 9, 118, 9);
            this.LbNumericText.Size = new System.Drawing.Size(233, 53);
            this.LbNumericText.TabIndex = 6;
            this.LbNumericText.Text = "MSSV:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label7.Location = new System.Drawing.Point(0, 117);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(9, 9, 118, 9);
            this.label7.Size = new System.Drawing.Size(285, 53);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label5.Location = new System.Drawing.Point(0, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(9, 9, 118, 9);
            this.label5.Size = new System.Drawing.Size(204, 53);
            this.label5.TabIndex = 2;
            this.label5.Text = "Lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(0, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(9, 9, 118, 9);
            this.label2.Size = new System.Drawing.Size(278, 53);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ và tên:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(50, 732);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(388, 66);
            this.label14.TabIndex = 2;
            this.label14.Text = "Đổi mật khẩu";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label15.Location = new System.Drawing.Point(138, 856);
            this.label15.Margin = new System.Windows.Forms.Padding(0);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(9, 9, 118, 9);
            this.label15.Size = new System.Drawing.Size(325, 54);
            this.label15.TabIndex = 13;
            this.label15.Text = "Mật khẩu cũ:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label16.Location = new System.Drawing.Point(138, 918);
            this.label16.Margin = new System.Windows.Forms.Padding(0);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(9, 9, 118, 9);
            this.label16.Size = new System.Drawing.Size(346, 54);
            this.label16.TabIndex = 14;
            this.label16.Text = "Mật khẩu mới:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label17.Location = new System.Drawing.Point(138, 981);
            this.label17.Margin = new System.Windows.Forms.Padding(0);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(9, 9, 118, 9);
            this.label17.Size = new System.Drawing.Size(470, 54);
            this.label17.TabIndex = 15;
            this.label17.Text = "Nhập lại mật khẩu mới:";
            // 
            // ChangePasswordOK
            // 
            this.ChangePasswordOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ChangePasswordOK.Location = new System.Drawing.Point(650, 1075);
            this.ChangePasswordOK.Margin = new System.Windows.Forms.Padding(4);
            this.ChangePasswordOK.Name = "ChangePasswordOK";
            this.ChangePasswordOK.Size = new System.Drawing.Size(188, 62);
            this.ChangePasswordOK.TabIndex = 13;
            this.ChangePasswordOK.Text = "Lưu";
            this.ChangePasswordOK.UseVisualStyleBackColor = false;
            this.ChangePasswordOK.Click += new System.EventHandler(this.ChangePasswordOK_Click);
            // 
            // ChangePasswordResetAll
            // 
            this.ChangePasswordResetAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ChangePasswordResetAll.Location = new System.Drawing.Point(394, 1075);
            this.ChangePasswordResetAll.Margin = new System.Windows.Forms.Padding(4);
            this.ChangePasswordResetAll.Name = "ChangePasswordResetAll";
            this.ChangePasswordResetAll.Size = new System.Drawing.Size(188, 62);
            this.ChangePasswordResetAll.TabIndex = 16;
            this.ChangePasswordResetAll.Text = "Hủy";
            this.ChangePasswordResetAll.UseVisualStyleBackColor = false;
            this.ChangePasswordResetAll.Click += new System.EventHandler(this.ChangePasswordResetAll_Click);
            // 
            // InputOldPassword
            // 
            this.InputOldPassword.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputOldPassword.Location = new System.Drawing.Point(644, 866);
            this.InputOldPassword.Margin = new System.Windows.Forms.Padding(0);
            this.InputOldPassword.Name = "InputOldPassword";
            this.InputOldPassword.PasswordChar = '*';
            this.InputOldPassword.Size = new System.Drawing.Size(452, 49);
            this.InputOldPassword.TabIndex = 17;
            // 
            // InputNewPassword
            // 
            this.InputNewPassword.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputNewPassword.Location = new System.Drawing.Point(644, 928);
            this.InputNewPassword.Margin = new System.Windows.Forms.Padding(0);
            this.InputNewPassword.Name = "InputNewPassword";
            this.InputNewPassword.PasswordChar = '*';
            this.InputNewPassword.Size = new System.Drawing.Size(452, 49);
            this.InputNewPassword.TabIndex = 18;
            // 
            // InputRetypeNewPassword
            // 
            this.InputRetypeNewPassword.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputRetypeNewPassword.Location = new System.Drawing.Point(644, 991);
            this.InputRetypeNewPassword.Margin = new System.Windows.Forms.Padding(0);
            this.InputRetypeNewPassword.Name = "InputRetypeNewPassword";
            this.InputRetypeNewPassword.PasswordChar = '*';
            this.InputRetypeNewPassword.Size = new System.Drawing.Size(452, 49);
            this.InputRetypeNewPassword.TabIndex = 19;
            // 
            // UserInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InputRetypeNewPassword);
            this.Controls.Add(this.InputNewPassword);
            this.Controls.Add(this.InputOldPassword);
            this.Controls.Add(this.ChangePasswordResetAll);
            this.Controls.Add(this.ChangePasswordOK);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserInformation";
            this.Size = new System.Drawing.Size(1352, 1221);
            this.Load += new System.EventHandler(this.UserInformation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label13;
        private Label label11;
        private Label LbNumericText;
        private Label label7;
        private Label label5;
        private Button BtnUpdateInfo;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Button ChangePasswordOK;
        private Button ChangePasswordResetAll;
        private TextBox InputOldPassword;
        private TextBox InputNewPassword;
        private TextBox InputRetypeNewPassword;
        private TextBox TxtPhoneNum;
        private TextBox TxtEmailAddress;
        private TextBox TxtAccountID;
        private DateTimePicker DTPBirthday;
        private ComboBox CbClass;
        private TextBox TxtLastName;
        private TextBox TxtFirstName;
        private ComboBox CbGender;
        private Label label3;
    }
}
