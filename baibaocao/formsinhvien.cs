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
    public partial class formsinhvien : Form
    {
        public formsinhvien()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private Form activeForm = null;
        private void openchildForm(Form childform)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel2.Controls.Add(childform);
            panel2.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            openchildForm(new xemttsv());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            openchildForm(new xemttlop());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            openchildForm(new tracuugv());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            openchildForm(new xemttmh());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 d = new Form1();
            d.Show();
        }
    }
}
