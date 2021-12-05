using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_VLXD.Business.Component;
using QL_VLXD.Business.EntitiesClass;

namespace QL_VLXD.Presentation
{
    public partial class fr_Info : Form
    {
        E_tb_NhanVien thucthi = new E_tb_NhanVien();
        EC_tb_NhanVien ck = new EC_tb_NhanVien();
        string manv;
        public fr_Info()
        {
            InitializeComponent();
        }
        public fr_Info(string Manv)
        {
            InitializeComponent();
            this.manv = Manv;
        }
        void LockText()
        {
            txtMNV.Enabled = false;
            txtTNV.Enabled = false;
            txtDC.Enabled = false;
            txtSDT.Enabled = false;

            btnLuu.Enabled = false;
        }
        void Unlocktext()
        {
            txtMNV.Enabled = false;
            txtTNV.Enabled = true;
            txtDC.Enabled = true;
            txtSDT.Enabled = true;

            btnLuu.Enabled = true;
        }

        void loadinfo()
        {
            List<EC_tb_NhanVien> listBillinfr = thucthi.GetTb_Menus(manv);
            foreach (EC_tb_NhanVien item in listBillinfr)
            {
                txtMNV.Text = item.MANV;
                txtTNV.Text = item.TENNV;
                txtDC.Text = item.DIACHI;
                txtSDT.Text = item.SDT;
            }
        }
        private void fr_Info_Load(object sender, EventArgs e)
        {
            loadinfo();
            LockText();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Unlocktext();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ck.TENNV = txtTNV.Text;
            ck.DIACHI = txtDC.Text;
            ck.SDT = txtSDT.Text;
            ck.MANV = txtMNV.Text;
            thucthi.suanv(ck);
            MessageBox.Show("Đã Sửa Thành Công.", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LockText();
            loadinfo();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
