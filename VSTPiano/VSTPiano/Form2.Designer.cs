namespace VSTPiano
{
    partial class Settings
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
            this.showNotesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showNotesButton
            // 
            this.showNotesButton.Location = new System.Drawing.Point(11, 11);
            this.showNotesButton.Margin = new System.Windows.Forms.Padding(2);
            this.showNotesButton.Name = "showNotesButton";
            this.showNotesButton.Size = new System.Drawing.Size(105, 51);
            this.showNotesButton.TabIndex = 33;
            this.showNotesButton.Text = "show notes";
            this.showNotesButton.UseVisualStyleBackColor = true;
            this.showNotesButton.Click += new System.EventHandler(this.showNotesButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(229)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showNotesButton);
            this.Name = "Settings";
            this.Text = "#settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showNotesButton;
    }
}