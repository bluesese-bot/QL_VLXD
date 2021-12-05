using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_VLXD.Business.EntitiesClass;
using QL_VLXD.DataAccess;

namespace QL_VLXD.Business.Component
{
    class E_tb_Loai
    {
        SQL_tb_Loai nvsql = new SQL_tb_Loai();
        public void themoinv(EC_tb_Loai nv)
        {
            if (!nvsql.kiemtraLoai(nv.Maloai))
            {
                nvsql.themLoai(nv);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suanv(EC_tb_Loai nv)
        {
            nvsql.suaLoai(nv);
        }
        public void xoanv(EC_tb_Loai nv)
        {
            nvsql.xoaLoai(nv);
        }
    }
}
