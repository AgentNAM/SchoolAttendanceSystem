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
    public partial class Form1 : Form
    {
        private string adminUsername;
        private DateTime lastValidDate;

        public Form1(string currentName, string currentUserame)
        {
            InitializeComponent();
            PopulateDataGrid();

            // Prevent weekends from being selected, even if the program is launched during the weekend
            if (dateTimePicker1.Value.ToString("ddd") == "Sat") dateTimePicker1.Value = dateTimePicker1.Value.AddDays(-1);
            else if (dateTimePicker1.Value.ToString("ddd") == "Sun") dateTimePicker1.Value = dateTimePicker1.Value.AddDays(-2);

            lastValidDate = dateTimePicker1.Value;

            RefreshAdminDisplay(currentName, currentUserame);
        }

        public void PopulateDataGrid()
        {
            dataGridView1.Rows.Clear();
            using (var connection = new SQLiteConnection("Data Source=school_att.db"))
            {
                connection.Open();

                var commGetData = connection.CreateCommand();
                commGetData.CommandText = @"
                    SELECT * FROM students
                    ";

                using (SQLiteDataReader read = commGetData.ExecuteReader())
                {
                    while (read.Read())
                    {
                        string schedule = (string)read.GetValue(read.GetOrdinal("schedule"));
                        string[] scheduleStrings = schedule.Split('|');
                        string date = "";
                        string att = "";

                        // Find the attendance schedule for the user-selected date
                        foreach (string scheduleString in scheduleStrings)
                        {
                            string[] scheduleParts = scheduleString.Split('_');
                            if (scheduleParts[0] == dateTimePicker1.Value.ToShortDateString())
                            {
                                date = scheduleParts[0];
                                att = scheduleParts[1];
                                break;
                            }
                        }

                        // If no attendance schedule is found for the user-selected date,
                        // create new attendance schedule for that date
                        if (date != dateTimePicker1.Value.ToShortDateString())
                        {
                            // Sort schedule
                            string newSchedule = dateTimePicker1.Value.ToShortDateString() + "_-";
                            List<string> newScheduleList = Enumerable.ToList(schedule.Split('|'));
                            int currentScheduleCount = newScheduleList.Count;
                            for (int i = 0; i < currentScheduleCount; i++)
                            {
                                string newDateStr = newSchedule.Split('_')[0];
                                string currentDateStr = newScheduleList[i].Split('_')[0];

                                DateTime newDate = DateTime.Parse(newDateStr);
                                DateTime currentDate = DateTime.Parse(currentDateStr);

                                if (DateTime.Compare(newDate, currentDate) < 0)
                                {
                                    newScheduleList.Insert(i, newSchedule);
                                    break;
                                }
                                else if (DateTime.Compare(newDate, currentDate) > 0 && i + 1 == currentScheduleCount)
                                {
                                    newScheduleList.Add(newSchedule);
                                    break;
                                }
                            }

                            string sortedSchedules = String.Join("|", newScheduleList.ToArray());

                            // Update schedule
                            var commBlankStatus = connection.CreateCommand();
                            commBlankStatus.CommandText = @"
                                UPDATE students
                                SET schedule = '" + sortedSchedules + @"'
                                WHERE name = '" + (string)read.GetValue(read.GetOrdinal("name")) + @"'
                                ";
                            commBlankStatus.ExecuteNonQuery();
                            date = dateTimePicker1.Value.ToShortDateString();
                            att = "-";
                        }

                        // Display the data for each student
                        dataGridView1.Rows.Add(new object[] {
                        read.GetValue(read.GetOrdinal("name")),
                        read.GetValue(read.GetOrdinal("id")),
                        date,
                        att
                        });
                    }
                }
            }
        }

        public void RefreshAdminDisplay(string name, string username)
        {
            welcomeLabel.Text = $"Welcome, {name}!";
            adminUsername = username;
        }

        // ----- ADD STUDENTS -----
        private void addButton_Click(object sender, EventArgs e)
        {
            if (!userControl11.Visible)
            {
                userControl11.Show();
                userControl11.BringToFront();
            }
            else userControl11.Hide();

            userControl21.Hide();
            userControl31.Hide();

            PopulateDataGrid();
        }

        // ----- MODIFY STUDENTS -----
        private void modifyButton_Click(object sender, EventArgs e)
        {
            if (!userControl21.Visible)
            {
                userControl21.Show();
                userControl21.BringToFront();

                userControl21.PopulateComboBox();
                userControl21.SetUserDate(dateTimePicker1.Value.ToShortDateString());
            }
            else userControl21.Hide();

            userControl11.Hide();
            userControl31.Hide();

            PopulateDataGrid();
        }

        // ----- REMOVE STUDENTS -----
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (!userControl31.Visible)
            {
                userControl31.Show();
                userControl31.BringToFront();

                userControl31.PopulateComboBox();
            }
            else userControl31.Hide();

            userControl11.Hide();
            userControl21.Hide();

            PopulateDataGrid();
        }

        // Close application if this form is closed
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // DateTimePicker Value Change
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Prevent weekends from being selected
            if (new string[] { "Sat", "Sun" }.Contains(dateTimePicker1.Value.ToString("ddd")))
            {
                dateTimePicker1.Value = lastValidDate;
            }
            else
            {
                PopulateDataGrid(); // Update dataGridView1 to show data for the new date
                userControl21.SetUserDate(dateTimePicker1.Value.ToShortDateString());
                lastValidDate = dateTimePicker1.Value;
            }
        }

        // ----- SIGN OUT -----
        private void signOutButton_Click(object sender, EventArgs e)
        {
            if (!userControl71.Visible)
            {
                userControl71.Show();
                userControl71.BringToFront();
            }
            else userControl71.Hide();

            userControl51.Hide();
        }

        // ----- CHANGE ACCOUNT DETAILS -----
        private void accDetailsButton_Click(object sender, EventArgs e)
        {
            if (!userControl51.Visible)
            {
                userControl51.Show();
                userControl51.BringToFront();

                userControl51.SetAdminDisplay(adminUsername);
            }
            else userControl51.Hide();

            string newName = userControl51.GetAdminName();

            RefreshAdminDisplay(newName, userControl51.GetAdminUsername());

            userControl71.Hide();
        }

        // Prevent user from selecting cells in dataGridView1
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
