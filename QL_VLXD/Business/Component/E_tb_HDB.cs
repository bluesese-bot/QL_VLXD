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
    class E_tb_HDB
    {
        SQL_tb_HDB hdnsql = new SQL_tb_HDB();
        public void themoihdn(EC_tb_HDB hdn)
        {
            if (!hdnsql.kiemtraHDN(hdn.Mahd))
            {
                hdnsql.themmoiHDN(hdn);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suahdn(EC_tb_HDB hdn)
        {
            hdnsql.suaHDN(hdn);
        }
        public void xoahdn(EC_tb_HDB hdn)
        {
            hdnsql.xoaHDN(hdn);
        }
        //load khách
        public void loadmanv(ComboBox cbncc)
        {
            hdnsql.loadmanv(cbncc);
        }
        public string loadtennv(string Tenncc, string Mancc)
        {
            Tenncc = hdnsql.Loadtennv(Tenncc, Mancc);
            return Tenncc;
        }
    }
}
