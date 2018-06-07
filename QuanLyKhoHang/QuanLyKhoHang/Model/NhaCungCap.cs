using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHang.Model
{
   public class NhaCungCap
    {
        private string maNCC;
        private string tenNCC;
        private string diaChi;
        private string SDT;
        private string email;

        public string MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }
        public string TenNCC
        {
            get { return tenNCC; }
            set { tenNCC = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public string sdt
        {
            get { return SDT; }
            set { SDT = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
