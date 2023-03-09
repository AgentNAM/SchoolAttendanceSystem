using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Q1Capstone
{
    public partial class UserControl5 : UserControl
    {
        public UserControl5()
        {
            InitializeComponent();
        }

        private string adminUsername;

        public string GetAdminName()
        {
            return nameDisplay.Text;
        }

        public string GetAdminUsername()
        {
            return adminUsername;
        }

        public void SetAdminDisplay(string currentUsername)
        {
            adminUsername = currentUsername;
            usernameDisplay.Text = adminUsername;

            using (var connection = new SQLiteConnection("Data Source=admin_data.db"))
            {
                connection.Open();
                var commGetName = connection.CreateCommand();
                commGetName.CommandText = @"
                    SELECT name
                    FROM admins
                    WHERE username = '" + adminUsername + @"'
                    ";

                using (SQLiteDataReader read = commGetName.ExecuteReader())
                {
                    while (read.Read())
                    {
                        string name = (string)read.GetValue(read.GetOrdinal("name"));
                        nameDisplay.Text = name;
                    }
                }
            }
        }

        private void changeDetailsButton_Click(object sender, EventArgs e)
        {
            using (var connection = new SQLiteConnection("Data Source=admin_data.db"))
            {
                connection.Open();
                var commGetPass = connection.CreateCommand();
                commGetPass.CommandText = @"
                    SELECT password
                    FROM admins
                    WHERE username = '" + adminUsername + @"'
                    ";

                using (SQLiteDataReader read = commGetPass.ExecuteReader())
                {
                    while (read.Read())
                    {
                        string password = (string)read.GetValue(read.GetOrdinal("password"));
                        if (passwordTextBox.Text == password)
                        {
                            userControl61.Show();
                            userControl61.GiveAdminData(nameDisplay.Text, adminUsername, password);
                            passwordTextBox.Text = "";
                        }
                    }
                }
            }
        }

        public void SetAdminUsername(string newUsername)
        {
            adminUsername = newUsername;
            this.SetAdminDisplay(adminUsername);
        }

        private void UserControl5_VisibleChanged(object sender, EventArgs e)
        {
            userControl61.Hide();
        }
    }
}
