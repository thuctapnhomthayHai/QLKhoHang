using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang.Views
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void buttonItem8_Click(object sender, EventArgs e)
        {
            panelEx1.Controls.Clear();
            UserCtrolHangHoa us = new UserCtrolHangHoa();
                panelEx1.Controls.Add(us);
                panelEx1.Dock = DockStyle.Fill;
            //else if (ts.Text == "Sản phẩm")
            //    panelEx1.Controls.Add(new Sanpham());
            //else if (ts.Text == "Phiếu nhập")
            //    panelEx1.Controls.Add(new Phieunhap());
            //else if (ts.Text == "Phiếu xuất")
            //    panelEx1.Controls.Add(new Phieuxuat());
            //else if (ts.Text == "Hướng dẫn")
            //    panelEx1.Controls.Add(new Huongdan());
            //if (ts.Text == "Đăng xuất")
            //{
            //    frmDangNhap dn = new frmDangNhap();
            //    this.Close();
            //    dn.ShowDialog();
            //}
            //else if (ts.Text == "Thoát")
            //    Application.Exit();
        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {
            panelEx1.Controls.Clear();
            UserCtrolHangHoa us = new UserCtrolHangHoa();
            panelEx1.Controls.Add(us);
            panelEx1.Dock = DockStyle.Fill;
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
