using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormChamCong : Form
    {
        Database db = new Database();

        public FormChamCong()
        {
            InitializeComponent();
        }

        void LoadNhanVien()
        {
            DataTable dtNV = db.GetData("SELECT MaNV, HoTen FROM NhanVien");
            cboNhanVien.Items.Clear();
            foreach (DataRow row in dtNV.Rows)
                cboNhanVien.Items.Add(row["MaNV"] + " - " + row["HoTen"]);
        }

        void LoadChamCong()
        {
            string sql = "SELECT cc.*, nv.HoTen FROM ChamCong cc JOIN NhanVien nv ON cc.MaNV=nv.MaNV ORDER BY cc.Ngay DESC";
            dataGridView1.DataSource = db.GetData(sql);
        }

        private void FormChamCong_Load(object sender, EventArgs e)
        {
            dtNgay.Value = DateTime.Today;
            LoadNhanVien();
            LoadChamCong();
        }

        // Chấm công - Có mặt
        private void btnCoMat_Click(object sender, EventArgs e)
        {
            ChamCong("Có mặt");
        }

        // Vắng
        private void btnVang_Click(object sender, EventArgs e)
        {
            ChamCong("Vắng");
        }

        // Nghỉ phép
        private void btnNghiPhep_Click(object sender, EventArgs e)
        {
            ChamCong("Nghỉ phép");
        }

        void ChamCong(string trangThai)
        {
            if (cboNhanVien.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn Nhân Viên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maNV = cboNhanVien.Text.Split('-')[0].Trim();
            string ngay = dtNgay.Value.ToString("yyyy-MM-dd");
            string ghiChu = txtGhiChu.Text;

            // Kiểm tra đã chấm công chưa
            string sqlCheck = $"SELECT COUNT(*) FROM ChamCong WHERE MaNV='{maNV}' AND Ngay='{ngay}'";
            object count = db.ExecuteScalar(sqlCheck);
            if (count != null && Convert.ToInt32(count) > 0)
            {
                // Cập nhật
                string sqlUpdate = $"UPDATE ChamCong SET TrangThai=N'{trangThai}', GhiChu=N'{ghiChu}' WHERE MaNV='{maNV}' AND Ngay='{ngay}'";
                if (db.Execute(sqlUpdate))
                {
                    MessageBox.Show("Cập nhật chấm công thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadChamCong();
                }
            }
            else
            {
                // Thêm mới
                string sqlInsert = $"INSERT INTO ChamCong(MaNV, Ngay, TrangThai, GhiChu) VALUES('{maNV}', '{ngay}', N'{trangThai}', N'{ghiChu}')";
                if (db.Execute(sqlInsert))
                {
                    MessageBox.Show("Chấm công thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadChamCong();
                }
            }
        }

        // Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            DialogResult dr = MessageBox.Show("Xóa bản ghi chấm công này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string maChamCong = dataGridView1.CurrentRow.Cells[0].Value?.ToString();
                string sql = $"DELETE FROM ChamCong WHERE MaChamCong={maChamCong}";
                if (db.Execute(sql))
                    LoadChamCong();
            }
        }

        // Tải lại
        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadChamCong();
        }

        // Lọc theo tháng
        private void btnLoc_Click(object sender, EventArgs e)
        {
            int thang = dtNgay.Value.Month;
            int nam = dtNgay.Value.Year;
            string sql = $"SELECT cc.*, nv.HoTen FROM ChamCong cc JOIN NhanVien nv ON cc.MaNV=nv.MaNV WHERE MONTH(cc.Ngay)={thang} AND YEAR(cc.Ngay)={nam} ORDER BY cc.Ngay DESC";
            dataGridView1.DataSource = db.GetData(sql);
        }
    }
}