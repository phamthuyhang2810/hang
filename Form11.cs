using System;
using System.Windows.Forms;

namespace PhamThuyHang_T7
{
    public partial class Form11 : Form
    {
        decimal memory = 0;
        decimal workingMemory = 0;
        string opr = "";

        public Form11()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;

            // Xử lý nhập số và dấu chấm
            if ((char.IsDigit(bt.Text, 0) && bt.Text.Length == 1) || bt.Text == ".")
            {
                txtDisplay.Text += bt.Text;
            }
            // Xử lý phép tính (+, -, *, /)
            else if (bt.Text == "*" || bt.Text == "/" || bt.Text == "+" || bt.Text == "-")
            {
                if (!string.IsNullOrEmpty(txtDisplay.Text))  // Kiểm tra ô hiển thị không rỗng
                {
                    opr = bt.Text;
                    workingMemory = decimal.Parse(txtDisplay.Text);  // Lưu giá trị hiện tại
                    txtDisplay.Clear();  // Xóa ô hiển thị để nhập số tiếp theo
                }
            }
            // Xử lý dấu bằng "="
            else if (bt.Text == "=")
            {
                if (!string.IsNullOrEmpty(txtDisplay.Text))  // Kiểm tra ô hiển thị không rỗng
                {
                    decimal seconValue = decimal.Parse(txtDisplay.Text);  // Lấy giá trị thứ hai
                    switch (opr)
                    {
                        case "+":
                            txtDisplay.Text = (workingMemory + seconValue).ToString();
                            break;
                        case "-":
                            txtDisplay.Text = (workingMemory - seconValue).ToString();
                            break;
                        case "*":
                            txtDisplay.Text = (workingMemory * seconValue).ToString();
                            break;
                        case "/":
                            if (seconValue != 0)  // Kiểm tra chia cho 0
                            {
                                txtDisplay.Text = (workingMemory / seconValue).ToString();
                            }
                            else
                            {
                                MessageBox.Show("Không thể chia cho 0");
                                txtDisplay.Clear();
                            }
                            break;
                    }
                    workingMemory = 0;  // Reset giá trị sau khi tính
                    opr = "";  // Reset phép toán
                }
            }
            // Xử lý đổi dấu "±"
            else if (bt.Text == "±")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                currVal = -currVal;
                txtDisplay.Text = currVal.ToString();
            }
            // Xử lý căn bậc hai "√"
            else if (bt.Text == "√")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                if (currVal > 0)
                {
                    currVal = (decimal)Math.Sqrt((double)currVal);
                    txtDisplay.Text = currVal.ToString();
                }
                else
                {
                    MessageBox.Show("Không thể thực hiện phép tính căn bậc hai cho số âm");
                }
            }
            // Xử lý phần trăm "%"
            else if (bt.Text == "%")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                currVal = currVal / 100;
                txtDisplay.Text = currVal.ToString();
            }
            // Xử lý chia ngược "1/x"
            else if (bt.Text == "1/x")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                if (currVal != 0)
                {
                    currVal = 1 / currVal;
                    txtDisplay.Text = currVal.ToString();
                }
                else
                {
                    MessageBox.Show("Không thể chia cho 0");
                }
            }
            // Xóa ký tự cuối "←"
            else if (bt.Text == "←")
            {
                if (txtDisplay.TextLength != 0)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.TextLength - 1);
                }
            }
            // Xóa bộ nhớ "MC"
            else if (bt.Text == "MC")
            {
                memory = 0;
            }
            // Đọc bộ nhớ "MR"
            else if (bt.Text == "MR")
            {
                txtDisplay.Text = memory.ToString();
            }
            // Lưu vào bộ nhớ "MS"
            else if (bt.Text == "MS")
            {
                memory = decimal.Parse(txtDisplay.Text);
                txtDisplay.Clear();
            }
            // Cộng vào bộ nhớ "M+"
            else if (bt.Text == "M+")
            {
                memory += decimal.Parse(txtDisplay.Text);
            }
            // Trừ bộ nhớ "M-"
            else if (bt.Text == "M-")
            {
                memory -= decimal.Parse(txtDisplay.Text);
            }
            // Xóa tất cả "C"
            else if (bt.Text == "C")
            {
                workingMemory = 0;
                opr = "";
                txtDisplay.Clear();
            }
            // Xóa dữ liệu hiện tại "CE"
            else if (bt.Text == "CE")
            {
                txtDisplay.Clear();
            }
        }

        // Kiểm soát nhập từ bàn phím
        private void txtDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        // Các sự kiện khác (nếu có)
        private void Form1_Load(object sender, EventArgs e) { }

        private void txtDisplay_TextChanged(object sender, EventArgs e) { }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }
}
