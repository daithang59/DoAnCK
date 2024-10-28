using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_UIDangKy
{
    internal class TaiKhoan
    {
        private string tentk;
        private string matkhau;
        public TaiKhoan(string tentk, string matkhau)
        {
            this.tentk = tentk;
            this.matkhau = matkhau;
        }
        public string TenTK
        {
            get { return tentk; }
            set { tentk = value; }
        }
        public string MatKhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }

        public TaiKhoan()
        {
        }
    }
}
