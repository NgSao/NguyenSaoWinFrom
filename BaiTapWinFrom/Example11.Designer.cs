namespace BaiTapWinFrom
{
    partial class Example11
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.chonAnh = new System.Windows.Forms.Button();
            this.anh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.anh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ảnh 3x4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên nhân viên";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(164, 79);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(243, 22);
            this.textBox3.TabIndex = 3;
            // 
            // chonAnh
            // 
            this.chonAnh.Location = new System.Drawing.Point(319, 126);
            this.chonAnh.Name = "chonAnh";
            this.chonAnh.Size = new System.Drawing.Size(88, 42);
            this.chonAnh.TabIndex = 4;
            this.chonAnh.Text = "Chọn ảnh";
            this.chonAnh.UseVisualStyleBackColor = true;
            this.chonAnh.Click += new System.EventHandler(this.chonAnh_Click);
            // 
            // anh
            // 
            this.anh.Location = new System.Drawing.Point(164, 126);
            this.anh.Name = "anh";
            this.anh.Size = new System.Drawing.Size(128, 127);
            this.anh.TabIndex = 5;
            this.anh.TabStop = false;
            this.anh.Click += new System.EventHandler(this.anh_Click);
            // 
            // Example11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 292);
            this.Controls.Add(this.anh);
            this.Controls.Add(this.chonAnh);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Example11";
            this.Text = "Quản lý nhân sự";
            ((System.ComponentModel.ISupportInitialize)(this.anh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button chonAnh;
        private System.Windows.Forms.PictureBox anh;
    }
}