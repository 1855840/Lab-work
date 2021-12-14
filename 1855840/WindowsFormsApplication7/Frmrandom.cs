using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Frmrandom : Form
    {
        Random y= new Random();

        public Frmrandom()
        {
            InitializeComponent();
        }

        private void btnrandom_Click(object sender, EventArgs e)
        {
            btnrandom.Text = Convert.ToString(y.Next(1, 100));
        }

        private void btnbackgg_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btngenerate_Click(object sender, EventArgs e)
        {
            int r = y.Next(0, 255);
            int g = y.Next(0, 255);
            int b = y.Next(0, 255);

            btngenerate.BackColor = Color.FromArgb(r, g, b);
            lblcolorrandom.Text = Convert.ToString(r) + "-" + Convert.ToString(g) + "-" + Convert.ToString(b);
        }
    }
}
