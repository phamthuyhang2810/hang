using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PhamThuyHang_T7
{
    public partial class Form22 : Form
    {
        private List<Employee> lstEmp; // Danh sách nhân viên
        private BindingSource bs = new BindingSource(); // BindingSource để liên kết dữ liệu

        public Form22()
        {
            InitializeComponent();
            
        }

        // Phương thức lấy dữ liệu nhân viên ban đầu
        public List<Employee> GetData()
        {
            // Khởi tạo danh sách nhân viên mẫu
            List<Employee> lstEmp = new List<Employee>();

            Employee em1 = new Employee
            {
                Id = "53418",
                Name = "Trần Tiến",
                Age = 20,
                Gender = true // Nam
            };
            lstEmp.Add(em1);

            Employee em2 = new Employee
            {
                Id = "53416",
                Name = "Nguyễn Cường",
                Age = 25,
                Gender = true // Nam
            };
            lstEmp.Add(em2);

            Employee em3 = new Employee
            {
                Id = "53417",
                Name = "Nguyễn Hào",
                Age = 23,
                Gender = false // Nữ
            };
            lstEmp.Add(em3);

            return lstEmp;
        }

        // Sự kiện khi form load
        private void Form22_Load(object sender, EventArgs e)
        {
            lstEmp = GetData(); // Lấy dữ liệu nhân viên
            bs.DataSource = lstEmp; // Gán danh sách nhân viên cho BindingSource
            dgvEmployee.AutoGenerateColumns = true; // Để DataGridView tự tạo cột
            dgvEmployee.DataSource = bs; // Gán BindingSource cho DataGridView
        }

        // Sự kiện khi bấm nút "Thêm mới"
        private void btAddNew_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng Employee mới và gán giá trị từ các điều khiển
            Employee em = new Employee
            {
                Id = tbId.Text,
                Name = tbName.Text,
                Age = int.Parse(tbAge.Text),
                Gender = ckGender.Checked // Lấy giá trị từ checkbox
            };

            // Thêm nhân viên mới vào danh sách và BindingSource
            lstEmp.Add(em);
            bs.ResetBindings(false); // Làm mới BindingSource để cập nhật DataGridView
        }

        private void btDeleteNew_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentRow != null) // Kiểm tra nếu có hàng được chọn
            {
                int idx = dgvEmployee.CurrentCell.RowIndex; // Lấy chỉ số hàng được chọn

                // Xóa nhân viên khỏi danh sách và DataGridView
                lstEmp.RemoveAt(idx);
                bs.ResetBindings(false); // Làm mới BindingSource để cập nhật DataGridView
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        // Sự kiện khi chọn hàng trong DataGridView
        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex; // Lấy chỉ số hàng được chọn

            // Kiểm tra xem chỉ số hàng có hợp lệ không
            if (idx >= 0 && idx < dgvEmployee.Rows.Count && dgvEmployee.Rows[idx].Cells[0].Value != null)
            {
                // Gán giá trị của các ô trong hàng được chọn vào các TextBox và Checkbox
                tbId.Text = dgvEmployee.Rows[idx].Cells[0].Value.ToString();
                tbName.Text = dgvEmployee.Rows[idx].Cells[1].Value.ToString();
                tbAge.Text = dgvEmployee.Rows[idx].Cells[2].Value.ToString();

                // Chuyển đổi giá trị của giới tính và gán cho checkbox
                ckGender.Checked = Convert.ToBoolean(dgvEmployee.Rows[idx].Cells[3].Value);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

   
}
