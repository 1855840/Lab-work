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
    public partial class frarray : Form
    {
        

        Int32[] iArray2 = new Int32[5];
        Int32[] iArray3 = new Int32[5] { 21, 22, 23, 24, 25 };

        Int32[] iArray4 = new Int32[] { 11, 12, 13, 14, 15 };

        Int32[] iArray5 = { 31, 32, 33, 34, 35 };
        public frarray()
        {
            InitializeComponent();
            

        }

        private void frarray_Load(object sender, EventArgs e)
        {

        }

        private void btnArray_Click(object sender, EventArgs e)
        {
            for (Int32 i=1; i < 5; i++)
            {
                iArray3[i] = 5 * i;
                MessageBox.Show(Convert.ToString(iArray3[i]));
            }
            
        }

        private void btnForeach_Click(object sender, EventArgs e)
        {
            foreach (Int32 j in iArray3)
            {
                MessageBox.Show(Convert.ToString(j));
            }
        }

        private void btnnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
