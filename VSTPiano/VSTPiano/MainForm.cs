using System;
using System.Drawing;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace VSTPiano
{
    public partial class MainForm : Form
    {
        /* notes Dictionary */
        private WaveOut wave_out = new WaveOut(); 

        public MainForm()
        {
            InitializeComponent();
        }

        /* ---Initialize */

        /* --Information message box */
        private void informationLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "🎵 Hey there, welcome to #keys! 🎸\n\n" +
                              "🔖 Version: 1.0\n" +
                              "👤 Dev: @kahooso\n" +
                              "📅 Release date: 2024.X.X\n\n" +
                              "#keys is my first project, created with love and dedication. Every detail has been designed with your convenience in mind, aiming to make your time spent here as enjoyable as possible.\n\n" +
                              "Dope Features:\n" +
                              "- 🎹 Your musical genius is about to unfold. Get ready to rock the virtual stage with #keys!\n" +
                              "- 🎷 I am thrilled to have you on board, and I hope your musical journey with my app is nothing short of extraordinary.\n\n" +
                              "Feel the music, give me your feedback, and if you're stuck, I'm here to help you. Thanks for rocking out with #keys!\n\n" +
                              "Keep the vibes alive,\n@kahooso 🎤🎶", "Welcome to #keys!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        /* Volume progress bar */

        private void C_button_Click(object sender, EventArgs e)
        {

        }

        private void panSlider_PanChanged(object sender, EventArgs e)
        {

        }
    }
}
