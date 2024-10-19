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
    public partial class StartGame : Form
    {
        private string selectedCar = ""; 

        public StartGame()
        {
            InitializeComponent();
        }

        private void StartGame_Load(object sender, EventArgs e)
        {
            pictureBoxCar1.Image = Image.FromFile(@"E:\C#\NguyenSao_212210145\BaiTapWinFrom\Resources\cart1.png"); // Đường dẫn đến hình ảnh xe 1
            pictureBoxCar2.Image = Image.FromFile(@"E:\C#\NguyenSao_212210145\BaiTapWinFrom\Resources\cart2.png"); // Đường dẫn đến hình ảnh xe 1
            pictureBoxCar3.Image = Image.FromFile(@"E:\C#\NguyenSao_212210145\BaiTapWinFrom\Resources\cart3.png"); // Đường dẫn đến hình ảnh xe 1
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedCar))
            {
                MessageBox.Show("Hãy chọn một chiếc xe trước khi bắt đầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                GameCart gameCart = new GameCart(selectedCar);
                gameCart.Show();


                this.Hide();
            };
        }

        private void pictureBoxCar1_Click(object sender, EventArgs e)
        {
            selectedCar = "car1"; 
            pictureBoxCar1.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxCar2.BorderStyle = BorderStyle.None;
            pictureBoxCar3.BorderStyle = BorderStyle.None; 
        }

        private void pictureBoxCar2_Click(object sender, EventArgs e)
        {
            selectedCar = "car2"; 
            pictureBoxCar2.BorderStyle = BorderStyle.FixedSingle; 
            pictureBoxCar1.BorderStyle = BorderStyle.None; 
            pictureBoxCar3.BorderStyle = BorderStyle.None; 
        }

        private void pictureBoxCar3_Click(object sender, EventArgs e)
        {
            selectedCar = "car3";
            pictureBoxCar3.BorderStyle = BorderStyle.FixedSingle; 
            pictureBoxCar1.BorderStyle = BorderStyle.None; 
            pictureBoxCar2.BorderStyle = BorderStyle.None;

        }

   
    }
}
