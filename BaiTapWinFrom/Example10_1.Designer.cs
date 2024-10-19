namespace BaiTapWinFrom
{
    partial class Example10_1
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
            this.listYT = new System.Windows.Forms.ListBox();
            this.listBH = new System.Windows.Forms.ListBox();
            this.btnTT = new System.Windows.Forms.Button();
            this.btnPP = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listYT
            // 
            this.listYT.FormattingEnabled = true;
            this.listYT.ItemHeight = 16;
            this.listYT.Location = new System.Drawing.Point(494, 72);
            this.listYT.Name = "listYT";
            this.listYT.Size = new System.Drawing.Size(363, 292);
            this.listYT.TabIndex = 15;
            // 
            // listBH
            // 
            this.listBH.FormattingEnabled = true;
            this.listBH.ItemHeight = 16;
            this.listBH.Location = new System.Drawing.Point(42, 72);
            this.listBH.Name = "listBH";
            this.listBH.Size = new System.Drawing.Size(336, 292);
            this.listBH.TabIndex = 14;
            this.listBH.SelectedIndexChanged += new System.EventHandler(this.listBH_SelectedIndexChanged);
            // 
            // btnTT
            // 
            this.btnTT.Location = new System.Drawing.Point(409, 203);
            this.btnTT.Name = "btnTT";
            this.btnTT.Size = new System.Drawing.Size(53, 38);
            this.btnTT.TabIndex = 13;
            this.btnTT.Text = "<<";
            this.btnTT.UseVisualStyleBackColor = true;
            this.btnTT.Click += new System.EventHandler(this.btnTT_Click);
            // 
            // btnPP
            // 
            this.btnPP.Location = new System.Drawing.Point(409, 159);
            this.btnPP.Name = "btnPP";
            this.btnPP.Size = new System.Drawing.Size(53, 38);
            this.btnPP.TabIndex = 12;
            this.btnPP.Text = ">>";
            this.btnPP.UseVisualStyleBackColor = true;
            this.btnPP.Click += new System.EventHandler(this.btnPP_Click);
            // 
            // btnT
            // 
            this.btnT.Location = new System.Drawing.Point(409, 115);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(53, 38);
            this.btnT.TabIndex = 11;
            this.btnT.Text = "<";
            this.btnT.UseVisualStyleBackColor = true;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // btnP
            // 
            this.btnP.Location = new System.Drawing.Point(409, 71);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(53, 38);
            this.btnP.TabIndex = 10;
            this.btnP.Text = ">";
            this.btnP.UseVisualStyleBackColor = true;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(490, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Danh sách bài hát yêu thích";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Danh sách bài hát";
            // 
            // Example10_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 586);
            this.Controls.Add(this.listYT);
            this.Controls.Add(this.listBH);
            this.Controls.Add(this.btnTT);
            this.Controls.Add(this.btnPP);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Example10_1";
            this.Text = "Music2.0";
            this.Load += new System.EventHandler(this.Example10_1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listYT;
        private System.Windows.Forms.ListBox listBH;
        private System.Windows.Forms.Button btnTT;
        private System.Windows.Forms.Button btnPP;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}