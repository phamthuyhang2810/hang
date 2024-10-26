using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PhamThuyHang_T7
{
    public partial class Form16 : Form
    {
        // Danh sách để lưu trữ thông tin sinh viên
        private List<string> studentList = new List<string>();

        public Form16()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string msg = null;

            // Kiểm tra giới tính
            if (rbMale.Checked)
                msg += "Nam ";
            if (rbFemale.Checked)
                msg += "Nữ";

            // Tạo thông tin sinh viên mới
            string studentInfo = tbname.Text + "\r\n" +
                                 "- Giới tính: " + msg + "\r\n" +
                                 "- Ngày Sinh: " + dtpNS.Value.ToShortDateString() + "\r\n" +
                                 "- Khoa: " + comboBox1.Text + "\r\n";

            // Thêm thông tin sinh viên mới vào danh sách
            studentList.Add(studentInfo);

            // Cập nhật richTextBox1 để hiển thị tất cả sinh viên
            richTextBox1.Clear(); // Xóa nội dung cũ
            foreach (var student in studentList)
            {
                richTextBox1.AppendText(student + "\r\n");
            }

            // Đặt lại giá trị đầu vào để nhập sinh viên mới
            tbname.Clear();
            rbMale.Checked = false;
            rbFemale.Checked = false;
            dtpNS.Value = DateTime.Now; // Đặt lại giá trị ngày sinh
            comboBox1.SelectedIndex = -1; // Đặt lại giá trị combobox
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            // Nếu cần khởi tạo các giá trị ban đầu cho combobox hoặc các điều khiển khác
        }
    }
}
