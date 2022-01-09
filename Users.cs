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
            string db = "Data Source=C:/Users/CHRAJEM/Desktop/Taskly/db/Taskly.db";
            var conn = new Microsoft.Data.Sqlite.SqliteConnection(db);
            conn.Open();
            var AddQuery = new Microsoft.Data.Sqlite.SqliteCommand($"INSERT INTO Users(name,email,password,img) VALUES ('{Name}','{Email}', {Password} , 'https://img.icons8.com/external-bearicons-glyph-bearicons/32/000000/external-User-essential-collection-bearicons-glyph-bearicons.png')", conn);
            AddQuery.ExecuteReader();
        }
        public Microsoft.Data.Sqlite.SqliteDataReader GetAll()
        {
            string db = "Data Source=C:/Users/CHRAJEM/Desktop/Taskly/db/Taskly.db";
            var conn = new Microsoft.Data.Sqlite.SqliteConnection(db);
            conn.Open();
            var UsersQuery = new Microsoft.Data.Sqlite.SqliteCommand("Select * From Users", conn);
            Microsoft.Data.Sqlite.SqliteDataReader UsersReader = UsersQuery.ExecuteReader();

            return UsersReader;
        }
        public List<string> Get(int UserID)
        {
            string db = "Data Source=C:/Users/CHRAJEM/Desktop/Taskly/db/Taskly.db";
            var conn = new Microsoft.Data.Sqlite.SqliteConnection(db);
            conn.Open();
            var UsersQuery = new Microsoft.Data.Sqlite.SqliteCommand($"Select * From Users where id  = {UserID}", conn);
            Microsoft.Data.Sqlite.SqliteDataReader UsersReader = UsersQuery.ExecuteReader();

            List<string> UserData = new List<string>();
            while(UsersReader.Read())
            {
                UserData.Add(UsersReader.GetValue(1).ToString());
                UserData.Add(UsersReader.GetValue(2).ToString());
            }
            return UserData;
        }
    }
}
