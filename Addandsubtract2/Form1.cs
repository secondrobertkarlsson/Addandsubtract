using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Addandsubtract2
{
    public partial class Form1 : Form
    {
        int sum;

        public Form1()
        {
            InitializeComponent();
            sum = 0;
            labelSum.Text = sum.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            sum++;
            labelSum.Text = sum.ToString();
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            sum--;
            labelSum.Text = sum.ToString();
        }
    }
}
