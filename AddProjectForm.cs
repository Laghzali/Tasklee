using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
namespace Takliy
{
    public partial class AddProjectForm : Form
    {
        public int UID { get; set; }
        public AddProjectForm()
        {
            InitializeComponent();
        }

        MainForm _MainFormObj = (MainForm)Application.OpenForms["MainForm"];
        private void AddProjectForm_Load(object sender, EventArgs e)
        {
            Users users = new Users();
            SqliteDataReader UsersReader = users.GetAll();
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            while (UsersReader.Read())
            {
                comboSource.Add(UsersReader.GetValue(1).ToString(), UsersReader.GetValue(0).ToString());
            }
            UsersReader.Close();


            //Owner
            LeaderComboBox.DisplayMember = "Key";
            LeaderComboBox.ValueMember = "Value";
            LeaderComboBox.DataSource = new BindingSource(comboSource, null);
        }

        private void AddProjectButton_Click(object sender, EventArgs e)
        {
            Project project = new Project();
            var add = project.Add(ProjectNaneInput.Text, Int32.Parse(LeaderComboBox.SelectedValue.ToString()));

            if (add)
            {
                ProjectForm projectform = new ProjectForm();
                projectform.UID = this.UID;
                _MainFormObj.loadform(projectform);
                _MainFormObj.Refresh();
                Feed feed = new Feed();
                feed.AddPost(UID, $"Added new Project {ProjectNaneInput.Text}, Leader is {LeaderComboBox.Text}");
                MessageBox.Show("Project has been created");
            } else
            {
                MessageBox.Show("Error creating new project");
            }
        }
    }
}
