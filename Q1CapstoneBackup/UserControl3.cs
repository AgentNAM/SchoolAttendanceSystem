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
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
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

        private void removeStudentButton_Click(object sender, EventArgs e)
        {
            using (var connection = new SQLiteConnection("Data Source=school_att.db"))
            {
                connection.Open();

                var commDeleteStudent = connection.CreateCommand();
                commDeleteStudent.CommandText = @"
                    DELETE FROM students
                    WHERE name = '" + comboBox1.SelectedItem + @"'
                    ";
                commDeleteStudent.ExecuteNonQuery();
            }

            PopulateComboBox();

            Form1 tmp = (Form1)this.FindForm();
            tmp.PopulateDataGrid();
        }
    }
}
