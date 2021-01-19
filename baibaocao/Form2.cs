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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            DataSet ds = new DataSet();
            connect db = new connect();
            ds = db.truyvan("select * from lop");
            comboBoxmalop.DataSource = ds.Tables[0];
            comboBoxmalop.DisplayMember = "tenlop";
            comboBoxmalop.ValueMember = "id_lop";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void show()
        {
            DataSet ds = new DataSet();
            connect db = new connect();
            ds = db.truyvan("select sinhvien.id_sinhvien as 'Mã Sinh Viên',tensinhvien as 'Tên Sinh Viên',sinhvien.id_lop as 'Mã Lớp',quequan as 'Quê Quán' from sinhvien inner join lop on  lop.id_lop=sinhvien.id_lop ");
            dataGridView1.DataSource = ds.Tables[0];
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            connect db = new connect();
            bool b = db.capnhatdb("insert into sinhvien(id_sinhvien,tensinhvien,id_lop,quequan) values(N'" + textBoamasv.Text + "','" + textBoxtensv.Text + "',N'" + comboBoxmalop.SelectedValue + "',N'" + textBoxquequan.Text + "')");
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

        private void button3_Click(object sender, EventArgs e)
        {
            show();
        }

        private void buttonsua_Click(object sender, EventArgs e)
        {
            connect db = new connect();
            bool b = db.capnhatdb("update sinhvien set id_sinhvien='" + textBoamasv.Text + "',tensinhvien ='" + textBoxtensv.Text + "',id_lop='" +comboBoxmalop.SelectedValue + "',quequan='" + textBoxquequan.Text + "' where id_sinhvien ='" + textBoxsua.Text + "' ");
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

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            connect db = new connect();
            bool b = db.capnhatdb("delete from sinhvien where id_sinhvien ='" + textBoamasv.Text + "'");
            if (b == true)
            {
                MessageBox.Show("xóa thanh công");
                show();
            }
            else
            {
                MessageBox.Show(" xóa thất bại");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoamasv.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxtensv.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBoxmalop.SelectedValue = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxquequan.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            connect db = new connect();
            ds = db.truyvan("Select * from sinhvien where id_sinhvien ='" + textBox1.Text + "' ");
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
