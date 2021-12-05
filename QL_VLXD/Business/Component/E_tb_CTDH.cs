using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_VLXD.Business.EntitiesClass;
using QL_VLXD.DataAccess;
using System.Windows.Forms;

namespace QL_VLXD.Business.Component
{
    class E_tb_CTDH
    {
        SQL_tb_CTDH cthdnsql = new SQL_tb_CTDH();
        public void themoicthdn(EC_tb_CTDH cthdn)
        {
            if (!cthdnsql.kiemtratb_CTHDN(cthdn.Maphieu, cthdn.Msp))
            {
                cthdnsql.themmoicthdb(cthdn);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suacthdn(EC_tb_CTDH cthdn)
        {
            cthdnsql.suacthdb(cthdn);
        }
        public void xoacthdn(EC_tb_CTDH cthdn)
        {
            cthdnsql.xoacthdb(cthdn);
        }

        //load mã sản phẩm

        public void loadmasp(ComboBox cbsp)
        {
            cthdnsql.loadmasp(cbsp);
        }
        public string loadtensp(string Tensp, string Masp)
        {
            Tensp = cthdnsql.Loadtenhang(Tensp, Masp);
            return Tensp;
        }
    }
}
