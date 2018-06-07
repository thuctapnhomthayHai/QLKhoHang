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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Controller.Connecction.ConnectionString);
                conn.Open();

                string sql = "select *from TaiKhoan where acc = '" + txtUserName.Text.Trim() + "' and pass = '" + txtPassWord.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader dta = cmd.ExecuteReader();

                if (dta.Read() == true)
                {
                    Controller.Connecction.NameLogin = txtUserName.Text.Trim();

                    if (cbxNhoTaiKhoan.Checked == true)
                    {
                        using (StreamWriter wr = new StreamWriter("info.ini"))
                        {
                            wr.WriteLine(txtUserName.Text.Trim());
                            wr.WriteLine(txtPassWord.Text.Trim());
                            wr.Close();
                        }
                    }
                    else
                    {
                        File.Delete("info.ini");
                    }
                    Views.frmMain m = new Views.frmMain();
                    this.Hide();
                    m.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
