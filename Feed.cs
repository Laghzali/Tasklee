using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Takliy
{
    public class Feed
    {
        private string db = "Data Source=C:/Users/emret/source/repos/Laghzali/Taskly/db/Taskly.db";

        public void AddPost(int UserID, string Post)
        {
            
            var conn = new Microsoft.Data.Sqlite.SqliteConnection(db);
            conn.Open();
            var PostQuery = new Microsoft.Data.Sqlite.SqliteCommand($"INSERT INTO Posts(post,userid) VALUES ('{Post}','{UserID}')", conn);
            PostQuery.ExecuteNonQuery();
            conn.Close();
        }

        public Microsoft.Data.Sqlite.SqliteDataReader GetPosts()
        {
            var conn = new Microsoft.Data.Sqlite.SqliteConnection(db);
            conn.Open();
            var PostQuery = new Microsoft.Data.Sqlite.SqliteCommand("Select * From Posts", conn);
            var reader = PostQuery.ExecuteReader();

            return reader;
        }
    }
}
