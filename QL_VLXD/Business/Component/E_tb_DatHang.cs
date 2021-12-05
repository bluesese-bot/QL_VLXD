using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_VLXD.DataAccess;
using QL_VLXD.Business.EntitiesClass;
using System.Windows.Forms;

namespace QL_VLXD.Business.Component
{
    class E_tb_DatHang
    {
        SQL_tb_DatHang hdnsql = new SQL_tb_DatHang();
        public void themoihdn(EC_tb_DatHang hdn)
        {
            if (!hdnsql.kiemtraHDN(hdn.Maphieu))
            {
                hdnsql.themmoiHDN(hdn);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suahdn(EC_tb_DatHang hdn)
        {
            hdnsql.suaHDN(hdn);
        }
        public void xoahdn(EC_tb_DatHang hdn)
        {
            hdnsql.xoaHDN(hdn);
        }
    }
}
