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
    public partial class PhieuNhap : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SNTR6UK;Initial Catalog=QLKH;Integrated Security=True");
        public PhieuNhap()
        {
            InitializeComponent();
        }
        public void Show()
        {
            con.Open();
            string sql = "SELECT *FROM PHIEUNHAPKHO";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "INSERT INTO PHIEUNHAPKHO VALUES (@MAPN, @MAKHO, @NVNHAP, @NGAYNHAP, @MANCC, @GHICHU)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MAPN",txt_maPN.Text);
            cmd.Parameters.AddWithValue("MAKHO", txt_khohang.Text);
            cmd.Parameters.AddWithValue("NVNHAP", txt_NV.Text);
            cmd.Parameters.AddWithValue("NGAYNHAP", Txt_ngaynhap.Text);
            cmd.Parameters.AddWithValue("MANCC", txt_nhacungcap.Text);
            cmd.Parameters.AddWithValue("GHICHU", txt_ghichu.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "UPDATE PHIEUNHAPKHO SET MAKHO = @MAKHO, NVNHAP = @NVNHAP, NGAYNHAP = @NGAYNHAP, MANCC = @MANCC, GHICHU = @GHICHU WHERE MAPN = @MAPN";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MAPN", txt_maPN.Text);
            cmd.Parameters.AddWithValue("MAKHO", txt_khohang.Text);
            cmd.Parameters.AddWithValue("NVNHAP", txt_NV.Text);
            cmd.Parameters.AddWithValue("NGAYNHAP", Txt_ngaynhap.Text);
            cmd.Parameters.AddWithValue("MANCC", txt_nhacungcap.Text);
            cmd.Parameters.AddWithValue("GHICHU", txt_ghichu.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "DELETE FROM PHIEUNHAPKHO WHERE MAPN = @MAPN";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MAPN", txt_maPN.Text);
            cmd.Parameters.AddWithValue("MAKHO", txt_khohang.Text);
            cmd.Parameters.AddWithValue("NVNHAP", txt_NV.Text);
            cmd.Parameters.AddWithValue("NGAYNHAP", Txt_ngaynhap.Text);
            cmd.Parameters.AddWithValue("MANCC", txt_nhacungcap.Text);
            cmd.Parameters.AddWithValue("GHICHU", txt_ghichu.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "SELECT FROM PHIEUNHAPKHO WHERE MAPN = @MAPN";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MAPN", txtTimKIem.Text);
            cmd.Parameters.AddWithValue("MAKHO", txt_khohang.Text);
            cmd.Parameters.AddWithValue("NVNHAP", txt_NV.Text);
            cmd.Parameters.AddWithValue("NGAYNHAP", Txt_ngaynhap.Text);
            cmd.Parameters.AddWithValue("MANCC", txt_nhacungcap.Text);
            cmd.Parameters.AddWithValue("GHICHU", txt_ghichu.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PhieuNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
