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
    class SQL_tb_User
    {
        ConnectDB cn = new ConnectDB();

        public bool Kiemtrauser(EC_tb_User user)
        {
            string sql = "select count(*) from tblDangNhap where TaiKhoan ='" + user.USERNAME + "' and MatKhau = '" + user.PASSWORD + "'";
            return cn.KiemtraUsername(sql);
        }

        public void themmoinv(EC_tb_User nv)
        {
            string sql = @"INSERT INTO dbo.tblDangNhap (TaiKhoan,MatKhau,Loaitk,Manv) VALUES   (N'" + nv.USERNAME + "',N'" + nv.PASSWORD + "',N'" + nv.Loaitk + "',N'" + nv.Manv + "')";
            cn.ExcuteNonQuery(sql);
        }
        public void xoanv(EC_tb_User nv)
        {
            cn.ExcuteNonQuery("DELETE FROM [tblDangNhap] WHERE TaiKhoan=N'" + nv.USERNAME + "'");
        }

        public void suanv(EC_tb_User nv)
        {
            string sql = (@"UPDATE    tblDangNhap
                    SET  MatKhau =N'" + nv.PASSWORD + "', Loaitk =N'" + nv.Loaitk + "', Manv =N'" + nv.Manv + "' where TaiKhoan =N'" + nv.USERNAME + "'");
            cn.ExcuteNonQuery(sql);
        }
        public void suaMK(EC_tb_User mk,string MK)
        {
            string sql = (@"UPDATE dbo.tblDangNhap SET MatKhau = N'" + mk.PASSWORD + "'WHERE TaiKhoan = N'" + mk.USERNAME + "' AND MatKhau =N'"+MK+"'");
            cn.ExcuteNonQuery(sql);
        }
        public void loadTKMK(TextBox tk, TextBox mk, string TK)
        {
            tk.Text = TK;
            cn.LoadTextBox(mk, @"SELECT Password FROM dbo.tblDangNhap WHERE TaiKhoan = N'" + TK + "'");
        }
    }
}
