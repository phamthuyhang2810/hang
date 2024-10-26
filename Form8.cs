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
    public partial class Form8cs : Form
    {
        public Form8cs()
        {
            InitializeComponent();
        }

        private void Form8cs_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSoX.Text);
            int y = int.Parse(tbSoY.Text);
            int kq = x + y;
            tbKetQua.Text = kq.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSoX.Text);
            int y = int.Parse(tbSoY.Text);
            int kq = x * y;
            tbKetQua.Text = kq.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
