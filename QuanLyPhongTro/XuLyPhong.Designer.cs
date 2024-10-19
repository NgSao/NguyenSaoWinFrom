namespace QuanLyPhongTro
{
    partial class XuLyPhong
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
            this.textBoxRoomTypeName = new System.Windows.Forms.ComboBox();
            this.textBoxRoomName = new System.Windows.Forms.TextBox();
            this.comboBoxStatus = new System.Windows.Forms.CheckBox();
            this.btXacNhan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại phòng";
            // 
            // textBoxRoomTypeName
            // 
            this.textBoxRoomTypeName.FormattingEnabled = true;
            this.textBoxRoomTypeName.Location = new System.Drawing.Point(182, 55);
            this.textBoxRoomTypeName.Name = "textBoxRoomTypeName";
            this.textBoxRoomTypeName.Size = new System.Drawing.Size(214, 24);
            this.textBoxRoomTypeName.TabIndex = 1;
            // 
            // textBoxRoomName
            // 
            this.textBoxRoomName.Location = new System.Drawing.Point(182, 107);
            this.textBoxRoomName.Name = "textBoxRoomName";
            this.textBoxRoomName.Size = new System.Drawing.Size(214, 22);
            this.textBoxRoomName.TabIndex = 2;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.AutoSize = true;
            this.comboBoxStatus.Checked = true;
            this.comboBoxStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.comboBoxStatus.Location = new System.Drawing.Point(182, 157);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(92, 20);
            this.comboBoxStatus.TabIndex = 3;
            this.comboBoxStatus.Text = "Hoạt đồng";
            this.comboBoxStatus.UseVisualStyleBackColor = true;
            // 
            // btXacNhan
            // 
            this.btXacNhan.Location = new System.Drawing.Point(182, 199);
            this.btXacNhan.Name = "btXacNhan";
            this.btXacNhan.Size = new System.Drawing.Size(105, 32);
            this.btXacNhan.TabIndex = 4;
            this.btXacNhan.Text = "Xác nhận";
            this.btXacNhan.UseVisualStyleBackColor = true;
            this.btXacNhan.Click += new System.EventHandler(this.btXacNhan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Trạng thái";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(293, 199);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(103, 32);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // XuLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 325);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btXacNhan);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.textBoxRoomName);
            this.Controls.Add(this.textBoxRoomTypeName);
            this.Controls.Add(this.label1);
            this.Name = "XuLyPhong";
            this.Text = "XuLyPhong";
            this.Load += new System.EventHandler(this.XuLyPhong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox textBoxRoomTypeName;
        private System.Windows.Forms.TextBox textBoxRoomName;
        private System.Windows.Forms.CheckBox comboBoxStatus;
        private System.Windows.Forms.Button btXacNhan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHuy;
    }
}