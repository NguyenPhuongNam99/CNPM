using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baibaocao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
            //them bang hoac them thuoc tinh
        {
            DataSet ds = new DataSet();
            connect db = new connect();
            if (sv.Checked == true)
            {
                ds = db.truyvan("select * from Admin where taikhoan ='" + textBox1.Text + "' and matkhau ='" + textBox2.Text + "' and thuoctinh= 'sinhvien'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("bạn đã đăng nhập thành công");
                    formsinhvien gd = new formsinhvien();
                    gd.Show();
                    this.Hide();
                    return;
                }
            }
            else {
                ds = db.truyvan("select * from Admin where taikhoan ='" + textBox1.Text + "' and matkhau ='" + textBox2.Text + "' and thuoctinh= 'admin'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("bạn đã đăng nhập thành công");
                    giaodien gd = new giaodien();
                    gd.Show();
                    this.Hide();
                    return;
                }
            }
                MessageBox.Show("Tài khoản hoặc mật khẩu sai");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            dangky dk = new dangky();
            dk.Show();
        }
    }
}
