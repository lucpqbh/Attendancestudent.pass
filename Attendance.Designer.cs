namespace asm2.kk
{
    partial class Attendance
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendance));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbStudentID = new System.Windows.Forms.TextBox();
            this.btnFindStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(2, 78);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(841, 313);
            this.dgv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "StudentID";
            // 
            // tbStudentID
            // 
            this.tbStudentID.Location = new System.Drawing.Point(141, 19);
            this.tbStudentID.Multiline = true;
            this.tbStudentID.Name = "tbStudentID";
            this.tbStudentID.Size = new System.Drawing.Size(210, 31);
            this.tbStudentID.TabIndex = 2;
            // 
            // btnFindStudent
            // 
            this.btnFindStudent.Location = new System.Drawing.Point(390, 19);
            this.btnFindStudent.Name = "btnFindStudent";
            this.btnFindStudent.Size = new System.Drawing.Size(119, 31);
            this.btnFindStudent.TabIndex = 3;
            this.btnFindStudent.Text = "Search";
            this.btnFindStudent.UseVisualStyleBackColor = true;
            this.btnFindStudent.Click += new System.EventHandler(this.btnFindStudent_Click);
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(848, 396);
            this.Controls.Add(this.btnFindStudent);
            this.Controls.Add(this.tbStudentID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Attendance";
            this.Text = "Attendance(User)";
            this.Load += new System.EventHandler(this.Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbStudentID;
        private System.Windows.Forms.Button btnFindStudent;
    }
}