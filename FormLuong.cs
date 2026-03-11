using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormLuong : Form
    {
        Database db = new Database();
        // Lưu MaBangLuong đang chọn để phục vụ Sửa/Xóa
        private int selectedMaBangLuong = -1;

        public FormLuong()
        {
            InitializeComponent();
        }

        private void FormLuong_Load(object sender, EventArgs e)
        {
            LoadComboBoxThang();
            LoadComboBoxNam();
            LoadComboBoxNhanVien();
            LoadBangLuong();
        }

        // ===== LOAD DỮ LIỆU =====

        void LoadComboBoxThang()
        {
            cboThang.Items.Clear();
            for (int i = 1; i <= 12; i++)
                cboThang.Items.Add(i.ToString());
            cboThang.SelectedItem = DateTime.Now.Month.ToString();
        }

        void LoadComboBoxNam()
        {
            cboNam.Items.Clear();
            int namHienTai = DateTime.Now.Year;
            for (int y = namHienTai - 3; y <= namHienTai + 1; y++)
                cboNam.Items.Add(y.ToString());
            cboNam.SelectedItem = namHienTai.ToString();
        }

        void LoadComboBoxNhanVien()
        {
            DataTable dt = db.GetData("SELECT MaNV, HoTen FROM NhanVien ORDER BY HoTen");
            cboNhanVien.Items.Clear();
            cboNhanVien.Items.Add("-- Tất cả --");
            foreach (DataRow row in dt.Rows)
                cboNhanVien.Items.Add(row["MaNV"] + " - " + row["HoTen"]);
            cboNhanVien.SelectedIndex = 0;
        }

        void LoadBangLuong(string whereSql = "")
        {
            string sql = @"SELECT bl.MaBangLuong, bl.MaNV, nv.HoTen, bl.Thang, bl.Nam,
                                  bl.NgayCong, bl.LuongCoBan, bl.PhuCap, bl.KhauTru, bl.LuongThucNhan
                           FROM BangLuong bl
                           JOIN NhanVien nv ON bl.MaNV = nv.MaNV "
                         + whereSql
                         + " ORDER BY bl.Nam DESC, bl.Thang DESC";
            dataGridView1.DataSource = db.GetData(sql);
        }

        // ===== TÌM / LÀM MỚI =====

        private void btnTim_Click(object sender, EventArgs e)
        {
            string where = "WHERE 1=1";

            if (cboThang.SelectedIndex >= 0)
                where += $" AND bl.Thang = {cboThang.SelectedItem}";

            if (cboNam.SelectedIndex >= 0)
                where += $" AND bl.Nam = {cboNam.SelectedItem}";

            if (cboNhanVien.SelectedIndex > 0) // bỏ qua "-- Tất cả --"
            {
                string maNV = cboNhanVien.Text.Split('-')[0].Trim();
                where += $" AND bl.MaNV = '{maNV}'";
            }

            LoadBangLuong(where);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cboThang.SelectedItem = DateTime.Now.Month.ToString();
            cboNam.SelectedItem = DateTime.Now.Year.ToString();
            cboNhanVien.SelectedIndex = 0;
            selectedMaBangLuong = -1;
            LoadBangLuong();
        }

        // ===== THÊM =====

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboNhanVien.SelectedIndex <= 0)
            {
                MessageBox.Show("Vui lòng chọn Nhân Viên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maNV = cboNhanVien.Text.Split('-')[0].Trim();
            int thang = int.Parse(cboThang.SelectedItem.ToString());
            int nam = int.Parse(cboNam.SelectedItem.ToString());

            // Kiểm tra đã có bảng lương chưa
            string sqlCheck = $"SELECT COUNT(*) FROM BangLuong WHERE MaNV='{maNV}' AND Thang={thang} AND Nam={nam}";
            object count = db.ExecuteScalar(sqlCheck);
            if (count != null && Convert.ToInt32(count) > 0)
            {
                MessageBox.Show("Nhân viên này đã có bảng lương tháng " + thang + "/" + nam + "!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy lương cơ bản từ bảng NhanVien
            object luongObj = db.ExecuteScalar($"SELECT Luong FROM NhanVien WHERE MaNV='{maNV}'");
            decimal luongCoBan = luongObj != null ? Convert.ToDecimal(luongObj) : 0;

            // Đếm ngày công trong tháng từ bảng ChamCong
            int ngayCong = 26;
            try
            {
                object ncObj = db.ExecuteScalar(
                    $"SELECT COUNT(*) FROM ChamCong WHERE MaNV='{maNV}' AND MONTH(Ngay)={thang} AND YEAR(Ngay)={nam} AND TrangThai=N'Có mặt'");
                if (ncObj != null && Convert.ToInt32(ncObj) > 0)
                    ngayCong = Convert.ToInt32(ncObj);
            }
            catch { }

            decimal phuCap = 0;
            decimal khauTru = 0;
            decimal luongThucNhan = (luongCoBan / 26m) * ngayCong + phuCap - khauTru;

            string sql = $@"INSERT INTO BangLuong(MaNV, Thang, Nam, NgayCong, LuongCoBan, PhuCap, KhauTru, LuongThucNhan)
                            VALUES('{maNV}', {thang}, {nam}, {ngayCong}, {luongCoBan}, {phuCap}, {khauTru}, {luongThucNhan})";

            if (db.Execute(sql))
            {
                MessageBox.Show($"Đã tính lương thành công!\nNgày công: {ngayCong}\nLương thực nhận: {luongThucNhan:N0} VNĐ",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBangLuong();
            }
        }

        // ===== SỬA =====

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedMaBangLuong < 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng trong bảng để sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mở dialog nhập thông tin sửa
            using (var frm = new FormSuaLuong(selectedMaBangLuong, db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    LoadBangLuong();
            }
        }

        // ===== XÓA =====

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedMaBangLuong < 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng trong bảng để xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa bảng lương này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string sql = $"DELETE FROM BangLuong WHERE MaBangLuong = {selectedMaBangLuong}";
                if (db.Execute(sql))
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    selectedMaBangLuong = -1;
                    LoadBangLuong();
                }
            }
        }

        // ===== XUẤT =====

        private void btnXuat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng xuất báo cáo đang phát triển!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ===== CHỌN DÒNG =====

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var val = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                selectedMaBangLuong = val != null ? Convert.ToInt32(val) : -1;
            }
        }
    }
}