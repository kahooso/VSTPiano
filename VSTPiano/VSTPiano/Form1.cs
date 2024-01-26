using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using NAudio;

namespace VSTPiano
{
    public partial class Form1 : Form
    {
        /* notes Dictionary */
        private Dictionary<string, string> key_sounds = new Dictionary<string, string>();
        private WaveOut wave_out; 
        private AudioFileReader audioFileReader;

        public Form1()
        {
            InitializeComponent();
            InitializeWaveOut();
            InitializeKeySounds();
        }

        /* ---Initialize */
        
        /* WaveOut */
        private void InitializeWaveOut()
        {
            wave_out = new WaveOut();
            audioFileReader = null; 
        }

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
                button1, button2, button3, 
                button4, button5, button6, 
                button7, button8, button9, 
                button10, button11, button12, 
                button13, button14, button15,
                button16, button17, button18, 
                button19, button20, button21 
            };

            for(byte notesCounter = 0, charNotesCounter = 0; notesCounter < whiteNotes.Length; ++notesCounter, ++charNotesCounter)
            {
                if (charNotesCounter == 7) charNotesCounter = 0;
                whiteNotes[notesCounter].Text = notesVisible ? charNotes[charNotesCounter] : "";
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
                using (var newAudioFileReader = new AudioFileReader(soundFilePath))
                {
                    if (audioFileReader != null)
                    {
                        audioFileReader.Dispose();
                    }

                    audioFileReader = newAudioFileReader;

                    // Создаем экземпляр WdlResamplingSampleProvider с желаемым коэффициентом изменения тональности
                    var pitchShifter = new WdlResamplingSampleProvider(audioFileReader, Convert.ToInt32(audioFileReader.WaveFormat.SampleRate * 1.5));
                    wave_out.Init(pitchShifter);
                    wave_out.Play();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Ошибка воспроизведения звука: {exception.Message}", "Ошибка");
            }
        }
    }
}
