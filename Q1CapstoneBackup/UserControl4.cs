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
    public partial class UserControl4 : UserControl
    {
        public UserControl4()
        {
            InitializeComponent();
        }

        private void createNewAccountButton_Click(object sender, EventArgs e)
        {
            if (VerifyAccount())
            {
                using (var connection = new SQLiteConnection("Data Source=admin_data.db"))
                {
                    connection.Open();
                    var commNewAccount = connection.CreateCommand();

                    commNewAccount.CommandText = @"
                        INSERT INTO admins
                        VALUES ('" + newNameBox.Text + "', '" + newUsernameBox.Text + "', '" + newPasswordBox.Text + @"')
                        ";
                    commNewAccount.ExecuteNonQuery();
                }

                this.Hide();
            }
        }

        // Verify account data
        private bool VerifyAccount()
        {
            // Reset error labels
            nameErrorLabel.Text = "";
            usernameErrorLabel.Text = "";
            passwordErrorLabel.Text = "";
            confirmErrorLabel.Text = "";

            // Verify name
            bool blankName = newNameBox.Text == "";

            // Verify username
            bool blankUserame = newUsernameBox.Text == "";
            bool usernameInUse = IsUsernameInUse(newUsernameBox.Text);

            // Verify password
            bool blankPassword = newPasswordBox.Text == "";
            bool tooShort = newPasswordBox.Text.Length < 8;
            bool noUpper = !HasUpper(newPasswordBox.Text);
            bool noLower = !HasLower(newPasswordBox.Text);
            bool noDigit = !HasDigit(newPasswordBox.Text);

            // Verify password confirmation
            bool invalidConfirm = confirmPasswordBox.Text != newPasswordBox.Text;

            // Set error labels as needed
            if (blankName) nameErrorLabel.Text = "* Please enter a name.";

            if (blankUserame) usernameErrorLabel.Text = "* Please enter a username.";
            else if (usernameInUse) usernameErrorLabel.Text = "* Username already exists.";

            if (blankPassword) passwordErrorLabel.Text = "* Please enter a password.";
            else if (tooShort) passwordErrorLabel.Text = "* Must be at least 8 characters.";
            else if (noUpper) passwordErrorLabel.Text = "* Must have at least 1 uppercase letter.";
            else if (noLower) passwordErrorLabel.Text = "* Must have at least 1 lowercase letter.";
            else if (noDigit) passwordErrorLabel.Text = "* Must have at least 1 digit.";

            if (invalidConfirm) confirmErrorLabel.Text = "* Does not match password.";

            // Return whether password is valid or not
            return !(blankName
                || blankUserame
                || usernameInUse
                || blankPassword
                || tooShort
                || noUpper
                || noLower
                || noDigit
                || invalidConfirm);
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
    }
}
