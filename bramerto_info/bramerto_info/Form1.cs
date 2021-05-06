using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bramerto_info
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fun fun = new Fun();
            fun.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Biography biography = new Biography();
            biography.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Programmer programmer = new Programmer();
            programmer.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Music music = new Music();
            music.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contact contact = new Contact();
            contact.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutProgramm about = new AboutProgramm();
            about.Show();
        }
    }
}
