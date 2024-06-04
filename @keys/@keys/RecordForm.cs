using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _keys
{
    public partial class RecordForm : Form
    {
        private List<Users> users = new List<Users>();
        public RecordForm()
        {
            InitializeComponent();
            InitializeFont();
            InitializeUsers();
            RefreshDataGridView();
        }

        private void InitializeUsers() { users = DatabaseHelper.DatabaseHelper.load_users(); }
        private void InitializeFont() { Font = new Font("Roboto", 12, FontStyle.Regular); }
        private void RefreshDataGridView()
        {
            users.Sort((user1, user2) => user2.time.CompareTo(user1.time));

            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            dataGridView.Columns.Add("login", "login");
            dataGridView.Columns.Add("time", "time");

            foreach (var user in users) 
            { 
                dataGridView.Rows.Add(user.login, Users.ConvertSecondsToDate(user.time).ToString()); 
            }
        }
    }
}
