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
    public partial class SV : Form
    {
        public SV()
        {
            InitializeComponent();
        }
        public void show()
        {
            DataSet ds = new DataSet();
            connect db = new connect();
            ds = db.truyvan("select COUNT(id_sinhvien) as 'SLSV',id_lop as 'Mã Lớp' from sinhvien group by id_lop");
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void SV_Load(object sender, EventArgs e)
        {
            show();
        }
    }
}
