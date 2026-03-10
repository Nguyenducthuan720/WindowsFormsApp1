using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Database
    {
        // Chuỗi kết nối
        string strConn = @"Data Source=.;Initial Catalog=QLNhanSu;Integrated Security=True";

        SqlConnection conn;

        // Mở kết nối
        public void OpenConnection()
        {
            conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        // Đóng kết nối
        public void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        // Lấy dữ liệu SELECT
        public DataTable GetData(string sql)
        {
            OpenConnection();

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            CloseConnection();

            return dt;
        }

        // Thực thi INSERT UPDATE DELETE
        public int Execute(string sql)
        {
            OpenConnection();

            SqlCommand cmd = new SqlCommand(sql, conn);
            int result = cmd.ExecuteNonQuery();

            CloseConnection();

            return result;
        }
}
}
