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
    public partial class monhoc : Form
    {
        public monhoc()
        {
            InitializeComponent();
            DataSet ds = new DataSet();
            connect db = new connect();
            ds = db.truyvan("select * from khoa");
            comboBox1makhoa.DataSource = ds.Tables[0];
            comboBox1makhoa.DisplayMember = "tenkhoa";
            comboBox1makhoa.ValueMember = "id_khoa";
           
        }
        public void show()
        {
            DataSet ds = new DataSet();
            connect db = new connect();
            ds = db.truyvan("select id_monhoc,tenmonhoc,id_khoa,sotin,giamon,Status from monhoc ");
            dataGridView1monhoc.DataSource = ds.Tables[0];
        }
        private void monhoc_Load(object sender, EventArgs e)
        {

        }

        private void button1hienthi_Click(object sender, EventArgs e)
        {
            show();
        }

        private void button2them_Click(object sender, EventArgs e)
        {
            connect db = new connect();
            bool b = db.capnhatdb("insert into monhoc(id_monhoc,tenmonhoc,id_khoa,sotin,giamon,Status) values(N'" + textBox1mamh.Text + "','" + textBox2tenmh.Text + "',N'" + comboBox1makhoa.SelectedValue + "',N'" + textBox4sotin.Text + "',N'" + textBox5dongia.Text+ "',N'" + textBox1status.Text + "')");
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
            bool b = db.capnhatdb("update monhoc set id_monhoc='" + textBox1mamh.Text + "',tenmonhoc ='" + textBox2tenmh.Text + "',id_khoa='" + comboBox1makhoa.SelectedValue + "',sotin='" + textBox4sotin.Text + "',giamon='" + textBox5dongia.Text + "',Status ='"+textBox1status.Text+"' where id_monhoc ='" + textBox1update.Text + "' ");
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

        private void button4xoa_Click(object sender, EventArgs e)
        {
            connect db = new connect();
            bool b = db.capnhatdb("delete from monhoc where id_monhoc ='" + textBox1update.Text + "'");
            if (b == true)
            {
                MessageBox.Show("xóa thanh công");
                show();
            }
            else
            {
                MessageBox.Show("thất bại");
            }
        }

        private void button5timkiem_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            connect db = new connect();
            ds = db.truyvan("Select id_monhoc,tenmonhoc,id_khoa,sotin,giamon,Status from monhoc where id_monhoc ='" +textBox1update.Text + "' ");
            dataGridView1monhoc.DataSource = ds.Tables[0];
        }
         
        private void dataGridView1monhoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1mamh.Text = dataGridView1monhoc.CurrentRow.Cells[0].Value.ToString();
            textBox2tenmh.Text = dataGridView1monhoc.CurrentRow.Cells[1].Value.ToString();
            comboBox1makhoa.SelectedValue = dataGridView1monhoc.CurrentRow.Cells[2].Value.ToString();
            textBox4sotin.Text = dataGridView1monhoc.CurrentRow.Cells[3].Value.ToString();
            textBox5dongia.Text = dataGridView1monhoc.CurrentRow.Cells[4].Value.ToString();
            textBox1status.Text = dataGridView1monhoc.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
