using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace portfolio_C_
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

            Form1 fs = new Form1();
            this.Hide();
            fs.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
