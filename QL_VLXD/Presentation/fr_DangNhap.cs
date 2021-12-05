using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QL_VLXD.DataAccess;
using QL_VLXD.Business.EntitiesClass;
using QL_VLXD.Business.Component;


namespace QL_VLXD.Presentation
{
    public partial class fr_DangNhap : Form
    {
        public fr_DangNhap()
        {
            InitializeComponent();
        }
        ConnectDB cn = new ConnectDB();
        E_tb_User thucthi = new E_tb_User();
        EC_tb_User ck = new EC_tb_User();
        string user = "";
        string pass = "";
        string loaitk = "";
        string manv = "";
        public void ThreadProc()
        {
            fr_Main fr = new fr_Main(user, pass, loaitk, manv);
            Application.Run(fr);
        }
        private void cmddn_Click(object sender, EventArgs e)
        {
            user = txtuser.Text;
            pass = txtpass.Text;
            try
            {
                ck.USERNAME = user;
                ck.PASSWORD = pass;

                if (!thucthi.kiemtrauser(user, pass))
                {
                    List<EC_tb_User> listBillinfr = thucthi.GetTb_Menus(user, pass);
                    foreach (EC_tb_User item in listBillinfr)
                    {
                        user = item.USERNAME;
                        pass = item.PASSWORD;
                        loaitk = item.Loaitk;
                        manv = item.Manv;
                    }
                    MessageBox.Show("Đăng Nhập Thành Công", "Chúc Mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
                    t.Start();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Tài khoản đăng nhập chưa đúng. Vui lòng kiểm tra lại.", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtuser.Text = "";
                    txtpass.Text = "";
                    txtuser.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void txtuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                SendKeys.Send("{TAB}");
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                cmddn.Enabled = false;
                cmddn_Click(sender, e);
            }
        }
    }
}
