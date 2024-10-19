namespace BaiTapWinFrom
{
    partial class Example14
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
            this.chonAnh = new System.Windows.Forms.Button();
            this.anh = new System.Windows.Forms.PictureBox();
            this.btnT = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.anh)).BeginInit();
            this.SuspendLayout();
            // 
            // chonAnh
            // 
            this.chonAnh.Location = new System.Drawing.Point(322, 254);
            this.chonAnh.Name = "chonAnh";
            this.chonAnh.Size = new System.Drawing.Size(88, 42);
            this.chonAnh.TabIndex = 6;
            this.chonAnh.Text = "Chọn ảnh";
            this.chonAnh.UseVisualStyleBackColor = true;
            this.chonAnh.Click += new System.EventHandler(this.chonAnh_Click);
            // 
            // anh
            // 
            this.anh.Location = new System.Drawing.Point(52, 26);
            this.anh.Name = "anh";
            this.anh.Size = new System.Drawing.Size(128, 127);
            this.anh.TabIndex = 7;
            this.anh.TabStop = false;
            this.anh.Click += new System.EventHandler(this.anh_Click);
            // 
            // btnT
            // 
            this.btnT.Location = new System.Drawing.Point(52, 254);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(52, 42);
            this.btnT.TabIndex = 8;
            this.btnT.Text = "<-";
            this.btnT.UseVisualStyleBackColor = true;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // btnP
            // 
            this.btnP.Location = new System.Drawing.Point(128, 254);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(52, 42);
            this.btnP.TabIndex = 9;
            this.btnP.Text = "->";
            this.btnP.UseVisualStyleBackColor = true;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // Example14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 328);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.anh);
            this.Controls.Add(this.chonAnh);
            this.Name = "Example14";
            this.Text = "Simple Game";
            this.Load += new System.EventHandler(this.Example14_Load);
            ((System.ComponentModel.ISupportInitialize)(this.anh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button chonAnh;
        private System.Windows.Forms.PictureBox anh;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnP;
    }
}