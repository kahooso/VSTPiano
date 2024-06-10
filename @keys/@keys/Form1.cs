using System;
using System.Windows.Forms;
using System.IO;
using NAudio.Wave;
using System.Collections.Generic;
using System.Drawing;
using AudioSwitcher.AudioApi.CoreAudio;

namespace _keys
{
    public partial class Form1 : Form
    {
        private int octave;
        private Users _user;

        public Form1(Users user)
        {
            _user = user;
            InitializeComponent();
            InitializeComboBox();
            InitializeOctave();
            InitializeColors();
            InitializeFont();
            InitializeVolume();
            InitializeAudioDevice();
            nickNameToolStripLabel.Text = $"{user.login}^^";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
            InitializeCurrentUserTime();
        }

        // INITIALIZATIONS

        private CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
        private void InitializeAudioDevice()
        {
            defaultPlaybackDevice.Volume = 80;
        }
        private void InitializeVolume()
        {
            volumeTrackBar.Minimum = 0;
            volumeTrackBar.Maximum = 100;
            volumeTrackBar.Value = 75;
            volumeTrackBar.TickFrequency = 10;
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
        private void octaveComboBox_SelectedIndexChanged(object sender, EventArgs e) { InitializeOctave(); }

        // PLAY SOUNDS

        private void PlaySound(string note, int octave)
        {
            string resourceName = $"{pianoComboBox.Text}_{note}{octave}";
            var resource = Properties.Resources.ResourceManager.GetStream(resourceName);
            if (resource != null)
                PlaySound(resource);
            else
                MessageBox.Show($"sound {resourceName} not found.", "@error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private DirectSoundOut output = null;

        private BlockAlignReductionStream stream = null;
        private void PlaySound(UnmanagedMemoryStream resource_stream)
        {
            WaveChannel32 wave = new WaveChannel32(new WaveFileReader(resource_stream));
            EffectStream effect = new EffectStream(wave);
            stream = new BlockAlignReductionStream(effect);

            if (echoTrackBar.Value > 0)
                for (int i = 0; i < wave.WaveFormat.Channels; ++i)
                    effect.Effects.Add(new Echo(echo_length, echo_factor));

            output = new DirectSoundOut(100);
            output.Init(stream);
            output.Play();
        }

        // echo

        private int echo_length = 0;
        private float echo_factor = 0.0f;
        private void echoTrackBar_Scroll(object sender, EventArgs e)
        {
            echo_length = echoTrackBar.Value;
            echo_factor = echoTrackBar.Value / 32768.0f;
        }

        // volume

        private void volumeTrackBar_Scroll(object sender, EventArgs e)
        {
            defaultPlaybackDevice.Volume = volumeTrackBar.Value;
        }

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

        private void analyzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MediaForm media_form = new MediaForm();
            this.Hide();
            media_form.ShowDialog();
            this.Show();
        }

        // NOTES

        private void whiteKeys_MouseUp(object sender, MouseEventArgs e) { ((Button)sender).BackColor = current_white_key; }
        private void whiteKeys_MouseDown(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackColor = current_pressed_key_color;
            PlaySound(((Button)sender).Text, octave);
        }
        private void blackKeys_MouseUp(object sender, MouseEventArgs e) { ((Button)sender).BackColor = current_black_key; }
        private void blackKeys_MouseDown(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackColor = current_pressed_key_color;
            PlaySound(((Button)sender).Text.Substring(0, ((Button)sender).Text.Length - 1) + "_", octave);
        }
        // EXIT

        private void exitToolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitToolStripButton_Click(sender, e);
        }

        // DATABASE, USERS, TIME

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

        // UI settings

        private void interfaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settings_form = new SettingsForm();
            settings_form.ApplySettings += OnApplySettings;
            this.Hide();
            settings_form.ShowDialog();
            this.Show();
        }
        private Color current_white_key = Color.FromArgb(255, 234, 244, 225), current_black_key = ColorTranslator.FromHtml("#567856"), current_pressed_key_color = ColorTranslator.FromHtml("#94C9A9");
        private void OnApplySettings(Color whiteNotesColor, Color blackNotesColor, Color pressedNotesColor, Color mainPanelColor, Color pianoPanelColor, Color toolStripColor, Color menuStripColor)
        {
            pianoPanel.BackColor = pianoPanelColor;
            toolStrip.BackColor = toolStripColor;
            menuStrip.BackColor = menuStripColor;
            mainPanel.BackColor = mainPanelColor;

            Button[] white_keys = { C_button, D_button, E_button, F_button, G_button, A_button, B_button };
            Button[] black_keys = { C_sharp_button, D_sharp_button, F_sharp_button, G_sharp_button, A_sharp_button };

            current_white_key = whiteNotesColor;
            current_black_key = blackNotesColor;
            current_pressed_key_color = pressedNotesColor;

            foreach (var key in white_keys) { key.BackColor = whiteNotesColor; }
            foreach (var key in black_keys) { key.BackColor = blackNotesColor; }
        }

        private void panSlider_Scroll(object sender, ScrollEventArgs e)
        {
        }

        // PLAY WITH KEYBOARD

        private HashSet<Keys> pressedKeys = new HashSet<Keys>();
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!pressedKeys.Contains(e.KeyCode))
            {
                pressedKeys.Add(e.KeyCode);
                Button note = GetButtonFromKey(e.KeyCode);
                if (note != null)
                {
                    MouseEventArgs mouseEventArgs = new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0);
                    if (note.Text.Length == 1)
                        whiteKeys_MouseDown(note, mouseEventArgs);
                    else 
                        blackKeys_MouseDown(note, mouseEventArgs);
                }
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (pressedKeys.Contains(e.KeyCode))
            {
                pressedKeys.Remove(e.KeyCode);
                Button note = GetButtonFromKey(e.KeyCode);
                if (note != null)
                {
                    MouseEventArgs mouseEventArgs = new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0);
                    if (note.Text.Length == 1)
                        whiteKeys_MouseUp(note, mouseEventArgs);
                    else 
                        blackKeys_MouseUp(note, mouseEventArgs);
                }
            }
        }
        private Button GetButtonFromKey(Keys key)
        {
            switch (key)
            {
                case Keys.Z: return C_button;
                case Keys.X: return C_sharp_button;
                case Keys.C: return D_button;
                case Keys.V: return D_sharp_button;
                case Keys.B: return E_button;
                case Keys.N: return F_button;
                case Keys.M: return F_sharp_button;
                case Keys.R: return G_button;
                case Keys.T: return G_sharp_button;
                case Keys.Y: return A_button;
                case Keys.U: return A_sharp_button;
                case Keys.I: return B_button;
                default: return null;
            }
        }
    }
}