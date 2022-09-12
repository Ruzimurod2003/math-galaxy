using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MGalaktika
{
    public partial class Left : UserControl
    {
        public Left()
        {
            InitializeComponent();
        }

        private void Birinchi(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"d:\MGalaktika\MGalaktika\MGalaktika\Rasmlar\Fizika.jpg");
        }

        private void Birinchi_1(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"d:\MGalaktika\MGalaktika\MGalaktika\Rasmlar\Biologiya.jpg");
        }
    }
}
