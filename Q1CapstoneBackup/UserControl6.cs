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
    public partial class UserControl6 : UserControl
    {
        public UserControl6()
        {
            InitializeComponent();
        }

        private string adminName;
        private string adminUsername;
        private string adminPass;

        public void GiveAdminData(string name, string username, string pass)
        {
            adminName = name;
            adminUsername = username;
            adminPass = pass;
        }

        public string GetAdminUsername()
        {
            return adminUsername;
        }

        // Single method for changing data for individual fields
        private void ChangeAdminData(string newData, string field)
        {
            using (var connection = new SQLiteConnection("Data Source=admin_data.db"))
            {
                connection.Open();
                var commChangeData = connection.CreateCommand();
                commChangeData.CommandText = @"
                        UPDATE admins
                        SET " + field + @" = '" + newData + @"'
                        WHERE username = '" + adminUsername + @"'
                        ";
                commChangeData.ExecuteNonQuery();
            }

            // Update admin display
            UserControl5 tmpUserControl5 = (UserControl5)this.Parent.Parent;
            tmpUserControl5.SetAdminUsername(adminUsername);
        }

        // Change specific fields depending on which button is clicked
        private void changeNameButton_Click(object sender, EventArgs e)
        {
            if (newNameBox.Text != "")
            {
                ChangeAdminData(newNameBox.Text, "name");
                adminName = newNameBox.Text;
                changeNameButton.ForeColor = Color.Green;

                Form1 tmp = (Form1)this.FindForm();
                tmp.RefreshAdminDisplay(adminName, adminUsername);
            }
            else
            {
                changeNameButton.ForeColor = Color.Red;
            }
        }

        private void changeUsernameButton_Click(object sender, EventArgs e)
        {
            if (newUsernameBox.Text != "" && !IsUsernameInUse(newUsernameBox.Text))
            {
                ChangeAdminData(newUsernameBox.Text, "username");
                adminUsername = newUsernameBox.Text;
                changeUsernameButton.ForeColor = Color.Green;

                Form1 tmp = (Form1)this.FindForm();
                tmp.RefreshAdminDisplay(adminName, adminUsername);
            }
            else
            {
                changeUsernameButton.ForeColor = Color.Red;
            }
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            if (VerifyPass(newPasswordBox.Text))
            {
                ChangeAdminData(newPasswordBox.Text, "password");
                adminPass = newPasswordBox.Text;
                changePasswordButton.ForeColor = Color.Green;
            }
            else
            {
                changePasswordButton.ForeColor = Color.Red;
            }
        }

        // Username validation
        private bool IsUsernameInUse(string newUsername)
        {
            using (var connection = new SQLiteConnection("Data Source=admin_data.db"))
            {
                connection.Open();
                var commUsernames = connection.CreateCommand();
                commUsernames.CommandText = @"
                        SELECT username FROM admins
                        ";

                using (SQLiteDataReader read = commUsernames.ExecuteReader())
                {
                    while (read.Read())
                    {
                        string username = (string)read.GetValue(read.GetOrdinal("username"));
                        if (username == newUsername)
                        {
                            return true;
                        }
                    }
                }

                connection.Close();
            }
            return false;
        }

        // Password validation
        private bool VerifyPass(string pass)
        {
            bool blankPassword = pass == "";
            bool tooShort = pass.Length < 8;
            bool noUpper = !HasUpper(pass);
            bool noLower = !HasLower(pass);
            bool noDigit = !HasDigit(pass);
            bool invalidConfirm = confirmPasswordBox.Text != pass;

            return (!
                (blankPassword
                || tooShort
                || noUpper
                || noLower
                || noDigit
                || invalidConfirm)
                );
        }

        private bool HasUpper(string newPassword)
        {
            foreach (char c in newPassword)
            {
                if (Char.IsUpper(c)) return true;
            }
            return false;
        }

        private bool HasLower(string newPassword)
        {
            foreach (char c in newPassword)
            {
                if (Char.IsLower(c)) return true;
            }
            return false;
        }

        private bool HasDigit(string newPassword)
        {
            foreach (char c in newPassword)
            {
                if (Char.IsDigit(c)) return true;
            }
            return false;
        }

        // Reset button text colors
        private void ResetButtonTextColors()
        {
            changeNameButton.ForeColor = Color.Black;
            changeUsernameButton.ForeColor = Color.Black;
            changePasswordButton.ForeColor = Color.Black;
        }

        // Close button
        private void closeButton_Click(object sender, EventArgs e)
        {
            ResetButtonTextColors();
            this.Hide();
        }

        // Reset button text colors when the text in any of the text boxes changes
        private void newNameBox_TextChanged(object sender, EventArgs e)
        {
            ResetButtonTextColors();
        }

        private void newUsernameBox_TextChanged(object sender, EventArgs e)
        {
            ResetButtonTextColors();
        }

        private void newPasswordBox_TextChanged(object sender, EventArgs e)
        {
            ResetButtonTextColors();
        }

        private void confirmPasswordBox_TextChanged(object sender, EventArgs e)
        {
            ResetButtonTextColors();
        }

        // Clear text from all text boxes when this user control is hidden
        private void UserControl6_VisibleChanged(object sender, EventArgs e)
        {
            newNameBox.Text = "";
            newUsernameBox.Text = "";
            newPasswordBox.Text = "";
            confirmPasswordBox.Text = "";
        }
    }
}
