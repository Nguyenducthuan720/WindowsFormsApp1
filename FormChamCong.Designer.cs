namespace WindowsFormsApp1
{
    partial class FormChamCong
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnCoMat = new System.Windows.Forms.Button();
            this.btnVang = new System.Windows.Forms.Button();
            this.btnNghiPhep = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNghiPhep);
            this.groupBox1.Controls.Add(this.btnVang);
            this.groupBox1.Controls.Add(this.btnCoMat);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtNgay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboNhanVien);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chấm Công Nhân Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.Text = "Nhân Viên:";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.Location = new System.Drawing.Point(90, 25);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(220, 21);
            this.cboNhanVien.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.Text = "Ngày:";
            // 
            // dtNgay
            // 
            this.dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgay.Location = new System.Drawing.Point(372, 25);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(110, 20);
            this.dtNgay.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.Text = "Ghi Chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(68, 59);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(300, 20);
            this.txtGhiChu.TabIndex = 2;
            // 
            // btnCoMat
            // 
            this.btnCoMat.BackColor = System.Drawing.Color.LightGreen;
            this.btnCoMat.Location = new System.Drawing.Point(90, 88);
            this.btnCoMat.Name = "btnCoMat";
            this.btnCoMat.Size = new System.Drawing.Size(110, 28);
            this.btnCoMat.TabIndex = 3;
            this.btnCoMat.Text = "✅ Có Mặt";
            this.btnCoMat.UseVisualStyleBackColor = false;
            this.btnCoMat.Click += new System.EventHandler(this.btnCoMat_Click);
            // 
            // btnVang
            // 
            this.btnVang.BackColor = System.Drawing.Color.LightCoral;
            this.btnVang.Location = new System.Drawing.Point(210, 88);
            this.btnVang.Name = "btnVang";
            this.btnVang.Size = new System.Drawing.Size(90, 28);
            this.btnVang.TabIndex = 4;
            this.btnVang.Text = "❌ Vắng";
            this.btnVang.UseVisualStyleBackColor = false;
            this.btnVang.Click += new System.EventHandler(this.btnVang_Click);
            // 
            // btnNghiPhep
            // 
            this.btnNghiPhep.BackColor = System.Drawing.Color.LightYellow;
            this.btnNghiPhep.Location = new System.Drawing.Point(310, 88);
            this.btnNghiPhep.Name = "btnNghiPhep";
            this.btnNghiPhep.Size = new System.Drawing.Size(110, 28);
            this.btnNghiPhep.TabIndex = 5;
            this.btnNghiPhep.Text = "🏖️ Nghỉ Phép";
            this.btnNghiPhep.UseVisualStyleBackColor = false;
            this.btnNghiPhep.Click += new System.EventHandler(this.btnNghiPhep_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnTaiLai);
            this.panel1.Controls.Add(this.btnLoc);
            this.panel1.Location = new System.Drawing.Point(10, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 40);
            this.panel1.TabIndex = 1;
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(0, 8);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(140, 28);
            this.btnLoc.TabIndex = 0;
            this.btnLoc.Text = "🔍 Lọc Theo Tháng";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(150, 8);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 28);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "🗑️ Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Location = new System.Drawing.Point(250, 8);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(90, 28);
            this.btnTaiLai.TabIndex = 2;
            this.btnTaiLai.Text = "🔃 Tải lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(760, 330);
            this.dataGridView1.TabIndex = 2;
            // 
            // FormChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 530);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormChamCong";
            this.Text = "Quản Lý Chấm Công";
            this.Load += new System.EventHandler(this.FormChamCong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnCoMat;
        private System.Windows.Forms.Button btnVang;
        private System.Windows.Forms.Button btnNghiPhep;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}