using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using NAudio;
using CircularProgressBar;
using VSTPiano.Properties;

namespace VSTPiano
{
    public partial class Form1 : Form
    {
        /* notes Dictionary */
        private Dictionary<string, string> key_sounds = new Dictionary<string, string>();
        private WaveOut wave_out = new WaveOut(); 
        private AudioFileReader audioFileReader = null;
        private PanningSampleProvider panningSampleProvider = null; /* Pan */
        private Settings Settings;

        public Form1()
        {
            InitializeComponent();
            InitializeKeySounds();

            /* default volume */;
            volumeProgressBar.Value = 75;
            updateVolume();
        }

        /* ---Initialize */

        /* KeySounds */
        private void InitializeKeySounds()
        {
            string baseSoundFilePath = "C:/Users/ryche/Desktop/VSTPiano/VSTPiano/VSTPiano/Sounds/C.wav";
            string[] notes = { "C", "D", "E", "F", "G", "A", "B" };

            for (int i = 0; i < notes.Length; ++i)
            {
                key_sounds.Add(notes[i], baseSoundFilePath);
            }
        }

        /* ---form loader */
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        /* ---notes */

        /* trigger if note is clicked */
        private void KeyButton_click(object sender, EventArgs e)
        {
            if (sender is Button keyButton)
            {
                if (key_sounds.TryGetValue(keyButton.Text, out string soundsFilePath))
                {
                    PlaySound(soundsFilePath);
                }
            }
        }

        /* white notes if mouse down */
        private void whiteNotes_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is Button clickedNote)
            {
                clickedNote.BackColor = ColorTranslator.FromHtml("#B0E57C");
            }
        }

        /* white notes if mouse up */
        private void whiteNotes_MouseUp(object sender, MouseEventArgs e)
        {
            if (sender is Button clickedNote)
            {
                clickedNote.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            }
        }

        /* black notes if mouse down */
        private void blackNotes_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is Button clickedNote)
            {
                clickedNote.BackColor = ColorTranslator.FromHtml("#B0E57C");
            }
        }

        /* black notes if mouse up */
        private void blackNotes_MouseUp(object sender, MouseEventArgs e)
        {
            if (sender is Button clickedNote)
            {
                clickedNote.BackColor = ColorTranslator.FromHtml("#000000");
            }
        }

        /* show note's button */

        private bool notesVisible = true;
        private void showNotesButton_Click(object sender, EventArgs e)
        {
            
            // Массив нот
            string[] charNotes = { "C", "D", "E", "F", "G", "A", "B" };
            
            Button[] whiteNotes = { 
                note1, note2, note3, 
                note4, note5, note6, 
                note7, note8, note9, 
                note10, note11, note12, 
                note13, note14, note15,
                note16, note17, note18, 
                note19, note20, note21,
                note22, note23, note23,
                note24, note25, note26,
                note27, note28, note29,
                note30, note31, note32, 
                note33, note34, note35, note36
            };

            for(byte notesCounter = 0, charNotesCounter = 0; notesCounter < whiteNotes.Length; ++notesCounter, ++charNotesCounter)
            {
                if (charNotesCounter == 7) charNotesCounter = 0;
                whiteNotes[notesCounter].Text = notesVisible ? charNotes[charNotesCounter] : " ";
            }
            notesVisible = !notesVisible;
        }

        /* ---NAudio */

        /* free memory form closed */
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (wave_out != null)
            {
                wave_out.Stop();
                wave_out.Dispose();
            }
            if (audioFileReader != null) audioFileReader.Dispose();
        }

        /* play sound function */
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
            catch (Exception exception)
            {
                MessageBox.Show($"Ошибка воспроизведения звука: {exception.Message}", "Ошибка");
            }
        }

        /* Setting's, progress bar's */

        /* Volume progress bar */
        private void updateVolume()
        {
            float volume = volumeProgressBar.Value / 100f; 
            wave_out.Volume = volume;
        }
        private void volumeProgressBar_MouseCaptureChanged(object sender, EventArgs e)
        {
            updateVolume();
        }

        /* Pan */
        private void Pan()
        {
            panoramProgressBar.Minimum = -100;
            panoramProgressBar.Maximum = 100;
            panoramProgressBar.Value = 0;

            panningSampleProvider = new PanningSampleProvider(audioFileReader);
            wave_out.Init(panningSampleProvider);
        }

        /* Settings button */

        private void panoramProgressBar_MouseCaptureChanged(object sender, EventArgs e)
        {
            panoramProgressBar.Value = 100;
        }

        /* Open Settings Form */
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Settings = new Settings();
            Settings.Show();
        }
    }
}
