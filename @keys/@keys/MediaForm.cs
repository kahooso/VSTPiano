using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;

namespace _keys
{
    public partial class MediaForm : Form
    {
        private List<string> filtered_files = new List<string>();
        private FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        private int current_file = 0;

        public MediaForm()
        {
            InitializeComponent();
        }
        
        // MEDIA PLAYER

        private void loadFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            windowsMediaPlayer.Ctlcontrols.stop();

            if (filtered_files.Count > 1)
            {
                filtered_files.Clear();
                filtered_files = null;

                mediaListBox.Items.Clear();

                current_file = 0;
            }

            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                filtered_files = Directory.GetFiles(folderBrowserDialog.SelectedPath, "*.*").Where(file => file.ToLower().EndsWith("wav")).ToList();
            }

            LoadPlaylist();
        }
        private void windowsMediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 0)
            {
                // undefined loaded
                directionLabel.Text = "media player is ready to be loaded";
            }
            else if (e.newState == 1)
            {
                directionLabel.Text = "media player stopped";
            }
            else if (e.newState == 3)
            {
                directionLabel.Text = "duration: " + windowsMediaPlayer.currentMedia.durationString;
            }
            else if (e.newState == 8)
            {
                if (current_file >= filtered_files.Count - 1)
                    current_file = 0;
                else
                    current_file += 1;
                mediaListBox.SelectedIndex = current_file;
                ShowFileName(fileNameLabel);
            }
            else if (e.newState == 9)
            {
                // if the media player is loading new video
                directionLabel.Text = "loading new video";
            }
            else if (e.newState == 10)
            {
                // media is ready to play again
                timer.Start();
            }
        }
        private void mediaListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            current_file = mediaListBox.SelectedIndex;
            PlayFile(mediaListBox.SelectedItem.ToString());
            ShowFileName(fileNameLabel);
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            windowsMediaPlayer.Ctlcontrols.play();
            timer.Stop();
        }
        private void LoadPlaylist()
        {
            windowsMediaPlayer.currentPlaylist = windowsMediaPlayer.newPlaylist("playlist", "");

            foreach(string files in filtered_files)
            {
                windowsMediaPlayer.currentPlaylist.appendItem(windowsMediaPlayer.newMedia(files));
                mediaListBox.Items.Add(files);
            }

            if (filtered_files.Count > 0)
            {
                fileNameLabel.Text = "files found -> " + filtered_files.Count;
                mediaListBox.SelectedIndex = current_file;
                PlayFile(mediaListBox.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("no video files found in this folder", "@media", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PlayFile(string url)
        {
            windowsMediaPlayer.URL = url;
            if (Path.GetExtension(url).Equals(".wav", StringComparison.OrdinalIgnoreCase))
            {
                onlyWaveLabel.Visible = false;
                customWaveViewer.WaveStream = new NAudio.Wave.WaveFileReader(url);
                customWaveViewer.FitToScreen();
            }
            else
            {
                customWaveViewer.ResetText();
                onlyWaveLabel.Visible = true;
            }
        }

        private void ShowFileName(Label name)
        {
            directionLabel.Text = $"currenly playing -> {Path.GetFileName(mediaListBox.SelectedItem.ToString())}";
        }

        // ANALIZE

        private void analizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { customWaveViewer.FitToScreen(); }
            catch { }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) { this.Close(); }

        private void MediaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (windowsMediaPlayer != null)
            {
                windowsMediaPlayer.Ctlcontrols.stop();
                windowsMediaPlayer.close();
            }

            if (customWaveViewer != null && customWaveViewer.WaveStream != null)
            {
                customWaveViewer.WaveStream.Dispose();
                customWaveViewer.WaveStream = null;
            }

            if (filtered_files != null)
            {
                filtered_files.Clear();
                filtered_files = null;
            }
            this.Dispose();
        }

        private void fitLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            analizeToolStripMenuItem_Click(sender, e);
        }
    }
}
