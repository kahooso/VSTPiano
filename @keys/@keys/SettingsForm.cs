using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace _keys
{
    public partial class SettingsForm : Form
    {
        public delegate void ApplySettingsHandler(Color whiteNotesColor, Color blackNotesColor, Color pressedColor, Color mainPanelColor, Color pianoPanelColor, Color toolStripColor, Color menuStripColor);
        public event ApplySettingsHandler ApplySettings;

        public SettingsForm()
        {
            InitializeComponent();
            InitializeFont();
            InitializeDefaultColors();
        }

        private void InitializeDefaultColors()
        {
            mainPanel.BackColor = mainPanelLabel.ForeColor = pianoPanel.BackColor = pianoPanelLabel.ForeColor = toolStrip.BackColor = toolStripLabel.ForeColor = SystemColors.Info;
            whiteNote.BackColor = whiteNoteLabel.ForeColor = menuStrip.BackColor = menuStripLabel.ForeColor = Color.FromArgb(255, 234, 244, 225);
            pressedNote.BackColor = pressedNoteLabel.ForeColor = ColorTranslator.FromHtml("#94C9A9");
            blackNote.BackColor = blackNoteLabel.ForeColor = Color.FromArgb(255, 86, 120, 86);
            settingsPanel.BackColor = Color.FromArgb(127, 255, 255, 225);
        }

        private void InitializeFont() { Font = new Font("Roboto", 14, FontStyle.Regular); }

        // apply button event

        private void applyButton_Click(object sender, System.EventArgs e)
        {
            ApplySettings?.Invoke(
                whiteNote.BackColor,
                blackNote.BackColor,
                pressedNote.BackColor,
                mainPanel.BackColor,
                pianoPanel.BackColor,
                toolStrip.BackColor,
                menuStrip.BackColor
            );

            MessageBox.Show("Your settings have been changed successfully!", "@settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        // all panels click event

        private void allPanels_Click(object sender, System.EventArgs e)
        {
            colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Panel panel = (Panel)sender;
                panel.BackColor = colorDialog.Color;
                
                string labelName = panel.Name + "Label";
                Label label = Controls.Find(labelName, true).FirstOrDefault() as Label;

                if (label != null)
                {
                    label.ForeColor = colorDialog.Color;
                }
            }
        }

        // reset button

        private void resetButton_Click(object sender, System.EventArgs e) { InitializeDefaultColors(); }
    }
}
