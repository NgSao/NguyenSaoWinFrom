namespace QuanLyPhongTro
{
    partial class Form1
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
            this.lbname = new System.Windows.Forms.Label();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.tbMk = new System.Windows.Forms.TextBox();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.btnDN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(534, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHÀO MỨNG ĐẾN VỚI NHATRO.COM";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.Location = new System.Drawing.Point(33, 118);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(151, 25);
            this.lbname.TabIndex = 1;
            this.lbname.Text = "Tên đăng nhập:";
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(217, 122);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(327, 22);
            this.tbTen.TabIndex = 2;
            // 
            // tbMk
            // 
            this.tbMk.Location = new System.Drawing.Point(217, 185);
            this.tbMk.Name = "tbMk";
            this.tbMk.PasswordChar = '*';
            this.tbMk.Size = new System.Drawing.Size(327, 22);
            this.tbMk.TabIndex = 4;
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatKhau.Location = new System.Drawing.Point(33, 181);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(99, 25);
            this.lbMatKhau.TabIndex = 3;
            this.lbMatKhau.Text = "Mật khẩu:";
            // 
            // btnDN
            // 
            this.btnDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDN.Location = new System.Drawing.Point(239, 251);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(174, 41);
            this.btnDN.TabIndex = 5;
            this.btnDN.Text = "Đăng nhập";
            this.btnDN.UseVisualStyleBackColor = true;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 341);
            this.Controls.Add(this.btnDN);
            this.Controls.Add(this.tbMk);
            this.Controls.Add(this.lbMatKhau);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbMk;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.Button btnDN;
    }
}

