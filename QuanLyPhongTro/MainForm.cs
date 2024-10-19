using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
      


        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var PhongForm = new Phong();
            AddForm(PhongForm);
        }

        private void loạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var loaiPhongForm = new LoaiPhong();
            AddForm(loaiPhongForm);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }



        private void AddForm(Form f)
        {
            this.Content.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll= true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.Text=f.Text;
            this.Content.Controls.Add(f);
            f.Show();
        }

        private void Content_Enter(object sender, EventArgs e)
        {

        }
    }
}
