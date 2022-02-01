using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace Takliy
{
    class Users
    {
        public  int ID;
        private static string db = "Data Source=db/Taskly.db";
        private readonly Microsoft.Data.Sqlite.SqliteConnection conn = new Microsoft.Data.Sqlite.SqliteConnection(db);
        public void Add(String Email , String Name , String Password)
        {
           
            conn.Open();
            var AddQuery = new Microsoft.Data.Sqlite.SqliteCommand($"INSERT INTO Users(name,email,password,img) VALUES ('{Name}','{Email}', {Password} , 'https://img.icons8.com/external-bearicons-glyph-bearicons/32/000000/external-User-essential-collection-bearicons-glyph-bearicons.png')", conn);
            AddQuery.ExecuteReader();
        }
        public Microsoft.Data.Sqlite.SqliteDataReader GetAll()
        {
           
            conn.Open();
            var UsersQuery = new Microsoft.Data.Sqlite.SqliteCommand("Select * From Users", conn);
            Microsoft.Data.Sqlite.SqliteDataReader UsersReader = UsersQuery.ExecuteReader();

            return UsersReader;
        }
        public List<string> Get(int UserID)
        {
           
            conn.Open();
            var UsersQuery = new Microsoft.Data.Sqlite.SqliteCommand($"Select * From Users where id  = {UserID}", conn);
            Microsoft.Data.Sqlite.SqliteDataReader UsersReader = UsersQuery.ExecuteReader();

            List<string> UserData = new List<string>();
            while(UsersReader.Read())
            {
                UserData.Add(UsersReader.GetValue(1).ToString());
                UserData.Add(UsersReader.GetValue(2).ToString());
            }
            conn.Close();
            return UserData;
        }

        public string GetUserName(int UserID)
        {
            string username = "";
            conn.Open();
            var UsersQuery = new Microsoft.Data.Sqlite.SqliteCommand($"Select name From Users where id  = {UserID}", conn);
            Microsoft.Data.Sqlite.SqliteDataReader UsersReader = UsersQuery.ExecuteReader();
            while (UsersReader.Read())
            {
                username =  UsersReader.GetValue(0).ToString();
            }
            return username;

        }
        public string GetUserIMG(int UserID)
        {
            string imgURL = "";
            conn.Open();
            var UsersQuery = new Microsoft.Data.Sqlite.SqliteCommand($"Select img From Users where id  = {UserID}", conn);
            Microsoft.Data.Sqlite.SqliteDataReader UsersReader = UsersQuery.ExecuteReader();
            while (UsersReader.Read())
            {
                imgURL = UsersReader.GetValue(0).ToString();
            }
            return imgURL;

        }
        public int Login(string user , string pass) 
        {
            int id = -1;
            conn.Open();
            var UsersQuery = new Microsoft.Data.Sqlite.SqliteCommand($"Select * From Users", conn);
            Microsoft.Data.Sqlite.SqliteDataReader UsersReader = UsersQuery.ExecuteReader();
            while (UsersReader.Read())
            {
                string idx = UsersReader.GetValue(0).ToString();
                string email = UsersReader.GetValue(3).ToString();
                string rpass = UsersReader.GetValue(4).ToString();

                if (user == email && pass == rpass)
                {
                    id = Int32.Parse(idx);
                    ID = id;

                }
            }

            return id;

        }

    }
}
