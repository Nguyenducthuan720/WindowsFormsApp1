using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Database
    {
        // Thay đổi connection string cho phù hợp với SQL Server của bạn
        private string connectionString =
            "Data Source=laptop-i2ta3hpl\\thuan;Initial Catalog=QuanLyNhanSu;Integrated Security=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public DataTable GetData(string sql)
        {
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }

        public bool Execute(string sql)
        {
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực thi SQL: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public object ExecuteScalar(string sql)
        {
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    return cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}