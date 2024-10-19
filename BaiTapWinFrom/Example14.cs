using System;
using System.Drawing;
using System.Windows.Forms;

namespace BaiTapWinFrom
{
    public partial class Example14 : Form
    {
        private const int moveDistance = 20; // Khoảng cách di chuyển ảnh theo pixel

        public Example14()
        {
            InitializeComponent();
            this.KeyPreview = true; // Cho phép form bắt sự kiện bàn phím
        }

        private void Example14_Load(object sender, EventArgs e)
        {
            // Thiết lập form có thể bắt sự kiện bàn phím
            this.KeyDown += new KeyEventHandler(Example14_KeyDown);
        }

        private void chonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                anh.SizeMode = PictureBoxSizeMode.StretchImage;
                anh.ImageLocation = openFileDialog.FileName;
            }
        }

        private void Example14_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra phím nhấn
            if (e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Right) // Phím ">" hoặc mũi tên phải
            {
                MovePictureBoxRight(); // Di chuyển ảnh sang phải
            }
            else if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.Left) // Phím "<" hoặc mũi tên trái
            {
                MovePictureBoxLeft(); // Di chuyển ảnh sang trái
            }
        }

        // Hàm di chuyển ảnh sang phải
        private void MovePictureBoxRight()
        {
            anh.Location = new Point(anh.Location.X + moveDistance, anh.Location.Y);
        }

        // Hàm di chuyển ảnh sang trái
        private void MovePictureBoxLeft()
        {
            anh.Location = new Point(anh.Location.X - moveDistance, anh.Location.Y);
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            MovePictureBoxLeft(); // Di chuyển ảnh sang trái khi nhấn nút "<-"
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            MovePictureBoxRight(); // Di chuyển ảnh sang phải khi nhấn nút "->"
        }

        private void anh_Click(object sender, EventArgs e)
        {

        }
    }
}
