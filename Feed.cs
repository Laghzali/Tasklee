﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Takliy
{
    public class Feed
    {
        private string db = "Data Source=db/Taskly.db";

        public void AddPost(int UserID, string Post)
        {
            
            var conn = new Microsoft.Data.Sqlite.SqliteConnection(db);
            conn.Open();
            var PostQuery = new Microsoft.Data.Sqlite.SqliteCommand($"INSERT INTO Posts(post,userid,date) VALUES ('{Post}','{UserID}','{DateTime.Now.ToString()}')", conn);
            PostQuery.ExecuteNonQuery();
            conn.Close();
        }

        public Microsoft.Data.Sqlite.SqliteDataReader GetPosts()
        {
            var conn = new Microsoft.Data.Sqlite.SqliteConnection(db);
            conn.Open();
            var PostQuery = new Microsoft.Data.Sqlite.SqliteCommand("Select *  From Posts Order by id desc", conn);
            var reader = PostQuery.ExecuteReader();

            return reader;
        }
    }
}
