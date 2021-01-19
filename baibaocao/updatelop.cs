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
    public partial class updatelop : Form
    {
        public updatelop()
        {
            InitializeComponent();
        }
        public void show()
        {
            DataSet ds = new DataSet();
            connect db = new connect();
            ds = db.truyvan("select lop.id_lop as 'Mã Lớp',lop.tenlop,lop.id_khoa,lop.id_giaovien,giaovien.tengiaovien as'Tên Giaos Viên',lop.id_monhoc as 'Tên Lớp',sinhvien.id_sinhvien from lop inner join giaovien on lop.id_lop=giaovien.id_lop inner join sinhvien on lop.id_lop=sinhvien.id_lop");
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void buttonhienthi_Click(object sender, EventArgs e)
        {
            show();
        }

        private void buttonthem_Click(object sender, EventArgs e)
        {
            connect db = new connect();
            bool b = db.capnhatdb("insert into lop(id_lop,tenlop,id_khoa,id_giaovien,id_monhoc) values(N'" + textBoxmalop.Text + "','" +textBoxtenlop.Text + "',N'" + textBoxmakhoa.Text + "',N'" + textBoxmagv.Text+ "',N'" +  textBoxmamonhoc.Text+ "')");
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

        private void buttonsua_Click(object sender, EventArgs e)
        {
            connect db = new connect();
            bool b = db.capnhatdb("update lop set id_lop='" + textBoxmalop.Text + "',tenlop ='" + textBoxtenlop.Text + "',id_khoa='" + textBoxmakhoa.Text + "',id_giaovien ='" + textBoxmagv.Text + "',id_monhoc ='" + textBoxmamonhoc.Text + "' where id_Lop ='" +textBoxupdate.Text + "' ");
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
            bool b = db.capnhatdb("delete from lop where id_lop ='" + textBoxupdate.Text + "'");
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

        private void buttontimkiem_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            connect db = new connect();
            ds = db.truyvan("Select id_lop,tenlop,id_khoa,id_giaovien,id_monhoc from lop where id_lop ='"+textBoxupdate.Text+"' ");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxmalop.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxtenlop.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxmakhoa.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxmagv.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxmamonhoc.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
