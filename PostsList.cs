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
    public partial class PostsList : UserControl
    {


        public PostsList(string UserName, string Post , string Date, string ImgURL)
        {
            InitializeComponent();
            UserNameLabel.Text = UserName;
            PostContent.Text = Post;
            DateLabel.Text = Date;

            pictureBox1.Size = new Size(32, 32);
            try
            {
                pictureBox1.Load(ImgURL);
            } catch
            {

            }
            

        }
    }
}