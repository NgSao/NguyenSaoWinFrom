using System;

using System.Windows.Forms;

namespace BaiTapWinFrom
{
    public partial class Example06 : Form
    {
        decimal workingMemory = 0;
        string opr = "";
        decimal memory = 0;
        public Example06()
        {
            InitializeComponent();
        }


        private void button_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;


            if ((char.IsDigit(bt.Text, 0) && bt.Text.Length == 1) || bt.Text == ",")
            {
                textKq.Text += bt.Text;
            }

            else if (bt.Text == "+" || bt.Text == "-" || bt.Text == "*" || bt.Text == "/")
            {
                opr = bt.Text;
                workingMemory = decimal.Parse(textKq.Text);
                textKq.Clear();
            }

            else if (bt.Text == "=")
            {
                decimal secondValue = decimal.Parse(textKq.Text);
                if (opr == "+")
                {
                    textKq.Text = (workingMemory + secondValue).ToString();
                }
                else if (opr == "-")
                {
                    textKq.Text = (workingMemory - secondValue).ToString();
                }
                else if (opr == "*")
                {
                    textKq.Text = (workingMemory * secondValue).ToString();
                }
                else if (opr == "/")
                {
                    if (secondValue != 0)
                    {
                        textKq.Text = (workingMemory / secondValue).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Không thể chia cho 0.");
                    }
                }
            }

            else if (bt.Text == "±")
            {
                decimal currVal = decimal.Parse(textKq.Text);
                currVal = -currVal;
                textKq.Text = currVal.ToString();
            }

            else if (bt.Text == "√")
            {
                decimal currVal = decimal.Parse(textKq.Text);
                currVal = (decimal)Math.Sqrt((double)currVal);
                textKq.Text = currVal.ToString();
            }

            else if (bt.Text == "%")
            {
                decimal currVal = decimal.Parse(textKq.Text);
                currVal = currVal / 100;
                textKq.Text = currVal.ToString();
            }

            else if (bt.Text == "1/x")
            {
                decimal currVal = decimal.Parse(textKq.Text);
                if (currVal != 0)
                {
                    currVal = 1 / currVal;
                    textKq.Text = currVal.ToString();
                }
                else
                {
                    MessageBox.Show("Không thể chia cho 0.");
                }
            }

            else if (bt.Text == "<-")
            {
                if (textKq.TextLength != 0)
                {
                    textKq.Text = textKq.Text.Remove(textKq.TextLength - 1);
                }
            }

            else if (bt.Text == "MC")
            {
                memory = 0;
            }
            else if (bt.Text == "MR")
            {
                textKq.Text = memory.ToString();
            }
            else if (bt.Text == "MS")
            {
                memory = decimal.Parse(textKq.Text);
                textKq.Clear();
            }
            else if (bt.Text == "M+")
            {
                memory += decimal.Parse(textKq.Text);
            }
            else if (bt.Text == "M-")
            {
                memory -= decimal.Parse(textKq.Text);
            }

            else if (bt.Text == "C")
            {
                workingMemory = 0;
                opr = "";
                textKq.Clear();
            }

            else if (bt.Text == "CE")
            {
                textKq.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
