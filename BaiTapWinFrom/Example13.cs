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
    public partial class Example13 : Form
    {
        public Example13()
        {
            InitializeComponent();
        }

        List<Employee> lst;


        public List<Employee> GetData()
        {
            List<Employee> lst = new List<Employee>();
            Employee em = new Employee();
            em.Id = "2122110145";
            em.Name = "Nguyễn Sao";
            em.Age = 20;
            lst.Add(em);

            em = new Employee();
            em.Id = "2122110146";
            em.Name = "Sao Nguyen";
            em.Age = 25;
            lst.Add(em);

            em = new Employee();
            em.Id = "2122110147";
            em.Name = "Sao";
            em.Age = 23;
            lst.Add(em);

            return lst;
        }

        private void Example13_Load(object sender, EventArgs e)
        {
            lst = GetData();
            foreach (Employee em in lst)
            {
                dataGridView1.Rows.Add(em.Id, em.Name, em.Age, em.Gender);
            }
        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            textMnv.Text = dataGridView1.Rows[idx].Cells[0].Value.ToString();
            textTen.Text = dataGridView1.Rows[idx].Cells[1].Value.ToString();
            textTuoi.Text = dataGridView1.Rows[idx].Cells[2].Value.ToString();
            checkBox1.Checked = bool.Parse(dataGridView1.Rows[idx].Cells[3].Value.ToString());
        }

        private void textMnv_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (int.TryParse(textTuoi.Text, out int age))
            {
                Employee em = new Employee
                {
                    Id = textMnv.Text,
                    Name = textTen.Text,
                    Age = age,
                    Gender = checkBox1.Checked
                };
                lst.Add(em);
                dataGridView1.Rows.Add(textMnv.Text, textTen.Text, textTuoi.Text, checkBox1.Checked);
            }
            else
            {
                MessageBox.Show("Please enter a valid age.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int idx = dataGridView1.CurrentCell.RowIndex;
            if (idx >= 0)
            {
                lst.RemoveAt(idx);
                dataGridView1.Rows.RemoveAt(idx);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
