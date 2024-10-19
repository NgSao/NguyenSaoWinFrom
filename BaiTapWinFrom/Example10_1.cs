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

namespace BaiTapWinFrom
{
    public partial class Example10_1 : Form
    {
        public Example10_1()
        {
            InitializeComponent();
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            if (listBH.SelectedItem != null) // Kiểm tra có bài hát được chọn không
            {
                Song song = (Song)listBH.SelectedItem;
                string id = song.Id.ToString();
                string name = song.Name;
                string author = song.Author;
                listYT.Items.Add(id + " - " + name + " - " + author); // Thêm vào danh sách yêu thích

                ArrayList lst = (ArrayList)listBH.DataSource; // Lấy DataSource (ArrayList)
                lst.Remove(song); // Xóa bài hát đã chọn từ ArrayList

                listBH.DataSource = null; // Đặt DataSource thành null để cập nhật lại danh sách
                listBH.DataSource = lst; // Gán lại DataSource
                listBH.DisplayMember = "Name"; // Gán lại DisplayMember
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
                // Lấy danh sách gốc từ DataSource của listBH
                ArrayList lstBH = (ArrayList)listBH.DataSource;

                // Lấy bài hát được chọn từ listYT (dạng chuỗi "id - name - author")
                string bh = listYT.SelectedItem.ToString();

                // Tách chuỗi để lấy thông tin bài hát
                string[] parts = bh.Split('-');
                string id = parts[0].Trim();
                string name = parts[1].Trim();
                string author = parts[2].Trim();

                // Tạo đối tượng bài hát mới
                Song song = new Song { Id = id, Name = name, Author = author };

                // Thêm bài hát vào danh sách gốc (listBH)
                lstBH.Add(song);

                // Cập nhật lại DataSource cho listBH
                listBH.DataSource = null; // Đặt null để cập nhật lại danh sách
                listBH.DataSource = lstBH;
                listBH.DisplayMember = "Name"; // Hiển thị lại theo thuộc tính Name

                // Xóa bài hát khỏi danh sách yêu thích (listYT)
                listYT.Items.RemoveAt(listYT.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bài hát để chuyển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        // Chuyển toàn bộ bài hát từ listBH sang listYT
        private void btnPP_Click(object sender, EventArgs e)
        {
            ArrayList lst = (ArrayList)listBH.DataSource; // Lấy DataSource (ArrayList)
            foreach (Song song in lst.ToArray()) // Dùng ToArray để tránh lỗi khi thay đổi Collection
            {
                string id = song.Id.ToString();
                string name = song.Name;
                string author = song.Author;
                listYT.Items.Add(id + " - " + name + " - " + author); // Thêm vào danh sách yêu thích
            }

            // Xóa tất cả các bài hát trong ArrayList và cập nhật lại DataSource
            lst.Clear();
            listBH.DataSource = null; // Đặt DataSource thành null để cập nhật lại danh sách
            listBH.DataSource = lst; // Gán lại DataSource
            listBH.DisplayMember = "Name"; // Gán lại DisplayMember
        }



        // Chuyển toàn bộ bài hát từ listYT về listBH
        private void btnTT_Click(object sender, EventArgs e)
        {
            ArrayList lstBH = (ArrayList)listBH.DataSource; // Lấy danh sách gốc từ DataSource của listBH

            while (listYT.Items.Count > 0)
            {
                string bh = listYT.Items[0].ToString(); // Lấy bài hát đầu tiên từ listYT

                // Tách chuỗi để lấy thông tin bài hát (định dạng "id - name - author")
                string[] parts = bh.Split('-');
                string id = parts[0].Trim();
                string name = parts[1].Trim();
                string author = parts[2].Trim();

                // Tạo lại đối tượng bài hát
                Song song = new Song { Id = id, Name = name, Author = author };

                // Thêm bài hát vào danh sách gốc (listBH)
                lstBH.Add(song);

                // Xóa bài hát đã chuyển khỏi listYT
                listYT.Items.RemoveAt(0);
            }

            // Cập nhật lại DataSource cho listBH
            listBH.DataSource = null; // Đặt null để cập nhật lại danh sách
            listBH.DataSource = lstBH;
            listBH.DisplayMember = "Name"; // Hiển thị lại theo thuộc tính Name
        }




        public ArrayList GetData()
        {
            ArrayList lst = new ArrayList();
            Song s = new Song();

            // Bài hát 1
            s = new Song();
            s.Id = "290604";
            s.Name = "Ngôi Sao May Mắn";
            s.Author = "Nguyễn Sao";
            lst.Add(s);

            // Bài hát 2
            s = new Song();
            s.Id = "290605";
            s.Name = "Hoa Hải Đường";
            s.Author = "Jack";
            lst.Add(s);

            // Bài hát 3
            s = new Song();
            s.Id = "290606";
            s.Name = "Sóng Gió";
            s.Author = "Jack & K-ICM";
            lst.Add(s);

            // Bài hát 4
            s = new Song();
            s.Id = "290607";
            s.Name = "Bạc Phận";
            s.Author = "Jack & K-ICM";
            lst.Add(s);

            // Bài hát 5
            s = new Song();
            s.Id = "290608";
            s.Name = "Đừng Chờ Anh Nữa";
            s.Author = "Tăng Phúc";
            lst.Add(s);

            // Bài hát 6
            s = new Song();
            s.Id = "290609";
            s.Name = "Chúng Ta Của Hiện Tại";
            s.Author = "Sơn Tùng M-TP";
            lst.Add(s);

            return lst;
        }

        private void listBH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Example10_1_Load_1(object sender, EventArgs e)
        {
            ArrayList lst = GetData();
            listBH.DataSource = lst;
            listBH.DisplayMember = "Name";
        }
    }
}
