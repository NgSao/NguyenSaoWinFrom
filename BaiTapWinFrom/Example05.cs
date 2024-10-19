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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace BaiTapWinFrom
{

    public partial class Example05 : Form
    {
        decimal workingMemory = 0;
        string opr = "";
        public Example05()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void btn0_Click(object sender, EventArgs e)
        {
            textKq.Text += btn0.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textKq.Text += btn1.Text;

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textKq.Text += btn2.Text;

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textKq.Text += btn3.Text;

        }
        private void btnCong_Click(object sender, EventArgs e)
        {
            opr = btnCong.Text;
            workingMemory = decimal.Parse(textKq.Text);
            textKq.Clear();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            opr = btnNhan.Text;
            workingMemory = decimal.Parse(textKq.Text);
            textKq.Clear();
        }

        private void btnCham_Click(object sender, EventArgs e)
        {
            textKq.Text += btnCham.Text;

        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            decimal seconValue = decimal.Parse(textKq.Text);
            if (opr == "+")
                textKq.Text = (workingMemory + seconValue).ToString();
            if (opr == "*")
                textKq.Text = (workingMemory * seconValue).ToString();
            opr = "";
            workingMemory = 0;
        }
    }
}
