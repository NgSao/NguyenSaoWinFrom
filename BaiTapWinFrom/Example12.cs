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
    public partial class Example12 : Form
    {
        public Example12()
        {
            InitializeComponent();
        }

        private void textTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textTuoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textMnv_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textMnv.Text, textTen.Text, textTuoi.Text, checkBox1.Checked);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int idx=dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(idx);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx=e.RowIndex;
            textMnv.Text = dataGridView1.Rows[idx].Cells[0].Value.ToString();
            textTen.Text = dataGridView1.Rows[idx].Cells[1].Value.ToString();
            textTuoi.Text = dataGridView1.Rows[idx].Cells[2].Value.ToString();
            checkBox1.Checked = bool.Parse(dataGridView1.Rows[idx].Cells[3].Value.ToString());

        }
    }
}
