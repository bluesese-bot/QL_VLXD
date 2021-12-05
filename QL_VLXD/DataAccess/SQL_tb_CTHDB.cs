using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_VLXD.Business.EntitiesClass;

namespace QL_VLXD.DataAccess
{
    class SQL_tb_CTHDB
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtratb_CTHDN(string mahdn, string masp)
        {
            return cn.kiemtra("select count(*) from [tblChiTietHDX] where MaHD=N'" + mahdn + "'and MaMH=N'" + masp + "'");
        }
        public void themmoicthdb(EC_tb_CTHDB cthdb)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tblChiTietHDX
                      (MaHD, MaMH, SoLuong, DonViTinh, DonGia,ThanhTien) VALUES   (N'" + cthdb.Mahd + "',N'" + cthdb.Masp + "',N'" + cthdb.Sl + "',N'" + cthdb.Donvi + "',N'" + cthdb.Dongia + "',N'" + cthdb.Thanhtien + "')");
        }
        public void xoacthdb(EC_tb_CTHDB cthdb)
        {
            cn.ExcuteNonQuery("DELETE FROM [tblChiTietHDX] WHERE  MaHD=N'" + cthdb.Mahd + "' and MaMH=N'" + cthdb.Masp + "' ");
        }

        public void suacthdb(EC_tb_CTHDB cthdb)
        {
            string sql = (@"UPDATE tblChiTietHDX
            SET soluong =N'" + cthdb.Sl + "', DonViTinh = N'" + cthdb.Donvi + "', DonGia = N'" + cthdb.Dongia + "', ThanhTien = N'" + cthdb.Thanhtien + "' where  MaHD=N'" + cthdb.Mahd + "' and MaMH=N'" + cthdb.Masp + "'");
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
        //load đơn giá bán
        public void Loaddgb(TextBox dg, string masp)
        {
            cn.LoadTextBox(dg,"SELECT [GiaBan] From [tblMatHang] where MaMatH= N'" + masp + "'");

        }
    }
}
