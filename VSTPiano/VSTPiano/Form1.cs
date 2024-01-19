using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio;
using NAudio.Wave;

namespace VSTPiano
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> key_sounds = new Dictionary<string, string>();
        private WaveOut wave_out;
        public Form1()
        {
            InitializeComponent();
            InitializeWaveOut();
            InitializeKeySounds();
        }

        private void InitializeKeySounds()
        {
            key_sounds.Add("C", "D:/FL Studio/Program Files/@@kits/(@kurai) 2022/@kurai11/~sound presets~/fai bell one shot.wav");
        }

        private void InitializeWaveOut()
        {
            wave_out = new WaveOut();
        }

        private void PlaySound(string soundFilePath)
        {
            if (wave_out != null)
            {
                var audioFileReader = new AudioFileReader(soundFilePath);
                wave_out.Init(audioFileReader);
                wave_out.Play();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button_MouseDown(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Red;
        }
        private void button_MouseUp(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void KeyButton_click(object sender, EventArgs e)
        {
            if (sender is Button keyButton)
                if (key_sounds.TryGetValue(keyButton.Text, out string soundsFilePath))
                    PlaySound(soundsFilePath);
        }
    }
}
