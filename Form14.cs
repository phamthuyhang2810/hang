using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhamThuyHang_T7
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form14_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = null;
            int dict = 0;
            if (rbMale.Checked == true)
            
                msg += "ông";
            
            if (rbFemale.Checked == true)
            
                msg += "bà";
            if (checkBox1.Checked == true)
            {
                dict = 5;
                richTextBox1.Text = msg + tbname.Text + " được giảm " + dict.ToString() + "%" + "\r\n";
            }
        }
        private void ckDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true )
            {
                tbresult.Enabled = true;

            }
            else
            {
                tbresult.Enabled = false;
            }
        }
    }
}
