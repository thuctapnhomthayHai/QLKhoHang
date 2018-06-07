using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QuanLyKhoHang.Model;

namespace QuanLyKhoHang.Controller
{
    class NhaCungCap_Controller
    {
        SqlConnection conn = new SqlConnection(Controller.Connecction.ConnectionString);
        SqlCommand cmd = new SqlCommand();
        NhaCungCap NCCModel = new NhaCungCap();


        // lấy dữ liệu sử dụng câu lệnh
        public DataTable GetData(string strSql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strSql, conn);
            conn.Open();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        // lấy dữ liệu sử dụng thủ tục trong sql
        public DataTable GetData(string NameProc, SqlParameter[] para)
        {

            SqlCommand cmd = new SqlCommand(NameProc, conn);
            // cmd.CommandText = NameProc;
            cmd.CommandType = CommandType.StoredProcedure;
            if (para != null)
                cmd.Parameters.AddRange(para);
            //cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            conn.Open();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        // thực thi bằng thủ tục
        public int ExcuteSQL(string NameProc, SqlParameter[] para)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = NameProc;
            cmd.CommandType = CommandType.StoredProcedure;
            if (para != null)
            {
                cmd.Parameters.AddRange(para);
            }
            cmd.Connection = conn;
            conn.Open();
            int count = cmd.ExecuteNonQuery();
            conn.Close();
            return count;
        }

        public DataTable GetData()
        {
            return GetData("dbo.Xem_NCC", null);
        }

        public int InsertData(NhaCungCap NCC)
        {
            SqlParameter[] para =
            {
                new SqlParameter("maNCC",NCC.MaNCC),
                new SqlParameter("tenNCC",NCC.TenNCC),
                new SqlParameter("diaChi",NCC.DiaChi),
                new SqlParameter ("SDT",NCC.sdt),
                new SqlParameter ("email",NCC.Email)
            };
            return ExcuteSQL("dbo.them_NCC", para);
        }

        public int UpdateData(NhaCungCap NCC)
        {
            SqlParameter[] para =
            {
              new SqlParameter("maNCC",NCC.MaNCC),
                new SqlParameter("tenNCC",NCC.TenNCC),
                new SqlParameter("diaChi",NCC.DiaChi),
                new SqlParameter ("SDT",NCC.sdt),
                new SqlParameter ("email",NCC.Email)
        };
            return ExcuteSQL("dbo.sua_NCC", para);
        }

        public int DeleteData(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("maNCC",ID)
        };
            return ExcuteSQL("dbo.Xoa_NhaCungCap", para);
        }

        public DataTable TimKiemNCC(string strTimKiem)
        {
            return GetData(strTimKiem);
        }




    }
}
