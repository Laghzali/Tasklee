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
    public partial class AddTaskForm : Form
    {
        public AddTaskForm()
        {
            InitializeComponent();
        }
        public int UID { get; set; }
        private void AddTask_Load(object sender, EventArgs e)
        {
            Users users = new Users();
            SqliteDataReader UsersReader = users.GetAll();
            Dictionary<string, string> comboSource = new Dictionary<string, string>();


            while (UsersReader.Read())
            {
                comboSource.Add(UsersReader.GetValue(1).ToString(), UsersReader.GetValue(0).ToString());
                
            }

            UsersReader.Close();

            Project projects = new Project();
            SqliteDataReader ProjectsReader = projects.GetAll();
            Dictionary<string, int> ProjectsComboSource = new Dictionary<string, int>();
            while (ProjectsReader.Read())
            {
                ProjectsComboSource.Add(ProjectsReader.GetValue(1).ToString(), Int32.Parse(ProjectsReader.GetValue(0).ToString()));
            }
            ProjectsReader.Close();
            StageComboBox.SelectedIndex = 0;

            //Owner
            OwnerComboBox.DisplayMember = "Key";
            OwnerComboBox.ValueMember = "Value";
            OwnerComboBox.DataSource = new BindingSource(comboSource, null);
            //Project
            ProjectComboBox.DisplayMember = "Key";
            ProjectComboBox.ValueMember = "Value";
            ProjectComboBox.DataSource = new BindingSource(ProjectsComboSource, null);

            //Assigne
            AssigneComboBox.DisplayMember = "Key";
            AssigneComboBox.ValueMember = "Value";
            AssigneComboBox.DataSource = new BindingSource(comboSource, null);
        }

        MainForm _MainFormObj = (MainForm)Application.OpenForms["MainForm"];
        private void button2_Click(object sender, EventArgs e)
        {

            Task task = new Task();
            Feed feed = new Feed();
            string message = "";

            try
            {
                if (!string.IsNullOrWhiteSpace(TaskNameInput.Text) && !string.IsNullOrWhiteSpace(StageComboBox.Text))
                {
                    if (DateTime.Compare(StartDatePicker.Value, EndDatePicker.Value) > 0 || DateTime.Compare(StartDatePicker.Value, EndDatePicker.Value) == 0)
                    {
                        message = "Invalid date";

                    } else
                    {
                        task.Add(
                        TaskNameInput.Text,
                        StageComboBox.Text,
                        Int32.Parse(OwnerComboBox.SelectedValue.ToString()),
                        Int32.Parse(AssigneComboBox.SelectedValue.ToString()),
                        StartDatePicker.Value.ToString(),
                        EndDatePicker.Value.ToString(),
                        Int32.Parse(ProjectComboBox.SelectedValue.ToString()));
                        _MainFormObj.ReloadMain();
                        _MainFormObj.Refresh();
                        feed.AddPost(UID, $"Added new task {TaskNameInput.Text} in Project {ProjectComboBox.SelectedValue.ToString()}");
                        message = "Task has been added succusfully";
                    }

                } else
                {
                    message = "All fields must be filled";
                }
            } catch
            {
                message = "Error adding task";
            }
            MessageBox.Show(message);
        }
    }
}
