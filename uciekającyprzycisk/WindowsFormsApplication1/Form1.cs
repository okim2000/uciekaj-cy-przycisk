using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Random los = new Random();
            int x = los.Next(this.Width-button1.Width);
            int y = los.Next(this.Height-button1.Height);

            Point p = new Point(x, y);


            button1.Location = p;
          
        }
    }
}
