using System.Windows.Forms;

namespace BaiTapWinFrom
{
    partial class Game
    {
        private System.ComponentModel.IContainer components = null;
        private PictureBox player;
        private PictureBox monster;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.player = new System.Windows.Forms.PictureBox();
            this.monster = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monster)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.Image = global::BaiTapWinFrom.Properties.Resources.princesss;
            this.player.Location = new System.Drawing.Point(12, 200);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 50);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            this.player.Click += new System.EventHandler(this.player_Click);
            // 
            // monster
            // 
            this.monster.ErrorImage = global::BaiTapWinFrom.Properties.Resources.princess;
            this.monster.Location = new System.Drawing.Point(738, 12);
            this.monster.Name = "monster";
            this.monster.Size = new System.Drawing.Size(50, 50);
            this.monster.TabIndex = 1;
            this.monster.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.monster);
            this.Controls.Add(this.player);
            this.Name = "Game";
            this.Text = "Mèo Bắt Chuột";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monster)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
