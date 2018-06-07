using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHang.Controller
{
    public static class Connecction
    {
        public static string NameLogin = ""; //tên đăng nhập vào hệ thống sau khi đăng nhập xong sql 
        public static string SeverName = "";
        public static string DatabaseName = "";
        public static string UserName = ""; //tên đăng nhập sql
        public static string PassWord;
        public static bool WindowAuthentication = true;

        public static string ConnectionString = "";

        public static void MakeConnectionString()
        {
            string temp = "";
            temp = "Data Source=" + SeverName + ";Initial Catalog=" + DatabaseName + "";

            if (WindowAuthentication == true)
            {
                temp = temp + ";Integrated Security=true";
            }
            else
            {
                temp = temp + ";Integrated Security = false; User ID= " + UserName + ";" + "Password =" + PassWord;
            }
            ConnectionString = temp;
        }
    }
}
