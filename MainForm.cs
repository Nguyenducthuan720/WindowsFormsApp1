using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // ===== HÀM MỞ FORM CON TRONG PANEL2 =====
        private void MoFormTrongPanel(Form form)
        {
            // Đóng tất cả form con đang mở trong panel2
            foreach (Control ctrl in panel2.Controls)
            {
                if (ctrl is Form)
                    ((Form)ctrl).Close();
            }
            panel2.Controls.Clear();

            // Nhúng form vào panel2
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel2.Controls.Add(form);
            panel2.Tag = form;
            form.Show();
        }

        // ===== CÁC NÚT TRONG PANEL BÊN TRÁI =====

        private void button1_Click(object sender, EventArgs e)
        {
            MoFormTrongPanel(new FormNhanVien());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MoFormTrongPanel(new FormPhongBan());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MoFormTrongPanel(new FormChucVu());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MoFormTrongPanel(new FormChamCong());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MoFormTrongPanel(new FormLuong());
        }

        // ===== MENU - HỆ THỐNG =====

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn thoát không?", "Xác nhận thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.Exit();
        }

        // ===== MENU - QUẢN LÝ =====

        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoFormTrongPanel(new FormNhanVien());
        }

        private void phongBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoFormTrongPanel(new FormPhongBan());
        }

        private void chucVuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoFormTrongPanel(new FormChucVu());
        }

        // ===== MENU - NGHIỆP VỤ =====

        private void chamCongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoFormTrongPanel(new FormChamCong());
        }

        private void tinhLuongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoFormTrongPanel(new FormLuong());
        }

        // ===== MENU - THỐNG KÊ =====

        private void baoCaoNhanSuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng Báo Cáo Nhân Sự đang phát triển!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void nghiepVuToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}