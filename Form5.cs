using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhamThuyHang_T7
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"D:\Key_Logger.txt", true);
            sw.Write(e.KeyCode);
            sw.Close();

        }
    }
}
