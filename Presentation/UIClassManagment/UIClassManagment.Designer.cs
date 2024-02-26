namespace OnlineExamSystem.PresentationLayer
{
    partial class UIClassManagment
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
            this.label2 = new System.Windows.Forms.Label();
            this.NewClassBtn = new System.Windows.Forms.Button();
            this.ClassListview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ClassListview)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(32, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(427, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách lớp học";
            // 
            // NewClassBtn
            // 
            this.NewClassBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.NewClassBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewClassBtn.ForeColor = System.Drawing.Color.White;
            this.NewClassBtn.Location = new System.Drawing.Point(1150, 32);
            this.NewClassBtn.Name = "NewClassBtn";
            this.NewClassBtn.Size = new System.Drawing.Size(174, 89);
            this.NewClassBtn.TabIndex = 2;
            this.NewClassBtn.Text = "Thêm lớp học";
            this.NewClassBtn.UseVisualStyleBackColor = false;
            this.NewClassBtn.Click += new System.EventHandler(this.NewClassBtn_Click);
            // 
            // ClassListview
            // 
            this.ClassListview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClassListview.Location = new System.Drawing.Point(32, 165);
            this.ClassListview.Name = "ClassListview";
            this.ClassListview.RowHeadersWidth = 62;
            this.ClassListview.RowTemplate.Height = 33;
            this.ClassListview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ClassListview.Size = new System.Drawing.Size(1292, 1021);
            this.ClassListview.TabIndex = 3;
            this.ClassListview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClassListview_CellContentClick);
            // 
            // UIClassManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ClassListview);
            this.Controls.Add(this.NewClassBtn);
            this.Controls.Add(this.label2);
            this.Name = "UIClassManagment";
            this.Size = new System.Drawing.Size(1352, 1221);
            this.Load += new System.EventHandler(this.ClassManagment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClassListview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Button NewClassBtn;
        private DataGridView ClassListview;
    }
}
