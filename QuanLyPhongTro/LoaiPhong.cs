using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyPhongTro
{
    public partial class LoaiPhong : Form
    {
        List<RoomType> lst;

        public List<RoomType> GetData()
        {
            List<RoomType> lst = new List<RoomType>();
            RoomType em;

            em = new RoomType() { Id = 1, Name = "Loại A", Price = 200000m }; // Sử dụng decimal
            lst.Add(em);

            em = new RoomType() { Id = 2, Name = "Loại B", Price = 100000m }; // Sử dụng decimal
            lst.Add(em);

            em = new RoomType() { Id = 3, Name = "Loại C", Price = 300000m }; // Sử dụng decimal
            lst.Add(em);

            return lst;
        }

        public LoaiPhong()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(tbPhong.Text) || string.IsNullOrWhiteSpace(tbGia.Text) ||
                !decimal.TryParse(tbGia.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Vui lòng nhập đúng thông tin phòng và giá (giá phải lớn hơn 0).");
                return;
            }

            // Check for duplicate room name
            if (lst.Any(r => r.Name.Equals(tbPhong.Text, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Tên phòng đã tồn tại. Vui lòng nhập tên khác.");
                return;
            }

            // Create new RoomType
            RoomType newRoom = new RoomType
            {
                Id = lst.Count + 1, // Assign a new ID
                Name = tbPhong.Text,
                Price = price
            };

            // Add to list and DataGridView
            lst.Add(newRoom);
            dataGridView1.Rows.Add(newRoom.Id, newRoom.Name, newRoom.Price.ToString("N0") + " VNĐ"); // Format price

            MessageBox.Show("Thêm phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputs();
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (dataGridView1.CurrentRow == null || string.IsNullOrWhiteSpace(tbPhong.Text) ||
                string.IsNullOrWhiteSpace(tbGia.Text) ||
                !decimal.TryParse(tbGia.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Vui lòng chọn phòng để cập nhật và nhập đúng thông tin (giá phải lớn hơn 0).");
                return;
            }

            // Get the index of the selected row
            int idx = dataGridView1.CurrentRow.Index;

            // Check for duplicate room name, except for the current one
            if (lst.Where((r, index) => index != idx).Any(r => r.Name.Equals(tbPhong.Text, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Tên phòng đã tồn tại. Vui lòng nhập tên khác.");
                return;
            }

            // Update the RoomType in the list
            lst[idx].Name = tbPhong.Text;
            lst[idx].Price = price;

            // Update DataGridView
            dataGridView1.Rows[idx].Cells[1].Value = lst[idx].Name;
            dataGridView1.Rows[idx].Cells[2].Value = lst[idx].Price.ToString("N0") + " VNĐ"; // Format price

            MessageBox.Show("Cập nhật phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputs();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int idx = dataGridView1.CurrentRow.Index;
                lst.RemoveAt(idx);
                dataGridView1.Rows.RemoveAt(idx);
                ClearInputs();

                MessageBox.Show("Xóa phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phòng để xóa.");
            }
        }

        private void ClearInputs()
        {
            tbPhong.Text = "";
            tbGia.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbPhong.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                // Lấy giá trị số nguyên mà không có định dạng tiền tệ
                string priceString = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbGia.Text = priceString.Replace(" VNĐ", "").Replace(",", ""); // Xóa tiền tệ và dấu phẩy
            }
        }

        private void LoaiPhong_Load_1(object sender, EventArgs e)
        {
            lst = GetData();
            foreach (RoomType em in lst)
            {
                dataGridView1.Rows.Add(em.Id, em.Name, em.Price.ToString("N0") + " VNĐ"); // Format price
            }
        }
    }
}
