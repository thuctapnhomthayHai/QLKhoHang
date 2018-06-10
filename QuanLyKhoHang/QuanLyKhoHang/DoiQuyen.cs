using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyKhoHang
{
    public partial class DoiQuyen : Form
    {
        public static string USERNAME = "";
        public static string QuyenHan = "";
        Connection con = new Connection();
        public DoiQuyen()
        {
            InitializeComponent();
        }
        public DataTable QH(string USERNAME)
        {
            Connection con = new Connection();
            SqlDataReader a = con.ExecuteReader("SELECT QUYENHAN FROM DANGNHAP WHERE USERNAME='" + USERNAME + "'");
            while (a.Read())
            {
                QuyenHan = a["QUYENHAN"].ToString();

            }
            return null;
        }

        private void DoiQuyen_Load(object sender, EventArgs e)
        {
            con.AutoComplete(tbx_tdn, "SELECT USERNAME FROM DANGNHAP");
            con.AutoComplete(tbx_quyencu, "SELECT QUYENHAN FROM DANGNHAP");
            con.AutoComplete(tbx_quyenmoi, "SELECT QUYENHAN FROM DANGNHAP");
        }

        private void btn_dq_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            if (tbx_tdn.Text == null)
            {
                SqlDataReader reader = con.ExecuteReader("select QUYENHAN from DANGNHAP where USERNAME= '" + USERNAME + "'");
                while (reader.Read() == true)
                {
                    string sql = "update DANGNHAP set QUYENHAN ='" + tbx_quyenmoi.Text + "' where USERNAME ='" + USERNAME + "'";
                    if (tbx_quyencu.Text == "" || tbx_quyenmoi.Text == "")
                    {
                        MessageBox.Show("Yêu cầu điền đủ vào các mục");
                    }
                    else
                    {
                        if (tbx_quyenmoi.Text == tbx_quyencu.Text)
                        {
                            MessageBox.Show("Quyền Hạn mới phải khác Quyền Hạn cũ!");
                            tbx_quyenmoi.Clear();
                        }
                        else
                        {
                            if (con.executenonquery(sql) == true)
                            {
                                MessageBox.Show("Cập nhật quyền hạn thành công");
                                this.Hide();
                            }
                        }
                    }
                }
            }
            else
            {
                SqlDataReader reader = con.ExecuteReader("select QUYENHAN from DANGNHAP where USERNAME= '" + tbx_tdn.Text + "'");
                while (reader.Read() == true)
                {
                    string sql = "update DANGNHAP set QUYENHAN ='" + tbx_quyenmoi.Text + "' where USERNAME ='" + tbx_tdn.Text + "'";
                    if (tbx_quyencu.Text == "" || tbx_quyenmoi.Text == "")
                    {
                        MessageBox.Show("Yêu cầu điền đủ vào các mục");
                    }
                    else
                    {
                        if (tbx_quyenmoi.Text == tbx_quyencu.Text)
                        {
                            MessageBox.Show("Quyền Hạn mới phải khác Quyền Hạn cũ!");
                            tbx_quyenmoi.Clear();
                        }
                        else
                        {
                            if (con.executenonquery(sql) == true)
                            {
                                MessageBox.Show("Cập nhật quyền hạn thành công");
                                this.Hide();
                            }
                        }
                    }
                }
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Chắc Chắn Muốn Hủy Thao Tác?", "Xác Nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
            }
            else
            {

            }
        }

        private void tbx_tdn_Validated(object sender, EventArgs e)
        {
            if(tbx_tdn.Text == null)
            {
                tbx_tdn.Enabled = false;
                QH(USERNAME);
                tbx_quyencu.Text = QuyenHan.Trim();
            }
            else
            {
                QH(tbx_tdn.Text);
                tbx_quyencu.Text = QuyenHan.Trim();
            }
        }
    }
}
