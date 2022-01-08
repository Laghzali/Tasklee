using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
namespace Takliy
{
    public partial class AddProjectForm : Form
    {
        public AddProjectForm()
        {
            InitializeComponent();
        }

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
                MessageBox.Show("Project has been created");
            } else
            {
                MessageBox.Show("Error creating new project");
            }
        }
    }
}
