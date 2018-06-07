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
            ToolStripDropDownItem ts = (ToolStripDropDownItem)sender;
            if (ts.Text == "Quản lý nhà cung cấp")
                panelEx1.Controls.Add(new NhaCungCap());
            else if (ts.Text == "Quản lý hàng hóa")
                panelEx1.Controls.Add(new HangHoa());
            //else if (ts.Text == "Sản phẩm")
            //    panelEx1.Controls.Add(new Sanpham());
            //else if (ts.Text == "Phiếu nhập")
            //    panelEx1.Controls.Add(new Phieunhap());
            //else if (ts.Text == "Phiếu xuất")
            //    panelEx1.Controls.Add(new Phieuxuat());
            //else if (ts.Text == "Hướng dẫn")
            //    panelEx1.Controls.Add(new Huongdan());
            else if (ts.Text == "Đăng xuất")
            {
                frmDangNhap dn = new frmDangNhap();
                this.Close();
                dn.ShowDialog();
            }
            else if (ts.Text == "Thoát")
                Application.Exit();
        }
    }
}
