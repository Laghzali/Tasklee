using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
namespace Takliy
{
    public partial class TaskForm : Form
    {
        public TaskForm()
        {
            InitializeComponent();
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {
            BindTasks();

        }

        private void BindTasks()
        {
            
            string db = "Data Source=C:/Users/CHRAJEM/Desktop/Taskly/db/Taskly.db";
            var conn = new Microsoft.Data.Sqlite.SqliteConnection(db);
            conn.Open();
            var TasksQuery = new Microsoft.Data.Sqlite.SqliteCommand("Select * From Tasks", conn);
            Microsoft.Data.Sqlite.SqliteDataReader TaskReader = TasksQuery.ExecuteReader();
            while (TaskReader.Read())
            {
                string OwnerName = "";
                string AssigneName = "";

                string OwnerID = TaskReader.GetValue(3).ToString();
                string AssigneID = TaskReader.GetValue(4).ToString();

                //geting Owner name and assigne name by id query
                var OwnerNameQuery = new Microsoft.Data.Sqlite.SqliteCommand($"Select name From Users  Where id= {OwnerID} ", conn);
                var AssigneNameQuery = new Microsoft.Data.Sqlite.SqliteCommand($"Select name  From Users Where id= {AssigneID}", conn);

                //executing owner & assigne names query
                Microsoft.Data.Sqlite.SqliteDataReader OwnerReader = OwnerNameQuery.ExecuteReader();
                Microsoft.Data.Sqlite.SqliteDataReader AssigneReader = AssigneNameQuery.ExecuteReader();

                //getting owner & assigne name values and plug them to the correspandant variable
                while (OwnerReader.Read()) { OwnerName = OwnerReader.GetValue(0).ToString(); }
                while (AssigneReader.Read()) { AssigneName = AssigneReader.GetValue(0).ToString(); }


                //Fill the data grid with the final data
                dataGridView1.Rows.Add(new object[] {

                TaskReader.GetValue(1),
                TaskReader.GetValue(2),
                OwnerName,
                AssigneName,
                TaskReader.GetValue(5),
                TaskReader.GetValue(6),
                "Edit"
                });
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ShowAddTask = new AddTask();
            ShowAddTask.Show();
        }
    }
}
