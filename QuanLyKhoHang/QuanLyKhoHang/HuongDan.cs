using System;
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
    public partial class HuongDan : Form
    {
        public HuongDan()
        {
            InitializeComponent();
        }

        private void HuongDan_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainMenu mn = new MainMenu();
            mn.ShowDialog();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "Nhà cung cấp")
                webBrowser1.Navigate(@"D:\Kỳ 6\Thực tập nhóm_TH14\QLKhoHang\QuanLyKhoHang\QuanLyKhoHang\Guide\Nhacungcap.html");
            if (e.Node.Text == "Khách hàng")
                webBrowser1.Navigate(@"D:\Kỳ 6\Thực tập nhóm_TH14\QLKhoHang\QuanLyKhoHang\QuanLyKhoHang\Guide\Khachhang.html");
            if (e.Node.Text == "Sản phẩm")
                webBrowser1.Navigate(@"D:\Kỳ 6\Thực tập nhóm_TH14\QLKhoHang\QuanLyKhoHang\QuanLyKhoHang\Guide\Sanpham.html");
            if (e.Node.Text == "Phiếu xuất")
                webBrowser1.Navigate(@"D:\Kỳ 6\Thực tập nhóm_TH14\QLKhoHang\QuanLyKhoHang\QuanLyKhoHang\Guide\Phieuxuat.html");
            if (e.Node.Text == "Phiếu nhập")
                webBrowser1.Navigate(@"D:\Kỳ 6\Thực tập nhóm_TH14\QLKhoHang\QuanLyKhoHang\QuanLyKhoHang\Guide\Phieunhap.html");
            if (e.Node.Text == "Nhân viên")
                webBrowser1.Navigate(@"D:\Kỳ 6\Thực tập nhóm_TH14\QLKhoHang\QuanLyKhoHang\QuanLyKhoHang\Guide\NhanVien.html");
        }
    }
}
