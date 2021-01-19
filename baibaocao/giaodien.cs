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
    public partial class giaodien : Form
    {
        public giaodien()
        {
            InitializeComponent();
            customizeDesing();

        }

        private void customizeDesing()
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel5.Visible = false;
            panel4.Visible = false;
        }
        private void hideSubMenu()
        {
            if(panel1.Visible == true)
            {
                panel1.Visible = false;
            }
            if(panel2.Visible == true)
            {
                panel2.Visible = false;
            }
            if(panel5.Visible == true)
            {
                panel5.Visible = false;
            }
            if (panel4.Visible == true)
            {
                panel4.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void paneslidemenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openchildForm(new Form2());
            showSubMenu(panel1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openchildForm(new Form3());
            showSubMenu(panel1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
           // openchildForm(new Form3());
            showSubMenu(panel1);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            showSubMenu(panel2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openchildForm(new updatelop());
            showSubMenu(panel2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openchildForm(new giaovien());
           
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            showSubMenu(panel5);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openchildForm(new monhoc());
            showSubMenu(panel5);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
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
            panel7.Controls.Add(childform);
            panel7.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            openchildForm(new Danhgiarenluyen());
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            openchildForm(new khoa());
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            showSubMenu(panel4);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void iconButton9solgsv_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            svxs sv = new svxs();
            sv.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            SV sv = new SV();
            sv.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            TKMONHOC tk = new TKMONHOC();
            tk.Show();
        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr1 = new Form1();
            fr1.Show();
        }
    }
}
