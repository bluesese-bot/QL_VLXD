using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QL_VLXD.Business.EntitiesClass;

namespace QL_VLXD.DataAccess
{
    class SQL_tb_Sanpham
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtraHang(string mahang)
        {
            return cn.kiemtra("select count(*) from [tblMatHang] where masp=N'" + mahang + "'");
        }
        public void themmoiHang(EC_tb_Sanpham hang)
        {
            SqlConnection con = cn.getcon();
            try
            {

                con.Open();
                string sql = @"INSERT INTO tblMatHang  (MaMatH, TenMatH, SoLuong, GiaNhap, GiaBan) VALUES (N'" + hang.MASP + "',N'" + hang.TENSP + "',N'" + hang.SOLUONG + "',N'" + hang.GIANHAP + "',N'" + hang.GIABAN + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void xoaHang(EC_tb_Sanpham hang)
        {
            cn.ExcuteNonQuery("DELETE FROM [tblMatHang] WHERE  MaMatH=N'" + hang.MASP + "'");
        }

        public void suaHang(EC_tb_Sanpham hang)
        {
            SqlConnection con = cn.getcon();
            try
            {
                con.Open();
                string sql = @"UPDATE    tblMatHang
                SET  TenMatH =N'" + hang.TENSP + "', GiaBan =N'" + hang.GIABAN + "', SoLuong =N'" + hang.SOLUONG + "' where MaMatH=N'" + hang.MASP + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
