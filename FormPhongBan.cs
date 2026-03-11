using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormPhongBan : Form
    {
        Database db = new Database();

        public FormPhongBan()
        {
            InitializeComponent();
        }

        void LoadPhongBan()
        {
            string sql = "SELECT * FROM PhongBan";
            dataGridView1.DataSource = db.GetData(sql);
        }

        private void FormPhongBan_Load(object sender, EventArgs e)
        {
            LoadPhongBan();
        }

        // Thêm
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã Phòng Ban!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = $"INSERT INTO PhongBan(MaPhong, TenPhong, DiaDiem) VALUES(N'{textBox1.Text}', N'{textBox2.Text}', N'{textBox3.Text}')";
            if (db.Execute(sql))
            {
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPhongBan();
                XoaForm();
            }
        }

        // Sửa
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Vui lòng chọn Phòng Ban cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = $"UPDATE PhongBan SET TenPhong=N'{textBox2.Text}', DiaDiem=N'{textBox3.Text}' WHERE MaPhong=N'{textBox1.Text}'";
            if (db.Execute(sql))
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPhongBan();
                XoaForm();
            }
        }

        // Xóa
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Vui lòng chọn Phòng Ban cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string sql = $"DELETE FROM PhongBan WHERE MaPhong=N'{textBox1.Text}'";
                if (db.Execute(sql))
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPhongBan();
                    XoaForm();
                }
            }
        }

        // Làm mới
        private void button4_Click(object sender, EventArgs e)
        {
            XoaForm();
        }

        // Tải lại
        private void button5_Click(object sender, EventArgs e)
        {
            LoadPhongBan();
        }

        void XoaForm()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value?.ToString();
                textBox2.Text = row.Cells[1].Value?.ToString();
                textBox3.Text = row.Cells[2].Value?.ToString();
            }
        }
    }
}