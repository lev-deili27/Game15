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
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();
           pictureBox1.Image = Control.big_img[Control.count_img];
        }
    }
}
