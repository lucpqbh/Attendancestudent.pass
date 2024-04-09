namespace asm2.kk
{
    partial class StudentCourse
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbStudentID = new System.Windows.Forms.TextBox();
            this.btnCresteStudent = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbphoneNumber = new System.Windows.Forms.TextBox();
            this.lable1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeleteStudentID = new System.Windows.Forms.Button();
            this.btnUploadStudentID = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tbDeleteUpdateStudentID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbbGender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Course = new System.Windows.Forms.TabPage();
            this.cbbAttendance = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Course.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbStudentID
            // 
            this.tbStudentID.Location = new System.Drawing.Point(154, 20);
            this.tbStudentID.Multiline = true;
            this.tbStudentID.Name = "tbStudentID";
            this.tbStudentID.Size = new System.Drawing.Size(416, 33);
            this.tbStudentID.TabIndex = 0;
            // 
            // btnCresteStudent
            // 
            this.btnCresteStudent.Location = new System.Drawing.Point(750, 20);
            this.btnCresteStudent.Name = "btnCresteStudent";
            this.btnCresteStudent.Size = new System.Drawing.Size(90, 33);
            this.btnCresteStudent.TabIndex = 2;
            this.btnCresteStudent.Text = "Create";
            this.btnCresteStudent.UseVisualStyleBackColor = true;
            this.btnCresteStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(154, 80);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(416, 33);
            this.tbName.TabIndex = 0;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(154, 197);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(416, 33);
            this.tbAddress.TabIndex = 0;
            // 
            // tbphoneNumber
            // 
            this.tbphoneNumber.Location = new System.Drawing.Point(154, 264);
            this.tbphoneNumber.Multiline = true;
            this.tbphoneNumber.Name = "tbphoneNumber";
            this.tbphoneNumber.Size = new System.Drawing.Size(416, 33);
            this.tbphoneNumber.TabIndex = 0;
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(12, 33);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(83, 20);
            this.lable1.TabIndex = 3;
            this.lable1.Text = "StudentID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "PhoneNumber";
            // 
            // btnDeleteStudentID
            // 
            this.btnDeleteStudentID.Location = new System.Drawing.Point(805, 140);
            this.btnDeleteStudentID.Name = "btnDeleteStudentID";
            this.btnDeleteStudentID.Size = new System.Drawing.Size(73, 33);
            this.btnDeleteStudentID.TabIndex = 2;
            this.btnDeleteStudentID.Text = "Delete";
            this.btnDeleteStudentID.UseVisualStyleBackColor = true;
            this.btnDeleteStudentID.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUploadStudentID
            // 
            this.btnUploadStudentID.Location = new System.Drawing.Point(896, 138);
            this.btnUploadStudentID.Name = "btnUploadStudentID";
            this.btnUploadStudentID.Size = new System.Drawing.Size(73, 33);
            this.btnUploadStudentID.TabIndex = 2;
            this.btnUploadStudentID.Text = "Upload";
            this.btnUploadStudentID.UseVisualStyleBackColor = true;
            this.btnUploadStudentID.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgv.Location = new System.Drawing.Point(2, 327);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(1029, 266);
            this.dgv.TabIndex = 4;
            // 
            // tbDeleteUpdateStudentID
            // 
            this.tbDeleteUpdateStudentID.Location = new System.Drawing.Point(750, 80);
            this.tbDeleteUpdateStudentID.Multiline = true;
            this.tbDeleteUpdateStudentID.Name = "tbDeleteUpdateStudentID";
            this.tbDeleteUpdateStudentID.Size = new System.Drawing.Size(219, 33);
            this.tbDeleteUpdateStudentID.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(636, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "StudentID";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Course);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1045, 627);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabPage1.Controls.Add(this.cbbGender);
            this.tabPage1.Controls.Add(this.tbStudentID);
            this.tabPage1.Controls.Add(this.tbName);
            this.tabPage1.Controls.Add(this.dgv);
            this.tabPage1.Controls.Add(this.btnCresteStudent);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btnUploadStudentID);
            this.tabPage1.Controls.Add(this.btnDeleteStudentID);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tbAddress);
            this.tabPage1.Controls.Add(this.tbDeleteUpdateStudentID);
            this.tabPage1.Controls.Add(this.tbphoneNumber);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lable1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1037, 594);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Student";
            // 
            // cbbGender
            // 
            this.cbbGender.FormattingEnabled = true;
            this.cbbGender.Items.AddRange(new object[] {
            "Nam ",
            "Nu",
            "LGBT",
            "Red Flat"});
            this.cbbGender.Location = new System.Drawing.Point(154, 143);
            this.cbbGender.Name = "cbbGender";
            this.cbbGender.Size = new System.Drawing.Size(416, 28);
            this.cbbGender.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(918, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 3;
            // 
            // Course
            // 
            this.Course.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Course.Controls.Add(this.cbbAttendance);
            this.Course.Controls.Add(this.btnSave);
            this.Course.Controls.Add(this.label6);
            this.Course.Controls.Add(this.dgv1);
            this.Course.Location = new System.Drawing.Point(4, 29);
            this.Course.Name = "Course";
            this.Course.Padding = new System.Windows.Forms.Padding(3);
            this.Course.Size = new System.Drawing.Size(1037, 594);
            this.Course.TabIndex = 1;
            this.Course.Text = "Attendance";
            this.Course.Click += new System.EventHandler(this.Course_Click);
            // 
            // cbbAttendance
            // 
            this.cbbAttendance.AutoCompleteCustomSource.AddRange(new string[] {
            "Absent",
            "Present"});
            this.cbbAttendance.FormattingEnabled = true;
            this.cbbAttendance.Items.AddRange(new object[] {
            "Absent",
            "Present"});
            this.cbbAttendance.Location = new System.Drawing.Point(38, 45);
            this.cbbAttendance.Name = "cbbAttendance";
            this.cbbAttendance.Size = new System.Drawing.Size(180, 28);
            this.cbbAttendance.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(122, 94);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 37);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Attendance Status";
            // 
            // dgv1
            // 
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(0, 172);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 62;
            this.dgv1.RowTemplate.Height = 28;
            this.dgv1.Size = new System.Drawing.Size(1034, 444);
            this.dgv1.TabIndex = 0;
            // 
            // StudentCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1050, 632);
            this.Controls.Add(this.tabControl1);
            this.Name = "StudentCourse";
            this.Text = "StudentCourse(Admin)";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.Course.ResumeLayout(false);
            this.Course.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbStudentID;
        private System.Windows.Forms.Button btnCresteStudent;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbphoneNumber;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteStudentID;
        private System.Windows.Forms.Button btnUploadStudentID;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox tbDeleteUpdateStudentID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Course;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbbAttendance;
        private System.Windows.Forms.ComboBox cbbGender;
        private System.Windows.Forms.Label label7;
    }
}

