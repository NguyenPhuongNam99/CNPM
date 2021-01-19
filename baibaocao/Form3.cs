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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
           
        }
        public void show()
        {
            DataSet ds = new DataSet();
            connect db = new connect();
            ds = db.truyvan("select diemthi.id_lop,diemthi.id_sinhvien,monhoc.id_monhoc,monhoc.tenmonhoc,diemthi.diemthi  from lop inner join diemthi on lop.id_lop = diemthi.id_lop inner join monhoc on  monhoc.id_monhoc = lop.id_monhoc where monhoc.status ='loading'");
            dataGridViewdiem.DataSource = ds.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonnhapdiem_Click(object sender, EventArgs e)
        {
            show();
        }

        private void dataGridViewdiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxidsinhvien.Text = dataGridViewdiem.CurrentRow.Cells[1].Value.ToString();
        }

        private void buttonnd_Click(object sender, EventArgs e)
        {
            connect db = new connect();
            bool b = db.capnhatdb("update diemthi set diemthi ='"+textBoxdiemthi.Text+"' where id_sinhvien ='" + textBoxidsinhvien.Text + "' ");
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

        private void button2_Click(object sender, EventArgs e)
        {
            importexcel im = new importexcel();
            im.Show();
        }
    }
}
