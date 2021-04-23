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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            DialogResult result = MessageBox.Show("Would you like to Color Form", "Event click",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            MessageBox.Show($"Your choose: {result}", "Info");
            if (result == DialogResult.Yes)
            {
                //this.BackColor = Color.LightBlue;
                this.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Load Form", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Form closed", "Event FromClosed");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Повезло повезло");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            this.BackgroundImage = Image.FromFile(@"C:\Users\tlvla\Desktop\c###\image" + random.Next(1, 7) + ".jpg");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
        double opacity;
        private void button4_Click(object sender, EventArgs e)
        {
            opacity += 0.1;
            this.Opacity = opacity;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            opacity -= 0.1;
            this.Opacity = opacity;
        }
    }
}
