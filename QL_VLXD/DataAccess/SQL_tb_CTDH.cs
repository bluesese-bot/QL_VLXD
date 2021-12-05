using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_VLXD.Business.EntitiesClass;
using System.Windows.Forms;

namespace QL_VLXD.DataAccess
{
    class SQL_tb_CTDH
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtratb_CTHDN(string mahdn, string masp)
        {
            return cn.kiemtra("select count(*) from [tblDatHangCT] where MaPhieu=N'" + mahdn + "'and MaMatH=N'" + masp + "'");
        }
        public void themmoicthdb(EC_tb_CTDH cthdb)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tblDatHangCT
                      (MaPhieu, MaMatH, SoLuong, NgayDat, NgayNhan) VALUES   (N'" + cthdb.Maphieu + "',N'" + cthdb.Msp + "',N'" + cthdb.Sl + "',N'" + cthdb.Ngaydat + "',N'" + cthdb.Ngaynhan + "')");
        }
        public void xoacthdb(EC_tb_CTDH cthdb)
        {
            cn.ExcuteNonQuery("DELETE FROM [tblDatHangCT] WHERE  MaPhieu=N'" + cthdb.Maphieu + "' and MaMatH=N'" + cthdb.Msp + "' ");
        }

        public void suacthdb(EC_tb_CTDH cthdb)
        {
            string sql = (@"UPDATE tblDatHangCT
            SET SoLuong =N'" + cthdb.Sl + "', NgayDat = N'" + cthdb.Ngaydat + "', NgayNhan = N'" + cthdb.Ngaynhan + "' where  MaPhieu=N'" + cthdb.Maphieu + "' and MaMatH=N'" + cthdb.Msp + "'");
            cn.ExcuteNonQuery(sql);
        }
        //load sp
        public void loadmasp(ComboBox masp)
        {
            cn.LoadLenCombobox(masp, "SELECT     MaMatH FROM tblMatHang", 0);
        }
        public string Loadtenhang(string tenhang, string masp)
        {
            tenhang = cn.LoadLable("SELECT [TenMatH] From [tblMatHang] where MaMatH= N'" + masp + "'");
            return tenhang;
        }
    }
}
