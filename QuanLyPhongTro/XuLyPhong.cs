using System;
using System.Windows.Forms;

namespace QuanLyPhongTro
{
    public partial class XuLyPhong : Form
    {
        private bool isAdding;
        public Room Room { get; private set; } 

        public XuLyPhong(int newId)
        {
            InitializeComponent();
            isAdding = true;
            Room = new Room { Id = newId };
            LoadRoomTypes(); 
            this.Text = "Thêm Phòng"; 
        }

        public XuLyPhong(Room existingRoom)
        {
            InitializeComponent();
            isAdding = false;
            Room = existingRoom; 
            LoadRoomTypes(); 
            textBoxRoomTypeName.Text = existingRoom.Name;
            textBoxRoomName.Text = existingRoom.RoomName;
            comboBoxStatus.Checked = existingRoom.Status == "Hoạt động"; 
        }

        private void LoadRoomTypes()
        {
            textBoxRoomTypeName.Items.Clear(); 
            textBoxRoomTypeName.Items.Add("Loại A");
            textBoxRoomTypeName.Items.Add("Loại B");
            textBoxRoomTypeName.Items.Add("Loại C");
            textBoxRoomTypeName.SelectedIndex = 0; 
        }

        private void btXacNhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxRoomTypeName.Text) ||
                string.IsNullOrWhiteSpace(textBoxRoomName.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin hợp lệ.");
                return;
            }

 
            Room.Name = textBoxRoomTypeName.Text;
            Room.RoomName = textBoxRoomName.Text; 
            Room.Price = 200000m; 
            Room.Status = comboBoxStatus.Checked ? "Hoạt động" : "Không hoạt động";

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; 
            Close();
        }

        private void XuLyPhong_Load(object sender, EventArgs e)
        {
            comboBoxStatus.Checked = true;
        }
    }
}
