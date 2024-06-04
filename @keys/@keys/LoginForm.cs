using System.Collections.Generic;
using System.Windows.Forms;

namespace _keys
{
    public partial class LoginForm : Form
    {
        List<Users> users = new List<Users>();
        public LoginForm()
        {
            InitializeComponent();
            InitializeFont();
            InitializeComponents();
            InitializeColors();
            InitializeUsers();
        }

        private void InitializeUsers() { users = DatabaseHelper.DatabaseHelper.load_users(); }
        private void InitializeColors() { BackColor = System.Drawing.Color.LightSteelBlue; }
        private void InitializeFont() { Font = new System.Drawing.Font("Roboto", 12, System.Drawing.FontStyle.Regular); }
        private void InitializeComponents()
        {
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.MaxLength = 50;
            loginTextBox.MaxLength = 50;
        }

        private void signInLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SigninForm signin_form = new SigninForm();
            this.Hide();
            signin_form.ShowDialog();
            this.Show();
        }

        private void logInButton_Click(object sender, System.EventArgs e)
        {
            string login = loginTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim(); ;
            Users user = DatabaseHelper.DatabaseHelper.AuthenticateUser(login, password);
            if (user != null)
            {
                MessageBox.Show($"welcome back, {user.login}!", "@log in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 main_form = new Form1(user);
                this.Hide();
                main_form.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("invalid login or password.", "@log in", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}