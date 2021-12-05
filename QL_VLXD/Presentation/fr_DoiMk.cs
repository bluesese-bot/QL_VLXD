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
    public partial class fr_DoiMk : Form
    {
        string tk = "";
        E_tb_User thucthi = new E_tb_User();
        EC_tb_User ck = new EC_tb_User();
        public fr_DoiMk()
        {
            InitializeComponent();
        }
        public fr_DoiMk(string TK)
        {
            InitializeComponent();
            this.tk = TK;
        }
        void loadForm()
        {
            textBox1.Text = "* Mật Khẩu Cũ";
            textBox2.Text = "* Mật Khẩu Mới";
            textBox3.Text = "* Mật Khẩu Mới";
            textBox1.ForeColor = Color.LightGray;
            textBox2.ForeColor = Color.LightGray;
            textBox3.ForeColor = Color.LightGray;
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "* Mật Khẩu Cũ")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "* Mật Khẩu Cũ";
                textBox1.ForeColor = Color.LightGray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "* Mật Khẩu Mới")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "* Mật Khẩu Mới";
                textBox2.ForeColor = Color.LightGray;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "* Mật Khẩu Mới")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "* Mật Khẩu Mới";
                textBox3.ForeColor = Color.LightGray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ck.USERNAME = tk;
            ck.PASSWORD = textBox2.Text;
            thucthi.suamk(ck,textBox1.Text);
            MessageBox.Show("Đã Sửa Thành Công Thành Công mk", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadForm();
        }
    }
}
