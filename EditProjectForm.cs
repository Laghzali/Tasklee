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
    public partial class EditProjectForm : Form
    {
        public int UID { get; set; }
        public EditProjectForm()
        {
            InitializeComponent();
        }
        public int PID;
        Project project = new Project();
        MainForm _MainFormObj = (MainForm)Application.OpenForms["MainForm"];
        private void EditProjectForm_Load(object sender, EventArgs e)
        {


            
            SqliteDataReader FetchProject = project.Get(PID);
            int LeaderID = 0;
            while(FetchProject.Read())
            {
                LeaderID = Int32.Parse(FetchProject.GetValue(2).ToString());
            }
            FetchProject.Close();
            Users users = new Users();
            SqliteDataReader UsersReader = users.GetAll();
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            string OriginalLeader = "";
            while (UsersReader.Read())
            {
                comboSource.Add(UsersReader.GetValue(1).ToString(), UsersReader.GetValue(0).ToString());
                if (Int32.Parse(UsersReader.GetValue(0).ToString()) == LeaderID) { OriginalLeader = UsersReader.GetValue(1).ToString();}
                
            }
            
            UsersReader.Close();

            //Owner
            LeaderComboBoxEdit.DisplayMember = "Key";
            LeaderComboBoxEdit.ValueMember = "Value";
            LeaderComboBoxEdit.DataSource = new BindingSource(comboSource, null);
            LeaderComboBoxEdit.Text = OriginalLeader;
        }
        private void EditProjectButton_Click(object sender, EventArgs e)
        {
            var edit = project.Update(PID, ProjectNaneInput.Text, Int32.Parse(LeaderComboBoxEdit.SelectedValue.ToString()));

            if (edit)
            {
                ProjectForm projectform = new ProjectForm();
                projectform.UID = this.UID;
                _MainFormObj.loadform(projectform);
                _MainFormObj.Refresh();
                Feed feed = new Feed();
                feed.AddPost(UID, $"Edited Project name : {ProjectNaneInput.Text}, Leader Is  {LeaderComboBoxEdit.Text}");
                MessageBox.Show("Project has been edited");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error editing project");
            }
        }
    }
}
