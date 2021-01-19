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
    public partial class svxs : Form
    {
        public svxs()
        {
            InitializeComponent();
        }
        public void show()
        {
            DataSet ds = new DataSet();
            connect db = new connect();
            ds = db.truyvan("select id_lop as 'Mã Lớp',id_sinhvien as 'Mã Sinh Viên',diemthi as 'Điểm Thi' from diemthi where diemthi >9");
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void svxs_Load(object sender, EventArgs e)
        {
            show();
        }
    }
}
