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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        public void PopulateComboBox()
        {
            comboBox1.Items.Clear();
            using (var connection = new SQLiteConnection("Data Source=school_att.db"))
            {
                connection.Open();

                var commGetNames = connection.CreateCommand();
                commGetNames.CommandText = @"
                    SELECT name FROM students
                    ";

                using (SQLiteDataReader read = commGetNames.ExecuteReader())
                {
                    while (read.Read())
                    {
                        string name = read.GetString(0);
                        comboBox1.Items.Add(name);
                    }
                }
            }
        }

        string date;

        public void SetUserDate(string user_date)
        {
            date = user_date;
        }

        // Update attendance status
        private void UpdateAtt(string att)
        {
            using (var connection = new SQLiteConnection("Data Source=school_att.db"))
            {
                connection.Open();

                var commGetSchedule = connection.CreateCommand();
                commGetSchedule.CommandText = @"
                    SELECT schedule FROM students
                    WHERE name = '" + comboBox1.SelectedItem + @"'
                    ";

                using (SQLiteDataReader read = commGetSchedule.ExecuteReader())
                {
                    while (read.Read())
                    {
                        string schedule = read.GetString(0);
                        string[] scheduleStrings = schedule.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                        // Loop through each date/status combo to find one with the correct date
                        for (int i = 0; i < scheduleStrings.Length; i++)
                        {
                            string scheduleDate = scheduleStrings[i].Split('_')[0];

                            // If a date/status combo with the correct date is found
                            if (scheduleDate == date)
                            {
                                // Set the attendance status for that date and update the table
                                string newSchedule = schedule.Replace(scheduleStrings[i], date + "_" + att);

                                var commSetSchedule = connection.CreateCommand();
                                commSetSchedule.CommandText = @"
                                    UPDATE students
                                    SET schedule = '" + newSchedule + @"'
                                    WHERE name = '" + comboBox1.SelectedItem + @"'
                                    ";
                                commSetSchedule.ExecuteNonQuery();
                                break;
                            }
                        }
                    }
                }
            }

            PopulateComboBox();

            Form1 tmp = (Form1)this.FindForm();
            tmp.PopulateDataGrid();
        }

        // Update attendance status with a different value depending on which button is pressed
        private void presentButton_Click(object sender, EventArgs e)
        {
            UpdateAtt("P");
        }

        private void tardyButton_Click(object sender, EventArgs e)
        {
            UpdateAtt("T");
        }

        private void absentButton_Click(object sender, EventArgs e)
        {
            UpdateAtt("A");
        }
    }
}
