namespace _keys
{
    partial class MediaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaForm));
            this.mediaListBox = new System.Windows.Forms.ListBox();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.directionLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.notesPictureBox = new System.Windows.Forms.PictureBox();
            this.onlyWaveLabel = new System.Windows.Forms.Label();
            this.customWaveViewer = new _keys.CustomWaveViewer();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowsMediaPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mediaListBox
            // 
            this.mediaListBox.FormattingEnabled = true;
            this.mediaListBox.Location = new System.Drawing.Point(543, 28);
            this.mediaListBox.Name = "mediaListBox";
            this.mediaListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mediaListBox.Size = new System.Drawing.Size(247, 173);
            this.mediaListBox.TabIndex = 1;
            this.mediaListBox.SelectedIndexChanged += new System.EventHandler(this.mediaListBox_SelectedIndexChanged);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.BackColor = System.Drawing.Color.White;
            this.fileNameLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.fileNameLabel.Location = new System.Drawing.Point(12, 449);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(52, 13);
            this.fileNameLabel.TabIndex = 2;
            this.fileNameLabel.Text = "file name:";
            // 
            // directionLabel
            // 
            this.directionLabel.AutoSize = true;
            this.directionLabel.BackColor = System.Drawing.Color.White;
            this.directionLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.directionLabel.Location = new System.Drawing.Point(540, 204);
            this.directionLabel.Name = "directionLabel";
            this.directionLabel.Size = new System.Drawing.Size(50, 13);
            this.directionLabel.TabIndex = 3;
            this.directionLabel.Text = "direction:";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFolderToolStripMenuItem,
            this.analizeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "file";
            // 
            // loadFolderToolStripMenuItem
            // 
            this.loadFolderToolStripMenuItem.Name = "loadFolderToolStripMenuItem";
            this.loadFolderToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.loadFolderToolStripMenuItem.Text = "load folder";
            this.loadFolderToolStripMenuItem.Click += new System.EventHandler(this.loadFolderToolStripMenuItem_Click);
            // 
            // analizeToolStripMenuItem
            // 
            this.analizeToolStripMenuItem.Name = "analizeToolStripMenuItem";
            this.analizeToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.analizeToolStripMenuItem.Text = "analize";
            this.analizeToolStripMenuItem.Click += new System.EventHandler(this.analizeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // windowsMediaPlayer
            // 
            this.windowsMediaPlayer.Enabled = true;
            this.windowsMediaPlayer.Location = new System.Drawing.Point(12, 28);
            this.windowsMediaPlayer.Name = "windowsMediaPlayer";
            this.windowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("windowsMediaPlayer.OcxState")));
            this.windowsMediaPlayer.Size = new System.Drawing.Size(522, 410);
            this.windowsMediaPlayer.TabIndex = 0;
            this.windowsMediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.windowsMediaPlayer_PlayStateChange);
            // 
            // notesPictureBox
            // 
            this.notesPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.notesPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.notesPictureBox.Image = global::_keys.Properties.Resources.aesthetic;
            this.notesPictureBox.InitialImage = global::_keys.Properties.Resources.notes;
            this.notesPictureBox.Location = new System.Drawing.Point(-37, -24);
            this.notesPictureBox.Name = "notesPictureBox";
            this.notesPictureBox.Size = new System.Drawing.Size(871, 624);
            this.notesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.notesPictureBox.TabIndex = 9;
            this.notesPictureBox.TabStop = false;
            // 
            // onlyWaveLabel
            // 
            this.onlyWaveLabel.AutoSize = true;
            this.onlyWaveLabel.Location = new System.Drawing.Point(613, 302);
            this.onlyWaveLabel.Name = "onlyWaveLabel";
            this.onlyWaveLabel.Size = new System.Drawing.Size(115, 13);
            this.onlyWaveLabel.TabIndex = 11;
            this.onlyWaveLabel.Text = "support only wav file =(";
            this.onlyWaveLabel.Visible = false;
            // 
            // customWaveViewer
            // 
            this.customWaveViewer.Location = new System.Drawing.Point(543, 236);
            this.customWaveViewer.Name = "customWaveViewer";
            this.customWaveViewer.PenColor = System.Drawing.Color.DodgerBlue;
            this.customWaveViewer.PenWidth = 1F;
            this.customWaveViewer.SamplesPerPixel = 128;
            this.customWaveViewer.Size = new System.Drawing.Size(247, 202);
            this.customWaveViewer.StartPosition = ((long)(0));
            this.customWaveViewer.TabIndex = 10;
            this.customWaveViewer.WaveStream = null;
            // 
            // MediaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.onlyWaveLabel);
            this.Controls.Add(this.customWaveViewer);
            this.Controls.Add(this.directionLabel);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.mediaListBox);
            this.Controls.Add(this.windowsMediaPlayer);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.notesPictureBox);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MediaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "@media";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MediaForm_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowsMediaPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer windowsMediaPlayer;
        private System.Windows.Forms.ListBox mediaListBox;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label directionLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFolderToolStripMenuItem;
        private System.Windows.Forms.PictureBox notesPictureBox;
        private CustomWaveViewer customWaveViewer;
        private System.Windows.Forms.ToolStripMenuItem analizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label onlyWaveLabel;
    }
}