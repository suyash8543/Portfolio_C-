using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace portfolio_C_
{
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            string url = "https://www.linkedin.com/in/suyashtripathi8543";

            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            string url = "https://github.com/suyash8543";

            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label11_Click(object sender, EventArgs e)
        {
            Form1 fs = new Form1();
            this.Hide();
            fs.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "stripathi8543@gmail.com";

            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://leetcode.com/u/Suyash8543/";

            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });

        }
    }
}
