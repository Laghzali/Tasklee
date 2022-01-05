﻿using System;
using System.Windows.Forms;
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
        public void Update(int TaskID , String Stage, String Name, int Owner, int Assigne, DateTime Startdate, DateTime Deadline)
        {
            string db = "Data Source=C:/Users/CHRAJEM/Desktop/Taskly/db/Taskly.db";
            var conn = new Microsoft.Data.Sqlite.SqliteConnection(db);
            conn.Open();
            var TasksQuery = new Microsoft.Data.Sqlite.SqliteCommand($"UPDATE Tasks SET name = '{Name}', owner = '{Owner}' , stage = '{Stage}' , assigne = '{Assigne}', start = '{Startdate}', end = '{Deadline}' where id = {TaskID} ", conn);
            TasksQuery.ExecuteReader();
        }
        public Microsoft.Data.Sqlite.SqliteDataReader Get(int TaskID)
        {
            string db = "Data Source=C:/Users/CHRAJEM/Desktop/Taskly/db/Taskly.db";
            var conn = new Microsoft.Data.Sqlite.SqliteConnection(db);
            conn.Open();
            var TasksQuery = new Microsoft.Data.Sqlite.SqliteCommand($"Select * From Tasks where id = {TaskID}", conn);
            Microsoft.Data.Sqlite.SqliteDataReader TaskReader = TasksQuery.ExecuteReader();
            return TaskReader;
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
    }
}

