using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace bramerto_info
{
    public partial class Music : Form
    {
        SoundPlayer simpleSound = new SoundPlayer();
        public Music()
        {
            InitializeComponent();

            simpleSound.Stream = Properties.Resources.L;
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            simpleSound.Stop();
            form.Show();
        }

        private void play_click(object sender, EventArgs e)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            
            simpleSound.Play();
        }

        private void stop_click(object sender, EventArgs e)
        {
            simpleSound.Stop();
        }
    }
}
