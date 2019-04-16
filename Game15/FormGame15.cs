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
        int lev=20;
        public FormGame15()
        {
            InitializeComponent();
            game = new Game(4);
            game.start();
            start_game();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int position = Convert.ToInt16(((Button)sender).Tag);
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
            for (int position = 0; position < 16; position++)
            {
                int n=game.get_num(position);
              //  button(position).Text = n.ToString();
                if (n > 0)
                {
                    button(position).Visible = true;
                    picture(position, n);

                }
                else button(position).Visible = false;
            }
        }
        private Button button(int position)
        {
            switch (position)
            {
                case 0: return button0;
                case 1: return button1;
                case 2: return button2;
                case 3: return button3;
                case 4: return button4;
                case 5: return button5;
                case 6: return button6;
                case 7: return button7;
                case 8: return button8;
                case 9: return button9;
                case 10: return button10;
                case 11: return button11;
                case 12: return button12;
                case 13: return button13;
                case 14: return button14;
                case 15: return button15;
                default: return null;
            }
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
            switch (n)
            {
                case 1: button(position).BackgroundImage = Game15.Properties.Resources._01_01; break;
                case 2: button(position).BackgroundImage = Game15.Properties.Resources._02_01; break;
                case 3: button(position).BackgroundImage = Game15.Properties.Resources._03_01; break;
                case 4: button(position).BackgroundImage = Game15.Properties.Resources._04_01; break;
                case 5: button(position).BackgroundImage = Game15.Properties.Resources._05_01; break;
                case 6: button(position).BackgroundImage = Game15.Properties.Resources._06_01; break;
                case 7: button(position).BackgroundImage = Game15.Properties.Resources._07_01; break;
                case 8: button(position).BackgroundImage = Game15.Properties.Resources._08_01; break;
                case 9: button(position).BackgroundImage = Game15.Properties.Resources._09_01; break;
                case 10: button(position).BackgroundImage = Game15.Properties.Resources._10_01; break;
                case 11: button(position).BackgroundImage = Game15.Properties.Resources._11_01; break;
                case 12: button(position).BackgroundImage = Game15.Properties.Resources._12_01; break;
                case 13: button(position).BackgroundImage = Game15.Properties.Resources._13_01; break;
                case 14: button(position).BackgroundImage = Game15.Properties.Resources._14_01; break;
                case 15: button(position).BackgroundImage = Game15.Properties.Resources._15_01; break;
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
