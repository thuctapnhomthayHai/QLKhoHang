namespace QuanLyKhoHang
{
    partial class KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHang));
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGT = new System.Windows.Forms.TextBox();
            this.txtfax = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIENTHOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FAX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtdc = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTimKiem = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnIndanhsach = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "Email";
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Width = 150;
            // 
            // txtGT
            // 
            this.txtGT.Location = new System.Drawing.Point(154, 180);
            this.txtGT.Name = "txtGT";
            this.txtGT.Size = new System.Drawing.Size(194, 21);
            this.txtGT.TabIndex = 4;
            this.txtGT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtGT_KeyUp);
            // 
            // txtfax
            // 
            this.txtfax.Location = new System.Drawing.Point(154, 344);
            this.txtfax.Name = "txtfax";
            this.txtfax.Size = new System.Drawing.Size(194, 21);
            this.txtfax.TabIndex = 7;
            this.txtfax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfax_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(410, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(630, 413);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng";
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAKH,
            this.TENKH,
            this.DIACHI,
            this.GIOITINH,
            this.DIENTHOAI,
            this.EMAIL,
            this.FAX});
            this.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView.Location = new System.Drawing.Point(3, 18);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(624, 392);
            this.DataGridView.TabIndex = 0;
            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellContentClick);
            // 
            // MAKH
            // 
            this.MAKH.DataPropertyName = "MAKH";
            this.MAKH.HeaderText = "Mã khách hàng";
            this.MAKH.Name = "MAKH";
            this.MAKH.Width = 120;
            // 
            // TENKH
            // 
            this.TENKH.DataPropertyName = "TENKH";
            this.TENKH.HeaderText = "Tên khách hàng";
            this.TENKH.Name = "TENKH";
            this.TENKH.Width = 120;
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa chỉ";
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Width = 120;
            // 
            // GIOITINH
            // 
            this.GIOITINH.DataPropertyName = "GIOITINH";
            this.GIOITINH.HeaderText = "Giới tính";
            this.GIOITINH.Name = "GIOITINH";
            // 
            // DIENTHOAI
            // 
            this.DIENTHOAI.DataPropertyName = "DIENTHOAI";
            this.DIENTHOAI.HeaderText = "SĐT";
            this.DIENTHOAI.Name = "DIENTHOAI";
            // 
            // FAX
            // 
            this.FAX.DataPropertyName = "FAX";
            this.FAX.HeaderText = "Fax";
            this.FAX.Name = "FAX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Giới tính";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(154, 291);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(194, 21);
            this.txtemail.TabIndex = 6;
            this.txtemail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtemail_KeyUp);
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(154, 232);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(194, 21);
            this.txtsdt.TabIndex = 5;
            this.txtsdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsdt_KeyPress);
            this.txtsdt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtsdt_KeyUp);
            // 
            // txtdc
            // 
            this.txtdc.Location = new System.Drawing.Point(154, 130);
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(194, 21);
            this.txtdc.TabIndex = 3;
            this.txtdc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtdc_KeyUp);
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(154, 92);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(194, 21);
            this.txtten.TabIndex = 2;
            this.txtten.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtten_KeyUp);
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(154, 46);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(194, 21);
            this.txtma.TabIndex = 1;
            this.txtma.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtma_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "SĐT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.txtGT);
            this.groupBox1.Controls.Add(this.txtfax);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.txtsdt);
            this.groupBox1.Controls.Add(this.txtdc);
            this.groupBox1.Controls.Add(this.txtten);
            this.groupBox1.Controls.Add(this.txtma);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 413);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Fax";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách hàng";
            // 
            // cbTimKiem
            // 
            this.cbTimKiem.FormattingEnabled = true;
            this.cbTimKiem.ItemHeight = 13;
            this.cbTimKiem.Location = new System.Drawing.Point(583, 27);
            this.cbTimKiem.Name = "cbTimKiem";
            this.cbTimKiem.Size = new System.Drawing.Size(121, 21);
            this.cbTimKiem.TabIndex = 34;
            this.cbTimKiem.SelectedIndexChanged += new System.EventHandler(this.cbTimKiem_SelectedIndexChanged);
            this.cbTimKiem.Click += new System.EventHandler(this.cbTimKiem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(444, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Tìm kiếm theo";
            // 
            // btnIndanhsach
            // 
            this.btnIndanhsach.Image = global::QuanLyKhoHang.Properties.Resources.if_export_17365;
            this.btnIndanhsach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIndanhsach.Location = new System.Drawing.Point(585, 19);
            this.btnIndanhsach.Name = "btnIndanhsach";
            this.btnIndanhsach.Padding = new System.Windows.Forms.Padding(3);
            this.btnIndanhsach.Size = new System.Drawing.Size(134, 39);
            this.btnIndanhsach.TabIndex = 14;
            this.btnIndanhsach.Text = "In danh sách";
            this.btnIndanhsach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIndanhsach.UseVisualStyleBackColor = true;
            this.btnIndanhsach.Click += new System.EventHandler(this.btnIndanhsach_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btnIndanhsach);
            this.groupBox3.Controls.Add(this.btnHuy);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnLuu);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Location = new System.Drawing.Point(211, 528);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(774, 85);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(734, 27);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(117, 20);
            this.txtTimKiem.TabIndex = 28;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(857, 19);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(111, 42);
            this.btnTim.TabIndex = 29;
            this.btnTim.Text = "Tìm Kiếm";
            this.btnTim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // button1
            // 
            this.button1.Image = global::QuanLyKhoHang.Properties.Resources.Huy1;
            this.button1.Location = new System.Drawing.Point(469, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 13;
            this.button1.Text = "Thoát";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = global::QuanLyKhoHang.Properties.Resources.Huy1;
            this.btnHuy.Location = new System.Drawing.Point(372, 19);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 39);
            this.btnHuy.TabIndex = 12;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLyKhoHang.Properties.Resources.delete;
            this.btnXoa.Location = new System.Drawing.Point(280, 19);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 39);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::QuanLyKhoHang.Properties.Resources.tick;
            this.btnLuu.Location = new System.Drawing.Point(199, 19);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 39);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QuanLyKhoHang.Properties.Resources.edit;
            this.btnSua.Location = new System.Drawing.Point(118, 19);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 39);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QuanLyKhoHang.Properties.Resources.plus;
            this.btnThem.Location = new System.Drawing.Point(37, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 39);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 632);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.cbTimKiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtTimKiem);
            this.Name = "KhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KhachHang";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.TextBox txtGT;
        private System.Windows.Forms.TextBox txtfax;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIENTHOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn FAX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtdc;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ComboBox cbTimKiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnIndanhsach;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}