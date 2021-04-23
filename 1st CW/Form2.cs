using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1st_CW
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int counter;
        private void button1_Click(object sender, EventArgs e)
        {
            counter--;
            label1.Text = counter.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            counter++;
            label2.Text = counter.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
