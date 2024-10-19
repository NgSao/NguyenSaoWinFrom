
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BaiTapWinFrom
{
    public partial class GameCart : Form
    {
        private string selectedCar; 
        public GameCart(string car) 
        {
            InitializeComponent();
            selectedCar = car; 
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(GameCart_KeyDown); 
            this.ActiveControl = mycar;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            linemove(carspeed);
            MoveEnemy(enemy1, 0, 200);
            MoveEnemy(enemy2, 0, 200);
            MoveEnemy(enemy3, 225, 280);
            MoveEnemy(enemy4, 225, 280);
            gameover();
            totalscore();
        }

        Random pos = new Random();
        int carspeed = 3;
        int score = 0;

        void linemove(int speed)
        {
            MoveLine(pictureBox1, speed);
            MoveLine(pictureBox2, speed);
            MoveLine(pictureBox3, speed);
        }

        void MoveLine(PictureBox line, int speed)
        {
            if (line.Top > 500)
                line.Top = 0;
            else
                line.Top += speed;
        }

        void MoveEnemy(PictureBox enemy, int minLeft, int maxLeft)
        {
            if (enemy.Top > 500)
            {
                score++;
                enemy.Left = pos.Next(minLeft, maxLeft);
                enemy.Top = 0;
            }
            else
            {
                enemy.Top += carspeed;
            }
        }

        private void GameCart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && mycar.Left > 0) mycar.Left -= 5;
            if (e.KeyCode == Keys.Right && mycar.Left < 300) mycar.Left += 5;
            if (e.KeyCode == Keys.Up && carspeed < 30) carspeed++;
            if (e.KeyCode == Keys.Down && carspeed > 3) carspeed--;
        }

        void totalscore()
        {
            textBox1.Text = score.ToString();
        }

        void gameover()
        {
            if (mycar.Bounds.IntersectsWith(enemy1.Bounds) ||
                mycar.Bounds.IntersectsWith(enemy2.Bounds) ||
                mycar.Bounds.IntersectsWith(enemy3.Bounds) ||
                mycar.Bounds.IntersectsWith(enemy4.Bounds))
            {
                timer1.Enabled = false;
                DialogResult go = MessageBox.Show("Bạn có muốn chơi nữa không?", "GAME OVER", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                if (go == DialogResult.Yes)
                {
                    RestartGame();
                }
                else if (go == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        void RestartGame()
        {
            timer1.Enabled = true;
            ResetEnemyPosition(enemy1, 0, 200);
            ResetEnemyPosition(enemy2, 0, 200);
            ResetEnemyPosition(enemy3, 225, 300);
            ResetEnemyPosition(enemy4, 225, 300);
            score = 0;
        }

        void ResetEnemyPosition(PictureBox enemy, int minLeft, int maxLeft)
        {
            enemy.Left = pos.Next(minLeft, maxLeft);
            enemy.Top = 0;
        }

        private void GameCart_Load(object sender, EventArgs e)
        {
            if (selectedCar == "car1")
            {

                mycar.Image = Image.FromFile(@"E:\C#\NguyenSao_212210145\BaiTapWinFrom\Resources\cart1.png");
            }
            else if (selectedCar == "car2")
            {
                mycar.Image = Image.FromFile(@"E:\C#\NguyenSao_212210145\BaiTapWinFrom\Resources\cart2.png");
            }
            else if (selectedCar == "car3")
            {
                mycar.Image = Image.FromFile(@"E:\C#\NguyenSao_212210145\BaiTapWinFrom\Resources\cart3.png");
            }

        }
    }
}
