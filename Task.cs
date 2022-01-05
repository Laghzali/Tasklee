using System;

namespace Takliy
{
    public class Task
    {

        public void Add(String Stage, String Name , int Owner , int Assigne , DateTime Startdate, DateTime Deadline)
        {
            string db = "Data Source=C:/Users/CHRAJEM/Desktop/Taskly/db/Taskly.db";
            var conn = new Microsoft.Data.Sqlite.SqliteConnection(db);
            conn.Open();
            var TasksQuery = new Microsoft.Data.Sqlite.SqliteCommand($"INSERT INTO Tasks(name,stage,owner,assigne,start,end) VALUES ('{Name}','{Stage}', {Owner}, {Assigne} , {Startdate}, {Deadline})", conn);
            Microsoft.Data.Sqlite.SqliteDataReader TaskReader = TasksQuery.ExecuteReader();
        }
        public void Remove(int TaskID)
        {
            string db = "Data Source=C:/Users/CHRAJEM/Desktop/Taskly/db/Taskly.db";
            var conn = new Microsoft.Data.Sqlite.SqliteConnection(db);
            conn.Open();
            var TasksQuery = new Microsoft.Data.Sqlite.SqliteCommand($"Delete From Tasks where id ={TaskID}", conn);
            Microsoft.Data.Sqlite.SqliteDataReader TaskReader = TasksQuery.ExecuteReader();
        }
        public void Update(int TaskID , String Stage, String Name, int Owner, int Assigne, DateTime Startdate, DateTime Deadline)
        {
            string db = "Data Source=C:/Users/CHRAJEM/Desktop/Taskly/db/Taskly.db";
            var conn = new Microsoft.Data.Sqlite.SqliteConnection(db);
            conn.Open();
            var TasksQuery = new Microsoft.Data.Sqlite.SqliteCommand($"UPDATE Tasks SET name = '{Name}', owner = {Owner} , stage = {Stage} , assigne = {Assigne}, start = {Startdate}, end = {Deadline} where id = {TaskID} ", conn);
            Microsoft.Data.Sqlite.SqliteDataReader TaskReader = TasksQuery.ExecuteReader();
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
    }
}

