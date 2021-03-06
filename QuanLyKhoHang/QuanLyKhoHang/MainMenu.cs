﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang
{
    public partial class MainMenu : Form
    {
        public static string Quyenhan = "";
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btn_nhanv_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhanVien nhanvien = new NhanVien();
            nhanvien.ShowDialog();
        }

        private void btn_luong_Click(object sender, EventArgs e)
        {
            this.Hide();
            BoPhan nhanvien = new BoPhan();
            nhanvien.ShowDialog();
        }

        private void btn_danhmuc_Click(object sender, EventArgs e)
        {
            this.Hide();
            DanhMucSP nhanvien = new DanhMucSP();
            nhanvien.ShowDialog();
        }

        private void btn_xuatnhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhapXuat nhanvien = new NhapXuat();
            nhanvien.ShowDialog();
        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            this.Hide();
            KhachHang KH = new KhachHang();
            KH.Show();
        }

        private void btn_khohang_Click(object sender, EventArgs e)
        {
            this.Hide();
            KhoHang nhanvien = new KhoHang();
            nhanvien.ShowDialog();
        }

        private void btn_nhacc_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhaCC ncc = new NhaCC();
            ncc.ShowDialog();
        }

        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            this.Hide();
            SANPHAM nhanvien = new SANPHAM();
            nhanvien.ShowDialog();
        }

        private void btn_baocao_Click(object sender, EventArgs e)
        {
            this.Hide();
            HuongDan nhanvien = new HuongDan();
            nhanvien.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn Phải là ADMIN thì mới đổi được mật khẩu cho tài khoản khác!");
            Doimatkhau dmk = new Doimatkhau();
            dmk.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void ngườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NguoiDung ND = new NguoiDung();
            ND.ShowDialog();
        }

        private void đổiQuyềnHạnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Quyenhan.Trim() == "ADMIN" || Quyenhan.Trim() == "Admin" || Quyenhan.Trim() == "admin")
            {
                DoiQuyen quyen = new DoiQuyen();
                quyen.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn Phải là ADMIN thì mới thực hiện được thao tác này!");
            } 
        }

        private void btn_huongdan_Click(object sender, EventArgs e)
        {
            this.Hide();
            HuongDan hd = new HuongDan();
            hd.ShowDialog();
        }
    }
}
