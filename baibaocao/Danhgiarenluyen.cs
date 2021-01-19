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
    public partial class Danhgiarenluyen : Form
    {
        public Danhgiarenluyen()
        {
            InitializeComponent();
           
            DataSet dss1 = new DataSet();
            connect dbb1 = new connect();
            dss1 = dbb1.truyvan("select * from mucdanhgia");
            comboBox1mucdanhgia.DataSource = dss1.Tables[0];
            comboBox1mucdanhgia.DisplayMember = "mucdanhgia";
            comboBox1mucdanhgia.ValueMember = "id_danhgia";

           

        }
        public void show()
        {
            DataSet ds = new DataSet();
            connect db = new connect();
            ds = db.truyvan("select id_lop,id_sinhvien,id_danhgia from danhgia_renluyen ");
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void button1hienthi_Click(object sender, EventArgs e)
        {
            show();
        }

        private void button1sua_Click(object sender, EventArgs e)
        {
            connect db = new connect();
            bool b = db.capnhatdb("update danhgia_renluyen set id_lop='" + textBox1malop.Text + "',id_sinhvien ='" + masv.Text + "',id_danhgia='" + comboBox1mucdanhgia.SelectedValue + "' where id_sinhvien ='" + textBox1up.Text + "' ");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1malop.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            masv.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox1mucdanhgia.SelectedValue = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
