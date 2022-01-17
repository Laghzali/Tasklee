using System;
using System.Windows.Forms;

namespace Takliy
{
    
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public Form aboutpage = new Form();
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
            loadform(new TaskForm());
        }
        public void ReloadMain()
        {
            loadform(new TaskForm());
        }
        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProjectsMenuButton_Click(object sender, EventArgs e)
        {
            loadform(new ProjectForm());
        }

        private void dashButton_Click(object sender, EventArgs e)
        {
            loadform(new FeedForm());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
