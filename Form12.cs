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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            cb_Faculty.SelectedIndex = 2;
        
        }
        private void cb_Faculty_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Lấy chỉ mục được chọn
            int index = cb_Faculty.SelectedIndex;

            // Sửa lỗi chuỗi hiển thị
            tbDisplay.Text = "Bạn đã chọn khoa thứ: " + index.ToString();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            // Lấy giá trị của mục được chọn
            string item = cb_Faculty.SelectedItem.ToString();

            // Hiển thị kết quả khi bấm OK
            tbDisplay.Text = "Bạn là sinh viên khoa: " + item;
        }
    }
}
