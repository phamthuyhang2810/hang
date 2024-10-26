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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            this.Text = "Ariticle for Button";
            this.Size = new Size(500, 500);
        }
    }
}
