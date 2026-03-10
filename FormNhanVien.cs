using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvNhanVien.CurrentRow.Index;

            txtMaNV.Text = dgvNhanVien.Rows[i].Cells[0].Value.ToString();
            txtHoTen.Text = dgvNhanVien.Rows[i].Cells[1].Value.ToString();
            cboGioiTinh.Text = dgvNhanVien.Rows[i].Cells[2].Value.ToString();
            txtSDT.Text = dgvNhanVien.Rows[i].Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO NhanVien(HoTen,GioiTinh,SDT) VALUES(N'"
         + txtHoTen.Text + "',N'"
         + cboGioiTinh.Text + "','"
         + txtSDT.Text + "')";

            db.Execute(sql);

            LoadNhanVien();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO NhanVien VALUES('"
        + txtMaNV.Text + "', N'"
        + txtHoTen.Text + "', '"
        + dtNgaySinh.Value.ToString("yyyy-MM-dd") + "', N'"
        + cboGioiTinh.Text + "', N'"
        + cboPhongBan.Text + "', N'"
        + cboChucVu.Text + "', '"
        + txtLuong.Text + "', '"
        + txtSDT.Text + "')";

            db.Execute(sql);

            LoadNhanVien();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE NhanVien SET HoTen=N'"
        + txtHoTen.Text +
        "', GioiTinh=N'" + cboGioiTinh.Text +
        "', SDT='" + txtSDT.Text +
        "' WHERE MaNV='" + txtMaNV.Text + "'";

            db.Execute(sql);

            LoadNhanVien();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM NhanVien WHERE MaNV='" + txtMaNV.Text + "'";

            db.Execute(sql);

            LoadNhanVien();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtSDT.Clear();
            cboGioiTinh.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadNhanVien();
        }
    }
}
