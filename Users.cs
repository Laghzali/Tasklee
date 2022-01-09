using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Takliy
{
    class Users
    {
        public void Add(String Email , String Name , String Password)
        {
            string db = "Data Source=C:/Users/emret/source/repos/Laghzali/Taskly/db/Taskly.db";
            var conn = new Microsoft.Data.Sqlite.SqliteConnection(db);
            conn.Open();
            var AddQuery = new Microsoft.Data.Sqlite.SqliteCommand($"INSERT INTO Users(name,email,password) VALUES ('{Name}','{Email}', {Password})", conn);
            AddQuery.ExecuteReader();
        }
        public Microsoft.Data.Sqlite.SqliteDataReader GetAll()
        {
            string db = "Data Source=C:/Users/emret/source/repos/Laghzali/Taskly/db/Taskly.db";
            var conn = new Microsoft.Data.Sqlite.SqliteConnection(db);
            conn.Open();
            var UsersQuery = new Microsoft.Data.Sqlite.SqliteCommand("Select * From Users", conn);
            Microsoft.Data.Sqlite.SqliteDataReader UsersReader = UsersQuery.ExecuteReader();

            return UsersReader;
        }
    }
}
