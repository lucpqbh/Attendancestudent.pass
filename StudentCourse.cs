using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;

namespace asm2.kk
{
    public partial class StudentCourse : Form
    {
        SqlConnection conn;
        public StudentCourse()
        {
            InitializeComponent();
            createConnection();
        }
        private void createConnection()
        {
            try
            {
                String stringConnection = "Server=DESKTOP-BTIGREQ\\SQLEXPRESS;Database=AttendanceSystems; Integrated Security = true";
                conn = new SqlConnection(stringConnection);
                // Intergrated Security = true
                MessageBox.Show(" ket noi csdl thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(" co loi xay ra ow createconnection " + ex.Message);
            }

        }
        private void DisplayDataStudent()
        {

            try
            {
                conn.Open();
                // khia bao lenh
                SqlCommand cmd = conn.CreateCommand();
                // khai bao kieu cau lenh
                cmd.CommandType = System.Data.CommandType.Text;
                // khai noi dung cau lenh
                string sql = "select * from Student";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                DataTable data = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(data);
                dgv.DataSource = data;
                MessageBox.Show(" lay du lieu thanh cong!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" co loi xay ra DisplayDataStudent " + ex.Message);
            }

        }
        private void CreateStudent()
        {
            try
            {
                conn.Open();
                // khai bao lenh
                SqlCommand cmd = conn.CreateCommand();
                // khai bao kieu cau lenh
                cmd.CommandType = System.Data.CommandType.Text;
                // khai noi dung cau lenh
                String sql = " INSERT INTO Student( studentID, name, gender, address, phoneNumber) VALUES ( @studentID, @name, @gender, @address, @phoneNumber)";
                // khai bao bien trong sql va gan gia tri cho bien
                cmd.Parameters.Add("@studentID", SqlDbType.VarChar);
                cmd.Parameters["@StudentID"].Value = tbStudentID.Text.ToString();

                cmd.Parameters.Add("@name", SqlDbType.VarChar);
                cmd.Parameters["@name"].Value = tbName.Text.ToString();

                cmd.Parameters.Add("@gender", SqlDbType.VarChar);
                cmd.Parameters["@gender"].Value = cbbGender.SelectedItem.ToString();

                cmd.Parameters.Add("@address", SqlDbType.VarChar);
                cmd.Parameters["@address"].Value = tbAddress.Text.ToString();

                cmd.Parameters.Add("@phoneNumber", SqlDbType.VarChar);
                cmd.Parameters["@phoneNumber"].Value = tbphoneNumber.Text.ToString();

                cmd.CommandText = sql;
                // thuc thi cau lenh
                cmd.ExecuteNonQuery();

                MessageBox.Show(" them moi thanh cong");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" co loi xay ra CreateStudent " + ex.Message);
            }
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            DisplayDataStudent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            CreateStudent();
            DisplayDataStudent();
            
        }
        private void DeleteStudent()
        {
            try
            {
                conn.Open();
                // khai bao lenh
                SqlCommand cmd = conn.CreateCommand();
                // khai bao kieu cau lenh
                cmd.CommandType = System.Data.CommandType.Text;
                // khai noi dung cau lenh
                String sql = " DELETE FROM Student WHERE StudentID = @StudentID";
                // khai bao bien trong sql va gan gia tri cho bien
                cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                cmd.Parameters["@StudentID"].Value = tbDeleteUpdateStudentID.Text.ToString();

                cmd.CommandText = sql;
                // thuc thi cau lenh
                cmd.ExecuteNonQuery();
                MessageBox.Show(" xoa thanh cong");
                // thuc thi cau lenh
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" co loi xay ra DeleteStudent " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            String StudentID = tbDeleteUpdateStudentID.Text.ToString();
            DialogResult re = MessageBox.Show(" ban co chac muon xoa ban ghi " + StudentID, "Xac nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                DeleteStudent();
                DisplayDataStudent();
            }
        }
        private void UpdateStudent()
        {
            try
            {
                conn.Open();
                // khai bao lenh
                SqlCommand cmd = conn.CreateCommand();
                // khai bao kieu cau lenh
                cmd.CommandType = System.Data.CommandType.Text;
                string sql = "UPDATE Student SET Name = @Name, Gender = @Gender, Address = @Address, PhoneNumber = @PhoneNumber WHERE StudentID = @StudentID";
                // khai bao bien trong sql va gan gia tri cho bien
                cmd.Parameters.Add("@name", SqlDbType.VarChar);
                cmd.Parameters["@name"].Value = tbName.Text.ToString();

                cmd.Parameters.Add("@gender", SqlDbType.VarChar);
                cmd.Parameters["@gender"].Value = cbbGender.SelectedItem.ToString();

                cmd.Parameters.Add("@address", SqlDbType.VarChar);
                cmd.Parameters["@address"].Value = tbAddress.Text.ToString();

                cmd.Parameters.Add("@phoneNumber", SqlDbType.VarChar);
                cmd.Parameters["@phoneNumber"].Value = tbphoneNumber.Text.ToString();

                cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                cmd.Parameters["@StudentID"].Value = tbDeleteUpdateStudentID.Text.ToString();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                MessageBox.Show("du lieu da duoc cap nhat thanh cong ");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cap nhat du lieu chua thanh cong");
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            UpdateStudent();
            DisplayDataStudent();
        }
       
        //Attendance:////////////////Attendance://///////////////Attendance://////////////////////////Attendance:///////////////////////////

        private void DisplayDataAttendance()
        {

            try
            {
                conn.Open();
                // khia bao lenh
                SqlCommand cmd = conn.CreateCommand();
                // khai bao kieu cau lenh
                cmd.CommandType = System.Data.CommandType.Text;
                // khai noi dung cau lenh
                string sql = "select * from Attendance";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                DataTable data = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(data);
                dgv1.DataSource = data;
                MessageBox.Show(" lay du lieu thanh cong!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" co loi xay ra DisplayDataAttendance " + ex.Message);
            }

        }

        private void Course_Click(object sender, EventArgs e)
        {
            DisplayDataAttendance();
        }
        private void Attendance()
        {
            if (dgv1.SelectedRows.Count > 0)
            {
                // Lấy dữ liệu từ dòng được chọn
                DataGridViewRow selectedRow = dgv1.SelectedRows[0];
                string studentID = selectedRow.Cells["StudentID"].Value.ToString();
                string classID = selectedRow.Cells["ClassID"].Value.ToString();
                DateTime dobDate = DateTime.Parse(selectedRow.Cells["DobDate"].Value.ToString());

                // Lấy trạng thái điểm danh từ ComboBox
                string attendanceStatus = selectedRow.Cells["AttendanceStatus"].Value.ToString();

                // Cập nhật dữ liệu điểm danh vào cơ sở dữ liệu
                try
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    string sql = "UPDATE Attendance SET AttendanceStatus = @attendanceStatus WHERE StudentID = @studentID AND ClassID = @classID AND DobDate = @dobDate";
                    cmd.CommandText = sql;
                    cmd.Parameters.Add("@attendanceStatus", SqlDbType.VarChar);
                    cmd.Parameters["@attendanceStatus"].Value = cbbAttendance.SelectedItem.ToString();

                    cmd.Parameters.Add("@studentID", SqlDbType.VarChar);
                    cmd.Parameters["@studentID"].Value = studentID;

                    cmd.Parameters.Add("@classID", SqlDbType.Int);
                    cmd.Parameters["@classID"].Value = int.Parse(classID); 

                    cmd.Parameters.Add("@dobDate", SqlDbType.Date);
                    cmd.Parameters["@dobDate"].Value = dobDate;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Điểm danh thành công!");
                    conn.Close();

                    // Sau khi cập nhật dữ liệu, cần hiển thị lại dữ liệu mới trong DataGridView
                    DisplayDataAttendance();
                }    
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để điểm danh!");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Attendance();
        }

    }
}
