using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Form nhỏ để sửa Phụ Cấp và Khấu Trừ của một bản ghi lương.
    /// </summary>
    public class FormSuaLuong : Form
    {
        private Database db;
        private int maBangLuong;

        private Label lblInfo = new Label();
        private Label lblPhuCap = new Label();
        private TextBox txtPhuCap = new TextBox();
        private Label lblKhauTru = new Label();
        private TextBox txtKhauTru = new TextBox();
        private Button btnLuu = new Button();
        private Button btnHuy = new Button();

        public FormSuaLuong(int maBangLuong, Database db)
        {
            this.maBangLuong = maBangLuong;
            this.db = db;
            BuildUI();
            LoadData();
        }

        void BuildUI()
        {
            this.Text = "Sửa Bảng Lương";
            this.Size = new System.Drawing.Size(340, 200);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            lblInfo.Location = new System.Drawing.Point(10, 15);
            lblInfo.Size = new System.Drawing.Size(300, 18);
            lblInfo.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);

            lblPhuCap.Text = "Phụ Cấp (VNĐ):";
            lblPhuCap.Location = new System.Drawing.Point(10, 48);
            lblPhuCap.AutoSize = true;

            txtPhuCap.Location = new System.Drawing.Point(140, 45);
            txtPhuCap.Size = new System.Drawing.Size(160, 22);

            lblKhauTru.Text = "Khấu Trừ (VNĐ):";
            lblKhauTru.Location = new System.Drawing.Point(10, 83);
            lblKhauTru.AutoSize = true;

            txtKhauTru.Location = new System.Drawing.Point(140, 80);
            txtKhauTru.Size = new System.Drawing.Size(160, 22);

            btnLuu.Text = "💾 Lưu";
            btnLuu.Location = new System.Drawing.Point(80, 120);
            btnLuu.Size = new System.Drawing.Size(80, 28);
            btnLuu.Click += BtnLuu_Click;

            btnHuy.Text = "Hủy";
            btnHuy.Location = new System.Drawing.Point(175, 120);
            btnHuy.Size = new System.Drawing.Size(80, 28);
            btnHuy.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };

            this.Controls.AddRange(new Control[] { lblInfo, lblPhuCap, txtPhuCap, lblKhauTru, txtKhauTru, btnLuu, btnHuy });
        }

        void LoadData()
        {
            string sql = $@"SELECT bl.MaNV, nv.HoTen, bl.Thang, bl.Nam, bl.LuongCoBan, bl.NgayCong, bl.PhuCap, bl.KhauTru
                            FROM BangLuong bl JOIN NhanVien nv ON bl.MaNV=nv.MaNV
                            WHERE bl.MaBangLuong={maBangLuong}";
            DataTable dt = db.GetData(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow r = dt.Rows[0];
                lblInfo.Text = $"{r["HoTen"]}  —  Tháng {r["Thang"]}/{r["Nam"]}";
                txtPhuCap.Text = r["PhuCap"].ToString();
                txtKhauTru.Text = r["KhauTru"].ToString();
            }
        }

        void BtnLuu_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtPhuCap.Text, out decimal phuCap) ||
                !decimal.TryParse(txtKhauTru.Text, out decimal khauTru))
            {
                MessageBox.Show("Phụ cấp và Khấu trừ phải là số!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tính lại lương thực nhận
            string sqlGet = $"SELECT LuongCoBan, NgayCong FROM BangLuong WHERE MaBangLuong={maBangLuong}";
            DataTable dt = db.GetData(sqlGet);
            if (dt.Rows.Count == 0) return;

            decimal luongCoBan = Convert.ToDecimal(dt.Rows[0]["LuongCoBan"]);
            int ngayCong = Convert.ToInt32(dt.Rows[0]["NgayCong"]);
            decimal luongThucNhan = (luongCoBan / 26m) * ngayCong + phuCap - khauTru;

            string sqlUpdate = $@"UPDATE BangLuong
                                  SET PhuCap={phuCap}, KhauTru={khauTru}, LuongThucNhan={luongThucNhan}
                                  WHERE MaBangLuong={maBangLuong}";
            if (db.Execute(sqlUpdate))
            {
                MessageBox.Show("Cập nhật thành công!\nLương thực nhận: " + luongThucNhan.ToString("N0") + " VNĐ",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
