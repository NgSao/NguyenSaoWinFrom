using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyPhongTro
{
    public partial class Phong : Form
    {
        private List<Room> roomList;

        public Phong()
        {
            InitializeComponent();
            roomList = new List<Room>();
        }

        private void Phong_Load(object sender, EventArgs e)
        {
            roomList.Add(new Room { Id = 1, Name = "Loại A", RoomName = "Phòng 01", Price = 200000m, Status = "Hoạt động" });
            roomList.Add(new Room { Id = 2, Name = "Loại B", RoomName = "Phòng 02", Price = 250000m, Status = "Không hoạt động" });
            roomList.Add(new Room { Id = 3, Name = "Loại C", RoomName = "Phòng 03", Price = 300000m, Status = "Hoạt động" });

            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            dataGridView1.Rows.Clear(); 
            foreach (var room in roomList)
            {
                dataGridView1.Rows.Add(room.Id, room.Name, room.RoomName, room.Price.ToString("N0") + " VNĐ", room.Status); // Thêm hàng mới
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            int newId = roomList.Any() ? roomList.Max(r => r.Id) + 1 : 1;
            XuLyPhong form = new XuLyPhong(newId); 
            if (form.ShowDialog() == DialogResult.OK)
            {
                Room newRoom = form.Room;
                roomList.Add(newRoom); 
                LoadDataGrid(); 
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int index = dataGridView1.CurrentRow.Index;
                roomList.RemoveAt(index); 
                LoadDataGrid();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phòng để xóa.");
            }
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string searchText = tbTimkiem.Text.ToLower(); 
            var filteredRooms = roomList.Where(r => r.RoomName.ToLower().Contains(searchText) ||
                                                    r.Name.ToLower().Contains(searchText)).ToList();

            dataGridView1.Rows.Clear();
            foreach (var room in filteredRooms)
            {
                dataGridView1.Rows.Add(room.Id, room.Name, room.RoomName, room.Price.ToString("N0") + " VNĐ", room.Status);
            }

            if (filteredRooms.Count == 0)
            {
                MessageBox.Show("Không tìm thấy phòng nào.");
            }
        }
    }
}
