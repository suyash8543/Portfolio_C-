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
    public partial class Achivements : Form
    {
        public Achivements()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label11_Click(object sender, EventArgs e)
        {

            Form1 fs = new Form1();
            this.Hide();
            fs.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.linkedin.com/posts/suyashtripathi8543_csharp-windowsforms-atmsystem-activity-7324560986730827776-CYMc?utm_source=share&utm_medium=member_desktop&rcm=ACoAAEdYIg8Bri0NR-G85_-0BeiUu3MKYcgtoLs";

            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.linkedin.com/posts/suyashtripathi8543_im-happy-to-share-my-first-billing-window-activity-7317291724177846272-WS6A?utm_source=share&utm_medium=member_desktop&rcm=ACoAAEdYIg8Bri0NR-G85_-0BeiUu3MKYcgtoLs";

            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
