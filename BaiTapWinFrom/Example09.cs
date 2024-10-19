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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BaiTapWinFrom
{
    public partial class Example09 : Form
    {
        public Example09()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Example09_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();
            comboBox1.DataSource = lst;
            comboBox1.DisplayMember = "Name";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private int stt = 1;
        private void button2_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng có nhập họ và tên không
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập họ và tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem tên có chứa ký tự số hoặc ký tự đặc biệt hay không
            if (textBox1.Text.Any(char.IsDigit) || !textBox1.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Tên không được chứa số hoặc ký tự đặc biệt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra độ dài tên (ít nhất 3 ký tự)
            if (textBox1.Text.Length < 3)
            {
                MessageBox.Show("Tên phải có ít nhất 3 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy ngày sinh đã chọn
            DateTime ngaysinh = dateTimePicker1.Value;

            // Kiểm tra xem ngày sinh có nhỏ hơn ngày hiện tại không
            if (ngaysinh >= DateTime.Now)
            {
                MessageBox.Show("Ngày sinh phải nhỏ hơn ngày hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem giới tính đã được chọn hay không
            string gioitinh = null;
            if (radioButton1.Checked)
                gioitinh += "Nam ";
            else if (radioButton2.Checked)
                gioitinh += "Nữ ";
            else
            {
                MessageBox.Show("Vui lòng chọn giới tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem người dùng có chọn khoa không (khác "Chọn khoa")
            string name = comboBox1.SelectedItem != null ? ((Faculty)comboBox1.SelectedItem).Name : "Chưa chọn khoa";
            if (name == "Chọn khoa")
            {
                MessageBox.Show("Vui lòng chọn khoa?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo một chuỗi mới để thêm vào textBox2
            string newEntry = $"{stt}. {textBox1.Text}\r\n -Giới tính: {gioitinh}\r\n -Ngày Sinh: {ngaysinh.ToShortDateString()}\r\n -Khoa: {name}\r\n";

            // Cập nhật nội dung của textBox2
            textBox2.Text += newEntry;

            // Tăng chỉ số stt cho lần nhập tiếp theo
            stt++;
        }




        private void groupBox1_Enter(object sender, EventArgs e)
        {
         
        }
        public ArrayList GetData()
        {
            ArrayList lst = new ArrayList();
            Faculty f = new Faculty();


            f = new Faculty();
            f.Id = "K00";
            f.Name = "Chọn khoa";
            lst.Add(f);

            f = new Faculty();
            f.Id = "K01";
            f.Name = "Công nghệ thông tin";
            lst.Add(f);

            f = new Faculty();
            f.Id = "K02";
            f.Name = "Truyền thông mạng máy tính";
            lst.Add(f);

            f = new Faculty();
            f.Id = "K03";
            f.Name = "Kế toán tài chính";
            lst.Add(f);
            return lst;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
