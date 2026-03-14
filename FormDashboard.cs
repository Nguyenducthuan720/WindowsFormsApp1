using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class FormDashboard : Form
    {
        Database db = new Database();
        public FormDashboard()
        {
            InitializeComponent();
        }

        void LoadThongKe()
        {
            string sql1 = "SELECT COUNT(*) FROM NhanVien";
            string sql2 = "SELECT COUNT(*) FROM PhongBan";
            string sql3 = "SELECT COUNT(*) FROM ChucVu";

            lblTongNhanVie.Text = db.GetData(sql1).Rows[0][0].ToString();
            lblTongPhongBa.Text = db.GetData(sql2).Rows[0][0].ToString();
            lblTongChucV.Text = db.GetData(sql3).Rows[0][0].ToString();
        }

        void LoadChart()
        {
            string sql = @"SELECT PhongBan, COUNT(*) AS SoNhanVien
                           FROM NhanVien
                           GROUP BY PhongBan";

            DataTable dt = db.GetData(sql);

            chart1.Series[0].Points.Clear();

            foreach (DataRow row in dt.Rows)
            {
                chart1.Series[0].Points.AddXY(
                    row["PhongBan"].ToString(),
                    Convert.ToInt32(row["SoNhanVien"])
                );
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTongNhanVien_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTongPhongBan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            LoadThongKe();
            LoadChart();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
