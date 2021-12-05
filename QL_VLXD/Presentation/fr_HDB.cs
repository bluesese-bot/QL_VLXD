using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_VLXD.Business.Component;
using QL_VLXD.Business.EntitiesClass;
using QL_VLXD.DataAccess;

namespace QL_VLXD.Presentation
{
    public partial class fr_HDB : Form
    {
        public fr_HDB()
        {
            InitializeComponent();
        }
        ConnectDB cn = new ConnectDB();
        E_tb_CTHDB thucthi = new E_tb_CTHDB();
        EC_tb_CTHDB ck = new EC_tb_CTHDB();
        E_tb_HDB thucthi1 = new E_tb_HDB();
        EC_tb_HDB ck1 = new EC_tb_HDB();
        bool themmoi;
        int dong = 0;
        public void setnull()
        {
            txtMHD.Text = "";
            dtNhap.Text = DateTime.Now.ToShortTimeString();
            cbNCC.SelectedIndex = -1;
            txtTongTien.Text = "0";
            txtGhiChu.Text = "";

            txtDonvitinh.Text = "";
            txtDongia.Text = "0";
        }
        void locktext()
        {
            txtMHD.Enabled = false;
            txtMHD1.Enabled = false;
            txtGhiChu.Enabled = false;
            txtDonvitinh.Enabled = false;
            txtDongia.Enabled = false;

            cbMatHang.Enabled = false;
            cbNCC.Enabled = false;
            numSL.Enabled = false;
            dtNhap.Enabled = false;

            btluu.Enabled = false;
            btnLuu1.Enabled = false;
            btmoi.Enabled = true;
            btnMoi1.Enabled = true;
            btsua.Enabled = true;
            btnSua1.Enabled = true;
            btxoa.Enabled = true;
            btnXoa1.Enabled = true;
        }
        void unLocktext()
        {
            txtMHD.Enabled = true;
            txtMHD1.Enabled = true;
            txtGhiChu.Enabled = true;
            txtDonvitinh.Enabled = true;
            txtDongia.Enabled = true;

            cbMatHang.Enabled = true;
            cbNCC.Enabled = true;
            numSL.Enabled = true;
            dtNhap.Enabled = true;


            btluu.Enabled = true;
            btnLuu1.Enabled = true;
            btmoi.Enabled = false;
            btnMoi1.Enabled = false;
            btsua.Enabled = false;
            btnSua1.Enabled = false;
            btxoa.Enabled = false;
            btnXoa1.Enabled = false;
        }
        public void khoitaoluoi()
        {
            //Khởi Tạo Lưới Cho Hóa Đơn Nhập
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Mã HDN";
            msds.Columns[0].Frozen = true;
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 100;
            msds.Columns[1].HeaderText = "Mã Nhà Cung Cấp";
            msds.Columns[1].Width = 100;
            msds.Columns[2].HeaderText = "Ngày Bán";
            msds.Columns[2].Width = 80; ;
            msds.Columns[3].HeaderText = "Tổng Tiền";
            msds.Columns[3].Width = 100;
            msds.Columns[4].HeaderText = "Chú Thích";
            msds.Columns[4].Width = 100;

            //Khởi Tạo Lưới Cho Chi Tiết Hóa Đơn Nhập
            msds1.Columns[0].HeaderText = "Mã HDN";
            msds1.Columns[1].HeaderText = "Mã Sản Phẩm";
            msds1.Columns[2].HeaderText = "Số Lượng";
            msds1.Columns[3].HeaderText = "Đơn Vị Tính";
            msds1.Columns[4].HeaderText = "Đơn Giá";
            msds1.Columns[5].HeaderText = "Thành Tiền";
        }
        public void hienthi()
        {
            string sql = "SELECT * FROM tblHoaDonXuat";
            msds.DataSource = cn.taobang(sql);
            SqlConnection con = cn.getcon();
            con.Open();
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        private void hienthi1(string sohdb)
        {
            string sql = "SELECT * FROM tblChiTietHDX where MaHD = N'" + sohdb + "'";
            msds1.DataSource = cn.taobang(sql);
            SqlConnection con = cn.getcon();
            con.Open();
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        private void fr_HDB_Load(object sender, EventArgs e)
        {
            locktext();
            thucthi1.loadmanv(cbNCC);
            thucthi.loadmasp(cbMatHang);
            hienthi();
            hienthi1(txtMHD1.Text);
            khoitaoluoi();
        }

        private void btmoi_Click(object sender, EventArgs e)
        {
            themmoi = true;
            unLocktext();
            txtMHD1.Enabled = false;
            txtDonvitinh.Enabled = false;
            txtDongia.Enabled = false;
            cbMatHang.Enabled = false;
            numSL.Enabled = false;
            btnLuu1.Enabled = false;
            setnull();
            txtMHD.Enabled = true;
            txtMHD.Focus();
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if (txtMHD.Text != "")
            {

                if (cbNCC.Text != "")
                {
                    if (themmoi == true)
                    {
                        try
                        {
                            ck1.Mahd = txtMHD.Text;
                            ck1.Manv = cbNCC.Text;
                            ck1.Ngaynhap = dtNhap.Text;
                            ck1.Tongtien = txtTongTien.Text;
                            ck1.Ghichu = txtGhiChu.Text;

                            thucthi1.themoihdn(ck1);
                            locktext();
                            hienthi();
                            MessageBox.Show("Đã Lưu Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                        try
                        {
                            ck1.Mahd = txtMHD.Text;
                            ck1.Manv = cbNCC.Text;
                            ck1.Ngaynhap = dtNhap.Text;
                            ck1.Tongtien = txtTongTien.Text;
                            ck1.Ghichu = txtGhiChu.Text;

                            thucthi1.suahdn(ck1);
                            MessageBox.Show("Đã Sửa Thành Công Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    txtMHD.Enabled = true;
                    locktext();
                    hienthi();
                }
                else
                {
                    MessageBox.Show("Mã Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                    cbNCC.Focus();
                }
            }
            else
            {
                MessageBox.Show("Mã Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                txtMHD.Focus();
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            unLocktext();
            txtMHD.ReadOnly = true;
            txtMHD1.ReadOnly = true;
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa dữ liệu này?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ck1.Mahd = txtMHD.Text;

                    thucthi1.xoahdn(ck1);
                    MessageBox.Show("Đã Xóa Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienthi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi");
                }
            }
        }

        private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txtMHD.Text = msds.Rows[dong].Cells[0].Value.ToString();
            cbNCC.Text = msds.Rows[dong].Cells[1].Value.ToString();
            dtNhap.Text = msds.Rows[dong].Cells[2].Value.ToString();
            txtTongTien.Text = msds.Rows[dong].Cells[3].Value.ToString();
            txtGhiChu.Text = msds.Rows[dong].Cells[4].Value.ToString();
            hienthi1(txtMHD.Text);
            lbNCC.Text = thucthi1.loadtennv(lbNCC.Text, cbNCC.Text);
            txtMHD1.Text = txtMHD.Text;
            locktext();
        }

        private void cbNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbNCC.Text = thucthi1.loadtennv(lbNCC.Text, cbNCC.Text);
            if (cbNCC.SelectedIndex == -1)
            {
                lbNCC.Text = "---";
            }
        }

        private void btnMoi1_Click(object sender, EventArgs e)
        {
            themmoi = true;
            unLocktext();
            txtMHD.Enabled = false;
            cbNCC.Enabled = false;
            dtNhap.Enabled = false;
            txtGhiChu.Enabled = false;
            btluu.Enabled = false;
            txtMHD1.Enabled = false;
            setnull();
        }

        private void btnLuu1_Click(object sender, EventArgs e)
        {
            if (cbMatHang.Text != "")
            {
                if (themmoi == true)
                {
                    try
                    {
                        float tt = (float.Parse(numSL.Text) * float.Parse(txtDongia.Text));

                        ck.Mahd = txtMHD1.Text;
                        ck.Masp = cbMatHang.Text;
                        ck.Sl = numSL.Text;
                        ck.Donvi = txtDonvitinh.Text;
                        ck.Dongia = txtDongia.Text;
                        ck.Thanhtien = tt.ToString();

                        thucthi.themoicthdn(ck);
                        locktext();
                        hienthi();
                        hienthi1(txtMHD1.Text);
                        MessageBox.Show("Đã Lưu Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    try
                    {
                        float tt = (float.Parse(numSL.Text) * float.Parse(txtDongia.Text));
                        ck.Mahd = txtMHD1.Text;
                        ck.Masp = cbMatHang.Text;
                        ck.Sl = numSL.Text;
                        ck.Donvi = txtDonvitinh.Text;
                        ck.Dongia = txtDongia.Text;
                        ck.Thanhtien = tt.ToString();

                        thucthi.suacthdn(ck);
                        MessageBox.Show("Đã Sửa Thành Công Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                float gn = float.Parse(txtDongia.Text);
                string upsl = "UPDATE tblMatHang SET SoLuong =  SoLuong - '" + numSL.Text + "' where MaMatH='" + cbMatHang.Text + "'";
                string uptt = "UPDATE tblHoaDonXuat set TongTien=(SELECT sum(ThanhTien) FROM tblChiTietHDX WHERE dbo.tblChiTietHDX.MaHD = dbo.tblHoaDonXuat.MaHD) where MaHD='" + txtMHD1.Text+"'";
                cn.ExcuteNonQuery(uptt);
                cn.ExcuteNonQuery(upsl);

                locktext();
                hienthi();
                hienthi1(txtMHD1.Text);
                float t1 = (float.Parse(numSL.Text) * float.Parse(txtDongia.Text));
                txtTT.Text = t1.ToString();
            }
            else
            {
                MessageBox.Show("Mã Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                cbMatHang.Focus();
            }
        }

        private void btnSua1_Click(object sender, EventArgs e)
        {
            themmoi = false;
            unLocktext();
            txtMHD1.ReadOnly = true;
            txtMHD.ReadOnly = true;
            cbMatHang.Enabled = false;
            cbNCC.Enabled = false;
            dtNhap.Enabled = false;
            txtGhiChu.Enabled = false;
        }

        private void btnXoa1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa dữ liệu này?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ck.Mahd = txtMHD1.Text;
                    ck.Masp = lbMatHang.Text;

                    thucthi.xoacthdn(ck);
                    MessageBox.Show("Đã Xóa Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienthi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi");
                }
            }
        }

        private void msds1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txtMHD1.Text = msds1.Rows[dong].Cells[0].Value.ToString();
            cbMatHang.Text = msds1.Rows[dong].Cells[1].Value.ToString();
            numSL.Text = msds1.Rows[dong].Cells[2].Value.ToString();
            txtDonvitinh.Text = msds1.Rows[dong].Cells[3].Value.ToString();
            txtDongia.Text = msds1.Rows[dong].Cells[4].Value.ToString();
            txtTT.Text = msds1.Rows[dong].Cells[5].Value.ToString();
            locktext();
        }

        private void cbMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn.LoadTextBox(txtDongia, "select GiaBan FROM dbo.tblMatHang WHERE MaMatH= N'" + cbMatHang.Text + "'");
            lbMatHang.Text = cn.LoadLable("SELECT TenMatH FROM dbo.tblMatHang WHERE MaMatH=N'" + cbMatHang.Text + "'");
            txtTT.Text = (double.Parse(numSL.Text) * double.Parse(txtDongia.Text)).ToString();
            if (cbMatHang.SelectedIndex == -1)
            {
                txtDongia.Text = "0";
                lbMatHang.Text = "---";
            }
        }

        private void numSL_Click(object sender, EventArgs e)
        {
            txtTT.Text = (double.Parse(numSL.Text) * double.Parse(txtDongia.Text)).ToString();
        }
    }
}
