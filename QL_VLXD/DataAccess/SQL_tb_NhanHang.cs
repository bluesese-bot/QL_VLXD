
using QL_VLXD.Business.EntitiesClass;
namespace QL_VLXD.DataAccess
{
    class SQL_tb_NhanHang
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtraHang(string mahdn)
        {
            return cn.kiemtra("select count(*) from [tb_hang] where mahang =N'" + mahdn + "'");
        }
        public void themHang(EC_tb_NhanHang ec)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_hang (mahang,tenhang) VALUES( N'" + ec.Mahang + "', N'" + ec.Tenhang + "' )");
        }
        public void xoaHang(EC_tb_NhanHang ec)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_hang] WHERE [mahang] = N'" + ec.Mahang + "'");
        }

        public void suaHang(EC_tb_NhanHang ec)
        {
            cn.ExcuteNonQuery(@"UPDATE tb_hang SET tenhang =N'" + ec.Tenhang + "' where  mahang =N'" + ec.Mahang + "'");
        }
    }
}
