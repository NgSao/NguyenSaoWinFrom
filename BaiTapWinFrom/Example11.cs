using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWinFrom
{
    public partial class Example11 : Form
    {
        public Example11()
        {
            InitializeComponent();
        }

        // Sự kiện khi nhấn nút chọn ảnh
        private void chonAnh_Click(object sender, EventArgs e)
        {
            // Tạo OpenFileDialog để chọn ảnh
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Chỉ cho phép chọn các tập tin ảnh
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            // Nếu người dùng chọn OK sau khi chọn file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Đặt chế độ hiển thị ảnh cho PictureBox (co dãn theo khung hình)
                anh.SizeMode = PictureBoxSizeMode.StretchImage;

                // Gán đường dẫn file ảnh vào PictureBox
                anh.ImageLocation = openFileDialog.FileName;
            }
        }

        // Sự kiện khi click vào PictureBox để hiện thông tin hoặc thực hiện hành động khác
        private void anh_Click(object sender, EventArgs e)
        {
            if (anh.Image != null) // Kiểm tra nếu có ảnh trong PictureBox
            {
                // Hiển thị thông báo về ảnh đang được hiển thị
                MessageBox.Show("Ảnh đang được hiển thị là: " + anh.ImageLocation, "Thông tin ảnh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Nếu chưa có ảnh, thông báo người dùng
                MessageBox.Show("Chưa có ảnh nào được chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
