using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w01p02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*   int a = int.Parse(textBox1.Text);
               int b = int.Parse(textBox2.Text);*/
            int a=0, b=0;
            if (!int.TryParse(textBox1.Text, out a))
            {
                a = 0;
                textBox1.Text = a.ToString();
            }
            if (!int.TryParse(textBox2.Text, out b)) 
            {
                b = 0;
                textBox2.Text = b.ToString();
            }


            label1.Text = (a + b).ToString();
        }
    }
}
