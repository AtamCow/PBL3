namespace OnlineExamSystem.Presentation.UITest.UIStudentTest
{
    partial class UCEnterExam
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
            this.label2 = new System.Windows.Forms.Label();
            this.LbStatus = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LbAllowTime = new System.Windows.Forms.Label();
            this.LbTestName = new System.Windows.Forms.Label();
            this.PanelPassword = new System.Windows.Forms.Panel();
            this.PanelPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(960, 243);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bài kiểm tra";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // LbStatus
            // 
            this.LbStatus.AutoSize = true;
            this.LbStatus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbStatus.ForeColor = System.Drawing.Color.Red;
            this.LbStatus.Location = new System.Drawing.Point(960, 740);
            this.LbStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbStatus.Name = "LbStatus";
            this.LbStatus.Size = new System.Drawing.Size(502, 38);
            this.LbStatus.TabIndex = 2;
            this.LbStatus.Text = "Sai mật khẩu làm bài. Vui lòng nhập lại.";
            this.LbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPassword.Location = new System.Drawing.Point(143, 3);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(219, 42);
            this.TxtPassword.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(960, 626);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 83);
            this.button1.TabIndex = 4;
            this.button1.Text = "Bắt đầu làm bài";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnRequestStartExam_Click);
            // 
            // LbAllowTime
            // 
            this.LbAllowTime.AutoSize = true;
            this.LbAllowTime.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbAllowTime.Location = new System.Drawing.Point(960, 436);
            this.LbAllowTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbAllowTime.Name = "LbAllowTime";
            this.LbAllowTime.Size = new System.Drawing.Size(307, 48);
            this.LbAllowTime.TabIndex = 5;
            this.LbAllowTime.Text = "Thời gian: 40 phút";
            // 
            // LbTestName
            // 
            this.LbTestName.AutoSize = true;
            this.LbTestName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbTestName.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.LbTestName.Location = new System.Drawing.Point(960, 336);
            this.LbTestName.Name = "LbTestName";
            this.LbTestName.Size = new System.Drawing.Size(130, 54);
            this.LbTestName.TabIndex = 6;
            this.LbTestName.Text = "label5";
            this.LbTestName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelPassword
            // 
            this.PanelPassword.Controls.Add(this.label2);
            this.PanelPassword.Controls.Add(this.TxtPassword);
            this.PanelPassword.Location = new System.Drawing.Point(960, 540);
            this.PanelPassword.Name = "PanelPassword";
            this.PanelPassword.Size = new System.Drawing.Size(366, 48);
            this.PanelPassword.TabIndex = 8;
            // 
            // UCEnterExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelPassword);
            this.Controls.Add(this.LbTestName);
            this.Controls.Add(this.LbAllowTime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LbStatus);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCEnterExam";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.PanelPassword.ResumeLayout(false);
            this.PanelPassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label LbStatus;
        private TextBox TxtPassword;
        private Button button1;
        private Label LbAllowTime;
        private Label LbTestName;
        private Panel PanelPassword;
    }
}
