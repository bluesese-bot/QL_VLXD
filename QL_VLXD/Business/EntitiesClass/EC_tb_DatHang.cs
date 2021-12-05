using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_VLXD.Business.EntitiesClass
{
    class EC_tb_DatHang
    {
        private string maphieu;
        private string tenkh;
        private string sdt;
        private string ghichu;

        public string Maphieu { get => maphieu; set => maphieu = value; }
        public string Tenkh { get => tenkh; set => tenkh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
    }
}
