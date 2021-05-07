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
    public partial class Fun : Form
    {
        public Fun()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
