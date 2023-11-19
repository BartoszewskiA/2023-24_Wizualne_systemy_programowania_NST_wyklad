using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w02p03
{
    public partial class Form1 : Form
    {

        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(i<progressBar1.Maximum)
                i++;
            else
                timer1.Stop();
            label1.Text = i.ToString();
            progressBar1.Value = i;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (i >= progressBar1.Maximum)
                i = 0;
                timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = 1001 - trackBar1.Value * 100;
        }
    }
}
