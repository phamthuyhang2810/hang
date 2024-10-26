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
    public partial class DoiMK : Form
    {
        public DoiMK()
        {
            InitializeComponent();
        }

        private void DoiMK_Load(object sender, EventArgs e)
        {

        }
       

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các textbox
            string matKhauCu = txbMatKhauCu.Text;
            string matKhauMoi = txbMatKhauMoi.Text;

            // Kiểm tra thông tin nhập vào
            if (string.IsNullOrWhiteSpace(matKhauCu) || string.IsNullOrWhiteSpace(matKhauMoi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //// Kiểm tra mật khẩu cũ
            //if (matKhauCu != MatKhauHienTai) // MatKhauHienTai là biến lưu mật khẩu hiện tại của người dùng
            //{
            //    MessageBox.Show("Mật khẩu cũ không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //// Cập nhật mật khẩu mới
            //MatKhauHienTai = matKhauMoi; // Cập nhật mật khẩu hiện tại

            MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Xóa các trường nhập liệu
            txbMatKhauCu.Clear();
            txbMatKhauMoi.Clear();
        }
    }
}

