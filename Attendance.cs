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
using System.Xml.Linq;
namespace asm2.kk
{
    public partial class Attendance : Form
    {
        SqlConnection conn;
        public Attendance()
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
        private void DisplayData()
        {

            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                string sql = "select * from Attendance";
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
                MessageBox.Show(" co loi xay ra DisplayData " + ex.Message);
            }

        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            DisplayData();
        }
        private void SearchStudentAttendance(string studentID)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                String sql = "SELECT StudentID, ClassID, DobDate, AttendanceStatus FROM Attendance WHERE StudentID = @StudentID";
                cmd.CommandText = sql;
                cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                cmd.Parameters["@StudentID"].Value = studentID;

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // Đọc thông tin điểm danh của sinh viên từ dữ liệu đọc được
                    string studentIDResult = reader["StudentID"].ToString();
                    int classID = Convert.ToInt32(reader["ClassID"]);
                    DateTime dobDate = Convert.ToDateTime(reader["DobDate"]);
                    string attendanceStatus = reader["AttendanceStatus"].ToString();

                    // Hiển thị thông tin điểm danh hoặc làm gì đó với thông tin này
                    MessageBox.Show("StudentID: " + studentIDResult + "\nClassID: " + classID + "\nDate of Birth: " + dobDate.ToString() + "\nAttendance Status: " + attendanceStatus);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy thông tin điểm danh của sinh viên theo StudentID: " + ex.Message);
            }
        }


        private void btnFindStudent_Click(object sender, EventArgs e)
        {
            string studentID = tbStudentID.Text;
            SearchStudentAttendance(studentID);
            DisplayData();
        }     
    }
}
