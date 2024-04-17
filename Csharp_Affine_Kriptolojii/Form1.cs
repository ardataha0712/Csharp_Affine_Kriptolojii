using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Affine_Kriptoloji
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 CF = new Form2();
            this.Hide();
            CF.ShowDialog();
            this.Show();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 DCF = new Form3();
            this.Hide();
            DCF.ShowDialog();
            this.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 Help = new Form4();
            
            Help.ShowDialog();
            this.Show();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
