using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWinFrom
{
    public partial class Example08 : Form
    {
        public Example08()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.Enabled = true;

            }
            else
                textBox2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = null;
            int disc = 0;
            if (radioButton1.Checked == true)
                msg += "Ông ";
            if (radioButton2.Checked == true)
                msg += "Bà ";
            if (checkBox1.Checked == true)
                disc = 5;
            textBox3.Text = msg + textBox1.Text + " được giảm " + disc.ToString() + "%" + "\r\n";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
