namespace OnlineExamSystem.Presentation.UITest.UIStudentTest.OnExam
{
    partial class UCExamScore
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnViewDetails = new System.Windows.Forms.Button();
            this.LbScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Controls.Add(this.BtnViewDetails);
            this.panel1.Controls.Add(this.LbScore);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(660, 340);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 400);
            this.panel1.TabIndex = 0;
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnExit.Location = new System.Drawing.Point(300, 332);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(147, 44);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "Hoàn tất";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnViewDetails
            // 
            this.BtnViewDetails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnViewDetails.Location = new System.Drawing.Point(300, 280);
            this.BtnViewDetails.Name = "BtnViewDetails";
            this.BtnViewDetails.Size = new System.Drawing.Size(168, 46);
            this.BtnViewDetails.TabIndex = 3;
            this.BtnViewDetails.Text = "Xem chi tiết";
            this.BtnViewDetails.UseVisualStyleBackColor = true;
            this.BtnViewDetails.Click += new System.EventHandler(this.BtnViewDetails_Click);
            // 
            // LbScore
            // 
            this.LbScore.AutoSize = true;
            this.LbScore.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbScore.Location = new System.Drawing.Point(300, 165);
            this.LbScore.Name = "LbScore";
            this.LbScore.Size = new System.Drawing.Size(495, 81);
            this.LbScore.TabIndex = 2;
            this.LbScore.Text = "Điểm số: 100/100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(300, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(523, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bạn đã hoàn thành bài kiểm tra.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(300, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chúc mừng!";
            // 
            // UCExamScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panel1);
            this.Name = "UCExamScore";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button BtnExit;
        private Button BtnViewDetails;
        private Label LbScore;
        private Label label2;
        private Label label1;
    }
}
