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
        Game game; Picture pic;
        int lev = 20; int position;
        int size = 4;
        Button[,] button;
        public static int count_img = 0, a=0;
        public static Image[] big_img;
        
        public FormGame15()
        {
            InitializeComponent();
            game = new Game(size);
            pic = new Picture(size);
            start_pic();
            generatoin_buttom();
            game.start();
            start_game();
            pictureBox1.Size = new Size(size * 65, size * 65);
        }

        private void start_pic()
        {
            big_img = new Image[size];
            big_img[0] = (Image)Game15.Properties.Resources._1;
            pic.loading(big_img[0]);
            pictureBox1.Image = big_img[0];
        }

        private void generatoin_buttom()
        {
            button = new Button[size, size];
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
                    //button[i, j].Text = a.ToString();
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
                //but(position).Text = n.ToString();
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
            for (int i = 0; i < 5; i++)
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
                            button[i, j].BackgroundImage = pic.img1.Images[(count_img*size*size)+(n - 1)];
                        }
                    }
                }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            size = 4; //Не знаю как перезапустить форму с новым zize
            //lev = 20;
            //?? this.Refresh();

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            size = 6;//Не знаю как перезапустить форму с новым zize
            //lev = 50;

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            size = 8;//Не знаю как перезапустить форму с новым zize
            //lev = 100;

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormHelp newForm = new FormHelp();
            newForm.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImage = new OpenFileDialog();
            openImage.Filter = "Imege Files(*.JPG;*.PNG)|*.JPG;*.PNG|All files(*.*)|*.*";
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image img = Image.FromFile(openImage.FileName);
                    pic.loading(img);
                    count_img++;
                    big_img[count_img] = pic.img;
                    pictureBox1.Image = big_img[count_img];
                    a++;
                    start_game();
                    buttonRight.Enabled = true;
                    buttonLeft.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть файл!");
                }
            }
            else return;
            
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if (count_img == 0)
            {
                pictureBox1.Image = big_img[count_img];
                buttonLeft.Enabled = false;
            }
            else
            {
                buttonRight.Enabled = true;
                count_img--;
                pictureBox1.Image = big_img[count_img];
                refresh();
            }
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            if (a == count_img) buttonRight.Enabled = false;
            else
            {
                buttonLeft.Enabled = true;
                count_img++;
                pictureBox1.Image = big_img[count_img];
                refresh();
            }
        }

       

    }
}
