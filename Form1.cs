using System.Drawing.Drawing2D;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace portfolio_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            Skills sk = new Skills();
            this.Hide();
            sk.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Education ed = new Education();
            this.Hide();
            ed.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Achivements ac = new Achivements();
            this.Hide();
            ac.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            About AB = new About();
            this.Hide();
            AB.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Certification cf = new Certification();
            this.Hide();
            cf.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Contact CN = new Contact();
            this.Hide();
            CN.Show();
        }


       

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

