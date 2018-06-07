using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace QuanLyKhoHang
{
    public partial class frmDangNhap_CSDL : Form
    {
        public frmDangNhap_CSDL()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenMayChu.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ tên máy chủ");
                ActiveControl = txtTenMayChu;
                return;
            }
            if (txtTenCSDL.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tên CSDL");
                ActiveControl = txtTenCSDL;
                return;
            }
            string connect = "";
            Controller.Connecction.SeverName = txtTenMayChu.Text.Trim();
            Controller.Connecction.DatabaseName = txtTenCSDL.Text.Trim();
            if (Controller.Connecction.WindowAuthentication == true)
            {
                Controller.Connecction.MakeConnectionString();
                connect = Controller.Connecction.ConnectionString;
            }
            else
            {
                if (txtTenDangNhap.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn phải nhập tên đăng nhập");
                    ActiveControl = txtTenDangNhap;
                    return;
                }
                if (txtMK.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn phải nhập mật khẩu");
                    ActiveControl = txtMK;
                    return;
                }
                Controller.Connecction.UserName = txtTenDangNhap.Text.Trim();
                Controller.Connecction.PassWord = txtMK.Text.Trim();
                Controller.Connecction.MakeConnectionString();

                connect = Controller.Connecction.ConnectionString;
            }
            // show connect
            try
            {
                SqlConnection conn = new SqlConnection(connect);
                conn.Open();

                if (conn.State == ConnectionState.Open)
                {
                    //MessageBox.Show("Kết nối thành công");
                    using (StreamWriter write = new StreamWriter("config"))
                    {
                        write.WriteLine(Controller.Connecction.SeverName);
                        write.WriteLine(Controller.Connecction.DatabaseName);
                        write.WriteLine(Controller.Connecction.UserName);
                        write.WriteLine(Controller.Connecction.PassWord);
                    }
                    frmDangNhap dangnhap = new frmDangNhap();
                    this.Hide();
                    dangnhap.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Kết nối thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbxChonTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxChonTaiKhoan.SelectedIndex == 0)
            {
                Controller.Connecction.WindowAuthentication = true;
                txtTenDangNhap.Enabled = false;
                txtMK.Enabled = false;
            }
            else
            {
                Controller.Connecction.WindowAuthentication = false;
                txtTenDangNhap.Enabled = true;
                txtMK.Enabled = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_CSDL_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Enabled = false;
            txtMK.Enabled = false;
        }

    }
}
