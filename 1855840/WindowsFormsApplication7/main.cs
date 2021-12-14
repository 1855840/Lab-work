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
    public partial class akn : Form
    {
        public akn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void log_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Log in succsessfully");
        }

        private void btnRadio_Click(object sender, EventArgs e)
        {
            frmRadio frm = new frmRadio();
            frm.ShowDialog();
        }

        private void btncobo_Click(object sender, EventArgs e)
        {
            frmcombo frm = new frmcombo();
            frm.ShowDialog();
        }

        private void btnfood_Click(object sender, EventArgs e)
        {
            frmcheck frm = new frmcheck();
            frm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_Click(object sender, EventArgs e)
        {
            Formlog frm = new Formlog();
            frm.ShowDialog();
        }

        private void btntorandom_Click(object sender, EventArgs e)
        {
            Frmrandom frm = new Frmrandom();
            frm.ShowDialog();
        }

        private void btnrandomcombo_Click(object sender, EventArgs e)
        {
            Frrandomcombo frm = new Frrandomcombo();
            frm.ShowDialog();
        }

        private void array_Click(object sender, EventArgs e)
        {
            frarray frm = new frarray();
            frm.ShowDialog();
        }

        private void BtnArray2_Click(object sender, EventArgs e)
        {
            frmArray frm = new frmArray();
            frm.ShowDialog();
        }
    }
}
