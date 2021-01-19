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
    public partial class khoa : Form
    {
        public khoa()
        {
            InitializeComponent();
        }
        public void show()
        {
            DataSet ds = new DataSet();
            connect db = new connect();
            ds = db.truyvan("select khoa.id_khoa,khoa.tenkhoa,lop.id_lop,lop.tenlop,lop.id_giaovien,lop.id_monhoc from khoa inner join lop on khoa.id_khoa = lop.id_khoa");
            dataGridView1k.DataSource = ds.Tables[0];
        }
        private void button1hienthi_Click(object sender, EventArgs e)
        {
            show();

        }

        private void button2them_Click(object sender, EventArgs e)
        {
            connect db = new connect();
            bool b = db.capnhatdb("insert into khoa(id_khoa,tenkhoa) values(N'" + textBox1makhoa.Text+ "','" + textBox1tenkhoa.Text + "')");
            if (b == true)
            {
                MessageBox.Show("cập nhật cơ sở dữ liệu thành công");
                show();
            }
            else
            {
                MessageBox.Show("cập nhật thất bại");
            }
        }

        private void button3sua_Click(object sender, EventArgs e)
        {
            connect db = new connect();
            bool b = db.capnhatdb("update khoa set id_khoa='" + textBox1makhoa.Text + "',tenkhoa ='" + textBox1tenkhoa.Text + "' where id_khoa ='" + textBox1upda.Text + "' ");
            if (b == true)
            {
                MessageBox.Show("sửa thành công");
                show();
            }
            else
            {
                MessageBox.Show("failed");
            }
        }

        private void khoa_Load(object sender, EventArgs e)
        {
            show();
        }
    }
}
