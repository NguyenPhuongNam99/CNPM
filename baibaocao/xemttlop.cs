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
    public partial class xemttlop : Form
    {
        public xemttlop()
        {
            InitializeComponent();
        }
        public void show()
        {
            DataSet ds = new DataSet();
            connect db = new connect();
            ds = db.truyvan("select lop.id_lop as 'Mã Lớp',lop.tenlop as 'Tên Lớp',lop.id_khoa as 'Mã Khoa',lop.id_giaovien as'Mã Giao Viên',lop.id_monhoc as 'Mã Môn Học' from lop inner join giaovien on lop.id_giaovien=giaovien.id_giaovien inner join monhoc on lop.id_monhoc = monhoc.id_monhoc");
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void xemttlop_Load(object sender, EventArgs e)
        {
            show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            connect db = new connect();
            ds = db.truyvan("select lop.id_lop as 'Mã Lớp',lop.tenlop as 'Tên Lớp',lop.id_khoa as 'Mã Khoa',lop.id_giaovien as'Mã Giao Viên',lop.id_monhoc as 'Mã Môn Học' from lop inner join giaovien on lop.id_giaovien=giaovien.id_giaovien inner join monhoc on lop.id_monhoc = monhoc.id_monhoc where lop.id_lop ='"+textBox1.Text+"'");
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
