using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormNhanVien : Form
    {
        Database db = new Database();

        public FormNhanVien()
        {
            InitializeComponent();
        }

        void LoadNhanVien()
        {
            string sql = "SELECT * FROM NhanVien";
            dgvNhanVien.DataSource = db.GetData(sql);
        }

        void LoadComboBox()
        {
            // Load PhongBan
            DataTable dtPB = db.GetData("SELECT TenPhong FROM PhongBan");
            cboPhongBan.Items.Clear();
            foreach (DataRow row in dtPB.Rows)
                cboPhongBan.Items.Add(row["TenPhong"].ToString());

            // Load ChucVu
            DataTable dtCV = db.GetData("SELECT TenChucVu FROM ChucVu");
            cboChucVu.Items.Clear();
            foreach (DataRow row in dtCV.Rows)
                cboChucVu.Items.Add(row["TenChucVu"].ToString());

            // GioiTinh
            cboGioiTinh.Items.Clear();
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");
            cboGioiTinh.Items.Add("Khác");
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadNhanVien();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells[0].Value?.ToString();
                txtHoTen.Text = row.Cells[1].Value?.ToString();
                if (row.Cells[2].Value != null && !string.IsNullOrEmpty(row.Cells[2].Value.ToString()))
                {
                    try { dtNgaySinh.Value = Convert.ToDateTime(row.Cells[2].Value); }
                    catch { }
                }
                cboGioiTinh.Text = row.Cells[3].Value?.ToString();
                cboPhongBan.Text = row.Cells[4].Value?.ToString();
                cboChucVu.Text = row.Cells[5].Value?.ToString();
                txtLuong.Text = row.Cells[6].Value?.ToString();
                txtSDT.Text = row.Cells[7].Value?.ToString();
            }
        }

        // Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã Nhân Viên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = $"INSERT INTO NhanVien(MaNV, HoTen, NgaySinh, GioiTinh, PhongBan, ChucVu, Luong, SDT) VALUES('{txtMaNV.Text}', N'{txtHoTen.Text}', '{dtNgaySinh.Value:yyyy-MM-dd}', N'{cboGioiTinh.Text}', N'{cboPhongBan.Text}', N'{cboChucVu.Text}', '{txtLuong.Text}', '{txtSDT.Text}')";
            if (db.Execute(sql))
            {
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNhanVien();
                XoaForm();
            }
        }

        // Sửa
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn Nhân Viên cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = $"UPDATE NhanVien SET HoTen=N'{txtHoTen.Text}', NgaySinh='{dtNgaySinh.Value:yyyy-MM-dd}', GioiTinh=N'{cboGioiTinh.Text}', PhongBan=N'{cboPhongBan.Text}', ChucVu=N'{cboChucVu.Text}', Luong='{txtLuong.Text}', SDT='{txtSDT.Text}' WHERE MaNV='{txtMaNV.Text}'";
            if (db.Execute(sql))
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNhanVien();
                XoaForm();
            }
        }

        // Xóa
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn Nhân Viên cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string sql = $"DELETE FROM NhanVien WHERE MaNV='{txtMaNV.Text}'";
                if (db.Execute(sql))
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNhanVien();
                    XoaForm();
                }
            }
        }

        // Làm mới
        private void button6_Click(object sender, EventArgs e)
        {
            XoaForm();
        }

        // Tải lại
        private void button5_Click(object sender, EventArgs e)
        {
            LoadNhanVien();
            txtTimKiem.Clear();
        }

        // button4 - thêm (phiên bản cũ giữ lại)
        private void button4_Click(object sender, EventArgs e)
        {
            btnThem_Click(sender, e);
        }

        void XoaForm()
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            cboGioiTinh.Text = "";
            cboPhongBan.Text = "";
            cboChucVu.Text = "";
            txtLuong.Clear();
            txtSDT.Clear();
            dtNgaySinh.Value = DateTime.Today;
            txtMaNV.Focus();
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { btnThem_Click(sender, e); }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                LoadNhanVien();
                return;
            }

            string sql = $@"SELECT * FROM NhanVien
                    WHERE MaNV LIKE '%{txtTimKiem.Text}%'
                    OR HoTen LIKE N'%{txtTimKiem.Text}%'
                    OR SDT LIKE '%{txtTimKiem.Text}%'";

            dgvNhanVien.DataSource = db.GetData(sql);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = $@"SELECT * FROM NhanVien
                    WHERE MaNV LIKE '%{txtTimKiem.Text}%'
                    OR HoTen LIKE N'%{txtTimKiem.Text}%'
                    OR SDT LIKE '%{txtTimKiem.Text}%'";

            dgvNhanVien.DataSource = db.GetData(sql);
        }
    }
}