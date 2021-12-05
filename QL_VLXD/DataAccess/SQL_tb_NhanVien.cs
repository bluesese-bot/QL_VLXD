using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_VLXD.DataAccess;
using QL_VLXD.Business.EntitiesClass;

namespace QL_VLXD.DataAccess
{
    class SQL_tb_NhanVien
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtranv(string manv)
        {
            return cn.kiemtra("select count(*) from [tblNhanVien] where MaNhanVien=N'" + manv + "'");
        }
        public void themmoinv(EC_tb_NhanVien nv)
        {
            string sql = @"INSERT INTO tblNhanVien
                      (MaNhanVien, TenNhanVien, DiaChi, DienThoai)
                        VALUES   (N'" + nv.MANV + "',N'" + nv.TENNV + "',N'" + nv.DIACHI + "',N'" + nv.SDT + "')";
            cn.ExcuteNonQuery(sql);
        }
        public void xoanv(EC_tb_NhanVien nv)
        {
            cn.ExcuteNonQuery("DELETE FROM [tblNhanVien] WHERE MaNhanVien=N'" + nv.MANV + "'");
        }

        public void suanv(EC_tb_NhanVien nv)
        {
            string sql = (@"UPDATE    tblNhanVien
                    SET TenNhanVien =N'" + nv.TENNV + "', DiaChi =N'" + nv.DIACHI+ "', DienThoai =N'" + nv.SDT + "'  where MaNhanVien=N'" + nv.MANV + "'");
            cn.ExcuteNonQuery(sql);
        }
    }
}
