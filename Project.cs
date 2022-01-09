using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Takliy
{
    public class Project
    {
        public bool Add(String Name, int Leader)
        {
            string db = "Data Source=C:/Users/CHRAJEM/Desktop/Taskly/db/Taskly.db";
            var conn = new Microsoft.Data.Sqlite.SqliteConnection(db);
            conn.Open();
            var ProjectsQuery = new Microsoft.Data.Sqlite.SqliteCommand($"INSERT INTO Projects(name,leader) VALUES ('{Name}','{Leader}')", conn);
            var reader = ProjectsQuery.ExecuteNonQuery();
            if(reader > 0)
            {
                return true;
            }
            return false;
    
        }
        public void Remove(int ProjectID)
        {
            string db = "Data Source=C:/Users/CHRAJEM/Desktop/Taskly/db/Taskly.db";
            var conn = new Microsoft.Data.Sqlite.SqliteConnection(db);
            conn.Open();
            var TasksQuery = new Microsoft.Data.Sqlite.SqliteCommand($"Delete From Projects where id ={ProjectID}", conn);
            TasksQuery.ExecuteReader();
        }
        public bool Update(int ProjectID, String Name, int Leader)
        {
            string db = "Data Source=C:/Users/CHRAJEM/Desktop/Taskly/db/Taskly.db";
            var conn = new Microsoft.Data.Sqlite.SqliteConnection(db);
            conn.Open();
            var TasksQuery = new Microsoft.Data.Sqlite.SqliteCommand($"UPDATE Projects SET name = '{Name}', leader = '{Leader}' where id = {ProjectID} ", conn);
            var reader = TasksQuery.ExecuteNonQuery();
            if (reader > 0)
            {
                return true;
            }
            return false;
        }
        public Microsoft.Data.Sqlite.SqliteDataReader GetAll()
        {
            string db = "Data Source=C:/Users/CHRAJEM/Desktop/Taskly/db/Taskly.db";
            var conn = new Microsoft.Data.Sqlite.SqliteConnection(db);
            conn.Open();
            var TasksQuery = new Microsoft.Data.Sqlite.SqliteCommand("Select * From Projects", conn);
            Microsoft.Data.Sqlite.SqliteDataReader TaskReader = TasksQuery.ExecuteReader();
            return TaskReader;
        }
        public Microsoft.Data.Sqlite.SqliteDataReader Get(int ProjectID)
        {
            string db = "Data Source=C:/Users/CHRAJEM/Desktop/Taskly/db/Taskly.db";
            var conn = new Microsoft.Data.Sqlite.SqliteConnection(db);
            conn.Open();
            var TasksQuery = new Microsoft.Data.Sqlite.SqliteCommand($"Select * From Projects where id = {ProjectID}", conn);
            Microsoft.Data.Sqlite.SqliteDataReader TaskReader = TasksQuery.ExecuteReader();
            return TaskReader;
        }
        public void GetProjects(DataGridView grid)
        {

            string db = "Data Source=C:/Users/CHRAJEM/Desktop/Taskly/db/Taskly.db";
            var conn = new Microsoft.Data.Sqlite.SqliteConnection(db);
            conn.Open();
            var ProjectsQuery = new Microsoft.Data.Sqlite.SqliteCommand("Select * From Projects", conn);
            Microsoft.Data.Sqlite.SqliteDataReader ProjectReader = ProjectsQuery.ExecuteReader();
            while (ProjectReader.Read())
            {
                string LeaderName = "";
                int LeaderID = Int32.Parse(ProjectReader.GetValue(2).ToString());

                var LeaderNameQuery = new Microsoft.Data.Sqlite.SqliteCommand($"Select name From Users  Where id= {LeaderID} ", conn);

                Microsoft.Data.Sqlite.SqliteDataReader OwnerReader = LeaderNameQuery.ExecuteReader();

                while (OwnerReader.Read()) { LeaderName = OwnerReader.GetValue(0).ToString(); }
                grid.Rows.Add(new object[] {
                ProjectReader.GetValue(0) , //TaskID
                ProjectReader.GetValue(1), //name
                LeaderName, //leader
                "View"
                });
            }

        }
    }
}
