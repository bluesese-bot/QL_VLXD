using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QL_VLXD.Business.EntitiesClass
{
    class EC_tb_NhanVien
    {
        private string manv;
        private string tennv;
        private string diachi;
        private string sdt;

        public EC_tb_NhanVien()
        {

        }
        public EC_tb_NhanVien(DataRow row)
        {
            this.manv = row["MaNhanVien"].ToString();
            this.tennv = row["TenNhanVien"].ToString();
            this.diachi = row["DiaChi"].ToString();
            this.sdt = row["DienThoai"].ToString();
        }
        public string MANV
        {
            get
            {
                return manv;
            }
            set
            {
                manv = value;
                if (manv == "")
                {
                    throw new Exception("Mã không để trống");
                }
            }
        }
        public string TENNV
        {
            get
            {
                return tennv;
            }
            set
            {
                tennv = value;
            }
        }
        public string DIACHI
        {
            get
            {
                return diachi;
            }
            set
            {
                diachi = value;
            }
        }
        public string SDT
        {
            get
            {
                return sdt;
            }
            set
            {
                sdt = value;
            }
        }
    }
}
