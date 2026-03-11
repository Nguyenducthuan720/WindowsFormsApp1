namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.heThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phongBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chucVuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nghiepVuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chamCongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tinhLuongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongKeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baoCaoNhanSuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heThongToolStripMenuItem,
            this.quanLyToolStripMenuItem,
            this.nghiepVuToolStripMenuItem,
            this.thongKeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // heThongToolStripMenuItem
            // 
            this.heThongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoatToolStripMenuItem});
            this.heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            this.heThongToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.heThongToolStripMenuItem.Text = "Hệ Thống";
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // quanLyToolStripMenuItem
            // 
            this.quanLyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhanVienToolStripMenuItem,
            this.phongBanToolStripMenuItem,
            this.chucVuToolStripMenuItem});
            this.quanLyToolStripMenuItem.Name = "quanLyToolStripMenuItem";
            this.quanLyToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.quanLyToolStripMenuItem.Text = "Quản Lý";
            // 
            // nhanVienToolStripMenuItem
            // 
            this.nhanVienToolStripMenuItem.Name = "nhanVienToolStripMenuItem";
            this.nhanVienToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nhanVienToolStripMenuItem.Text = "Nhân Viên";
            this.nhanVienToolStripMenuItem.Click += new System.EventHandler(this.nhanVienToolStripMenuItem_Click);
            // 
            // phongBanToolStripMenuItem
            // 
            this.phongBanToolStripMenuItem.Name = "phongBanToolStripMenuItem";
            this.phongBanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.phongBanToolStripMenuItem.Text = "Phòng Ban";
            this.phongBanToolStripMenuItem.Click += new System.EventHandler(this.phongBanToolStripMenuItem_Click);
            // 
            // chucVuToolStripMenuItem
            // 
            this.chucVuToolStripMenuItem.Name = "chucVuToolStripMenuItem";
            this.chucVuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chucVuToolStripMenuItem.Text = "Chức Vụ";
            this.chucVuToolStripMenuItem.Click += new System.EventHandler(this.chucVuToolStripMenuItem_Click);
            // 
            // nghiepVuToolStripMenuItem
            // 
            this.nghiepVuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chamCongToolStripMenuItem,
            this.tinhLuongToolStripMenuItem});
            this.nghiepVuToolStripMenuItem.Name = "nghiepVuToolStripMenuItem";
            this.nghiepVuToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.nghiepVuToolStripMenuItem.Text = "Nghiệp Vụ";
            this.nghiepVuToolStripMenuItem.Click += new System.EventHandler(this.nghiepVuToolStripMenuItem_Click);
            // 
            // chamCongToolStripMenuItem
            // 
            this.chamCongToolStripMenuItem.Name = "chamCongToolStripMenuItem";
            this.chamCongToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chamCongToolStripMenuItem.Text = "Chấm Công";
            this.chamCongToolStripMenuItem.Click += new System.EventHandler(this.chamCongToolStripMenuItem_Click);
            // 
            // tinhLuongToolStripMenuItem
            // 
            this.tinhLuongToolStripMenuItem.Name = "tinhLuongToolStripMenuItem";
            this.tinhLuongToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tinhLuongToolStripMenuItem.Text = "Tính Lương";
            this.tinhLuongToolStripMenuItem.Click += new System.EventHandler(this.tinhLuongToolStripMenuItem_Click);
            // 
            // thongKeToolStripMenuItem
            // 
            this.thongKeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baoCaoNhanSuToolStripMenuItem});
            this.thongKeToolStripMenuItem.Name = "thongKeToolStripMenuItem";
            this.thongKeToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.thongKeToolStripMenuItem.Text = "Thống Kê";
            // 
            // baoCaoNhanSuToolStripMenuItem
            // 
            this.baoCaoNhanSuToolStripMenuItem.Name = "baoCaoNhanSuToolStripMenuItem";
            this.baoCaoNhanSuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.baoCaoNhanSuToolStripMenuItem.Text = "Báo Cáo Nhân Sự";
            this.baoCaoNhanSuToolStripMenuItem.Click += new System.EventHandler(this.baoCaoNhanSuToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 537);
            this.panel1.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(0, 200);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(160, 40);
            this.button5.TabIndex = 4;
            this.button5.Text = "💰  Tính Lương";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 160);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "📅  Chấm Công";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 120);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "🏅  Chức Vụ";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "🏢  Phòng Ban";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "👤  Nhân Viên";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(160, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(824, 537);
            this.panel2.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Quản Lý Nhân Sự";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem heThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phongBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chucVuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nghiepVuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chamCongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tinhLuongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongKeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baoCaoNhanSuToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
    }
}