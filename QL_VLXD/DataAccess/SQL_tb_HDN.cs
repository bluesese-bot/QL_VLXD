using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_VLXD.Business.EntitiesClass;
using System.Windows.Forms;

namespace QL_VLXD.DataAccess
{
    class SQL_tb_HDN
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtraHDN(string mahdn)
        {
            return cn.kiemtra("select count(*) from [tblHoaDonNhap] where MaHD =N'" + mahdn + "'");
        }
        public void themmoiHDN(EC_tb_HDN hdn)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tblHoaDonNhap
                      (MaHD, MaNCC, NgayNhap, TongTien, GhiChu) VALUES   (N'" + hdn.Mahd + "',N'" + hdn.Mancc + "',N'" + hdn.Ngaynhap + "',N'" + hdn.Tongtien + "',N'" + hdn.Ghichu + "')");
        }
        public void xoaHDN(EC_tb_HDN hdn)
        {
            cn.ExcuteNonQuery("DELETE FROM [tblHoaDonNhap] WHERE [MaHD] = N'" + hdn.Mahd + "'");
        }

        public void suaHDN(EC_tb_HDN hdn)
        {
            string sql = (@"UPDATE tblHoaDonNhap
            SET MaNCC =N'" + hdn.Mancc + "',NgayNhap =N'" + hdn.Ngaynhap + "',GhiChu =N'" + hdn.Ghichu + "' where  MaHD =N'" + hdn.Mahd + "'");
            cn.ExcuteNonQuery(sql);
        }
        //load mã nhà cung cấp
        public void loadmancc(ComboBox macc)
        {
            cn.LoadLenCombobox(macc, "SELECT     MaNCC FROM tblNhaCungCap", 0);
        }
        public string Loadtenncc(string tencc, string macc)
        {
            tencc = cn.LoadLable("SELECT [TenNCC] From [tblNhaCungCap] where MaNCC= N'" + macc + "'");
            return tencc;
        }
    }
}
