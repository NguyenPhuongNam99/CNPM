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
    public partial class tracuugv : Form
    {
        public tracuugv()
        {
            InitializeComponent();
        }
        public void show()
        {
            DataSet ds = new DataSet();
            connect db = new connect();
            ds = db.truyvan("select id_giaovien as 'Mã ',tengiaovien as 'Tên Giaos Viên',giaovien.id_lop as 'Lớp Chủ Nhiệm' from giaovien inner join sinhvien on giaovien.id_lop=sinhvien.id_lop where sinhvien.id_sinhvien ='"+textBox1masv.Text+"' ");
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void button1tracuu_Click(object sender, EventArgs e)
        {
            show();
        }

        private void textBox1masv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
