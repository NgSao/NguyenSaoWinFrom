using System;
using System.Drawing;
using System.Windows.Forms;

namespace BaiTapWinFrom
{
    public partial class Game : Form
    {
        private int playerSpeed = 20;
        private Timer monsterTimer;
        private int monsterSpeed = 10;
        private PictureBox[,] grid;
        private int gridSize = 10;
        private PictureBox princess;
        private Label timerLabel;
        private Timer countdownTimer;
        private int timeLeft = 30;

        public Game()
        {
            InitializeComponent();
            SetupGame();
        }

        private void SetupGame()
        {
            // Setup grid and player/monster images
            SetupGrid();
            player.Image = Properties.Resources.player;
            monster.Image = Properties.Resources.monster;
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            monster.SizeMode = PictureBoxSizeMode.StretchImage;

            // Setup princess
            SetupPrincess();
            ResetMonsterPosition();

            // Initialize timer label
            timerLabel = new Label
            {
                Location = new Point(10, 10),
                Size = new Size(100, 20),
                Text = $"{timeLeft} giây"
            };
            this.Controls.Add(timerLabel);

            // Timer for monster movement
            monsterTimer = new Timer();
            monsterTimer.Interval = 100;
            monsterTimer.Tick += MonsterMovement;
            monsterTimer.Start();

            // Timer for countdown
            countdownTimer = new Timer();
            countdownTimer.Interval = 1000;
            countdownTimer.Tick += CountdownTimer_Tick;
            countdownTimer.Start();
        }

        private void SetupGrid()
        {
            grid = new PictureBox[gridSize, gridSize];
            int cellSize = this.ClientSize.Width / gridSize;

            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    grid[i, j] = new PictureBox
                    {
                        BorderStyle = BorderStyle.FixedSingle,
                        Width = cellSize,
                        Height = cellSize,
                        Location = new Point(i * cellSize, j * cellSize),
                        BackColor = Color.White
                    };
                    this.Controls.Add(grid[i, j]);
                }
            }

            // Add obstacles
            AddObstacles();
        }

        private void AddObstacles()
        {
            grid[3, 4].BackColor = Color.Gray;
            grid[5, 6].BackColor = Color.Gray;
            grid[7, 2].BackColor = Color.Gray;
        }

        private void SetupPrincess()
        {
            princess = new PictureBox
            {
                Image = Properties.Resources.princess,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(50, 50),
                Location = new Point(150, 150)
            };
            this.Controls.Add(princess);
        }

        private void ResetMonsterPosition()
        {
            monster.Location = new Point(0, 0);
        }

        private void MonsterMovement(object sender, EventArgs e)
        {
            int moveX = 0;
            int moveY = 0;

            if (monster.Left < player.Left)
            {
                moveX = monsterSpeed;
            }
            else if (monster.Left > player.Left)
            {
                moveX = -monsterSpeed;
            }

            if (monster.Top < player.Top)
            {
                moveY = monsterSpeed;
            }
            else if (monster.Top > player.Top)
            {
                moveY = -monsterSpeed;
            }

            monster.Left += moveX;
            monster.Top += moveY;

            // Check collision with player
            if (player.Bounds.IntersectsWith(monster.Bounds))
            {
                monsterTimer.Stop();
                countdownTimer.Stop();
                MessageBox.Show("Thua! Bạn đã bị yêu quái bắt!");
                this.Close();
            }

            // Check collision with princess
            if (player.Bounds.IntersectsWith(princess.Bounds))
            {
                monsterTimer.Stop();
                countdownTimer.Stop();
                MessageBox.Show("Chúc mừng! Bạn đã cứu được công chúa!");
                RestartGame(); // Restart the game
            }

            // Prevent monster from moving out of bounds (optional)
            if (monster.Left < 0) monster.Left = 0;
            if (monster.Top < 0) monster.Top = 0;
            if (monster.Right > this.ClientSize.Width) monster.Left = this.ClientSize.Width - monster.Width;
            if (monster.Bottom > this.ClientSize.Height) monster.Top = this.ClientSize.Height - monster.Height;
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                timerLabel.Text = $"{timeLeft} giây";
            }
            else
            {
                countdownTimer.Stop();
                monsterTimer.Stop();
                MessageBox.Show("Hết thời gian! Bạn đã thua!");
                this.Close();
            }
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && player.Top > 0)
            {
                player.Top -= playerSpeed;
            }
            else if (e.KeyCode == Keys.Down && player.Bottom < this.ClientSize.Height)
            {
                player.Top += playerSpeed;
            }
            else if (e.KeyCode == Keys.Left && player.Left > 0)
            {
                player.Left -= playerSpeed;
            }
            else if (e.KeyCode == Keys.Right && player.Right < this.ClientSize.Width)
            {
                player.Left += playerSpeed;
            }
        }

        private void RestartGame()
        {
            timeLeft = 30;
            timerLabel.Text = "30 giây";
            player.Location = new Point(12, 200); // Initial position of the player
            ResetMonsterPosition();
            countdownTimer.Start();
            monsterTimer.Start();
        }

        private void player_Click(object sender, EventArgs e)
        {

        }
    }
}
