using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio;

namespace VSTPiano
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> key_sounds = new Dictionary<string, string>();
        private WaveOut wave_out; 
        private AudioFileReader audioFileReader;

        public Form1()
        {
            InitializeComponent();
            InitializeWaveOut();
            InitializeKeySounds();
        }

        private void InitializeKeySounds()
        {
            string[] notes = { "C", "D", "E", "F", "G", "A", "B" };
            for (int i = 0; i < notes.Length; ++i)
            {
                string soundFilePath = $"C:/Users/ryche/Desktop/VSTPiano/VSTPiano/VSTPiano/Sounds/C.wav";
                key_sounds.Add(notes[i], soundFilePath);
            }
        }

        private void InitializeWaveOut()
        {
            wave_out = new WaveOut();
            audioFileReader = null; 
        }

        private void PlaySound(string soundFilePath)
        {
            try
            {
                if (audioFileReader != null)
                {
                    audioFileReader.Dispose();
                    audioFileReader = null;
                }

                audioFileReader = new AudioFileReader(soundFilePath);
                wave_out.Init(audioFileReader);
                wave_out.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка воспроизведения звука: {ex.Message}", "Ошибка");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#B0E57C");
            panel1.BackColor = ColorTranslator.FromHtml("#96D38C");
        }

        private void KeyButton_click(object sender, EventArgs e)
        {
            if (sender is Button keyButton) if (key_sounds.TryGetValue(keyButton.Text, out string soundsFilePath)) PlaySound(soundsFilePath);
        }

        private void whiteButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is Button clickedButton) clickedButton.BackColor = ColorTranslator.FromHtml("#B0E57C");
        }

        private void whiteButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (sender is Button clickedButton) clickedButton.BackColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void blackButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is Button clickedButton) clickedButton.BackColor = ColorTranslator.FromHtml("#000000");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (wave_out != null)
            {
                wave_out.Stop();
                wave_out.Dispose();
            }
            if (audioFileReader != null) audioFileReader.Dispose();
        }
    }
}
