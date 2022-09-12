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
    public partial class Header_test : UserControl
    {
        public Header_test()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myTextBox.Text);
        }
    }
}
