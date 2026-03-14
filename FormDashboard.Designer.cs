namespace WindowsFormsApp1
{
    partial class FormDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTongNhanVien = new System.Windows.Forms.Panel();
            this.lblTongPhongBan = new System.Windows.Forms.Panel();
            this.lblTongChucVu = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTongNhanVie = new System.Windows.Forms.Label();
            this.lblTongPhongBa = new System.Windows.Forms.Label();
            this.lblTongChucV = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTongNhanVien.SuspendLayout();
            this.lblTongPhongBan.SuspendLayout();
            this.lblTongChucVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(144, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ NHÂN SỰ";
            // 
            // lblTongNhanVien
            // 
            this.lblTongNhanVien.Controls.Add(this.label2);
            this.lblTongNhanVien.Controls.Add(this.lblTongNhanVie);
            this.lblTongNhanVien.Location = new System.Drawing.Point(12, 74);
            this.lblTongNhanVien.Name = "lblTongNhanVien";
            this.lblTongNhanVien.Size = new System.Drawing.Size(200, 100);
            this.lblTongNhanVien.TabIndex = 1;
            this.lblTongNhanVien.Paint += new System.Windows.Forms.PaintEventHandler(this.lblTongNhanVien_Paint);
            // 
            // lblTongPhongBan
            // 
            this.lblTongPhongBan.Controls.Add(this.label3);
            this.lblTongPhongBan.Controls.Add(this.lblTongPhongBa);
            this.lblTongPhongBan.Location = new System.Drawing.Point(254, 74);
            this.lblTongPhongBan.Name = "lblTongPhongBan";
            this.lblTongPhongBan.Size = new System.Drawing.Size(200, 100);
            this.lblTongPhongBan.TabIndex = 2;
            this.lblTongPhongBan.Paint += new System.Windows.Forms.PaintEventHandler(this.lblTongPhongBan_Paint);
            // 
            // lblTongChucVu
            // 
            this.lblTongChucVu.Controls.Add(this.label4);
            this.lblTongChucVu.Controls.Add(this.lblTongChucV);
            this.lblTongChucVu.Location = new System.Drawing.Point(512, 74);
            this.lblTongChucVu.Name = "lblTongChucVu";
            this.lblTongChucVu.Size = new System.Drawing.Size(200, 100);
            this.lblTongChucVu.TabIndex = 3;
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(12, 198);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Nhân viên theo phòng ban";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(700, 350);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // lblTongNhanVie
            // 
            this.lblTongNhanVie.AutoSize = true;
            this.lblTongNhanVie.Location = new System.Drawing.Point(64, 57);
            this.lblTongNhanVie.Name = "lblTongNhanVie";
            this.lblTongNhanVie.Size = new System.Drawing.Size(37, 16);
            this.lblTongNhanVie.TabIndex = 0;
            this.lblTongNhanVie.Text = "label";
            // 
            // lblTongPhongBa
            // 
            this.lblTongPhongBa.AutoSize = true;
            this.lblTongPhongBa.Location = new System.Drawing.Point(77, 57);
            this.lblTongPhongBa.Name = "lblTongPhongBa";
            this.lblTongPhongBa.Size = new System.Drawing.Size(44, 16);
            this.lblTongPhongBa.TabIndex = 1;
            this.lblTongPhongBa.Text = "label3";
            // 
            // lblTongChucV
            // 
            this.lblTongChucV.AutoSize = true;
            this.lblTongChucV.Location = new System.Drawing.Point(66, 57);
            this.lblTongChucV.Name = "lblTongChucV";
            this.lblTongChucV.Size = new System.Drawing.Size(44, 16);
            this.lblTongChucV.TabIndex = 2;
            this.lblTongChucV.Text = "label4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chức vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "phòng ban";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 563);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblTongChucVu);
            this.Controls.Add(this.lblTongPhongBan);
            this.Controls.Add(this.lblTongNhanVien);
            this.Controls.Add(this.label1);
            this.Name = "FormDashboard";
            this.Text = "FormDashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.lblTongNhanVien.ResumeLayout(false);
            this.lblTongNhanVien.PerformLayout();
            this.lblTongPhongBan.ResumeLayout(false);
            this.lblTongPhongBan.PerformLayout();
            this.lblTongChucVu.ResumeLayout(false);
            this.lblTongChucVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel lblTongNhanVien;
        private System.Windows.Forms.Panel lblTongPhongBan;
        private System.Windows.Forms.Panel lblTongChucVu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lblTongNhanVie;
        private System.Windows.Forms.Label lblTongPhongBa;
        private System.Windows.Forms.Label lblTongChucV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}