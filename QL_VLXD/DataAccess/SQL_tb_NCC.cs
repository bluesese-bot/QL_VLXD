using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_VLXD.Business.EntitiesClass;

namespace QL_VLXD.DataAccess
{
    class SQL_tb_NCC
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtrancc(string mancc)
        {
            return cn.kiemtra("select count(*) from [tblNhaCungCap] where MaNCC=N'" + mancc + "'");
        }
        public void themmoincc(EC_tb_NCC ncc)
        {
            cn.ExcuteNonQuery(@"INSERT INTO dbo.tblNhaCungCap (MaNCC,MaMatH,TenNCC,DienThoai,Email,DiaChi,GhiChu ) VALUES (N'"+ncc.Mancc+"',N'"+ncc.Mamh+"',N'"+ncc.Tenncc+"',N'"+ncc.Sdt+"',N'"+ncc.Email+"',N'"+ncc.Diachi+"',N'"+ncc.Diachi+"')");
        }
        public void xoancc(EC_tb_NCC ncc)
        {
            cn.ExcuteNonQuery("DELETE FROM [tblNhaCungCap] WHERE MaNCC=N'" + ncc.Mancc + "'");
        }

        public void suancc(EC_tb_NCC ncc)
        {
            string sql = (@"UPDATE    tblNhaCungCap
            SET TenNCC =N'" + ncc.Tenncc + "', diachi =N'" + ncc.Diachi + "', sdt =N'" + ncc.Sdt + "',MaMatH=N'"+ncc.Mamh+ "',Email=N'"+ncc.Email+ "',GhiChu=N'"+ncc.Ghichu+ "'  where MaNCC=N'" + ncc.Mancc + "'");
            cn.ExcuteNonQuery(sql);
        }
    }
}
