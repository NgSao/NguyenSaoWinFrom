namespace BaiTapWinFrom
{
    partial class StartGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.pictureBoxCar3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCar2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCar1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn xe yêu thích của bạn!";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(203, 354);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(140, 53);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Băt đầu";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pictureBoxCar3
            // 
            this.pictureBoxCar3.Location = new System.Drawing.Point(375, 149);
            this.pictureBoxCar3.Name = "pictureBoxCar3";
            this.pictureBoxCar3.Size = new System.Drawing.Size(140, 147);
            this.pictureBoxCar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCar3.TabIndex = 3;
            this.pictureBoxCar3.TabStop = false;
            this.pictureBoxCar3.Click += new System.EventHandler(this.pictureBoxCar3_Click);
            // 
            // pictureBoxCar2
            // 
            this.pictureBoxCar2.Location = new System.Drawing.Point(203, 149);
            this.pictureBoxCar2.Name = "pictureBoxCar2";
            this.pictureBoxCar2.Size = new System.Drawing.Size(140, 147);
            this.pictureBoxCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCar2.TabIndex = 2;
            this.pictureBoxCar2.TabStop = false;
            this.pictureBoxCar2.Click += new System.EventHandler(this.pictureBoxCar2_Click);
            // 
            // pictureBoxCar1
            // 
            this.pictureBoxCar1.Location = new System.Drawing.Point(27, 149);
            this.pictureBoxCar1.Name = "pictureBoxCar1";
            this.pictureBoxCar1.Size = new System.Drawing.Size(140, 147);
            this.pictureBoxCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCar1.TabIndex = 1;
            this.pictureBoxCar1.TabStop = false;
            this.pictureBoxCar1.Click += new System.EventHandler(this.pictureBoxCar1_Click);
            // 
            // StartGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBoxCar3);
            this.Controls.Add(this.pictureBoxCar2);
            this.Controls.Add(this.pictureBoxCar1);
            this.Controls.Add(this.label1);
            this.Name = "StartGame";
            this.Text = "Bắt đầu game";
            this.Load += new System.EventHandler(this.StartGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxCar1;
        private System.Windows.Forms.PictureBox pictureBoxCar2;
        private System.Windows.Forms.PictureBox pictureBoxCar3;
        private System.Windows.Forms.Button btnStart;
    }
}