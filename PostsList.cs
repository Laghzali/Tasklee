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
    public partial class PostsList : UserControl
    {


        public PostsList(string UserName, string Post , string Date)
        {
            InitializeComponent();
            UserNameLabel.Text = UserName;
            PostContent.Text = Post;
            DateLabel.Text = Date;
        }
    }
}
