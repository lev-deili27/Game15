using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Game15
{
    class Control 
    {
        Game game; Picture pic;
        int position;
        int size;
        public Button[,] button;
        public static int c;
        int count_img = 0, a = 0;
        public static Image[] big_img;
        int[] N;
        public Control(int size)
        {
            this.size = size;
            if (size < 2) size = 2;
            if (size > 8) size = 8;
            game = new Game(size);
            pic = new Picture(size);
            start_pic();
            generatoin_buttom();
            game.start();
            start_game();
            
        }

        public Image start_pic()
        {
            big_img = new Image[size];
            big_img[0] = (Image)Game15.Properties.Resources._1;
            pic.loading(big_img[0]);
            return big_img[0];
        }

        public void generatoin_buttom()
        {
            button = new Button[size, size];
            int a = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    button[i, j] = new Button();
                    button[i, j].Size = new Size(65, 65);
                    button[i, j].Location = new Point(j * 65, 23 + i * 65);
                    button[i, j].Tag = a;
                    button[i, j].Name = "button" + a;
                    button[i, j].Click += ButtonOnClick;
                    //button[i, j].Text = a.ToString();
                    a++;
                }

            }
        }

        public void ButtonOnClick(object sender, EventArgs e)
        {
            position = Convert.ToInt16(((Button)sender).Tag);
            game.shift(position);
            refresh();
            if (game.check())
            {
                but(game.space_but()).BackgroundImage = pic.img1.Images[(count_img * size * size) + (size * size-1)];
                but(game.space_but()).Visible = true;
                //f.pictureBox1.Visible = true;
                MessageBox.Show("Вы победили!");
            }
        }

        public void refresh()
        {
            int n;
                for (int position = 0; position < size * size; position++)
                {

                    n = game.get_num(position);
                   // but(position).Text = n.ToString();
                    if (n > 0)
                    {
                        but(position).Visible = true;
                        picture(position, n);

                    }
                    else but(position).Visible = false;
                }
        }

        public void Save(){
            using (StreamWriter str = new StreamWriter(@"E:\isd\Game15\SaveGame.txt"))
            {
                str.WriteLine(size);
                for (int position = 0; position < size * size; position++)
                {
                    int n = game.get_num(position);
                    str.WriteLine(n);
                }

               
                str.Close();
            }
        }

        public void loadSavedGame(){
            var fi = new FileInfo(@"E:\isd\Game15\SaveGame.txt");
            if (fi.Length == 0)
            {
                MessageBox.Show("Нет сохранненой игры.");
            }
            else
            {
                using (StreamReader str = new StreamReader(@"E:\isd\Game15\SaveGame.txt", System.Text.Encoding.Default))
                {
                    N = new int[size * size+1];
                    string line;
                    int i = 0;
                    while ((line = str.ReadLine())!=null)
                    {
                        N[i] = Convert.ToInt32(line);
                        i++;
                    }
                    rewrite_m();
                    refresh();
                }
            }
        }

        public int loadsize(){
            int s;
            using (StreamReader str = new StreamReader(@"E:\isd\Game15\SaveGame.txt", System.Text.Encoding.Default))
            {
                s = Convert.ToInt32(str.ReadLine());
            }
            return s;
        }

        private void rewrite_m()
        {
            int k = 1;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    game.m[j, i] = N[k];
                    k++;
                }
            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (game.m[j, i] == 0)
                    {
                        game.space_x = j;
                        game.space_y = i;
                    }
                }
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

        public void start_game()
        {
            game.start();
            game.mixing();
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
                        button[i, j].BackgroundImage = pic.img1.Images[(count_img * size * size) + (n - 1)];
                    }
                }
            }
        }

        public bool Left_Click()
        {
            if (count_img == 0)
            {
                return false;
            }
            else
            {
                count_img--;
                refresh();
                return true;
            }
        }

        public bool Right_Click()
        {
            if (a == count_img)
            {
                return false;
            }
            else
            {
                count_img++;
                refresh();
                return true;
            }
        }

        public bool Add_pictire()
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
                    a++;
                    //start_game();
                    refresh();
                    c = count_img;
                    return true;
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть файл!");
                    return false;
                }
            }
            else return false;
        }

        public void delete_button()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    button[i, j].Dispose();
                }

            }
        }

    }
}
