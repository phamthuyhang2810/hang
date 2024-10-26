using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhamThuyHang_T7.QLSV
{
    public partial class DN : Form
    {
        public DN()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       

        

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SinhVien f = new SinhVien();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
