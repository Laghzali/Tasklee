using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Takliy
{

    public partial class FeedForm : Form
    {
        public FeedForm()
        {
            InitializeComponent();
        }
        Feed feed = new Feed();

        private void FeedForm_Load(object sender, EventArgs e)
        {
            Microsoft.Data.Sqlite.SqliteDataReader reader = feed.GetPosts();
            List<Post> PostsList = new List<Post>();
            while (reader.Read())
            {
                Post newPost = new Post();
                newPost._Post = reader.GetValue(1).ToString();
                newPost.UserID = Int32.Parse(reader.GetValue(2).ToString());
                newPost.Date = reader.GetValue(3).ToString();
                PostsList.Add(newPost);
            }
            foreach(var post in PostsList)
            {
                UserControl newpost = new PostsList(post.UserID.ToString(), post._Post, post.Date);
               //flowLayoutPanel1.Controls.Add(newpost);
            }
        }
        private void PostButton_Click(object sender, EventArgs e)
        {
            feed.AddPost(1, PostText.Text);
        }

    }
    public class Post
    {
        public int PostID { get; set; }
        public string _Post { get; set; }
        public int UserID { get; set; }
        public string Date { get; set; }
    }
}
