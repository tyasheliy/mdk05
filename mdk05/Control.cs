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
    public partial class Control : Form
    {
        private readonly string _role;
        public Control(string role)
        {
            InitializeComponent();
            _role = role;
            label1.Text = _role;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {

        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
