using System;
using System.Windows.Forms;

namespace QuanLyPhongTro
{
    public partial class Form1 : Form
    {
        private Admin admin = new Admin { Id = 1,name="SaoNguyen", username = "sao", password = "123" };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            string inputUsername = tbTen.Text.Trim(); 
            string inputPassword = tbMk.Text.Trim(); 

            // Kiểm tra nếu username hoặc password bị để trống
            if (string.IsNullOrEmpty(inputUsername) || string.IsNullOrEmpty(inputPassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (inputUsername == admin.username && inputPassword == admin.password)
            {
                MessageBox.Show($"Đăng nhập thành công!\nTên: {admin.name}\nChào mừng đến với Quản lý phòng trọ!",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MainForm mainForm = new MainForm();
                this.Hide();  
                mainForm.Show(); 
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
