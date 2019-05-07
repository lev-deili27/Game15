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
        Game game;
        int lev = 20; int position;
        static int size = 4;
        Button[,] button = new Button[size, size];
        ImageList im = new ImageList();

        public FormGame15()
        {
            InitializeComponent();
            game = new Game(4);
            generatoin_buttom();
            game.start();
            start_game();
        }

        private void generatoin_buttom()
        {
            int a = 0;
      
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    button[i, j] = new Button();
                    button[i, j].Size = new Size(65, 65);
                    button[i, j].Location = new Point(j*65, 23+i*65);
                    button[i, j].Tag = a;
                    button[i, j].Name = "button" + a;
                    button[i, j].Click += ButtonOnClick;
                    button[i, j].Text = a.ToString();
                    this.Controls.Add(button[i, j]);
                    a++;
                }
                                
            }
        }

        private void ButtonOnClick(object sender, EventArgs e)
        {
            position = Convert.ToInt16(((Button)sender).Tag);
            game.shift(position);
            refresh();
            if (game.check())
            {
                pictureBox1.Visible = true;
                MessageBox.Show("Вы победили!");
                // menu_Click(sender, e);
            }
        }
        
        private void refresh()
        {
            for (int position = 0; position < size*size; position++)
            {
                int n = game.get_num(position);
                  but(position).Text = n.ToString();
                if (n > 0)
                {
                    but(position).Visible = true;
                    picture(position, n);

                }
                else but(position).Visible = false;
            }
        }

        private Button but(int position)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if ((int)button[i, j].Tag == position)
                    {
                        return button[i, j];
                    }
                }
            }
            return null;
        }

        private void menu_Click(object sender, EventArgs e)
        {
            game.start();
            start_game();
        }

        private void start_game()
        {
            pictureBox1.Visible = false;
            for (int i = 0; i < lev; i++)
            {
                game.mixing();
            }
           refresh();
        }

        private void picture(int position, int n)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if ((int)button[i, j].Tag == position)
                    {
                        button[i, j].BackgroundImage = imageList1.Images[n-1];
                    }
                }
            }
           
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            lev = 20;
            start_game();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            lev = 50;
            start_game();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            lev = 100;
            start_game();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormHelp newForm = new FormHelp();
            newForm.Show();
        }

    }
}
