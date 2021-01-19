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
    public partial class xemttsv : Form
    {
        public xemttsv()
        {
            InitializeComponent();
        }
        public void show()
        {
            DataSet ds = new DataSet();
            connect db = new connect();
            ds = db.truyvan("select id_sinhvien as 'Mã Lớp',tensinhvien as 'Tên Sinh Viên' ,id_lop as 'Mã Lớp',quequan as'Quê Quán' from sinhvien");
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            connect db = new connect();
            ds = db.truyvan("select id_sinhvien as 'Mã Lớp',tensinhvien as 'Tên Sinh Viên' ,id_lop as 'Mã Lớp',quequan as'Quê Quán' from sinhvien where id_sinhvien = '"+textBox1.Text+"'");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void xemttsv_Load(object sender, EventArgs e)
        {
            show();
        }
    }
}
