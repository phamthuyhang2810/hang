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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSoX.Text);
            int y = int.Parse(tbSoY.Text);
            int kq = x + y;
            tbKetQua.Text = tbKetQua.Text + x.ToString() + " + " + y.ToString() + "=" + kq.ToString() + "\r\n";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSoX.Text);
            int y = int.Parse(tbSoY.Text);
            int kq = x * y;
            tbKetQua.Text = tbKetQua.Text + x.ToString() + " * " + y.ToString() + "=" + kq.ToString() + "\r\n";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("caculator.txt", true))
                {
                    // Ghi kết quả vào tệp
                    sw.WriteLine(tbKetQua.Text);
                }
                MessageBox.Show("Kết quả đã được lưu vào caculator.txt.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu vào tệp: " + ex.Message);
            }
        }
    }
}
