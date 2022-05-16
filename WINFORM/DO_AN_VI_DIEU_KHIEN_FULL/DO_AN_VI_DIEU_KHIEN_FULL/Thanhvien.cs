using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_AN_VI_DIEU_KHIEN_FULL
{
    public class Thanhvien : People
    {
        private string taikhoan;
        private string matkhau;
        public string Taikhoan
        {
            get { return taikhoan; }
            set { taikhoan = value; }
        }
        public string Matkhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }
        public Thanhvien()
        {
            taikhoan = "THAI VAN SANG";
            matkhau = "sangdeptrai";
        }
        public Thanhvien(string taikhoan, string matkhau)
        {
            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
        }
    }
}
