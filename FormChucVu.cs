using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormChucVu : Form
    {
        Database db = new Database();

        public FormChucVu()
        {
            InitializeComponent();
        }

        void LoadChucVu()
        {
            string sql = "SELECT * FROM ChucVu";
            dataGridView1.DataSource = db.GetData(sql);
        }

        private void FormChucVu_Load(object sender, EventArgs e)
        {
            LoadChucVu();
        }

        // Thêm
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã Chức Vụ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = $"INSERT INTO ChucVu(MaChucVu, TenChucVu, MoTa, HeSoLuong) VALUES(N'{textBox1.Text}', N'{textBox2.Text}', N'{textBox3.Text}', '{textBox4.Text}')";
            if (db.Execute(sql))
            {
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadChucVu();
                XoaForm();
            }
        }

        // Sửa
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Vui lòng chọn Chức Vụ cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = $"UPDATE ChucVu SET TenChucVu=N'{textBox2.Text}', MoTa=N'{textBox3.Text}', HeSoLuong='{textBox4.Text}' WHERE MaChucVu=N'{textBox1.Text}'";
            if (db.Execute(sql))
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadChucVu();
                XoaForm();
            }
        }

        // Xóa
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Vui lòng chọn Chức Vụ cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string sql = $"DELETE FROM ChucVu WHERE MaChucVu=N'{textBox1.Text}'";
                if (db.Execute(sql))
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadChucVu();
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
            LoadChucVu();
        }

        void XoaForm()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
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
                textBox4.Text = row.Cells[3].Value?.ToString();
            }
        }
    }
}