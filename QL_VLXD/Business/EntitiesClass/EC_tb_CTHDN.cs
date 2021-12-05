using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_VLXD.Business.EntitiesClass
{
    class EC_tb_CTHDN
    {
        private string mahdn;
        private string masp;
        private string sl;
        private string donvi;
        private string dongia;
        private string thanhtien;
        public string Mahdn {
            get
            {
                return mahdn;
            }
            set
            {
                mahdn = value;
                if (mahdn == "")
                {
                    throw new Exception("Mã không để trống");
                }
            }
        }
        public string Masp { get => masp; set => masp = value; }
        public string Sl { get => sl; set => sl = value; }
        public string Donvi { get => donvi; set => donvi = value; }
        public string Dongia { get => dongia; set => dongia = value; }
        public string Thanhtien { get => thanhtien; set => thanhtien = value; }
    }
}
