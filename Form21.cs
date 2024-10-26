using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace PhamThuyHang_T7
{
    public partial class Form21 : Form
    {

        List<Employee> lst = new List<Employee>();
        public Form21()
        {

            InitializeComponent();
           
        }
        

        public List<Employee> GetData()
        {
            

            Employee em1 = new Employee
            {
                Id = "53418",
                Name = "Trần Tiến",
                Age = 20
            };
            lst.Add(em1);

            Employee em2 = new Employee
            {
                Id = "53416",
                Name = "Nguyễn Cường",
                Age = 25
            };
            lst.Add(em2);

            Employee em3 = new Employee
            {
                Id = "53417",
                Name = "Nguyễn Hào",
                Age = 23
            };
            lst.Add(em3);

            return lst;
        }

        private void Form21_Load(object sender, EventArgs e)
        {
            List<Employee> lst = GetData(); // Declare and initialize the list

            foreach (Employee em in lst)
            {
                dgvEmployee.Rows.Add(em.Id, em.Name, em.Age);
            }
            // Load data or initialize components here if needed
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng Employee mới
            Employee em = new Employee
            {
                Id = tbId.Text,
                Name = tbName.Text,
                Age = int.TryParse(tbAge.Text, out int age) ? age : 0,
                Gender = radioButton1.Checked // Giới tính dựa trên radio button
            };

            // Thêm nhân viên vào danh sách
            lst.Add(em);

            // Thêm thông tin nhân viên vào DataGridView
            dgvEmployee.Rows.Add(em.Id, em.Name, em.Age, em.Gender);

            // Xóa dữ liệu nhập sau khi thêm
            tbId.Clear();
            tbName.Clear();
            tbAge.Clear();
            radioButton1.Checked = false; // Hoặc ckGender.Checked = false nếu bạn sử dụng checkbox
        }


        private void btDeleteNew_Click(object sender, EventArgs e)
        {


            int idx= dgvEmployee.CurrentCell.RowIndex;

                lst.RemoveAt(idx);

                dgvEmployee.Rows.RemoveAt(idx);

            
        }


        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex; // Lấy chỉ số hàng hiện tại

            if (idx >= 0) // Kiểm tra xem chỉ số có hợp lệ không
            {
                tbId.Text = dgvEmployee.Rows[idx].Cells[0].Value.ToString(); // Lấy giá trị Mã
                tbName.Text = dgvEmployee.Rows[idx].Cells[1].Value.ToString(); // Lấy giá trị Tên
                tbAge.Text = dgvEmployee.Rows[idx].Cells[2].Value.ToString(); // Lấy giá trị Tuổi
                ckGender.Checked = bool.Parse(dgvEmployee.Rows[idx].Cells[3].Value.ToString()); // Lấy giá trị Giới tính
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

    }
}
