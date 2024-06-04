using System;
using System.Windows.Forms;
using System.IO;
using NAudio.Wave;
using System.Collections.Generic;
using System.Drawing;
using NAudio.Wave.SampleProviders;

namespace _keys
{
    public partial class Form1 : Form
    {
        private int octave;
        private List<WaveOutEvent> activePlayers = new List<WaveOutEvent>();
        private Users _user;

        public Form1(Users user)
        {
            _user = user;
            InitializeComponent();
            InitializeComboBox();
            InitializeOctave();
            InitializeColors();
            InitializeFont();
            nickNameToolStripLabel.Text = $"{user.login}^^";
        }
        private void InitializeFont() { Font = new Font("Roboto", 12, FontStyle.Regular); }
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
        private void InitializeCurrentUserTime()
        {
            timer.Start();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
            InitializeCurrentUserTime();
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

        private WaveChannel32 waveChannel;
        private StereoToMonoSampleProvider stereoProvider;
        private void PlaySound(UnmanagedMemoryStream soundStream)
        {
            var memoryStream = new MemoryStream();
            soundStream.CopyTo(memoryStream);
            memoryStream.Position = 0;

            var waveReader = new WaveFileReader(memoryStream);
            var bufferedWaveProvider = new BufferedWaveProvider(waveReader.WaveFormat);
            waveChannel = new WaveChannel32(new WaveProviderToWaveStream(bufferedWaveProvider)) { Pan = panSlider.Pan / 100.0f };

            // volume changing
            waveChannel.Volume = volumeTrackBar.Value / 100.0f;

            // stereo adjustment

            if (!stereoCheckBox.Checked)
            {
                var sampleProvider = waveChannel.ToSampleProvider();
                stereoProvider = new StereoToMonoSampleProvider(sampleProvider)
                {
                    LeftVolume = stereoTrackBar.Value / 100.0f,
                    RightVolume = stereoTrackBar.Value / 100.0f
                };
            }

            WaveOutEvent waveOut = new WaveOutEvent();

            if (!stereoCheckBox.Checked) 
            { 
                waveOut.Init(stereoProvider); 
            }
            else 
            { 
                waveOut.Init(waveChannel); 
            }

            waveOut.PlaybackStopped += (sender, args) =>
            {
                waveOut.Dispose();
                waveReader.Dispose();
                memoryStream.Dispose();
                activePlayers.Remove(waveOut);
            };

            activePlayers.Add(waveOut);

            try
            {
                byte[] buffer = new byte[waveReader.Length];
                int bytesRead;
                while ((bytesRead = waveReader.Read(buffer, 0, buffer.Length)) > 0)
                {
                    bufferedWaveProvider.AddSamples(buffer, 0, bytesRead);
                }
            }
            catch { }

            waveOut.Play();

            if (activePlayers.Count > 10)
            {
                var oldestPlayer = activePlayers[0];
                oldestPlayer.Stop();
            }
        }

        private void C_button_Click(object sender, EventArgs e)
        {
            PlaySound("C", octave);
        }

        private void C_sharp_button_Click(object sender, EventArgs e)
        {
            PlaySound("C_", octave);
        }

        private void D_button_Click(object sender, EventArgs e)
        {
            PlaySound("D", octave);
        }

        private void D_sharp_button_Click(object sender, EventArgs e)
        {
            PlaySound("D_", octave);
        }

        private void E_button_Click(object sender, EventArgs e)
        {
            PlaySound("E", octave);
        }

        private void F_button_Click(object sender, EventArgs e)
        {
            PlaySound("F", octave);
        }

        private void F_sharp_button_Click(object sender, EventArgs e)
        {
            PlaySound("F_", octave);
        }

        private void G_button_Click(object sender, EventArgs e)
        {
            PlaySound("G", octave);
        }

        private void G_sharp_button_Click(object sender, EventArgs e)
        {
            PlaySound("G_", octave);
        }

        private void A_button_Click(object sender, EventArgs e)
        {
            PlaySound("A", octave);
        }

        private void A_sharp_button_Click(object sender, EventArgs e)
        {
            PlaySound("A_", octave);
        }

        private void B_button_Click(object sender, EventArgs e)
        {
            PlaySound("B", octave);
        }

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

        // start recording

        private void recordStartToolStripButton_Click(object sender, EventArgs e)
        {
            StartRecording();
            recordStartToolStripButton.Enabled = false;
            recordStopToolStripButton.Enabled = true;
        }

        // stop recording

        private void recordStopToolStripButton_Click(object sender, EventArgs e)
        {
            StopRecording();
            recordStopToolStripButton.Enabled = false;
            recordStartToolStripButton.Enabled = true;
        }

        private void whiteKeys_MouseUp(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackColor = ColorTranslator.FromHtml("#EAF4E1");
        }

        private void whiteKeys_MouseDown(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackColor = ColorTranslator.FromHtml("#94C9A9");
        }

        private void blackKeys_MouseDown(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackColor = ColorTranslator.FromHtml("#94C9A9");
        }

        private void blackKeys_MouseUp(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackColor = ColorTranslator.FromHtml("#567856");
        }

        // exit

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitToolStripButton_Click(sender, e);
        }

        // database, users, and duration

        private int hour, minute, second;
        private void startstopRecordToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void nickNameToolStripLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"hey, {_user.login}, you've played for {Users.ConvertSecondsToDate(_user.time)}!", "@main form", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Invoke(new Action(() =>
            {
                ++second;
                if (second == 60)
                {
                    second = 0;
                    ++minute;
                }
                if (minute == 60)
                {
                    minute = 0;
                    ++hour;
                }
                timerToolStripTextBox.Text = string.Format("{0}:{1}:{2}", hour.ToString().PadLeft(2, '0'), minute.ToString().PadLeft(2, '0'), second.ToString().PadLeft(2, '0'));
            }));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
            int totalSeconds = hour * 3600 + minute * 60 + second;
            _user.time += totalSeconds;
            DatabaseHelper.DatabaseHelper.UpdateUserTime(_user);

            if (MessageBox.Show("do you want to see the records table?", "@main form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                RecordForm record_form = new RecordForm();
                record_form.ShowDialog();
            }
        }

        // exit 

        private void exitToolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // main panel

        // volume

        private void volumeTrackBar_Scroll(object sender, EventArgs e)
        {
            if (waveChannel != null)
            {
                waveChannel.Volume = volumeTrackBar.Value / 100.0f;
            }
        }

        // stereo

        private void stereoTrackBar_Scroll(object sender, EventArgs e)
        {
            if (stereoProvider != null)
            {
                stereoProvider.LeftVolume = stereoTrackBar.Value / 100.0f;
                stereoProvider.RightVolume = stereoTrackBar.Value / 100.0f;
            }
        }
        private void stereoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            stereoTrackBar.Enabled = !stereoTrackBar.Enabled;
        }


        // UI settings

        private void interfaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settings_form = new SettingsForm();
            settings_form.ApplySettings += OnApplySettings;
            this.Hide();
            settings_form.ShowDialog();
            this.Show();
        }
        private void OnApplySettings(Color whiteNotesColor, Color blackNotesColor, Color mainPanelColor, Color pianoPanelColor, Color toolStripColor, Color menuStripColor)
        {
            pianoPanel.BackColor = pianoPanelColor;
            toolStrip.BackColor = toolStripColor;
            menuStrip.BackColor = menuStripColor;
            mainPanel.BackColor = mainPanelColor;
            Button[] white_keys = { C_button, D_button, E_button, F_button, G_button, A_button, B_button };
            Button[] black_keys = { C_sharp_button, D_sharp_button, F_sharp_button, G_sharp_button, A_sharp_button };
            foreach (var key in white_keys) { key.BackColor = whiteNotesColor; }
            foreach (var key in black_keys) { key.BackColor = blackNotesColor; }
        }
    }

    // adapter, convert IWaveProvider to WaveStream
    public class WaveProviderToWaveStream : WaveStream
    {
        private readonly IWaveProvider sourceProvider;
        private long position;

        public WaveProviderToWaveStream(IWaveProvider sourceProvider)
        {
            this.sourceProvider = sourceProvider;
        }

        public override WaveFormat WaveFormat => sourceProvider.WaveFormat;

        public override long Length => long.MaxValue;

        public override long Position
        {
            get => position;
            set => position = value;
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            int read = sourceProvider.Read(buffer, offset, count);
            position += read;
            return read;
        }
    }
}