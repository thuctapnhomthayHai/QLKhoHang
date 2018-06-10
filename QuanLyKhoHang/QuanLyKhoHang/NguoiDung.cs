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
    public partial class NguoiDung : Form
    {
        Connection con = new Connection();
        public static string QuyenHan = "";
        public static string TenDangNhap = "";
        public static string filepath = "";
        private string filename;
        private string filepaths;
        private string MaNV;
        public NguoiDung()
        {
            InitializeComponent();
        }
     public DataTable NV(string UN)
        {
            Connection con = new Connection();
            SqlDataReader a = con.ExecuteReader("select MANV from DANGNHAP where USERNAME ='" +UN +"' ");
            while (a.Read())
            {
                MaNV = a["MANV"].ToString().Trim();
            }
            return null;
        }
        public DataTable SelectThongTin(string TDN )
     {
         SqlDataReader a = con.ExecuteReader("select TENNV,NS,GT,DIENTHOAI,CHUCVU,HINHANH from NHANVIEN,DANGNHAP where NHANVIEN.MANV = DANGNHAP.MANV AND DANGNHAP.USERNAME='" + TDN + "'");
         while (a.Read())
         {
             lbxNameUser.Text = a["TENNV"].ToString();
             string NS = a["NS"].ToString();
             DateTime dt = Convert.ToDateTime(NS);
             lbxNS.Text = dt.ToString("dd/MM/yyyy");
             lbxGT.Text = a["GT"].ToString();
             lbxDT.Text = a["DIENTHOAI"].ToString();
             lbxCV.Text = a["CHUCVU"].ToString();
             filename = a["HINHANH"].ToString();
             //if (filename == null || filename == "")
             //{
             //    pc_nguoidung.Image = null;
             //}
             //else
             //{
             //    filepath = Application.StartupPath + "\\Images\\" + filename;
             //    pc_nguoidung.Image = Image.FromFile(filepath.ToString());
             //    pc_nguoidung.SizeMode = PictureBoxSizeMode.StretchImage;
             //}

         }
         return null;
     }

        private void NguoiDung_Load(object sender, EventArgs e)
        {
            lbxUserName.Text = TenDangNhap;
            SelectThongTin(TenDangNhap);
            //pc_nguoidung.ImageLocation = filepath;
            //pc_nguoidung.SizeMode = PictureBoxSizeMode.StretchImage;
           // btn_luu.Enabled = false;
        }

        private void btThemUser_Click(object sender, EventArgs e)
        {
            if (QuyenHan.Trim() == "ADMIN" || QuyenHan.Trim() == "Admin" || QuyenHan.Trim() == "admin")
            {
                ThemTaiKhoan Them = new ThemTaiKhoan();
                Them.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn Phải là ADMIN thì mới thực hiện được thao tác này!");
            }
        }

        private void btn_file_Click(object sender, EventArgs e)
        {
            if (QuyenHan.Trim() == "ADMIN" || QuyenHan.Trim() == "Admin" || QuyenHan.Trim() == "admin")
            {
                ThemTaiKhoan Them = new ThemTaiKhoan();
                Them.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn Phải là ADMIN thì mới thực hiện được thao tác này!");
            }
        }

        //private void btn_luu_Click(object sender, EventArgs e)
        //{
        //    if (filepath.Length > 0)
        //    {
        //        NV(TenDangNhap);
        //        con.CapNhat_NguoiDung(MaNV, filename);
        //       // btn_luu.Enabled = false;
        //        filename = null;
        //    }
        //}
    }
}
