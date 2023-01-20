using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdk05
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //client
            var control = new Control(button1.Text);
            control.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //realtor
            var control = new Control(button2.Text);
            control.ShowDialog();
        }
    }
}
