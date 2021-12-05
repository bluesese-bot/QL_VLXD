using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_VLXD.DataAccess;
using QL_VLXD.Business.EntitiesClass;
using System.Windows.Forms;
using System.Data;

namespace QL_VLXD.Business.Component
{
    class E_tb_NhanVien
    {
        ConnectDB cn = new ConnectDB();
        SQL_tb_NhanVien nvsql = new SQL_tb_NhanVien();
        public List<EC_tb_NhanVien> GetTb_Menus(string manv)
        {
            List<EC_tb_NhanVien> listmenu = new List<EC_tb_NhanVien>();
            DataTable data = cn.taobang("select * from tblNhanVien where MaNhanVien = N'" + manv + "'");
            foreach (DataRow item in data.Rows)
            {
                EC_tb_NhanVien menu = new EC_tb_NhanVien(item);
                listmenu.Add(menu);
            }
            return listmenu;
        }
        public void themoinv(EC_tb_NhanVien nv)
        {
            if (!nvsql.kiemtranv(nv.MANV))
            {
                nvsql.themmoinv(nv);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suanv(EC_tb_NhanVien nv)
        {
            nvsql.suanv(nv);
        }
        public void xoanv(EC_tb_NhanVien nv)
        {
            nvsql.xoanv(nv);
        }
    }
}
