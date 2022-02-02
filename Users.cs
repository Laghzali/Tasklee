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
        public int add(string fullname , string email , string phone , string pass)
        {
            conn.Open();
            var InsertUserQuery = new Microsoft.Data.Sqlite.SqliteCommand($"INSERT INTO Users (name, email, phone, pass , img) VALUES ('{fullname}', '{email}', '{phone}', '{pass}' , 'https://img.icons8.com/color/32/000000/user.png');", conn);
            int InsertQueryCommand = InsertUserQuery.ExecuteNonQuery();
            return InsertQueryCommand;
        }

        public int Remove(int uid)
        {
            conn.Open();
            var InsertUserQuery = new Microsoft.Data.Sqlite.SqliteCommand($"DELETE FROM Users where id = {uid}", conn);
            int InsertQueryCommand = InsertUserQuery.ExecuteNonQuery();
            return InsertQueryCommand;
        }
        public void GetUsers(DataGridView grid)
        {


            conn.Open();
            var UsersQuery = new Microsoft.Data.Sqlite.SqliteCommand("Select * From Users", conn);
            Microsoft.Data.Sqlite.SqliteDataReader UsersQueryReader = UsersQuery.ExecuteReader();
            while (UsersQueryReader.Read())
            {
                grid.Rows.Add(new object[] {
                UsersQueryReader.GetValue(0) , //UserID
                UsersQueryReader.GetValue(1), //UserName
                UsersQueryReader.GetValue(3), //email
                UsersQueryReader.GetValue(5), //Phone

                });
            }

        }
    }
}
