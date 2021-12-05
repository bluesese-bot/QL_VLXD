using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_VLXD.DataAccess;
using QL_VLXD.Business.EntitiesClass;
using System.Windows.Forms;

namespace QL_VLXD.DataAccess
{
    class SQL_tb_HDB
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtraHDN(string mahdn)
        {
            return cn.kiemtra("select count(*) from [tblHoaDonXuat] where MaHD =N'" + mahdn + "'");
        }
        public void themmoiHDN(EC_tb_HDB hdn)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tblHoaDonXuat
                      (MaHD, MaNhanVien, NgayXuat, TongTien, GhiChu) VALUES   (N'" + hdn.Mahd + "',N'" + hdn.Manv + "',N'" + hdn.Ngaynhap + "',N'" + hdn.Tongtien + "',N'" + hdn.Ghichu + "')");
        }
        public void xoaHDN(EC_tb_HDB hdn)
        {
            cn.ExcuteNonQuery("DELETE FROM [tblHoaDonXuat] WHERE [MaHD] = N'" + hdn.Mahd + "'");
        }

        public void suaHDN(EC_tb_HDB hdn)
        {
            string sql = (@"UPDATE tblHoaDonXuat
            SET MaNhanVien =N'" + hdn.Manv + "',NgayXuat =N'" + hdn.Ngaynhap + "',GhiChu =N'" + hdn.Ghichu + "' where  MaHD =N'" + hdn.Mahd + "'");
            cn.ExcuteNonQuery(sql);
        }
        //load mã nhà cung cấp
        public void loadmanv(ComboBox macc)
        {
            cn.LoadLenCombobox(macc, "SELECT     MaNhanVien FROM tblNhanVien", 0);
        }
        public string Loadtennv(string tencc, string manv)
        {
            tencc = cn.LoadLable("SELECT [TenNhanVien] From [tblNhanVien] where MaNhanVien= N'" + manv + "'");
            return tencc;
        }
    }
}
