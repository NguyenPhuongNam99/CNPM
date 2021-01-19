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
    public partial class giaovien : Form
    {
        public giaovien()
        {
            InitializeComponent();
            DataSet ds = new DataSet();
            connect db = new connect();
            ds = db.truyvan("select * from lop");
            comboBoxmalop.DataSource = ds.Tables[0];
            comboBoxmalop.DisplayMember = "tenlop";
            comboBoxmalop.ValueMember = "id_lop";
        }
        public void show()
        {
            DataSet ds = new DataSet();
            connect db = new connect();
            ds = db.truyvan("select giaovien.id_giaovien,giaovien.tengiaovien,lop.id_lop from giaovien inner join lop on giaovien.id_lop= lop.id_lop");
            dataGridView1gvien.DataSource = ds.Tables[0];
        }

        private void buttonhienthi_Click(object sender, EventArgs e)
        {
            show();
        }

        private void button4them_Click(object sender, EventArgs e)
        {
            connect db = new connect();
            bool b = db.capnhatdb("insert into giaovien(id_giaovien,tengiaovien,id_lop) values(N'" + textBoxmagv.Text + "','" + textBox1tengv.Text + "',N'" + comboBoxmalop.SelectedValue + "' )");
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
            bool b = db.capnhatdb("update giaovien set id_giaovien='" + textBoxmagv.Text + "',tengiaovien ='" + textBox1tengv.Text+ "',id_lop='" + comboBoxmalop.SelectedValue+ "' where id_giaovien = '"+textBoxupdate.Text+"' ");
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

        private void button2xoa_Click(object sender, EventArgs e)
        {
            connect db = new connect();
            bool b = db.capnhatdb("delete from giaovien where id_giaovien ='" + textBoxupdate.Text + "'");
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

        private void buttonTimkiem_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            connect db = new connect();
            ds = db.truyvan("Select id_giaovien,tengiaovien,id_lop from giaovien where id_giaovien ='" + textBoxupdate.Text + "' ");
            dataGridView1gvien.DataSource = ds.Tables[0];
        }

        private void dataGridView1gvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxmagv.Text = dataGridView1gvien.CurrentRow.Cells[0].Value.ToString();
            textBox1tengv.Text = dataGridView1gvien.CurrentRow.Cells[1].Value.ToString();
            comboBoxmalop.SelectedValue = dataGridView1gvien.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
