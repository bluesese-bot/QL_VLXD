using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_VLXD.Business.EntitiesClass;
using System.Windows.Forms;

namespace QL_VLXD.DataAccess
{
    class SQL_tb_CTHDN
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtratb_CTHDN(string mahdn, string masp)
        {
            return cn.kiemtra("select count(*) from [tblChiTietHDN] where MaHD=N'" + mahdn + "'and MaMatH=N'" + masp + "'");
        }
        public void themmoicthdb(EC_tb_CTHDN cthdb)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tblChiTietHDN
                      (MaHD, MaMatH, SoLuong, DonViTinh, DonGia,ThanhTien) VALUES   (N'" + cthdb.Mahdn + "',N'" + cthdb.Masp + "',N'" + cthdb.Sl + "',N'" + cthdb.Donvi + "',N'" + cthdb.Dongia + "',N'"+cthdb.Thanhtien+"')");
        }
        public void xoacthdb(EC_tb_CTHDN cthdb)
        {
            cn.ExcuteNonQuery("DELETE FROM [tblChiTietHDN] WHERE  MaHD=N'" + cthdb.Mahdn + "' and MaMatH=N'" + cthdb.Masp + "' ");
        }

        public void suacthdb(EC_tb_CTHDN cthdb)
        {
            string sql = (@"UPDATE tblChiTietHDN
            SET soluong =N'" + cthdb.Sl + "', DonViTinh = N'" + cthdb.Donvi + "', DonGia = N'" + cthdb.Dongia + "', ThanhTien = N'" + cthdb.Thanhtien + "' where  MaHD=N'" + cthdb.Mahdn + "' and MaMatH=N'" + cthdb.Masp + "'");
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
        //load THD
        public void loadmahd(ComboBox mahdn)
        {
            cn.LoadLenCombobox(mahdn, "SELECT     mahdn FROM tblHoaDonNhap", 0);
        }
        //load đơn giá bán
        public string Loaddgb(string dg, string masp)
        {
            dg = cn.LoadLable("SELECT [GiaNhap] From [tblMatHang] where MaMatH= N'" + masp + "'");
            return dg;
        }
    }
}
