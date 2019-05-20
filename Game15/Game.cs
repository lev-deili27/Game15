using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Game15
{
    class Game
    {
        int size, space_x, space_y;
        public int[,] m;
        static Random rand = new Random();

        public Game (int size)
        {
            if (size < 2) size = 2;
            if (size > 8) size = 8;
            this.size = size;
            m = new int[size, size];
        }

        public void start()
        {
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    m[x, y] = coordinates_to_position(x, y) + 1;
                }
            }
            space_x = size - 1;
            space_y = size - 1;
            m[space_x, space_y] = 0;
        }

        public void shift(int position)
        {
            int x, y;
            position_to_coordnates(position, out x, out y);
            if ((Math.Abs(space_x - x) + Math.Abs(space_y - y)) == 1)
            {
                m[space_x, space_y] = m[x, y];
                m[x, y] = 0;
                space_x = x;
                space_y = y;
            }
        }

        public int get_num(int position)
        {
            int x, y;
            position_to_coordnates(position, out x, out y);
            if (x < 0 || x >= size) return 0;
            if (y < 0 || y >= size) return 0;
            return m[x, y];
        }
        private int coordinates_to_position(int x, int y)
        {
            if (x < 0) x = 0;
            if (x > size-1) x = size - 1;
            if (y < 0) y = 0;
            if (y > size - 1) y = size - 1;
            return y * size + x;
        }

        public void position_to_coordnates(int position, out int x, out int y)
        {
            if (position < 0) position = 0;
            if (position > size * size - 1) position = size * size - 1;
            x = position % size;
            y = position / size;
        }

        public void mixing()
        {
            for (int i = 0; i < size -1; i++)
            {
                for (int j = 0; j < size -1; j++)
                {
                    
                    int a = rand.Next(j + 1);
                    int b = rand.Next(i + 1);
                    var temp = m[b,a];
                    m[b,a] = m[i,j];
                    m[i,j] = temp;
                    if (m[i, j] == 0)
                    {
                        space_x = i;
                        space_y = j;
                    }
                }
            }
            mix_check();

            //int a = rand.Next(0, 4);
            //int x = space_x, y = space_y;
            //switch (a)
            //{
            //    case 0: x--; break;
            //    case 1: x++; break;
            //    case 2: y--; break;
            //    case 3: y++; break;
            //}
            //shift(coordinates_to_position(x, y));
        }

        public void mix_check()
        {
            int inv = 0;
            for (int i = 1; i < size; i++)
            {
                for (int j = 1; j < size; j++)
                {
                    if (m[i - 1, j - 1] > m[i, j])
                    {
                        inv++;
                    }
                }
            }
            int c = inv+1;
            //MessageBox.Show("c = " + c+ " inv = "+ inv+ " y = " + space_y+" x = " +space_x);
            if (c % 2 == 0)
            {
                return;
            }
            else
            {
                mixing();
            }

        }

        public bool check()
        {
            if (!(space_x == size - 1) &&
               (space_y == size - 1))
                return false;

                for (int x = 0; x < size; x++)
                {
                    for (int y = 0; y < size; y++)
                    {
                        if(!((x==size-1)&&(y==size-1)))
                        if (m[x, y] != coordinates_to_position(x, y) + 1) return false;
                    }
                }
                return true;
        }

        public int space_but()
        {
            return coordinates_to_position(space_x, space_y);
        }

    }
}
