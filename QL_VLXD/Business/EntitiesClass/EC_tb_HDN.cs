using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_VLXD.Business.EntitiesClass
{
    class EC_tb_HDN
    {
        private string mahd;
        private string mancc;
        private string ngaynhap;
        private string tongtien;
        private string ghichu;

        public string Mahd
        {
            get
            {
                return mahd;
            }
            set
            {
                mahd = value;
                if (mahd == "")
                {
                    throw new Exception("Mã không để trống");
                }
            }
        }
        public string Mancc { get => mancc; set => mancc = value; }
        public string Ngaynhap { get => ngaynhap; set => ngaynhap = value; }
        public string Tongtien { get => tongtien; set => tongtien = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
        
    }
}
