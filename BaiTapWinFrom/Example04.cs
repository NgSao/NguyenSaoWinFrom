using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BaiTapWinFrom
{
    public partial class Example04 : Form
    {
        public Example04()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {

            int x = int.Parse(textX.Text);
            int y = int.Parse(textY.Text);
            int kq = x + y;
            textKq.Text = textKq.Text + x.ToString() + "+" + y.ToString() + "=" + kq.ToString() + "\r\n";
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textX.Text);
            int y = int.Parse(textY.Text);
            int kq = x * y;
            textKq.Text = textKq.Text + x.ToString() + "*" + y.ToString() + "=" + kq.ToString() + "\r\n";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"E:\C#\\NguyenSao_212210145\Caculator.txt", true);
            sw.WriteLine(textKq.Text);
            sw.Close();
        }
    }
}
