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
    public partial class dangky : Form
    {
        public dangky()
        {
            InitializeComponent();
        }

        private void dangky_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect db = new connect();
            bool b = db.capnhatdb("insert into Admin(taikhoan,matkhau,thuoctinh,hoten,gmail) values(N'" + textBox3tk.Text + "','" + textBox4mk.Text+ "',N'" + textBox5tt.Text+ "',N'" + textBox1hoten.Text + "',N'" + textBox2gmail.Text + "' )");
            if (b == true)
            {
                MessageBox.Show("cập nhật cơ sở dữ liệu thành công");
               
            }
            else
            {
                MessageBox.Show("cập nhật thất bại");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
