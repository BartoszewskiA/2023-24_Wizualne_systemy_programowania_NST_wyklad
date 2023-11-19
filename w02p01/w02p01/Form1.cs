using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w02p01
{
    public partial class Form1 : Form
    {
        int ile = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

    /*        if (e.KeyChar == 'a')
            {
                ile++;

            }
            else if(e.KeyChar=='z')
            {
                ile--;
            }
            
            label1.Text = ile.ToString();*/
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Up)
            {
                ile++;

            }
            else if (e.KeyCode==Keys.Down)
            {
                ile--;
            }

            label1.Text = ile.ToString();
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            label1.ForeColor = Color.LightGray;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           /*if( MessageBox.Show("Czy zamknąć aplikację?","Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) { e.Cancel = true; }*/
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
