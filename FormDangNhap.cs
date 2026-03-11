using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormDangNhap : Form
    {
        Database db = new Database();
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaiKhoan.Text) ||
        string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = $@"SELECT * FROM TaiKhoan 
                    WHERE TaiKhoan='{txtTaiKhoan.Text}' 
                    AND MatKhau='{txtMatKhau.Text}'";

            DataTable dt = db.GetData(sql);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MainForm f = new MainForm();
                f.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
