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
        SoundPlayer songSound = new SoundPlayer();
        SoundPlayer song2Sound = new SoundPlayer();
        public Music()
        {
            InitializeComponent();

            simpleSound.Stream = Properties.Resources.L;
            songSound.Stream = Properties.Resources.LL;
            song2Sound.Stream = Properties.Resources.LLL;

        }

        private void Label1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
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
            songSound.Stop();
            song2Sound.Stop();
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

        private void Button2_Click(object sender, EventArgs e)
        {
            songSound.Play();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            songSound.Stop();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            song2Sound.Play();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            song2Sound.Stop();
        }
    }
}
