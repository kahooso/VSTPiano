using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSTPiano
{
    public partial class Settings : Form
    {
        public delegate void ShowNotesEventHandler(object sender, EventArgs e); /* deligate for show notes button */
        public event ShowNotesEventHandler ShowNotesEvent; /* show notes event */
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {            
        }

        /* Show notes button */
        private bool isNotesVisible = true;
        private void showNotesButton_Click(object sender, EventArgs e)
        {
            showNotesButton.Text = isNotesVisible ? "Show note's: ON" : "Show note's: OFF";
            ShowNotesEvent?.Invoke(sender, e);
            isNotesVisible = !isNotesVisible;
        }
    }
}
