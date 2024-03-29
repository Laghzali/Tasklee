﻿using System;
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
        public int UID { get; set; }
        MainForm _MainFormObj = (MainForm)Application.OpenForms["MainForm"];
        public FeedForm()
        {

            InitializeComponent();
        }
        
        private void FeedForm_Load(object sender, EventArgs e)
        {

            timer1.Start();
            Feed feed = new Feed();
            Project ProjectCount = new Project();
            Task taskcount = new Task();
            Users user = new Users();
          
            string username = user.GetUserName(UID);
 
            nameLabel.Text = username;
            projectCount.Text = ProjectCount.Count();
            todoLabel.Text = taskcount.Count(1);
            doneLabel.Text = taskcount.Count(0);
            progressLabel.Text = taskcount.Count(2);
            Microsoft.Data.Sqlite.SqliteDataReader reader = feed.GetPosts();
            List<Post> PostsList = new List<Post>();
            while (reader.Read())
            {
                Post newPost = new Post();
                int post_uid = Int32.Parse(reader.GetValue(2).ToString());
                newPost._Post = reader.GetValue(1).ToString();
                newPost.UserName = user.GetUserName(post_uid);
                newPost.ImgUrl = user.GetUserIMG(post_uid);
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
                Feed feed = new Feed();
                feed.AddPost(UID, PostText.Text);

                _MainFormObj.ReloadFeed();
            } else
            {
                MessageBox.Show("Post cant be empty");
            }
            
        }

        private void PostText_Click(object sender, EventArgs e)
        {
            PostText.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLablel.Text = DateTime.Now.ToString("T");
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
