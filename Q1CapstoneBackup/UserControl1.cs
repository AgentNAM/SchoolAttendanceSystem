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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            using (var connection = new SQLiteConnection("Data Source=school_att.db")) 
            {
                connection.Open();

                var commGetNamesAndIDs = connection.CreateCommand();
                commGetNamesAndIDs.CommandText = @"
                    SELECT name, id
                    FROM students
                    ";

                // Check if student data is not unique
                bool studentExists = false;
                bool idExists = false;

                using (SQLiteDataReader read = commGetNamesAndIDs.ExecuteReader())
                {
                    while (read.Read())
                    {
                        string name = (string)read.GetValue(read.GetOrdinal("name"));
                        string id = read.GetValue(read.GetOrdinal("id")).ToString();

                        if (nameTextBox.Text == name) studentExists = true;
                        if (idTextBox.Text == id) idExists = true;
                        if (studentExists || idExists) break;
                    }
                }

                // If new student data is valid, add new student
                if (!studentExists
                    && !idExists
                    && nameTextBox.Text != ""
                    && idTextBox.Text != ""
                    && idTextBox.Text.TrimStart('0').Length == 6)
                {
                    var commAdd = connection.CreateCommand();
                    commAdd.CommandText = @"
                        INSERT INTO students (name, id, schedule)
                        VALUES ('" + nameTextBox.Text + "', " + idTextBox.Text + @", '');
                        ";
                    commAdd.ExecuteNonQuery();

                    Form1 tmp = (Form1)this.FindForm();
                    tmp.PopulateDataGrid();
                }
            }
        }
    }
}
