namespace QuanLyKhoHang
{
    partial class ThemTaiKhoan
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
            this.dgvThemTK = new System.Windows.Forms.DataGridView();
            this.tbx_MaNV = new System.Windows.Forms.ComboBox();
            this.tbx_QuyenHan = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbx_timkiem = new System.Windows.Forms.TextBox();
            this.tbx_MK = new System.Windows.Forms.TextBox();
            this.tbx_TDN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_timkiem = new System.Windows.Forms.Button();
            this.btn_ghinhan = new System.Windows.Forms.Button();
            this.bt_lammoi = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemTK)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvThemTK
            // 
            this.dgvThemTK.AllowUserToAddRows = false;
            this.dgvThemTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThemTK.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvThemTK.Location = new System.Drawing.Point(6, 95);
            this.dgvThemTK.MultiSelect = false;
            this.dgvThemTK.Name = "dgvThemTK";
            this.dgvThemTK.RowHeadersVisible = false;
            this.dgvThemTK.Size = new System.Drawing.Size(633, 221);
            this.dgvThemTK.TabIndex = 0;
            this.dgvThemTK.TabStop = false;
            this.dgvThemTK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThemTK_CellContentClick);
            this.dgvThemTK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvThemTK_KeyDown);
            // 
            // tbx_MaNV
            // 
            this.tbx_MaNV.FormattingEnabled = true;
            this.tbx_MaNV.Location = new System.Drawing.Point(431, 19);
            this.tbx_MaNV.Name = "tbx_MaNV";
            this.tbx_MaNV.Size = new System.Drawing.Size(158, 27);
            this.tbx_MaNV.TabIndex = 2;
            // 
            // tbx_QuyenHan
            // 
            this.tbx_QuyenHan.Location = new System.Drawing.Point(431, 49);
            this.tbx_QuyenHan.Name = "tbx_QuyenHan";
            this.tbx_QuyenHan.Size = new System.Drawing.Size(119, 26);
            this.tbx_QuyenHan.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_timkiem);
            this.groupBox2.Controls.Add(this.tbx_timkiem);
            this.groupBox2.Controls.Add(this.dgvThemTK);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(645, 327);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Tài Khoản";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tbx_timkiem
            // 
            this.tbx_timkiem.Location = new System.Drawing.Point(82, 35);
            this.tbx_timkiem.Name = "tbx_timkiem";
            this.tbx_timkiem.Size = new System.Drawing.Size(228, 26);
            this.tbx_timkiem.TabIndex = 9;
            // 
            // tbx_MK
            // 
            this.tbx_MK.Location = new System.Drawing.Point(149, 53);
            this.tbx_MK.Name = "tbx_MK";
            this.tbx_MK.Size = new System.Drawing.Size(117, 26);
            this.tbx_MK.TabIndex = 1;
            // 
            // tbx_TDN
            // 
            this.tbx_TDN.Location = new System.Drawing.Point(149, 23);
            this.tbx_TDN.Name = "tbx_TDN";
            this.tbx_TDN.Size = new System.Drawing.Size(117, 26);
            this.tbx_TDN.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mật Khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên Đăng Nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quyền Hạn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_MaNV);
            this.groupBox1.Controls.Add(this.btn_ghinhan);
            this.groupBox1.Controls.Add(this.bt_lammoi);
            this.groupBox1.Controls.Add(this.bt_xoa);
            this.groupBox1.Controls.Add(this.bt_Sua);
            this.groupBox1.Controls.Add(this.tbx_QuyenHan);
            this.groupBox1.Controls.Add(this.bt_them);
            this.groupBox1.Controls.Add(this.tbx_MK);
            this.groupBox1.Controls.Add(this.tbx_TDN);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-4, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 142);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "QT Tài Khoản";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bt_timkiem
            // 
            this.bt_timkiem.Image = global::QuanLyKhoHang.Properties.Resources.search;
            this.bt_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_timkiem.Location = new System.Drawing.Point(373, 29);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(113, 36);
            this.bt_timkiem.TabIndex = 10;
            this.bt_timkiem.Text = "Tìm Kiếm";
            this.bt_timkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_timkiem.UseVisualStyleBackColor = true;
            this.bt_timkiem.Click += new System.EventHandler(this.bt_timkiem_Click);
            // 
            // btn_ghinhan
            // 
            this.btn_ghinhan.Image = global::QuanLyKhoHang.Properties.Resources.tick;
            this.btn_ghinhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ghinhan.Location = new System.Drawing.Point(318, 102);
            this.btn_ghinhan.Name = "btn_ghinhan";
            this.btn_ghinhan.Size = new System.Drawing.Size(111, 37);
            this.btn_ghinhan.TabIndex = 7;
            this.btn_ghinhan.Text = "Ghi Nhận";
            this.btn_ghinhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ghinhan.UseVisualStyleBackColor = true;
            this.btn_ghinhan.Click += new System.EventHandler(this.btn_ghinhan_Click);
            // 
            // bt_lammoi
            // 
            this.bt_lammoi.Image = global::QuanLyKhoHang.Properties.Resources.reset;
            this.bt_lammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_lammoi.Location = new System.Drawing.Point(488, 102);
            this.bt_lammoi.Name = "bt_lammoi";
            this.bt_lammoi.Size = new System.Drawing.Size(109, 34);
            this.bt_lammoi.TabIndex = 8;
            this.bt_lammoi.Text = "Làm Mới";
            this.bt_lammoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_lammoi.UseVisualStyleBackColor = true;
            this.bt_lammoi.Click += new System.EventHandler(this.bt_lammoi_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Image = global::QuanLyKhoHang.Properties.Resources.delete;
            this.bt_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_xoa.Location = new System.Drawing.Point(230, 102);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(68, 34);
            this.bt_xoa.TabIndex = 6;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_Sua
            // 
            this.bt_Sua.Image = global::QuanLyKhoHang.Properties.Resources.edit;
            this.bt_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Sua.Location = new System.Drawing.Point(122, 102);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(75, 34);
            this.bt_Sua.TabIndex = 5;
            this.bt_Sua.Text = "Sửa";
            this.bt_Sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Sua.UseVisualStyleBackColor = true;
            this.bt_Sua.Click += new System.EventHandler(this.bt_Sua_Click);
            // 
            // bt_them
            // 
            this.bt_them.Image = global::QuanLyKhoHang.Properties.Resources.plus;
            this.bt_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_them.Location = new System.Drawing.Point(11, 102);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(85, 34);
            this.bt_them.TabIndex = 4;
            this.bt_them.Text = "Thêm";
            this.bt_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // ThemTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 488);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThemTaiKhoan";
            this.Text = "ThemTaiKhoan";
            this.Load += new System.EventHandler(this.ThemTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemTK)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThemTK;
        private System.Windows.Forms.ComboBox tbx_MaNV;
        private System.Windows.Forms.Button btn_ghinhan;
        private System.Windows.Forms.Button bt_lammoi;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_Sua;
        private System.Windows.Forms.TextBox tbx_QuyenHan;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_timkiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbx_timkiem;
        private System.Windows.Forms.TextBox tbx_MK;
        private System.Windows.Forms.TextBox tbx_TDN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}