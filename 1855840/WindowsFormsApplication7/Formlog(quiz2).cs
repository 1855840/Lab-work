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
    public partial class Formlog : Form
    {
        public Formlog()
        {
            InitializeComponent();
        }

        private void btngpa_Click(object sender, EventArgs e)
        {
            Gpa frm = new Gpa();
            frm.ShowDialog();
        }
    }
}
