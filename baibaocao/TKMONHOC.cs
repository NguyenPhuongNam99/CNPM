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
    public partial class TKMONHOC : Form
    {
        public TKMONHOC()
        {
            InitializeComponent();
        }
        public void show()
        {
            DataSet ds = new DataSet();
            connect db = new connect();
            ds = db.truyvan("select id_monhoc as 'Mã Môn Học',tenmonhoc as 'Tên Môn Học',id_khoa as 'Khoa',sotin as 'Số Tín' from monhoc");
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void TKMONHOC_Load(object sender, EventArgs e)
        {
            show();
        }
    }
}
