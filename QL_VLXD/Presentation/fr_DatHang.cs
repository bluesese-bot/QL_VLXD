using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_VLXD.Business.EntitiesClass;
using QL_VLXD.Business.Component;
using QL_VLXD.DataAccess;
using System.Data.SqlClient;

namespace QL_VLXD.Presentation
{
    public partial class fr_DatHang : Form
    {
        public fr_DatHang()
        {
            InitializeComponent();
        }
        ConnectDB cn = new ConnectDB();
        E_tb_CTDH thucthi = new E_tb_CTDH();
        EC_tb_CTDH ck = new EC_tb_CTDH();
        E_tb_DatHang thucthi1 = new E_tb_DatHang();
        EC_tb_DatHang ck1 = new EC_tb_DatHang();
        bool themmoi;
        int dong = 0;
        public void setnull()
        {
            txtMHD.Text = "";
            dtNgayDat.Text = DateTime.Now.ToShortTimeString();
            dtNgayNhan.Text = DateTime.Now.ToShortTimeString();
            cbMatHang.SelectedIndex = -1;
            txtTenKH.Text = "";
            txtSDT.Text = "";
            txtGhiChu.Text = "";
            numSL.Value = 0;
        }
        void locktext()
        {
            txtMHD.Enabled = false;
            txtMHD1.Enabled = false;
            txtGhiChu.Enabled = false;
            txtSDT.Enabled = false;
            txtTenKH.Enabled = false;

            cbMatHang.Enabled = false;
            numSL.Enabled = false;
            dtNgayDat.Enabled = false;
            dtNgayNhan.Enabled = false;

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
            txtSDT.Enabled = true;
            txtTenKH.Enabled = true;

            cbMatHang.Enabled = true;
            numSL.Enabled = true;
            dtNgayDat.Enabled = true;
            dtNgayNhan.Enabled = true;


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
            msds.Columns[0].HeaderText = "Mã Phiếu";
            msds.Columns[0].Frozen = true;
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 100;
            msds.Columns[1].HeaderText = "Tên Khách Hàng";
            msds.Columns[1].Width = 100;
            msds.Columns[2].HeaderText = "Số Điện Thoại";
            msds.Columns[2].Width = 80; ;
            msds.Columns[3].HeaderText = "Chú Thích";
            msds.Columns[3].Width = 100;

            //Khởi Tạo Lưới Cho Chi Tiết Hóa Đơn Nhập
            msds1.Columns[0].HeaderText = "Mã Phiếu";
            msds1.Columns[1].HeaderText = "Mã Sản Phẩm";
            msds1.Columns[2].HeaderText = "Số Lượng";
            msds1.Columns[3].HeaderText = "Ngày Đặt";
            msds1.Columns[4].HeaderText = "Ngày Nhận";
        }
        public void hienthi()
        {
            string sql = "SELECT * FROM tblDatHang";
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
            string sql = "SELECT * FROM tblDatHangCT where MaPhieu = N'" + sohdb + "'";
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

        private void btmoi_Click(object sender, EventArgs e)
        {
            themmoi = true;
            unLocktext();
            txtMHD1.Enabled = false;
            dtNgayNhan.Enabled = false;
            dtNgayDat.Enabled = false;
            cbMatHang.Enabled = false;
            numSL.Enabled = false;
            btnLuu1.Enabled = false;
            setnull();
            txtMHD.Enabled = true;
            txtMHD.Focus();
        }

        private void fr_DatHang_Load(object sender, EventArgs e)
        {
            locktext();
            thucthi.loadmasp(cbMatHang);
            hienthi();
            hienthi1(txtMHD1.Text);
            khoitaoluoi();
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if (txtMHD.Text != "")
            {
                if (txtTenKH.Text != "")
                {
                    if(txtSDT.Text != "")
                    {
                        if (themmoi == true)
                        {
                            try
                            {
                                ck1.Maphieu = txtMHD.Text;
                                ck1.Tenkh = txtTenKH.Text;
                                ck1.Sdt = txtSDT.Text;
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
                        {
                            try
                            {
                                ck1.Maphieu = txtMHD.Text;
                                ck1.Tenkh = txtTenKH.Text;
                                ck1.Sdt = txtSDT.Text;
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
                    }
                    else
                    {
                        MessageBox.Show("Số Điện Thoại không được để trống", "Chú Ý", MessageBoxButtons.OK);
                        txtTenKH.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Tên khách hàng không được để trống", "Chú Ý", MessageBoxButtons.OK);
                    txtTenKH.Focus();
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
                    ck1.Maphieu = txtMHD.Text;

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
            txtTenKH.Text = msds.Rows[dong].Cells[1].Value.ToString();
            txtSDT.Text = msds.Rows[dong].Cells[2].Value.ToString();
            txtGhiChu.Text = msds.Rows[dong].Cells[3].Value.ToString();
            hienthi1(txtMHD.Text);
            txtMHD1.Text = txtMHD.Text;
            locktext();
        }

        private void btnMoi1_Click(object sender, EventArgs e)
        {
            themmoi = true;
            unLocktext();
            txtMHD.Enabled = false;
            txtTenKH.Enabled = false;
            txtSDT.Enabled = false;
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
                        ck.Maphieu = txtMHD1.Text;
                        ck.Msp = cbMatHang.Text;
                        ck.Sl = numSL.Text;
                        ck.Ngaydat = dtNgayDat.Text;
                        ck.Ngaynhan = dtNgayNhan.Text;


                        thucthi.themoicthdn(ck);
                        locktext();
                        hienthi();
                        hienthi1(txtMHD.Text);
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
                        ck.Maphieu = txtMHD1.Text;
                        ck.Msp = cbMatHang.Text;
                        ck.Sl = numSL.Text;
                        ck.Ngaydat = dtNgayDat.Text;
                        ck.Ngaynhan = dtNgayNhan.Text;

                        thucthi.suacthdn(ck);
                        MessageBox.Show("Đã Sửa Thành Công Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                string upsl = "UPDATE tblMatHang SET SoLuong =SoLuong - '" + numSL.Text + "' where MaMatH='" + lbMatHang.Text + "'";
                cn.ExcuteNonQuery(upsl);

                locktext();
                hienthi();
                hienthi1(txtMHD.Text);
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
            txtTenKH.Enabled = false;
            txtSDT.Enabled = false;
            txtGhiChu.Enabled = false;
            cbMatHang.Enabled = false;
        }

        private void btnXoa1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa dữ liệu này?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ck.Maphieu = txtMHD1.Text;
                    ck.Msp = lbMatHang.Text;

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
            dtNgayDat.Text = msds1.Rows[dong].Cells[3].Value.ToString();
            dtNgayNhan.Text = msds1.Rows[dong].Cells[4].Value.ToString();
            locktext();
        }

        private void cbMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbMatHang.Text = cn.LoadLable("SELECT TenMatH FROM dbo.tblMatHang WHERE MaMatH=N'" + cbMatHang.Text + "'");
            if (cbMatHang.SelectedIndex == -1)
            {
                lbMatHang.Text = "---";
            }
        }
    }
}
