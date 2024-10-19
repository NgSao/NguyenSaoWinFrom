namespace BaiTapWinFrom
{
    partial class Example10
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
            this.btnP = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnPP = new System.Windows.Forms.Button();
            this.btnTT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBH = new System.Windows.Forms.ListBox();
            this.listYT = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách bài hát";
            // 
            // btnP
            // 
            this.btnP.Location = new System.Drawing.Point(314, 66);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(53, 38);
            this.btnP.TabIndex = 2;
            this.btnP.Text = ">";
            this.btnP.UseVisualStyleBackColor = true;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // btnT
            // 
            this.btnT.Location = new System.Drawing.Point(314, 110);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(53, 38);
            this.btnT.TabIndex = 3;
            this.btnT.Text = "<";
            this.btnT.UseVisualStyleBackColor = true;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // btnPP
            // 
            this.btnPP.Location = new System.Drawing.Point(314, 154);
            this.btnPP.Name = "btnPP";
            this.btnPP.Size = new System.Drawing.Size(53, 38);
            this.btnPP.TabIndex = 4;
            this.btnPP.Text = ">>";
            this.btnPP.UseVisualStyleBackColor = true;
            this.btnPP.Click += new System.EventHandler(this.btnPP_Click);
            // 
            // btnTT
            // 
            this.btnTT.Location = new System.Drawing.Point(314, 198);
            this.btnTT.Name = "btnTT";
            this.btnTT.Size = new System.Drawing.Size(53, 38);
            this.btnTT.TabIndex = 5;
            this.btnTT.Text = "<<";
            this.btnTT.UseVisualStyleBackColor = true;
            this.btnTT.Click += new System.EventHandler(this.btnTT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(402, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Danh sách bài hát yêu thích";
            // 
            // listBH
            // 
            this.listBH.FormattingEnabled = true;
            this.listBH.ItemHeight = 16;
            this.listBH.Items.AddRange(new object[] {
            "Hoa hải đường",
            "Hồng Nhan",
            "Bạc Phận",
            "Sóng Gió"});
            this.listBH.Location = new System.Drawing.Point(36, 65);
            this.listBH.Name = "listBH";
            this.listBH.Size = new System.Drawing.Size(243, 276);
            this.listBH.TabIndex = 6;
            this.listBH.SelectedIndexChanged += new System.EventHandler(this.listBH_SelectedIndexChanged);
            // 
            // listYT
            // 
            this.listYT.FormattingEnabled = true;
            this.listYT.ItemHeight = 16;
            this.listYT.Location = new System.Drawing.Point(406, 65);
            this.listYT.Name = "listYT";
            this.listYT.Size = new System.Drawing.Size(258, 276);
            this.listYT.TabIndex = 7;
            // 
            // Example10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 486);
            this.Controls.Add(this.listYT);
            this.Controls.Add(this.listBH);
            this.Controls.Add(this.btnTT);
            this.Controls.Add(this.btnPP);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Example10";
            this.Text = "Music";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnPP;
        private System.Windows.Forms.Button btnTT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBH;
        private System.Windows.Forms.ListBox listYT;
    }
}