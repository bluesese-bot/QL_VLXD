using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_VLXD.Business.EntitiesClass;

namespace QL_VLXD.DataAccess
{
    class SQL_tb_DatHang
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtraHDN(string mahdn)
        {
            return cn.kiemtra("select count(*) from [tblDatHang] where MaPhieu =N'" + mahdn + "'");
        }
        public void themmoiHDN(EC_tb_DatHang hdn)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tblDatHang
                      (MaPhieu, TenKhachH, DienThoai, GhiChu) VALUES   (N'" + hdn.Maphieu + "',N'" + hdn.Tenkh + "',N'" + hdn.Sdt + "',N'" + hdn.Ghichu + "')");
        }
        public void xoaHDN(EC_tb_DatHang hdn)
        {
            cn.ExcuteNonQuery("DELETE FROM [tblDatHang] WHERE [MaPhieu] = N'" + hdn.Maphieu + "'");
        }

        public void suaHDN(EC_tb_DatHang hdn)
        {
            string sql = (@"UPDATE tblDatHang
            SET TenKhachH =N'" + hdn.Tenkh + "',DienThoai =N'" + hdn.Sdt + "',GhiChu =N'" + hdn.Ghichu + "' where  MaPhieu =N'" + hdn.Maphieu + "'");
            cn.ExcuteNonQuery(sql);
        }
    }
}
