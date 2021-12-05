using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_VLXD.Presentation
{
    public partial class fr_Main : Form
    {
        string username = "", pass = "", loaitk = "", manv = "";
        public void ThreadProc()
        {
            fr_DangNhap fr = new fr_DangNhap();
            Application.Run(fr);
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            t.Start();
            this.Close();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_Info));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_Info fr = new fr_Info(manv);
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_DoiMk));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_DoiMk fr = new fr_DoiMk(username);
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_TaiKhoan));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_TaiKhoan fr = new fr_TaiKhoan();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void nhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_NhanVien));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_NhanVien fr = new fr_NhanVien();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void mặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_Sanpham));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_Sanpham fr = new fr_Sanpham();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_NCC));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_NCC fr = new fr_NCC();
                fr.MdiParent = this;
                fr.Show();
            }
        }



        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_HDN));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_HDN fr = new fr_HDN();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_HDB));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_HDB fr = new fr_HDB();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void đặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_DatHang));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_DatHang fr = new fr_DatHang();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void xuấtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_BC_HDB));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_BC_HDB fr = new fr_BC_HDB();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void nhậpHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_BC_HDN));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_BC_HDN fr = new fr_BC_HDN();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void tồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_BC_SP));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_BC_SP fr = new fr_BC_SP();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void fr_Main_Load(object sender, EventArgs e)
        {
            if (loaitk == "User")
            {
                quảnLýToolStripMenuItem.Visible = false;
            }
        }

        public fr_Main()
        {
            InitializeComponent();
        }
        public fr_Main(string TenDanghap, string MatKhau, string LoaiTaiKhoan, string Manv)
        {
            InitializeComponent();
            this.username = TenDanghap;
            this.pass = MatKhau;
            this.loaitk = LoaiTaiKhoan;
            this.manv = Manv;
        }
        private Form kiemtratontai(Type formtype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == formtype)
                    return f;
            }
            return null;
        }
    }
}
