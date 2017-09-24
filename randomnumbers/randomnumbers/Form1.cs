using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace randomnumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string newLine = Environment.NewLine;
            int nums = rnd.Next(0, 1001);
            textBox1.Text = nums.ToString();
            for(int i=1; i <=100; i++)
            {
                nums = rnd.Next(0, 1001);
                textBox1.Text = textBox1.Text +newLine + nums.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }
    }
}
