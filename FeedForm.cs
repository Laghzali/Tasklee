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
        int UID = 2;
        private void FeedForm_Load(object sender, EventArgs e)
        {
            Microsoft.Data.Sqlite.SqliteDataReader reader = feed.GetPosts();
            List<Post> PostsList = new List<Post>();
            while (reader.Read())
            {
                Post newPost = new Post();
                Users user = new Users();
                
                newPost._Post = reader.GetValue(1).ToString();
                newPost.UserName = user.Get(Int32.Parse(reader.GetValue(2).ToString()))[0];
                newPost.ImgUrl = user.Get(Int32.Parse(reader.GetValue(2).ToString()))[1];
                newPost.Date = reader.GetValue(3).ToString();
                PostsList.Add(newPost);

            }
            foreach(var post in PostsList)
            {
                UserControl newpost = new PostsList(post.UserName, post._Post, post.Date, post.ImgUrl);
               flowLayoutPanel1.Controls.Add(newpost);
            }
        }
        private void PostButton_Click(object sender, EventArgs e)
        {
            //not checking for white space !!!!!!
            if (PostText.TextLength > 0)
            {
                feed.AddPost(UID, PostText.Text);
            } else
            {
                MessageBox.Show("Post cant be empty");
            }
            
        }

    }
    public class Post
    {
        public string ImgUrl { get; set; }
        public int PostID { get; set; }
        public string _Post { get; set; }
        public string UserName { get; set; }
        public string Date { get; set; }
    }
}
