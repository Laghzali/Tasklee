using System;
using System.Windows.Forms;

namespace Takliy
{
    
    public partial class MainForm : Form
    {
        public int UID { get; set; }
        public MainForm()
        {
            InitializeComponent();

        }


        public void loadform(object Form)
        {

            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();

        }
        private void tasksButton_Click(object sender, EventArgs e)
        {
            TaskForm taskform = new TaskForm();
            taskform.UID = this.UID;
            loadform(taskform);
        }
        public void ReloadMain()
        {
            TaskForm taskform = new TaskForm();
            taskform.UID = this.UID;
            loadform(taskform);
        }
        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProjectsMenuButton_Click(object sender, EventArgs e)
        {
            ProjectForm projectform = new ProjectForm();
            projectform.UID = this.UID;
            loadform(projectform);
        }

        private void dashButton_Click(object sender, EventArgs e)
        {
            FeedForm feedform = new FeedForm();
            feedform.UID = this.UID;
            loadform(feedform);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FeedForm feedform = new FeedForm();
            feedform.UID = this.UID;
            loadform(feedform);
            Users user = new Users();
           string userIMG = user.GetUserIMG(UID);
            string username = user.GetUserName(UID);
            pictureBox1.Load(userIMG);
            nameLabel.Text = username;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
