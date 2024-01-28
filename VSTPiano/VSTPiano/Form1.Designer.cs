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
            this.note1 = new System.Windows.Forms.Button();
            this.note2 = new System.Windows.Forms.Button();
            this.note3 = new System.Windows.Forms.Button();
            this.note4 = new System.Windows.Forms.Button();
            this.note5 = new System.Windows.Forms.Button();
            this.note6 = new System.Windows.Forms.Button();
            this.note7 = new System.Windows.Forms.Button();
            this.note8 = new System.Windows.Forms.Button();
            this.pianoPanel = new System.Windows.Forms.Panel();
            this.note36 = new System.Windows.Forms.Button();
            this.note31 = new System.Windows.Forms.Button();
            this.note35 = new System.Windows.Forms.Button();
            this.note30 = new System.Windows.Forms.Button();
            this.note34 = new System.Windows.Forms.Button();
            this.note29 = new System.Windows.Forms.Button();
            this.note33 = new System.Windows.Forms.Button();
            this.note32 = new System.Windows.Forms.Button();
            this.note28 = new System.Windows.Forms.Button();
            this.note27 = new System.Windows.Forms.Button();
            this.note26 = new System.Windows.Forms.Button();
            this.note25 = new System.Windows.Forms.Button();
            this.note24 = new System.Windows.Forms.Button();
            this.note23 = new System.Windows.Forms.Button();
            this.note22 = new System.Windows.Forms.Button();
            this.note21 = new System.Windows.Forms.Button();
            this.note20 = new System.Windows.Forms.Button();
            this.note19 = new System.Windows.Forms.Button();
            this.note18 = new System.Windows.Forms.Button();
            this.note17 = new System.Windows.Forms.Button();
            this.note9 = new System.Windows.Forms.Button();
            this.note10 = new System.Windows.Forms.Button();
            this.note11 = new System.Windows.Forms.Button();
            this.note15 = new System.Windows.Forms.Button();
            this.note12 = new System.Windows.Forms.Button();
            this.note13 = new System.Windows.Forms.Button();
            this.note14 = new System.Windows.Forms.Button();
            this.note16 = new System.Windows.Forms.Button();
            this.volumeProgressBar = new CircularProgressBar.CircularProgressBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label3 = new System.Windows.Forms.Label();
            this.panoramProgressBar = new CircularProgressBar.CircularProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.informationLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.settingsButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pianoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // note1
            // 
            this.note1.Location = new System.Drawing.Point(3, 2);
            this.note1.Margin = new System.Windows.Forms.Padding(2);
            this.note1.Name = "note1";
            this.note1.Size = new System.Drawing.Size(23, 64);
            this.note1.TabIndex = 0;
            this.note1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.note1.UseVisualStyleBackColor = true;
            this.note1.Click += new System.EventHandler(this.KeyButton_click);
            this.note1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseDown);
            this.note1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseUp);
            // 
            // note2
            // 
            this.note2.Location = new System.Drawing.Point(29, 2);
            this.note2.Margin = new System.Windows.Forms.Padding(2);
            this.note2.Name = "note2";
            this.note2.Size = new System.Drawing.Size(23, 64);
            this.note2.TabIndex = 1;
            this.note2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.note2.UseVisualStyleBackColor = true;
            this.note2.Click += new System.EventHandler(this.KeyButton_click);
            this.note2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseDown);
            this.note2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseUp);
            // 
            // note3
            // 
            this.note3.Location = new System.Drawing.Point(55, 2);
            this.note3.Margin = new System.Windows.Forms.Padding(2);
            this.note3.Name = "note3";
            this.note3.Size = new System.Drawing.Size(23, 64);
            this.note3.TabIndex = 2;
            this.note3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.note3.UseVisualStyleBackColor = true;
            this.note3.Click += new System.EventHandler(this.KeyButton_click);
            this.note3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseDown);
            this.note3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseUp);
            // 
            // note4
            // 
            this.note4.Location = new System.Drawing.Point(81, 2);
            this.note4.Margin = new System.Windows.Forms.Padding(2);
            this.note4.Name = "note4";
            this.note4.Size = new System.Drawing.Size(23, 64);
            this.note4.TabIndex = 3;
            this.note4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.note4.UseVisualStyleBackColor = true;
            this.note4.Click += new System.EventHandler(this.KeyButton_click);
            this.note4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseDown);
            this.note4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseUp);
            // 
            // note5
            // 
            this.note5.Location = new System.Drawing.Point(107, 2);
            this.note5.Margin = new System.Windows.Forms.Padding(2);
            this.note5.Name = "note5";
            this.note5.Size = new System.Drawing.Size(23, 64);
            this.note5.TabIndex = 4;
            this.note5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.note5.UseVisualStyleBackColor = true;
            this.note5.Click += new System.EventHandler(this.KeyButton_click);
            this.note5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseDown);
            this.note5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseUp);
            // 
            // note6
            // 
            this.note6.Location = new System.Drawing.Point(133, 2);
            this.note6.Margin = new System.Windows.Forms.Padding(2);
            this.note6.Name = "note6";
            this.note6.Size = new System.Drawing.Size(23, 64);
            this.note6.TabIndex = 5;
            this.note6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.note6.UseVisualStyleBackColor = true;
            this.note6.Click += new System.EventHandler(this.KeyButton_click);
            this.note6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseDown);
            this.note6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseUp);
            // 
            // note7
            // 
            this.note7.Location = new System.Drawing.Point(159, 2);
            this.note7.Margin = new System.Windows.Forms.Padding(2);
            this.note7.Name = "note7";
            this.note7.Size = new System.Drawing.Size(23, 64);
            this.note7.TabIndex = 6;
            this.note7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.note7.UseVisualStyleBackColor = true;
            this.note7.Click += new System.EventHandler(this.KeyButton_click);
            this.note7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseDown);
            this.note7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseUp);
            // 
            // note8
            // 
            this.note8.Location = new System.Drawing.Point(185, 2);
            this.note8.Margin = new System.Windows.Forms.Padding(2);
            this.note8.Name = "note8";
            this.note8.Size = new System.Drawing.Size(23, 64);
            this.note8.TabIndex = 7;
            this.note8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.note8.UseVisualStyleBackColor = true;
            this.note8.Click += new System.EventHandler(this.KeyButton_click);
            this.note8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseDown);
            this.note8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseUp);
            // 
            // pianoPanel
            // 
            this.pianoPanel.AutoSize = true;
            this.pianoPanel.BackColor = System.Drawing.Color.Transparent;
            this.pianoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pianoPanel.Controls.Add(this.note36);
            this.pianoPanel.Controls.Add(this.note31);
            this.pianoPanel.Controls.Add(this.note35);
            this.pianoPanel.Controls.Add(this.note30);
            this.pianoPanel.Controls.Add(this.note34);
            this.pianoPanel.Controls.Add(this.note29);
            this.pianoPanel.Controls.Add(this.note33);
            this.pianoPanel.Controls.Add(this.note32);
            this.pianoPanel.Controls.Add(this.note28);
            this.pianoPanel.Controls.Add(this.note27);
            this.pianoPanel.Controls.Add(this.note26);
            this.pianoPanel.Controls.Add(this.note25);
            this.pianoPanel.Controls.Add(this.note24);
            this.pianoPanel.Controls.Add(this.note23);
            this.pianoPanel.Controls.Add(this.note22);
            this.pianoPanel.Controls.Add(this.note21);
            this.pianoPanel.Controls.Add(this.note20);
            this.pianoPanel.Controls.Add(this.note19);
            this.pianoPanel.Controls.Add(this.note18);
            this.pianoPanel.Controls.Add(this.note17);
            this.pianoPanel.Controls.Add(this.note9);
            this.pianoPanel.Controls.Add(this.note10);
            this.pianoPanel.Controls.Add(this.note11);
            this.pianoPanel.Controls.Add(this.note15);
            this.pianoPanel.Controls.Add(this.note12);
            this.pianoPanel.Controls.Add(this.note13);
            this.pianoPanel.Controls.Add(this.note14);
            this.pianoPanel.Controls.Add(this.note16);
            this.pianoPanel.Controls.Add(this.note1);
            this.pianoPanel.Controls.Add(this.note3);
            this.pianoPanel.Controls.Add(this.note2);
            this.pianoPanel.Controls.Add(this.note4);
            this.pianoPanel.Controls.Add(this.note7);
            this.pianoPanel.Controls.Add(this.note5);
            this.pianoPanel.Controls.Add(this.note6);
            this.pianoPanel.Controls.Add(this.note8);
            this.pianoPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pianoPanel.Location = new System.Drawing.Point(19, 213);
            this.pianoPanel.Margin = new System.Windows.Forms.Padding(2);
            this.pianoPanel.Name = "pianoPanel";
            this.pianoPanel.Size = new System.Drawing.Size(550, 175);
            this.pianoPanel.TabIndex = 21;
            // 
            // note36
            // 
            this.note36.BackColor = System.Drawing.Color.Black;
            this.note36.Location = new System.Drawing.Point(511, 2);
            this.note36.Margin = new System.Windows.Forms.Padding(2);
            this.note36.Name = "note36";
            this.note36.Size = new System.Drawing.Size(20, 45);
            this.note36.TabIndex = 45;
            this.note36.UseVisualStyleBackColor = false;
            this.note36.Click += new System.EventHandler(this.KeyButton_click);
            this.note36.MouseDown += new System.Windows.Forms.MouseEventHandler(this.blackNotes_MouseDown);
            this.note36.MouseUp += new System.Windows.Forms.MouseEventHandler(this.blackNotes_MouseUp);
            // 
            // note31
            // 
            this.note31.BackColor = System.Drawing.Color.Black;
            this.note31.Location = new System.Drawing.Point(329, 2);
            this.note31.Margin = new System.Windows.Forms.Padding(2);
            this.note31.Name = "note31";
            this.note31.Size = new System.Drawing.Size(20, 45);
            this.note31.TabIndex = 45;
            this.note31.UseVisualStyleBackColor = false;
            this.note31.Click += new System.EventHandler(this.KeyButton_click);
            this.note31.MouseDown += new System.Windows.Forms.MouseEventHandler(this.blackNotes_MouseDown);
            this.note31.MouseUp += new System.Windows.Forms.MouseEventHandler(this.blackNotes_MouseUp);
            // 
            // note35
            // 
            this.note35.BackColor = System.Drawing.Color.Black;
            this.note35.Location = new System.Drawing.Point(485, 2);
            this.note35.Margin = new System.Windows.Forms.Padding(2);
            this.note35.Name = "note35";
            this.note35.Size = new System.Drawing.Size(20, 45);
            this.note35.TabIndex = 46;
            this.note35.UseVisualStyleBackColor = false;
            this.note35.Click += new System.EventHandler(this.KeyButton_click);
            this.note35.MouseDown += new System.Windows.Forms.MouseEventHandler(this.blackNotes_MouseDown);
            this.note35.MouseUp += new System.Windows.Forms.MouseEventHandler(this.blackNotes_MouseUp);
            // 
            // note30
            // 
            this.note30.BackColor = System.Drawing.Color.Black;
            this.note30.Location = new System.Drawing.Point(303, 2);
            this.note30.Margin = new System.Windows.Forms.Padding(2);
            this.note30.Name = "note30";
            this.note30.Size = new System.Drawing.Size(20, 45);
            this.note30.TabIndex = 46;
            this.note30.UseVisualStyleBackColor = false;
            this.note30.Click += new System.EventHandler(this.KeyButton_click);
            this.note30.MouseDown += new System.Windows.Forms.MouseEventHandler(this.blackNotes_MouseDown);
            this.note30.MouseUp += new System.Windows.Forms.MouseEventHandler(this.blackNotes_MouseUp);
            // 
            // note34
            // 
            this.note34.BackColor = System.Drawing.Color.Black;
            this.note34.Location = new System.Drawing.Point(459, 2);
            this.note34.Margin = new System.Windows.Forms.Padding(2);
            this.note34.Name = "note34";
            this.note34.Size = new System.Drawing.Size(20, 45);
            this.note34.TabIndex = 43;
            this.note34.UseVisualStyleBackColor = false;
            this.note34.Click += new System.EventHandler(this.KeyButton_click);
            this.note34.MouseDown += new System.Windows.Forms.MouseEventHandler(this.blackNotes_MouseDown);
            this.note34.MouseUp += new System.Windows.Forms.MouseEventHandler(this.blackNotes_MouseUp);
            // 
            // note29
            // 
            this.note29.BackColor = System.Drawing.Color.Black;
            this.note29.Location = new System.Drawing.Point(277, 2);
            this.note29.Margin = new System.Windows.Forms.Padding(2);
            this.note29.Name = "note29";
            this.note29.Size = new System.Drawing.Size(20, 45);
            this.note29.TabIndex = 43;
            this.note29.UseVisualStyleBackColor = false;
            this.note29.Click += new System.EventHandler(this.KeyButton_click);
            this.note29.MouseDown += new System.Windows.Forms.MouseEventHandler(this.blackNotes_MouseDown);
            this.note29.MouseUp += new System.Windows.Forms.MouseEventHandler(this.blackNotes_MouseUp);
            // 
            // note33
            // 
            this.note33.BackColor = System.Drawing.Color.Black;
            this.note33.Location = new System.Drawing.Point(407, 2);
            this.note33.Margin = new System.Windows.Forms.Padding(2);
            this.note33.Name = "note33";
            this.note33.Size = new System.Drawing.Size(20, 45);
            this.note33.TabIndex = 44;
            this.note33.UseVisualStyleBackColor = false;
            this.note33.Click += new System.EventHandler(this.KeyButton_click);
            this.note33.MouseDown += new System.Windows.Forms.MouseEventHandler(this.blackNotes_MouseDown);
            this.note33.MouseUp += new System.Windows.Forms.MouseEventHandler(this.blackNotes_MouseUp);
            // 
            // note32
            // 
            this.note32.BackColor = System.Drawing.Color.Black;
            this.note32.ForeColor = System.Drawing.SystemColors.ControlText;
            this.note32.Location = new System.Drawing.Point(381, 2);
            this.note32.Margin = new System.Windows.Forms.Padding(2);
            this.note32.Name = "note32";
            this.note32.Size = new System.Drawing.Size(20, 45);
            this.note32.TabIndex = 42;
            this.note32.UseVisualStyleBackColor = false;
            this.note32.Click += new System.EventHandler(this.KeyButton_click);
            this.note32.MouseDown += new System.Windows.Forms.MouseEventHandler(this.blackNotes_MouseDown);
            this.note32.MouseUp += new System.Windows.Forms.MouseEventHandler(this.blackNotes_MouseUp);
            // 
            // note28
            // 
            this.note28.BackColor = System.Drawing.Color.Black;
            this.note28.Location = new System.Drawing.Point(225, 2);
            this.note28.Margin = new System.Windows.Forms.Padding(2);
            this.note28.Name = "note28";
            this.note28.Size = new System.Drawing.Size(20, 45);
            this.note28.TabIndex = 44;
            this.note28.UseVisualStyleBackColor = false;
            this.note28.Click += new System.EventHandler(this.KeyButton_click);
            this.note28.MouseDown += new System.Windows.Forms.MouseEventHandler(this.blackNotes_MouseDown);
            this.note28.MouseUp += new System.Windows.Forms.MouseEventHandler(this.blackNotes_MouseUp);
            // 
            // note27
            // 
            this.note27.BackColor = System.Drawing.Color.Black;
            this.note27.Location = new System.Drawing.Point(199, 2);
            this.note27.Margin = new System.Windows.Forms.Padding(2);
            this.note27.Name = "note27";
            this.note27.Size = new System.Drawing.Size(20, 45);
            this.note27.TabIndex = 42;
            this.note27.UseVisualStyleBackColor = false;
            this.note27.Click += new System.EventHandler(this.KeyButton_click);
            this.note27.MouseDown += new System.Windows.Forms.MouseEventHandler(this.blackNotes_MouseDown);
            this.note27.MouseUp += new System.Windows.Forms.MouseEventHandler(this.blackNotes_MouseUp);
            // 
            // note26
            // 
            this.note26.BackColor = System.Drawing.Color.Black;
            this.note26.Location = new System.Drawing.Point(147, 2);
            this.note26.Margin = new System.Windows.Forms.Padding(2);
            this.note26.Name = "note26";
            this.note26.Size = new System.Drawing.Size(20, 45);
            this.note26.TabIndex = 41;
            this.note26.UseVisualStyleBackColor = false;
            this.note26.Click += new System.EventHandler(this.KeyButton_click);
            this.note26.MouseDown += new System.Windows.Forms.MouseEventHandler(this.blackNotes_MouseDown);
            this.note26.MouseUp += new System.Windows.Forms.MouseEventHandler(this.blackNotes_MouseUp);
            // 
            // note25
            // 
            this.note25.BackColor = System.Drawing.Color.Black;
            this.note25.Location = new System.Drawing.Point(121, 2);
            this.note25.Margin = new System.Windows.Forms.Padding(2);
            this.note25.Name = "note25";
            this.note25.Size = new System.Drawing.Size(20, 45);
            this.note25.TabIndex = 41;
            this.note25.UseVisualStyleBackColor = false;
            this.note25.Click += new System.EventHandler(this.KeyButton_click);
            this.note25.MouseDown += new System.Windows.Forms.MouseEventHandler(this.blackNotes_MouseDown);
            this.note25.MouseUp += new System.Windows.Forms.MouseEventHandler(this.blackNotes_MouseUp);
            // 
            // note24
            // 
            this.note24.BackColor = System.Drawing.Color.Black;
            this.note24.Location = new System.Drawing.Point(95, 2);
            this.note24.Margin = new System.Windows.Forms.Padding(2);
            this.note24.Name = "note24";
            this.note24.Size = new System.Drawing.Size(20, 45);
            this.note24.TabIndex = 40;
            this.note24.UseVisualStyleBackColor = false;
            this.note24.Click += new System.EventHandler(this.KeyButton_click);
            this.note24.MouseDown += new System.Windows.Forms.MouseEventHandler(this.blackNotes_MouseDown);
            this.note24.MouseUp += new System.Windows.Forms.MouseEventHandler(this.blackNotes_MouseUp);
            // 
            // note23
            // 
            this.note23.BackColor = System.Drawing.Color.Black;
            this.note23.Location = new System.Drawing.Point(43, 2);
            this.note23.Margin = new System.Windows.Forms.Padding(2);
            this.note23.Name = "note23";
            this.note23.Size = new System.Drawing.Size(20, 45);
            this.note23.TabIndex = 40;
            this.note23.UseVisualStyleBackColor = false;
            this.note23.Click += new System.EventHandler(this.KeyButton_click);
            this.note23.MouseDown += new System.Windows.Forms.MouseEventHandler(this.blackNotes_MouseDown);
            this.note23.MouseUp += new System.Windows.Forms.MouseEventHandler(this.blackNotes_MouseUp);
            // 
            // note22
            // 
            this.note22.BackColor = System.Drawing.Color.Black;
            this.note22.Location = new System.Drawing.Point(17, 2);
            this.note22.Margin = new System.Windows.Forms.Padding(2);
            this.note22.Name = "note22";
            this.note22.Size = new System.Drawing.Size(20, 45);
            this.note22.TabIndex = 39;
            this.note22.UseVisualStyleBackColor = false;
            this.note22.Click += new System.EventHandler(this.KeyButton_click);
            this.note22.MouseDown += new System.Windows.Forms.MouseEventHandler(this.blackNotes_MouseDown);
            this.note22.MouseUp += new System.Windows.Forms.MouseEventHandler(this.blackNotes_MouseUp);
            // 
            // note21
            // 
            this.note21.Location = new System.Drawing.Point(523, 2);
            this.note21.Margin = new System.Windows.Forms.Padding(2);
            this.note21.Name = "note21";
            this.note21.Size = new System.Drawing.Size(23, 64);
            this.note21.TabIndex = 38;
            this.note21.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.note21.UseVisualStyleBackColor = true;
            this.note21.Click += new System.EventHandler(this.KeyButton_click);
            this.note21.MouseDown += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseDown);
            this.note21.MouseUp += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseUp);
            // 
            // note20
            // 
            this.note20.Location = new System.Drawing.Point(497, 2);
            this.note20.Margin = new System.Windows.Forms.Padding(2);
            this.note20.Name = "note20";
            this.note20.Size = new System.Drawing.Size(23, 64);
            this.note20.TabIndex = 37;
            this.note20.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.note20.UseVisualStyleBackColor = true;
            this.note20.Click += new System.EventHandler(this.KeyButton_click);
            this.note20.MouseDown += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseDown);
            this.note20.MouseUp += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseUp);
            // 
            // note19
            // 
            this.note19.Location = new System.Drawing.Point(471, 2);
            this.note19.Margin = new System.Windows.Forms.Padding(2);
            this.note19.Name = "note19";
            this.note19.Size = new System.Drawing.Size(23, 64);
            this.note19.TabIndex = 36;
            this.note19.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.note19.UseVisualStyleBackColor = true;
            this.note19.Click += new System.EventHandler(this.KeyButton_click);
            this.note19.MouseDown += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseDown);
            this.note19.MouseUp += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseUp);
            // 
            // note18
            // 
            this.note18.Location = new System.Drawing.Point(445, 2);
            this.note18.Margin = new System.Windows.Forms.Padding(2);
            this.note18.Name = "note18";
            this.note18.Size = new System.Drawing.Size(23, 64);
            this.note18.TabIndex = 35;
            this.note18.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.note18.UseVisualStyleBackColor = true;
            this.note18.Click += new System.EventHandler(this.KeyButton_click);
            this.note18.MouseDown += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseDown);
            this.note18.MouseUp += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseUp);
            // 
            // note17
            // 
            this.note17.Location = new System.Drawing.Point(419, 2);
            this.note17.Margin = new System.Windows.Forms.Padding(2);
            this.note17.Name = "note17";
            this.note17.Size = new System.Drawing.Size(23, 64);
            this.note17.TabIndex = 34;
            this.note17.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.note17.UseVisualStyleBackColor = true;
            this.note17.Click += new System.EventHandler(this.KeyButton_click);
            this.note17.MouseDown += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseDown);
            this.note17.MouseUp += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseUp);
            // 
            // note9
            // 
            this.note9.Location = new System.Drawing.Point(211, 2);
            this.note9.Margin = new System.Windows.Forms.Padding(2);
            this.note9.Name = "note9";
            this.note9.Size = new System.Drawing.Size(23, 64);
            this.note9.TabIndex = 26;
            this.note9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.note9.UseVisualStyleBackColor = true;
            this.note9.Click += new System.EventHandler(this.KeyButton_click);
            this.note9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseDown);
            this.note9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseUp);
            // 
            // note10
            // 
            this.note10.Location = new System.Drawing.Point(237, 2);
            this.note10.Margin = new System.Windows.Forms.Padding(2);
            this.note10.Name = "note10";
            this.note10.Size = new System.Drawing.Size(23, 64);
            this.note10.TabIndex = 28;
            this.note10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.note10.UseVisualStyleBackColor = true;
            this.note10.Click += new System.EventHandler(this.KeyButton_click);
            this.note10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseDown);
            this.note10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseUp);
            // 
            // note11
            // 
            this.note11.Location = new System.Drawing.Point(263, 2);
            this.note11.Margin = new System.Windows.Forms.Padding(2);
            this.note11.Name = "note11";
            this.note11.Size = new System.Drawing.Size(23, 64);
            this.note11.TabIndex = 27;
            this.note11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.note11.UseVisualStyleBackColor = true;
            this.note11.Click += new System.EventHandler(this.KeyButton_click);
            this.note11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseDown);
            this.note11.MouseUp += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseUp);
            // 
            // note15
            // 
            this.note15.Location = new System.Drawing.Point(367, 2);
            this.note15.Margin = new System.Windows.Forms.Padding(2);
            this.note15.Name = "note15";
            this.note15.Size = new System.Drawing.Size(23, 64);
            this.note15.TabIndex = 31;
            this.note15.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.note15.UseVisualStyleBackColor = true;
            this.note15.Click += new System.EventHandler(this.KeyButton_click);
            this.note15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseDown);
            this.note15.MouseUp += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseUp);
            // 
            // note12
            // 
            this.note12.Location = new System.Drawing.Point(289, 2);
            this.note12.Margin = new System.Windows.Forms.Padding(2);
            this.note12.Name = "note12";
            this.note12.Size = new System.Drawing.Size(23, 64);
            this.note12.TabIndex = 29;
            this.note12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.note12.UseVisualStyleBackColor = true;
            this.note12.Click += new System.EventHandler(this.KeyButton_click);
            this.note12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseDown);
            this.note12.MouseUp += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseUp);
            // 
            // note13
            // 
            this.note13.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.note13.Location = new System.Drawing.Point(315, 2);
            this.note13.Margin = new System.Windows.Forms.Padding(2);
            this.note13.Name = "note13";
            this.note13.Size = new System.Drawing.Size(23, 64);
            this.note13.TabIndex = 32;
            this.note13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.note13.UseVisualStyleBackColor = true;
            this.note13.Click += new System.EventHandler(this.KeyButton_click);
            this.note13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseDown);
            this.note13.MouseUp += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseUp);
            // 
            // note14
            // 
            this.note14.Location = new System.Drawing.Point(341, 2);
            this.note14.Margin = new System.Windows.Forms.Padding(2);
            this.note14.Name = "note14";
            this.note14.Size = new System.Drawing.Size(23, 64);
            this.note14.TabIndex = 30;
            this.note14.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.note14.UseVisualStyleBackColor = true;
            this.note14.Click += new System.EventHandler(this.KeyButton_click);
            this.note14.MouseDown += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseDown);
            this.note14.MouseUp += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseUp);
            // 
            // note16
            // 
            this.note16.Location = new System.Drawing.Point(393, 2);
            this.note16.Margin = new System.Windows.Forms.Padding(2);
            this.note16.Name = "note16";
            this.note16.Size = new System.Drawing.Size(23, 64);
            this.note16.TabIndex = 33;
            this.note16.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.note16.UseVisualStyleBackColor = true;
            this.note16.Click += new System.EventHandler(this.KeyButton_click);
            this.note16.MouseDown += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseDown);
            this.note16.MouseUp += new System.Windows.Forms.MouseEventHandler(this.whiteNotes_MouseUp);
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
            this.volumeProgressBar.MouseCaptureChanged += new System.EventHandler(this.volumeProgressBar_MouseCaptureChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(96)))), ((int)(((byte)(123)))));
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(589, 65);
            this.toolStrip1.TabIndex = 26;
            this.toolStrip1.Text = "toolStrip1";
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
            this.panoramProgressBar.MouseCaptureChanged += new System.EventHandler(this.panoramProgressBar_MouseCaptureChanged);
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
            this.panel1.Location = new System.Drawing.Point(19, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 144);
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
            this.settingsButton.Size = new System.Drawing.Size(33, 33);
            this.settingsButton.TabIndex = 31;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VSTPiano.Properties.Resources.rZQfbgIeI2M;
            this.pictureBox1.Location = new System.Drawing.Point(-412, -13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1001, 330);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(229)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(589, 300);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pianoPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.informationLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panoramProgressBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.volumeProgressBar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(605, 339);
            this.MinimumSize = new System.Drawing.Size(605, 339);
            this.Name = "MainForm";
            this.Text = "#keys";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pianoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button note1;
        private System.Windows.Forms.Button note8;
        private System.Windows.Forms.Button note7;
        private System.Windows.Forms.Button note6;
        private System.Windows.Forms.Button note5;
        private System.Windows.Forms.Button note4;
        private System.Windows.Forms.Button note3;
        private System.Windows.Forms.Button note2;
        private System.Windows.Forms.Panel pianoPanel;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button note9;
        private System.Windows.Forms.Button note10;
        private System.Windows.Forms.Button note11;
        private System.Windows.Forms.Button note12;
        private System.Windows.Forms.Button note13;
        private System.Windows.Forms.Button note14;
        private System.Windows.Forms.Button note15;
        private System.Windows.Forms.Button note16;
        private System.Windows.Forms.Button note21;
        private System.Windows.Forms.Button note20;
        private System.Windows.Forms.Button note19;
        private System.Windows.Forms.Button note18;
        private System.Windows.Forms.Button note17;
        private System.Windows.Forms.Button note31;
        private System.Windows.Forms.Button note30;
        private System.Windows.Forms.Button note29;
        private System.Windows.Forms.Button note28;
        private System.Windows.Forms.Button note27;
        private System.Windows.Forms.Button note26;
        private System.Windows.Forms.Button note25;
        private System.Windows.Forms.Button note24;
        private System.Windows.Forms.Button note23;
        private System.Windows.Forms.Button note22;
        private System.Windows.Forms.Button note36;
        private System.Windows.Forms.Button note35;
        private System.Windows.Forms.Button note34;
        private System.Windows.Forms.Button note33;
        private System.Windows.Forms.Button note32;
        private CircularProgressBar.CircularProgressBar volumeProgressBar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label3;
        private CircularProgressBar.CircularProgressBar panoramProgressBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Label informationLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

