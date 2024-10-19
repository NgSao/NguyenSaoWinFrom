using System;
using System.Windows.Forms;

namespace BaiTapWinFrom
{
    public partial class Example15 : Form
    {
        private Timer timer;  // Timer để chạy đồng hồ
        private int seconds = 0;  // Đếm thời gian bằng giây

        public Example15()
        {
            InitializeComponent();
        }

        private void Example15_Load(object sender, EventArgs e)
        {
            // Khởi tạo timer và cấu hình
            timer = new Timer();
            timer.Interval = 1000; // Cập nhật mỗi 1 giây
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Mỗi lần timer tick, tăng số giây và cập nhật thời gian hiển thị
            seconds++;
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            timeLabel.Text = time.ToString(@"hh\:mm\:ss"); // Hiển thị định dạng giờ:phút:giây
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer.Start(); // Bắt đầu chạy đồng hồ
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop(); // Dừng đồng hồ
        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
