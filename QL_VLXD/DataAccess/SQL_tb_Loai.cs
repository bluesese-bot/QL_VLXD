using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_VLXD.Business.EntitiesClass;

namespace QL_VLXD.DataAccess
{
    class SQL_tb_Loai
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtraLoai(string mahdn)
        {
            return cn.kiemtra("select count(*) from [tb_Loaihang] where maloai =N'" + mahdn + "'");
        }
        public void themLoai(EC_tb_Loai ec)
        {
            cn.ExcuteNonQuery(@"INSERT INTO dbo.tb_Loaihang (maloai,tenloai) VALUES( N'"+ec.Maloai+"', N'"+ec.Tenloai+"' )");
        }
        public void xoaLoai(EC_tb_Loai ec)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_Loaihang] WHERE [maloai] = N'" + ec.Maloai + "'");
        }

        public void suaLoai(EC_tb_Loai ec)
        {
            cn.ExcuteNonQuery(@"UPDATE tb_Loaihang SET tenloai =N'" + ec.Tenloai + "' where  maloai =N'" + ec.Maloai + "'");
        }
    }
}
