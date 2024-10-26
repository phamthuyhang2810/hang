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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = dateTimePicker1.Value.ToLongDateString();
        }
        private void dtDate_Valuechanged(object sender, EventArgs e)
        {
            this.Text = dateTimePicker1.Value.ToShortDateString();
        }
    }
}
