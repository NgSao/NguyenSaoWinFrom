using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BaiTapWinFrom
{
    public partial class Example03 : Form
    {
        public Example03()
        {
            InitializeComponent();
        }

        private void Lưu_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textX.Text);
            int y = int.Parse(textY.Text);
            int kq = x + y;
            textKq.Text = kq.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Example03_Load(object sender, EventArgs e)
        {

        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textX.Text);
            int y = int.Parse(textY.Text);
            int kq = x * y;
            textKq.Text = kq.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
