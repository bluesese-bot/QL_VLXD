using QL_VLXD.DataAccess;
using QL_VLXD.Business.EntitiesClass;
using System.Windows.Forms;

namespace QL_VLXD.Business.Component
{
    class E_tb_NhanHang
    {
        SQL_tb_NhanHang nvsql = new SQL_tb_NhanHang();
        public void themoinv(EC_tb_NhanHang nv)
        {
            if (!nvsql.kiemtraHang(nv.Mahang))
            {
                nvsql.themHang(nv);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suanv(EC_tb_NhanHang nv)
        {
            nvsql.suaHang(nv);
        }
        public void xoanv(EC_tb_NhanHang nv)
        {
            nvsql.xoaHang(nv);
        }
    }
}
