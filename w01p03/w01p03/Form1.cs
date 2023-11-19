using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w01p03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Text = e.Location.X.ToString() + " : " + e.Location.Y.ToString();
            if (e.Button == MouseButtons.Left)
                label1.Text += " lewy";
            else if (e.Button == MouseButtons.Right)
                label1.Text += " prawy";
            else if (e.Button == MouseButtons.Middle)
                label1.Text += " Srodkowy";
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
       /*     label1.Text = e.Location.X.ToString() + " : " + e.Location.Y.ToString();*/
        }
    }
}
