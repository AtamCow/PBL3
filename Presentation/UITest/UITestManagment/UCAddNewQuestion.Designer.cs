namespace OnlineExamSystem.Presentation.UITest.UITestManagment
{
    partial class UCAddNewQuestion
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
            this.TxtQuestion = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtScore = new System.Windows.Forms.TextBox();
            this.LbScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtQuestion
            // 
            this.TxtQuestion.Location = new System.Drawing.Point(53, 18);
            this.TxtQuestion.Name = "TxtQuestion";
            this.TxtQuestion.Size = new System.Drawing.Size(715, 62);
            this.TxtQuestion.TabIndex = 0;
            this.TxtQuestion.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(783, 31);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(729, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Del";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(47, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thêm tùy chọn khác";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(23, 113);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(22, 21);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(847, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "X";
            // 
            // TxtScore
            // 
            this.TxtScore.Location = new System.Drawing.Point(786, 46);
            this.TxtScore.Name = "TxtScore";
            this.TxtScore.Size = new System.Drawing.Size(55, 31);
            this.TxtScore.TabIndex = 14;
            // 
            // LbScore
            // 
            this.LbScore.AutoSize = true;
            this.LbScore.Location = new System.Drawing.Point(786, 18);
            this.LbScore.Name = "LbScore";
            this.LbScore.Size = new System.Drawing.Size(58, 25);
            this.LbScore.TabIndex = 15;
            this.LbScore.Text = "Điểm:";
            // 
            // UCAddNewQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Controls.Add(this.LbScore);
            this.Controls.Add(this.TxtScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TxtQuestion);
            this.Name = "UCAddNewQuestion";
            this.Size = new System.Drawing.Size(896, 207);
            this.Load += new System.EventHandler(this.AddNewQuestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox TxtQuestion;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private CheckBox checkBox1;
        private Label label4;
        private TextBox TxtScore;
        private Label LbScore;
    }
}
