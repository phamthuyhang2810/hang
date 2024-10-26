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
    public partial class Form10 : Form
    {
        decimal workingMemory = 0;
        string opr = "";
        public Form10()
        {
            InitializeComponent();
        }
        private System.Windows.Forms.TextBox tbDisplay;

        private void button1_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += bt0.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += bt1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += bt2.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += bt3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            opr = btPlus.Text;
            workingMemory = decimal.Parse(tbDisplay.Text);
            tbDisplay.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            opr = btMul.Text;
            workingMemory = decimal.Parse(tbDisplay.Text);
            tbDisplay.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            decimal secondValue = decimal.Parse(tbDisplay.Text);
            if (opr == "+")
                tbDisplay.Text = (workingMemory + secondValue).ToString();
            if (opr == "*")
                tbDisplay.Text = (workingMemory * secondValue).ToString();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }
    }
}
