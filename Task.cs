using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace Takliy
{
    public class Task
    {

        public void Add(String Name, String Stage , int Owner , int Assigne , string Startdate, string Deadline)
        {
            string db = "Data Source=C:/Users/CHRAJEM/Desktop/Taskly/db/Taskly.db";
            var conn = new Microsoft.Data.Sqlite.SqliteConnection(db);
            conn.Open();
            var TasksQuery = new Microsoft.Data.Sqlite.SqliteCommand($"INSERT INTO Tasks(name,stage,owner,assigne,start,end) VALUES ('{Name}','{Stage}', '{Owner}', '{Assigne}' , '{Startdate}', '{Deadline}')", conn);
            TasksQuery.ExecuteReader();
        }
        public void Remove(int TaskID)
        {
            string db = "Data Source=C:/Users/CHRAJEM/Desktop/Taskly/db/Taskly.db";
            var conn = new Microsoft.Data.Sqlite.SqliteConnection(db);
            conn.Open();
            var TasksQuery = new Microsoft.Data.Sqlite.SqliteCommand($"Delete From Tasks where id ={TaskID}", conn);
            TasksQuery.ExecuteReader();
        }
        public void Update(int TaskID , String Name, String Stage, int Owner, int Assigne, DateTime Startdate, DateTime Deadline)
        {
            string db = "Data Source=C:/Users/CHRAJEM/Desktop/Taskly/db/Taskly.db";
            var conn = new Microsoft.Data.Sqlite.SqliteConnection(db);
            conn.Open();
            var TasksQuery = new Microsoft.Data.Sqlite.SqliteCommand($"UPDATE Tasks SET name = '{Name}', owner = '{Owner}' , stage = '{Stage}' , assigne = '{Assigne}', start = '{Startdate}', end = '{Deadline}' where id = {TaskID} ", conn);
            TasksQuery.ExecuteReader();
        }
        public List<object> Get(int TaskID)
        {
            List<object> ReturnData = new List<object>();

            string db = "Data Source=C:/Users/CHRAJEM/Desktop/Taskly/db/Taskly.db";
            var conn = new Microsoft.Data.Sqlite.SqliteConnection(db);
            conn.Open();
            var TasksQuery = new Microsoft.Data.Sqlite.SqliteCommand($"Select * From Tasks where id = {TaskID}", conn);


            Microsoft.Data.Sqlite.SqliteDataReader TaskReader = TasksQuery.ExecuteReader();
            while (TaskReader.Read())
            {
                ReturnData.Add(TaskReader.GetValue(1).ToString()); // name 0
                ReturnData.Add(TaskReader.GetValue(2).ToString()); // stage 1 
                ReturnData.Add(Int32.Parse(TaskReader.GetValue(3).ToString())); // owner 2 
                ReturnData.Add(Int32.Parse(TaskReader.GetValue(4).ToString())); // assigne 3
                ReturnData.Add(TaskReader.GetValue(5).ToString()); // start
                ReturnData.Add(TaskReader.GetValue(6).ToString()); // end

            }

            return ReturnData;
        }

        public Microsoft.Data.Sqlite.SqliteDataReader GetAll()
        {
            string db = "Data Source=C:/Users/CHRAJEM/Desktop/Taskly/db/Taskly.db";
            var conn = new Microsoft.Data.Sqlite.SqliteConnection(db);
            conn.Open();
            var TasksQuery = new Microsoft.Data.Sqlite.SqliteCommand("Select * From Tasks", conn);
            Microsoft.Data.Sqlite.SqliteDataReader TaskReader = TasksQuery.ExecuteReader();
            return TaskReader;
        }

        public void GetTasks(DataGridView grid )
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

                grid.Rows.Add(new object[] {
                TaskReader.GetValue(0) , //TaskID
                TaskReader.GetValue(1), //name
                TaskReader.GetValue(2), //stage
                OwnerName,
                AssigneName,
                TaskReader.GetValue(5), //start date
                TaskReader.GetValue(6), //end date

                });

                for (int i = 0; i <= grid.Rows.Count - 1; i++)
                {
                    string stage = grid.Rows[i].Cells[2].Value.ToString();

                    switch (stage)
                    {
                        case "To Do":
                            grid.Rows[i].Cells[2].Style.BackColor = Color.Red;
                            break;
                        case "In Progress":
                            grid.Rows[i].Cells[2].Style.BackColor = Color.LightYellow;
                            break;
                        case "Done":
                            grid.Rows[i].Cells[2].Style.BackColor = Color.LightGreen;
                            break;
                        case "Canceled":
                            grid.Rows[i].Cells[2].Style.BackColor = Color.Maroon;
                            break;
                    }

                }
            }

        }
    }
}

