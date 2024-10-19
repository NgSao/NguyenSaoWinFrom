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
    public partial class Example10 : Form
    {
        public Example10()
        {
            InitializeComponent();
        }

        private void baihat_TextChanged(object sender, EventArgs e)
        {

        }

        // Chuyển bài hát từ listBH sang listYT
        private void btnP_Click(object sender, EventArgs e)
        {
            if (listBH.SelectedItem != null) // Kiểm tra có bài hát được chọn không
            {
                string bh = listBH.SelectedItem.ToString();
                listYT.Items.Add(bh); // Thêm vào danh sách yêu thích
                listBH.Items.RemoveAt(listBH.SelectedIndex); // Xóa bài hát khỏi danh sách gốc
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bài hát để chuyển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Chuyển bài hát từ listYT về listBH
        private void btnT_Click(object sender, EventArgs e)
        {
            if (listYT.SelectedItem != null) // Kiểm tra có bài hát được chọn không
            {
                string bh = listYT.SelectedItem.ToString();
                listBH.Items.Add(bh); // Thêm vào danh sách gốc
                listYT.Items.RemoveAt(listYT.SelectedIndex); // Xóa bài hát khỏi danh sách yêu thích
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bài hát để chuyển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Chuyển toàn bộ bài hát từ listBH sang listYT
        private void btnPP_Click(object sender, EventArgs e)
        {
            while (listBH.Items.Count > 0)
            {
                string bh = listBH.Items[0].ToString(); // Lấy bài hát đầu tiên
                listYT.Items.Add(bh); // Thêm vào danh sách yêu thích
                listBH.Items.RemoveAt(0); // Xóa bài hát khỏi danh sách gốc
            }
        }

        // Chuyển toàn bộ bài hát từ listYT về listBH
        private void btnTT_Click(object sender, EventArgs e)
        {
            while (listYT.Items.Count > 0)
            {
                string bh = listYT.Items[0].ToString(); // Lấy bài hát đầu tiên
                listBH.Items.Add(bh); // Thêm vào danh sách gốc
                listYT.Items.RemoveAt(0); // Xóa bài hát khỏi danh sách yêu thích
            }
        }

        private void listBH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

