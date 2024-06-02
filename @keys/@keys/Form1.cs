using System;
using System.Windows.Forms;
using System.IO;
using NAudio.Wave;
using System.Collections.Generic;
using System.Drawing;

namespace _keys
{
    public partial class Form1 : Form
    {
        private int octave;
        private List<WaveOutEvent> activePlayers = new List<WaveOutEvent>();

        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
            InitializeOctave();
            InitializeColors();
        }
        private void InitializeColors()
        {
            C_button.BackColor = D_button.BackColor = E_button.BackColor = F_button.BackColor =
                                  G_button.BackColor = A_button.BackColor = B_button.BackColor = ColorTranslator.FromHtml("#EAF4E1");
            C_sharp_button.BackColor = D_sharp_button.BackColor = F_sharp_button.BackColor = G_sharp_button.BackColor = A_sharp_button.BackColor = ColorTranslator.FromHtml("#567856");
        }
        private void InitializeComboBox() { octaveComboBox.SelectedIndex = 1; pianoComboBox.SelectedIndex = 0; }
        private void InitializeOctave()
        {
            switch (octaveComboBox.SelectedItem.ToString())
            {
                case "C4":
                    octave = 4;
                    break;
                case "C5":
                    octave = 5;
                    break;
                case "C6":
                    octave = 6;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PlaySound(string note, int octave)
        {
            string resourceName = $"{pianoComboBox.Text}_{note}{octave}";
            var resource = Properties.Resources.ResourceManager.GetStream(resourceName);
            if (resource != null)
            {
                PlaySound(resource);
            }
            else
            {
                MessageBox.Show($"sound {resourceName} not found.", "@error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PlaySound(UnmanagedMemoryStream soundStream)
        {
            WaveOutEvent waveOut = new WaveOutEvent();
            var memoryStream = new MemoryStream();
            soundStream.CopyTo(memoryStream);
            memoryStream.Position = 0;
            var waveReader = new WaveFileReader(memoryStream);
            waveOut.Init(waveReader);
            waveOut.PlaybackStopped += (sender, args) =>
            {
                waveOut.Dispose();
                waveReader.Dispose();
                memoryStream.Dispose();
                activePlayers.Remove(waveOut);
            };
            activePlayers.Add(waveOut);
            waveOut.Play();
        }

        private void C_button_Click(object sender, EventArgs e) { PlaySound("C", octave); }
        private void C_sharp_button_Click(object sender, EventArgs e) { PlaySound("C_", octave); }
        private void D_button_Click(object sender, EventArgs e) { PlaySound("D", octave); }
        private void D_sharp_button_Click(object sender, EventArgs e) { PlaySound("D_", octave); }
        private void E_button_Click(object sender, EventArgs e) { PlaySound("E", octave); }
        private void F_button_Click(object sender, EventArgs e) { PlaySound("F", octave); }
        private void F_sharp_button_Click(object sender, EventArgs e) { PlaySound("F_", octave); }
        private void G_button_Click(object sender, EventArgs e) { PlaySound("G", octave); }
        private void G_sharp_button_Click(object sender, EventArgs e) { PlaySound("G_", octave); }
        private void A_button_Click(object sender, EventArgs e) { PlaySound("A", octave); }
        private void A_sharp_button_Click(object sender, EventArgs e) { PlaySound("A_", octave); }
        private void B_button_Click(object sender, EventArgs e) { PlaySound("B", octave); }

        private void octaveComboBox_SelectedIndexChanged(object sender, EventArgs e) { InitializeOctave(); }

        /// RECORDING

        private WasapiLoopbackCapture capture;
        private WaveFileWriter writer;
        private string outputFilename;

        private void StartRecording()
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "WAV file|*.wav";
                    saveFileDialog.Title = "Save an Audio File";
                    saveFileDialog.FileName = "output.wav";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK) outputFilename = saveFileDialog.FileName;
                    else return;
                }
                MessageBox.Show("start recording", "@recording", MessageBoxButtons.OK, MessageBoxIcon.Error);
                capture = new WasapiLoopbackCapture();
                writer = new WaveFileWriter(outputFilename, capture.WaveFormat);
                capture.DataAvailable += (s, a) =>
                {
                    writer.Write(a.Buffer, 0, a.BytesRecorded);
                };
                capture.RecordingStopped += (s, a) =>
                {
                    writer.Dispose();
                    writer = null;
                    capture.Dispose();
                };
                capture.StartRecording();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "@error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void StopRecording()
        {
            try
            {
                MessageBox.Show("stop recording", "@recording", MessageBoxButtons.OK, MessageBoxIcon.Information);
                capture.StopRecording();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "@error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // начать запись

        private void recordStartToolStripButton_Click(object sender, EventArgs e)
        {
            StartRecording();
            recordStartToolStripButton.Enabled = false;
            recordStopToolStripButton.Enabled = true;
        }

        // остановить запись

        private void recordStopToolStripButton_Click(object sender, EventArgs e)
        {
            StopRecording();
            recordStopToolStripButton.Enabled = false;
            recordStartToolStripButton.Enabled = true;
        }

        private void начатьзакончитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (recordStartToolStripButton.Enabled)
            {
                recordStartToolStripButton_Click(sender, e);
            }
            else
            {
                recordStopToolStripButton_Click(sender, e);
            }
        }

        private void whiteKeys_MouseUp(object sender, MouseEventArgs e) { ((Button)sender).BackColor = ColorTranslator.FromHtml("#EAF4E1"); }
        private void whiteKeys_MouseDown(object sender, MouseEventArgs e) { ((Button)sender).BackColor = ColorTranslator.FromHtml("#94C9A9"); }
        private void blackKeys_MouseDown(object sender, MouseEventArgs e) { ((Button)sender).BackColor = ColorTranslator.FromHtml("#94C9A9"); }
        private void blackKeys_MouseUp(object sender, MouseEventArgs e) { ((Button)sender).BackColor = ColorTranslator.FromHtml("#567856"); }
    }
}
