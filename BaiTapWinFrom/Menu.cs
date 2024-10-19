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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Example01 ex01 = new Example01();
            ex01.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Example02 ex02 = new Example02();
            ex02.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Example03 ex03 = new Example03();
            ex03.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Example04 ex04 = new Example04();
            ex04.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Example05 ex05 = new Example05();
            ex05.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Example06 ex06 = new Example06();
            ex06.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Example07 ex07 = new Example07();
            ex07.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Example08 ex08 = new Example08();
            ex08.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Example09 ex09 = new Example09();
            ex09.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Example10 ex10 = new Example10();
            ex10.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Example11 ex11 = new Example11();
            ex11.Show();
        }

        private void button10_1_Click(object sender, EventArgs e)
        {
            Example10_1 ex10_1 = new Example10_1();
            ex10_1.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Example12 ex12 = new Example12();
            ex12.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Example13 ex13 = new Example13();
            ex13.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Example14 ex14 = new Example14();
            ex14.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Example15 ex15 = new Example15();
            ex15.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //GameCart game2 = new GameCart();
            //game2.Show();

            StartGame game2 = new StartGame();
            game2.Show();
        }
    }
}
