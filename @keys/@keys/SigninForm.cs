using System;
using System.Windows.Forms;

namespace _keys
{
    public partial class SigninForm : Form
    {
        public SigninForm()
        {
            InitializeComponent();
            InitializeFont();
            InitializeComponents();
        }

        private void InitializeComponents() { confirmTextBox.UseSystemPasswordChar = true; }
        private void InitializeFont() { Font = new System.Drawing.Font("Roboto", 12, System.Drawing.FontStyle.Regular); }

        private void showHideButton_Click(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !passwordTextBox.UseSystemPasswordChar;
            showHideButton.BackgroundImage = passwordTextBox.UseSystemPasswordChar ? Properties.Resources.invisible_eye : Properties.Resources.visible_eye;
        }
        private void signInButton_Click(object sender, EventArgs e)
        {
            string current_login = loginTextBox.Text.Trim();
            string current_password = passwordTextBox.Text.Trim();
            string current_confirm_password = confirmTextBox.Text.Trim();

            if (string.IsNullOrEmpty(current_login) || string.IsNullOrEmpty(current_password) || string.IsNullOrEmpty(current_confirm_password))
            {
                MessageBox.Show("please fill in all fields.", "@sign in", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (current_password != current_confirm_password)
            {
                MessageBox.Show("passwords do not match.", "@sign in", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Users new_user = new Users { login = current_login, password = current_password, time = 0 };

            try
            {
                DatabaseHelper.DatabaseHelper.SaveUser(new_user);
                MessageBox.Show("registration successful!", "@sign in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show($"an error occurred: {ex.Message}", "@sign in", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void loginTextBox_KeyPress(object sender, KeyPressEventArgs e) { e.Handled = !(e.KeyChar == '\b' || char.IsLetter(e.KeyChar)); }
    }
}