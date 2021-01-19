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
    public partial class xemttmh : Form
    {
        public xemttmh()
        {
            InitializeComponent();
        }
        public void show()
        {
            DataSet ds = new DataSet();
            connect db = new connect();
            ds = db.truyvan("select id_monhoc as 'Môn Học',tenmonhoc as 'Tên Môn Học',id_khoa as'Tên Khoa',sotin as 'Số Tín' from monhoc");
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void xemttmh_Load(object sender, EventArgs e)
        {
            show();
        }
    }
}
