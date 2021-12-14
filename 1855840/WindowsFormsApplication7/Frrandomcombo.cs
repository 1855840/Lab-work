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
    public partial class Frrandomcombo : Form
    {
        public Frrandomcombo()
        {
            InitializeComponent();
        }

        private void btngeneratcomb_Click(object sender, EventArgs e)
        {
            cmbrandom.ResetText();
            cmbrandom.Items.Clear();
            Random r = new Random();
            for (int i = 0; i < r.Next(1, 50) - 1; i++)
            {
                cmbrandom.Items.Add(r.Next(100, 9990));
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnbackgg_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
