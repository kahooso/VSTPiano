namespace VSTPiano
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.C_button = new System.Windows.Forms.Button();
            this.D_button = new System.Windows.Forms.Button();
            this.E_button = new System.Windows.Forms.Button();
            this.F_button = new System.Windows.Forms.Button();
            this.G_button = new System.Windows.Forms.Button();
            this.A_button = new System.Windows.Forms.Button();
            this.B_button = new System.Windows.Forms.Button();
            this.pianoPanel = new System.Windows.Forms.Panel();
            this.G_sharp_button = new System.Windows.Forms.Button();
            this.A_sharp_button = new System.Windows.Forms.Button();
            this.C_sharp_button = new System.Windows.Forms.Button();
            this.F_sharp_button = new System.Windows.Forms.Button();
            this.D_sharp_button = new System.Windows.Forms.Button();
            this.volumeProgressBar = new CircularProgressBar.CircularProgressBar();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.label3 = new System.Windows.Forms.Label();
            this.panoramProgressBar = new CircularProgressBar.CircularProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.informationLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.settingsButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panSlider = new NAudio.Gui.PanSlider();
            this.pianoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // C_button
            // 
            this.C_button.Location = new System.Drawing.Point(11, 14);
            this.C_button.Margin = new System.Windows.Forms.Padding(2);
            this.C_button.Name = "C_button";
            this.C_button.Size = new System.Drawing.Size(85, 218);
            this.C_button.TabIndex = 0;
            this.C_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.C_button.UseVisualStyleBackColor = true;
            this.C_button.Click += new System.EventHandler(this.C_button_Click);
            // 
            // D_button
            // 
            this.D_button.Location = new System.Drawing.Point(100, 14);
            this.D_button.Margin = new System.Windows.Forms.Padding(2);
            this.D_button.Name = "D_button";
            this.D_button.Size = new System.Drawing.Size(85, 218);
            this.D_button.TabIndex = 1;
            this.D_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.D_button.UseVisualStyleBackColor = true;
            // 
            // E_button
            // 
            this.E_button.Location = new System.Drawing.Point(189, 14);
            this.E_button.Margin = new System.Windows.Forms.Padding(2);
            this.E_button.Name = "E_button";
            this.E_button.Size = new System.Drawing.Size(85, 218);
            this.E_button.TabIndex = 2;
            this.E_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.E_button.UseVisualStyleBackColor = true;
            // 
            // F_button
            // 
            this.F_button.Location = new System.Drawing.Point(278, 14);
            this.F_button.Margin = new System.Windows.Forms.Padding(2);
            this.F_button.Name = "F_button";
            this.F_button.Size = new System.Drawing.Size(85, 218);
            this.F_button.TabIndex = 3;
            this.F_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.F_button.UseVisualStyleBackColor = true;
            // 
            // G_button
            // 
            this.G_button.Location = new System.Drawing.Point(367, 14);
            this.G_button.Margin = new System.Windows.Forms.Padding(2);
            this.G_button.Name = "G_button";
            this.G_button.Size = new System.Drawing.Size(85, 218);
            this.G_button.TabIndex = 4;
            this.G_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.G_button.UseVisualStyleBackColor = true;
            // 
            // A_button
            // 
            this.A_button.Location = new System.Drawing.Point(456, 14);
            this.A_button.Margin = new System.Windows.Forms.Padding(2);
            this.A_button.Name = "A_button";
            this.A_button.Size = new System.Drawing.Size(85, 218);
            this.A_button.TabIndex = 5;
            this.A_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.A_button.UseVisualStyleBackColor = true;
            // 
            // B_button
            // 
            this.B_button.Location = new System.Drawing.Point(545, 14);
            this.B_button.Margin = new System.Windows.Forms.Padding(2);
            this.B_button.Name = "B_button";
            this.B_button.Size = new System.Drawing.Size(85, 218);
            this.B_button.TabIndex = 6;
            this.B_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.B_button.UseVisualStyleBackColor = true;
            // 
            // pianoPanel
            // 
            this.pianoPanel.AutoSize = true;
            this.pianoPanel.BackColor = System.Drawing.Color.Transparent;
            this.pianoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pianoPanel.Controls.Add(this.G_sharp_button);
            this.pianoPanel.Controls.Add(this.A_sharp_button);
            this.pianoPanel.Controls.Add(this.C_sharp_button);
            this.pianoPanel.Controls.Add(this.F_sharp_button);
            this.pianoPanel.Controls.Add(this.C_button);
            this.pianoPanel.Controls.Add(this.D_sharp_button);
            this.pianoPanel.Controls.Add(this.E_button);
            this.pianoPanel.Controls.Add(this.D_button);
            this.pianoPanel.Controls.Add(this.F_button);
            this.pianoPanel.Controls.Add(this.B_button);
            this.pianoPanel.Controls.Add(this.G_button);
            this.pianoPanel.Controls.Add(this.A_button);
            this.pianoPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pianoPanel.Location = new System.Drawing.Point(240, 216);
            this.pianoPanel.Margin = new System.Windows.Forms.Padding(2);
            this.pianoPanel.Name = "pianoPanel";
            this.pianoPanel.Size = new System.Drawing.Size(644, 246);
            this.pianoPanel.TabIndex = 21;
            // 
            // G_sharp_button
            // 
            this.G_sharp_button.BackColor = System.Drawing.Color.Black;
            this.G_sharp_button.Location = new System.Drawing.Point(424, 14);
            this.G_sharp_button.Margin = new System.Windows.Forms.Padding(2);
            this.G_sharp_button.Name = "G_sharp_button";
            this.G_sharp_button.Size = new System.Drawing.Size(85, 157);
            this.G_sharp_button.TabIndex = 41;
            this.G_sharp_button.UseVisualStyleBackColor = false;
            // 
            // A_sharp_button
            // 
            this.A_sharp_button.BackColor = System.Drawing.Color.Black;
            this.A_sharp_button.Location = new System.Drawing.Point(526, 14);
            this.A_sharp_button.Margin = new System.Windows.Forms.Padding(2);
            this.A_sharp_button.Name = "A_sharp_button";
            this.A_sharp_button.Size = new System.Drawing.Size(85, 157);
            this.A_sharp_button.TabIndex = 41;
            this.A_sharp_button.UseVisualStyleBackColor = false;
            // 
            // C_sharp_button
            // 
            this.C_sharp_button.BackColor = System.Drawing.Color.Black;
            this.C_sharp_button.Location = new System.Drawing.Point(58, 14);
            this.C_sharp_button.Margin = new System.Windows.Forms.Padding(2);
            this.C_sharp_button.Name = "C_sharp_button";
            this.C_sharp_button.Size = new System.Drawing.Size(85, 157);
            this.C_sharp_button.TabIndex = 39;
            this.C_sharp_button.UseVisualStyleBackColor = false;
            // 
            // F_sharp_button
            // 
            this.F_sharp_button.BackColor = System.Drawing.Color.Black;
            this.F_sharp_button.Location = new System.Drawing.Point(322, 14);
            this.F_sharp_button.Margin = new System.Windows.Forms.Padding(2);
            this.F_sharp_button.Name = "F_sharp_button";
            this.F_sharp_button.Size = new System.Drawing.Size(85, 157);
            this.F_sharp_button.TabIndex = 40;
            this.F_sharp_button.UseVisualStyleBackColor = false;
            // 
            // D_sharp_button
            // 
            this.D_sharp_button.BackColor = System.Drawing.Color.Black;
            this.D_sharp_button.Location = new System.Drawing.Point(160, 14);
            this.D_sharp_button.Margin = new System.Windows.Forms.Padding(2);
            this.D_sharp_button.Name = "D_sharp_button";
            this.D_sharp_button.Size = new System.Drawing.Size(85, 157);
            this.D_sharp_button.TabIndex = 40;
            this.D_sharp_button.UseVisualStyleBackColor = false;
            // 
            // volumeProgressBar
            // 
            this.volumeProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.volumeProgressBar.AnimationSpeed = 500;
            this.volumeProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(96)))), ((int)(((byte)(123)))));
            this.volumeProgressBar.Enabled = false;
            this.volumeProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.volumeProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.volumeProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(96)))), ((int)(((byte)(123)))));
            this.volumeProgressBar.InnerMargin = 2;
            this.volumeProgressBar.InnerWidth = -1;
            this.volumeProgressBar.Location = new System.Drawing.Point(455, 8);
            this.volumeProgressBar.Margin = new System.Windows.Forms.Padding(2);
            this.volumeProgressBar.MarqueeAnimationSpeed = 2000;
            this.volumeProgressBar.Name = "volumeProgressBar";
            this.volumeProgressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(250)))), ((int)(((byte)(160)))));
            this.volumeProgressBar.OuterMargin = -25;
            this.volumeProgressBar.OuterWidth = 26;
            this.volumeProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(211)))), ((int)(((byte)(140)))));
            this.volumeProgressBar.ProgressWidth = 10;
            this.volumeProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.volumeProgressBar.Size = new System.Drawing.Size(32, 32);
            this.volumeProgressBar.StartAngle = 270;
            this.volumeProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.volumeProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.volumeProgressBar.SubscriptText = ".23";
            this.volumeProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.volumeProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.volumeProgressBar.SuperscriptText = "°C";
            this.volumeProgressBar.TabIndex = 25;
            this.volumeProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.volumeProgressBar.Value = 68;
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(96)))), ((int)(((byte)(123)))));
            this.toolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1064, 89);
            this.toolStrip.TabIndex = 26;
            this.toolStrip.Text = "toolStrip";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(96)))), ((int)(((byte)(123)))));
            this.label3.Cursor = System.Windows.Forms.Cursors.Help;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 8F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(229)))), ((int)(((byte)(124)))));
            this.label3.Location = new System.Drawing.Point(459, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "vol";
            // 
            // panoramProgressBar
            // 
            this.panoramProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.panoramProgressBar.AnimationSpeed = 500;
            this.panoramProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(96)))), ((int)(((byte)(123)))));
            this.panoramProgressBar.Enabled = false;
            this.panoramProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.panoramProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panoramProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(96)))), ((int)(((byte)(123)))));
            this.panoramProgressBar.InnerMargin = 2;
            this.panoramProgressBar.InnerWidth = -1;
            this.panoramProgressBar.Location = new System.Drawing.Point(498, 8);
            this.panoramProgressBar.Margin = new System.Windows.Forms.Padding(2);
            this.panoramProgressBar.MarqueeAnimationSpeed = 2000;
            this.panoramProgressBar.Name = "panoramProgressBar";
            this.panoramProgressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(250)))), ((int)(((byte)(160)))));
            this.panoramProgressBar.OuterMargin = -25;
            this.panoramProgressBar.OuterWidth = 26;
            this.panoramProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(211)))), ((int)(((byte)(140)))));
            this.panoramProgressBar.ProgressWidth = 10;
            this.panoramProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.panoramProgressBar.Size = new System.Drawing.Size(32, 32);
            this.panoramProgressBar.StartAngle = 270;
            this.panoramProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.panoramProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.panoramProgressBar.SubscriptText = ".23";
            this.panoramProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.panoramProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.panoramProgressBar.SuperscriptText = "°C";
            this.panoramProgressBar.TabIndex = 29;
            this.panoramProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.panoramProgressBar.Value = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(96)))), ((int)(((byte)(123)))));
            this.label4.Cursor = System.Windows.Forms.Cursors.Help;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 8F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(229)))), ((int)(((byte)(124)))));
            this.label4.Location = new System.Drawing.Point(500, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "pan";
            // 
            // informationLabel
            // 
            this.informationLabel.AutoSize = true;
            this.informationLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(96)))), ((int)(((byte)(123)))));
            this.informationLabel.Cursor = System.Windows.Forms.Cursors.Help;
            this.informationLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.informationLabel.Font = new System.Drawing.Font("Segoe Print", 28F);
            this.informationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(229)))), ((int)(((byte)(124)))));
            this.informationLabel.Location = new System.Drawing.Point(0, -3);
            this.informationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.Size = new System.Drawing.Size(139, 67);
            this.informationLabel.TabIndex = 35;
            this.informationLabel.Text = "#keys";
            this.informationLabel.Click += new System.EventHandler(this.informationLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(96)))), ((int)(((byte)(123)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.Help;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 8F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(229)))), ((int)(((byte)(124)))));
            this.label1.Location = new System.Drawing.Point(544, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 19);
            this.label1.TabIndex = 36;
            this.label1.Text = "sets";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(19, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 119);
            this.panel1.TabIndex = 38;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(96)))), ((int)(((byte)(123)))));
            this.settingsButton.BackgroundImage = global::VSTPiano.Properties.Resources.Setting_s;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.settingsButton.Location = new System.Drawing.Point(542, 7);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(2);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(32, 33);
            this.settingsButton.TabIndex = 31;
            this.settingsButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VSTPiano.Properties.Resources.rZQfbgIeI2M;
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1064, 462);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // panSlider
            // 
            this.panSlider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panSlider.Location = new System.Drawing.Point(19, 217);
            this.panSlider.Name = "panSlider";
            this.panSlider.Pan = 0F;
            this.panSlider.Size = new System.Drawing.Size(216, 34);
            this.panSlider.TabIndex = 39;
            this.panSlider.PanChanged += new System.EventHandler(this.panSlider_PanChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(229)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(1064, 473);
            this.Controls.Add(this.panSlider);
            this.Controls.Add(this.pianoPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.informationLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panoramProgressBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.volumeProgressBar);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1080, 512);
            this.MinimumSize = new System.Drawing.Size(1080, 512);
            this.Name = "MainForm";
            this.Text = "#keys";
            this.pianoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button C_button;
        private System.Windows.Forms.Button B_button;
        private System.Windows.Forms.Button A_button;
        private System.Windows.Forms.Button G_button;
        private System.Windows.Forms.Button F_button;
        private System.Windows.Forms.Button E_button;
        private System.Windows.Forms.Button D_button;
        private System.Windows.Forms.Panel pianoPanel;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button A_sharp_button;
        private System.Windows.Forms.Button G_sharp_button;
        private System.Windows.Forms.Button F_sharp_button;
        private System.Windows.Forms.Button D_sharp_button;
        private System.Windows.Forms.Button C_sharp_button;
        private CircularProgressBar.CircularProgressBar volumeProgressBar;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.Label label3;
        private CircularProgressBar.CircularProgressBar panoramProgressBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Label informationLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private NAudio.Gui.PanSlider panSlider;
    }
}

