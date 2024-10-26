using System;
using System.Collections;
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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        public ArrayList GetData()
        {

            ArrayList lst = new ArrayList();

            Faculty f = new Faculty();

            f.Id = "K01";

            f.Name = "Công nghệ thông tin";

            f.Quantity = 1200;

            lst.Add(f);

            f = new Faculty();

            f.Id = "k02";

            f.Name = "Ngoại Ngữ";

            f.Quantity = 4200;

            lst.Add(f);

            f = new Faculty();

            f.Id = "K03";

            f.Name = "Quan trị kinh doanh";

            f.Quantity = 5200;

            lst.Add(f);

            f = new Faculty();

            f.Id = "k04";

            f.Name = "Cơ khí";

            f.Quantity = 4200;

            lst.Add(f);

            f = new Faculty();

            f.Id = "K05";

            f.Name = "Điện";

            f.Quantity = 5200;

            lst.Add(f);

            f = new Faculty();

            f.Id = "k06";

            f.Name = "Quản trị kinh doan";

            f.Quantity = 4200;

            lst.Add(f);

            f = new Faculty();

            f.Id = "K07";

            f.Name = "Cơ khí động lực";

            f.Quantity = 5200;

            lst.Add(f);

            return lst;

        }

        private void Form13_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();

            cb_Faculty.DataSource = lst;

            cb_Faculty.DisplayMember = "Name";

        }
        private void cb_Faculty_SelectedValueChanged(object sender, EventArgs e)
        {
            cb_Faculty.ValueMember = "Id";

            // Sửa cú pháp khai báo và gán giá trị cho id
            string id = cb_Faculty.SelectedValue.ToString();

            // Sử dụng id để hiển thị trong tbDisplay
            tbDisplay.Text = "Bạn đã chọn khoa có mã: " + id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cb_Faculty.ValueMember = "Name";

            // Sửa cú pháp khai báo và gán giá trị cho name
            string name = cb_Faculty.SelectedValue.ToString();

            // Sử dụng name để hiển thị trong tbDisplay
            tbDisplay.Text = "Bạn đã chọn khoa có tên: " + name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Làm sạch nội dung của TextBox
            tbDisplay.Text = string.Empty;

            // Đặt lại ComboBox về giá trị mặc định (nếu cần)
            if (cb_Faculty.Items.Count > 0)
            {
                cb_Faculty.SelectedIndex = -1; // Hoặc cb_Faculty.SelectedIndex = 0; để chọn mục đầu tiên
            }
        }

    }
}
