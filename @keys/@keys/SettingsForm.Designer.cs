namespace _keys
{
    partial class SettingsForm
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
            this.applyButton = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.stripsGroupBox = new System.Windows.Forms.GroupBox();
            this.menuStripLabel = new System.Windows.Forms.Label();
            this.toolStripLabel = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.Panel();
            this.toolStrip = new System.Windows.Forms.Panel();
            this.panelGroupBox = new System.Windows.Forms.GroupBox();
            this.mainPanelLabel = new System.Windows.Forms.Label();
            this.pianoPanelLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.pianoPanel = new System.Windows.Forms.Panel();
            this.notesGroupBox = new System.Windows.Forms.GroupBox();
            this.whiteNoteLabel = new System.Windows.Forms.Label();
            this.blackNote = new System.Windows.Forms.Panel();
            this.blackNoteLabel = new System.Windows.Forms.Label();
            this.whiteNote = new System.Windows.Forms.Panel();
            this.resetButton = new System.Windows.Forms.Button();
            this.settingsPanel.SuspendLayout();
            this.stripsGroupBox.SuspendLayout();
            this.panelGroupBox.SuspendLayout();
            this.notesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // applyButton
            // 
            this.applyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(244)))), ((int)(((byte)(225)))));
            this.applyButton.Location = new System.Drawing.Point(37, 295);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(208, 64);
            this.applyButton.TabIndex = 1;
            this.applyButton.Text = "apply";
            this.applyButton.UseVisualStyleBackColor = false;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // settingsPanel
            // 
            this.settingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.settingsPanel.Controls.Add(this.stripsGroupBox);
            this.settingsPanel.Controls.Add(this.panelGroupBox);
            this.settingsPanel.Controls.Add(this.notesGroupBox);
            this.settingsPanel.Location = new System.Drawing.Point(37, 12);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(277, 277);
            this.settingsPanel.TabIndex = 0;
            // 
            // stripsGroupBox
            // 
            this.stripsGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.stripsGroupBox.Controls.Add(this.menuStripLabel);
            this.stripsGroupBox.Controls.Add(this.toolStripLabel);
            this.stripsGroupBox.Controls.Add(this.menuStrip);
            this.stripsGroupBox.Controls.Add(this.toolStrip);
            this.stripsGroupBox.Location = new System.Drawing.Point(18, 120);
            this.stripsGroupBox.Name = "stripsGroupBox";
            this.stripsGroupBox.Size = new System.Drawing.Size(116, 100);
            this.stripsGroupBox.TabIndex = 16;
            this.stripsGroupBox.TabStop = false;
            this.stripsGroupBox.Text = "strips";
            // 
            // menuStripLabel
            // 
            this.menuStripLabel.AutoSize = true;
            this.menuStripLabel.Location = new System.Drawing.Point(16, 33);
            this.menuStripLabel.Name = "menuStripLabel";
            this.menuStripLabel.Size = new System.Drawing.Size(58, 13);
            this.menuStripLabel.TabIndex = 4;
            this.menuStripLabel.Text = "menu strip:";
            // 
            // toolStripLabel
            // 
            this.toolStripLabel.AutoSize = true;
            this.toolStripLabel.Location = new System.Drawing.Point(16, 62);
            this.toolStripLabel.Name = "toolStripLabel";
            this.toolStripLabel.Size = new System.Drawing.Size(49, 13);
            this.toolStripLabel.TabIndex = 5;
            this.toolStripLabel.Text = "tool strip:";
            // 
            // menuStrip
            // 
            this.menuStrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuStrip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuStrip.Location = new System.Drawing.Point(86, 31);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(16, 16);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Click += new System.EventHandler(this.allPanels_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStrip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toolStrip.Location = new System.Drawing.Point(86, 62);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(16, 16);
            this.toolStrip.TabIndex = 11;
            this.toolStrip.Click += new System.EventHandler(this.allPanels_Click);
            // 
            // panelGroupBox
            // 
            this.panelGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelGroupBox.Controls.Add(this.mainPanelLabel);
            this.panelGroupBox.Controls.Add(this.pianoPanelLabel);
            this.panelGroupBox.Controls.Add(this.mainPanel);
            this.panelGroupBox.Controls.Add(this.pianoPanel);
            this.panelGroupBox.Location = new System.Drawing.Point(140, 14);
            this.panelGroupBox.Name = "panelGroupBox";
            this.panelGroupBox.Size = new System.Drawing.Size(116, 100);
            this.panelGroupBox.TabIndex = 15;
            this.panelGroupBox.TabStop = false;
            this.panelGroupBox.Text = "panels";
            // 
            // mainPanelLabel
            // 
            this.mainPanelLabel.AutoSize = true;
            this.mainPanelLabel.Location = new System.Drawing.Point(23, 32);
            this.mainPanelLabel.Name = "mainPanelLabel";
            this.mainPanelLabel.Size = new System.Drawing.Size(61, 13);
            this.mainPanelLabel.TabIndex = 2;
            this.mainPanelLabel.Text = "main panel:";
            // 
            // pianoPanelLabel
            // 
            this.pianoPanelLabel.AutoSize = true;
            this.pianoPanelLabel.Location = new System.Drawing.Point(19, 62);
            this.pianoPanelLabel.Name = "pianoPanelLabel";
            this.pianoPanelLabel.Size = new System.Drawing.Size(65, 13);
            this.pianoPanelLabel.TabIndex = 3;
            this.pianoPanelLabel.Text = "piano panel:";
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainPanel.Location = new System.Drawing.Point(90, 30);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(16, 16);
            this.mainPanel.TabIndex = 12;
            this.mainPanel.Click += new System.EventHandler(this.allPanels_Click);
            // 
            // pianoPanel
            // 
            this.pianoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pianoPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pianoPanel.Location = new System.Drawing.Point(90, 60);
            this.pianoPanel.Name = "pianoPanel";
            this.pianoPanel.Size = new System.Drawing.Size(16, 16);
            this.pianoPanel.TabIndex = 10;
            this.pianoPanel.Click += new System.EventHandler(this.allPanels_Click);
            // 
            // notesGroupBox
            // 
            this.notesGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.notesGroupBox.Controls.Add(this.whiteNoteLabel);
            this.notesGroupBox.Controls.Add(this.blackNote);
            this.notesGroupBox.Controls.Add(this.blackNoteLabel);
            this.notesGroupBox.Controls.Add(this.whiteNote);
            this.notesGroupBox.Location = new System.Drawing.Point(18, 14);
            this.notesGroupBox.Name = "notesGroupBox";
            this.notesGroupBox.Size = new System.Drawing.Size(116, 100);
            this.notesGroupBox.TabIndex = 14;
            this.notesGroupBox.TabStop = false;
            this.notesGroupBox.Text = "notes";
            // 
            // whiteNoteLabel
            // 
            this.whiteNoteLabel.AutoSize = true;
            this.whiteNoteLabel.Location = new System.Drawing.Point(16, 32);
            this.whiteNoteLabel.Name = "whiteNoteLabel";
            this.whiteNoteLabel.Size = new System.Drawing.Size(64, 13);
            this.whiteNoteLabel.TabIndex = 0;
            this.whiteNoteLabel.Text = "white notes:";
            // 
            // blackNote
            // 
            this.blackNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blackNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blackNote.Location = new System.Drawing.Point(86, 60);
            this.blackNote.Name = "blackNote";
            this.blackNote.Size = new System.Drawing.Size(16, 16);
            this.blackNote.TabIndex = 13;
            this.blackNote.Click += new System.EventHandler(this.allPanels_Click);
            // 
            // blackNoteLabel
            // 
            this.blackNoteLabel.AutoSize = true;
            this.blackNoteLabel.Location = new System.Drawing.Point(16, 62);
            this.blackNoteLabel.Name = "blackNoteLabel";
            this.blackNoteLabel.Size = new System.Drawing.Size(65, 13);
            this.blackNoteLabel.TabIndex = 1;
            this.blackNoteLabel.Text = "black notes:";
            // 
            // whiteNote
            // 
            this.whiteNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.whiteNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.whiteNote.Location = new System.Drawing.Point(86, 30);
            this.whiteNote.Name = "whiteNote";
            this.whiteNote.Size = new System.Drawing.Size(16, 16);
            this.whiteNote.TabIndex = 6;
            this.whiteNote.Click += new System.EventHandler(this.allPanels_Click);
            // 
            // resetButton
            // 
            this.resetButton.AutoSize = true;
            this.resetButton.BackColor = System.Drawing.Color.Transparent;
            this.resetButton.BackgroundImage = global::_keys.Properties.Resources.reset;
            this.resetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resetButton.FlatAppearance.BorderSize = 0;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Location = new System.Drawing.Point(250, 295);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(64, 64);
            this.resetButton.TabIndex = 17;
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_keys.Properties.Resources.settings;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(344, 421);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.settingsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "@settings";
            this.settingsPanel.ResumeLayout(false);
            this.stripsGroupBox.ResumeLayout(false);
            this.stripsGroupBox.PerformLayout();
            this.panelGroupBox.ResumeLayout(false);
            this.panelGroupBox.PerformLayout();
            this.notesGroupBox.ResumeLayout(false);
            this.notesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.GroupBox stripsGroupBox;
        private System.Windows.Forms.Label menuStripLabel;
        private System.Windows.Forms.Label toolStripLabel;
        private System.Windows.Forms.Panel menuStrip;
        private System.Windows.Forms.Panel toolStrip;
        private System.Windows.Forms.GroupBox panelGroupBox;
        private System.Windows.Forms.Label mainPanelLabel;
        private System.Windows.Forms.Label pianoPanelLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel pianoPanel;
        private System.Windows.Forms.GroupBox notesGroupBox;
        private System.Windows.Forms.Label whiteNoteLabel;
        private System.Windows.Forms.Panel blackNote;
        private System.Windows.Forms.Label blackNoteLabel;
        private System.Windows.Forms.Panel whiteNote;
        private System.Windows.Forms.Button resetButton;
    }
}