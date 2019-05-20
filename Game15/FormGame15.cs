using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game15
{
    public partial class FormGame15 : Form
    {

        Control con;
        public FormGame15()
        {
            int size = 4;
            InitializeComponent();
            con = new Control(size);
            generatoin_buttom(size);
            pictureBox1.Size = new Size(size * 65, size * 65);
            pictureBox1.Image = con.start_pic();
            
        }

        private void generatoin_buttom(int size)
        {
            con.generatoin_buttom();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Controls.Add(con.button[i, j]);
                }

            }
            con.refresh();
        }


        private void menu_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            con.start_game();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            int size = 4; 
            con.delete_button();
            con = new Control(size);
            generatoin_buttom(size);
            pictureBox1.Size = new Size(size * 65, size * 65);
            pictureBox1.Image = con.start_pic();

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            
            int size = 6;
            con.delete_button();
            con = new Control(size);
            generatoin_buttom(size);
            pictureBox1.Size = new Size(size * 65, size * 65);
            pictureBox1.Image = con.start_pic();

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            int size = 8;
            con.delete_button();
            con = new Control(size);
            generatoin_buttom(size);
            pictureBox1.Size = new Size(size * 65, size * 65);
            pictureBox1.Image = con.start_pic();

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormHelp newForm = new FormHelp();
            newForm.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (con.Add_pictire() == true)
            {
                pictureBox1.Image = Control.big_img[Control.count_img];
                buttonRight.Enabled = true;
                buttonLeft.Enabled = true;
            }
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if (con.Left_Click() == false)
            {
                pictureBox1.Image = Control.big_img[Control.count_img];
                buttonLeft.Enabled = false;
            }
            else
            {
                buttonRight.Enabled = true;
                pictureBox1.Image = Control.big_img[Control.count_img];
            }
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {

            if (con.Right_Click() == false)
            {
                buttonRight.Enabled = false;
            }
            else
            {
                buttonLeft.Enabled = true;
                pictureBox1.Image = Control.big_img[Control.count_img];
            }
        }

       

    }
}
