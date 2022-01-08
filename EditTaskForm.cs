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
    public partial class EditTaskForm : Form
    {
        public EditTaskForm()
        {
            InitializeComponent();
        }
        public int TaskID = 0;
        MainForm _MainFormObj = (MainForm)Application.OpenForms["MainForm"];
        private Task TaskObj = new Task();
        private void EditTaskForm_Load(object sender, EventArgs e)
        {

            List<object> TaskReader = TaskObj.Get(TaskID);
            Users users = new Users();
            Microsoft.Data.Sqlite.SqliteDataReader UsersReader = users.GetAll();
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            string OriginalOwnerName = "";
            string OriginalAssigneName = "";
            while (UsersReader.Read())
            {
                if((string)UsersReader.GetValue(0).ToString() == (string)TaskReader[2].ToString())
                {
                    OriginalOwnerName = (string)UsersReader.GetValue(1);
                }
                if ((string)UsersReader.GetValue(0).ToString() == (string)TaskReader[3].ToString())
                {
                    OriginalAssigneName = (string)UsersReader.GetValue(1);
                }

                comboSource.Add(UsersReader.GetValue(1).ToString(), UsersReader.GetValue(0).ToString());
            }

            UsersReader.Close();

            Project projects = new Project();
            Microsoft.Data.Sqlite.SqliteDataReader ProjectsReader = projects.GetAll();
            Dictionary<string, int> ProjectsComboSource = new Dictionary<string, int>();
            string OriginalProjectName = "";
            while (ProjectsReader.Read())
            {
                if ((string)ProjectsReader.GetValue(0).ToString() == (string)TaskReader[6].ToString())
                {
                    OriginalProjectName = (string)ProjectsReader.GetValue(1);
                }
                ProjectsComboSource.Add(ProjectsReader.GetValue(1).ToString(), Int32.Parse(ProjectsReader.GetValue(0).ToString()));
            }
            ProjectsReader.Close();
            OwnerComboBox.DisplayMember = "Key";
            OwnerComboBox.ValueMember = "Value";
            AssigneComboBox.DisplayMember = "Key";
            AssigneComboBox.ValueMember = "Value";
            ProjectComboBox.DisplayMember = "Key";
            ProjectComboBox.ValueMember = "Value";
            ProjectComboBox.DataSource = new BindingSource(ProjectsComboSource, null);
            OwnerComboBox.DataSource = new BindingSource(comboSource, null);
            AssigneComboBox.DataSource = new BindingSource(comboSource, null);
            TaskNameInput.Text = (string)TaskReader[0];
            StageComboBox.Text = (string)TaskReader[1];
            OwnerComboBox.Text = OriginalOwnerName;
            AssigneComboBox.Text = OriginalAssigneName;
            ProjectComboBox.Text = OriginalProjectName;
            StartDatePicker.Value = DateTime.Parse((string)TaskReader[4]);
            EndDatePicker.Value = DateTime.Parse((string)TaskReader[5]);

        }

        private void EditButtonDone_Click(object sender, EventArgs e)
        {
            string message = "";

            try
            {
                if (!string.IsNullOrWhiteSpace(TaskNameInput.Text) && !string.IsNullOrWhiteSpace(StageComboBox.Text))
                {
                    if(DateTime.Compare( DateTime.Today , EndDatePicker.Value) < 0 && DateTime.Compare(DateTime.Today, StartDatePicker.Value) > 0)
                    {
                        message = "Invalid date";

                    }
                    else
                    {
                        TaskObj.Update(
                        TaskID,
                        TaskNameInput.Text,
                        StageComboBox.Text,
                        Int32.Parse(OwnerComboBox.SelectedValue.ToString()),
                        Int32.Parse(AssigneComboBox.SelectedValue.ToString()),
                        StartDatePicker.Value,
                        EndDatePicker.Value,
                        Int32.Parse(ProjectComboBox.SelectedValue.ToString())
                        );
                        _MainFormObj.ReloadMain();
                        _MainFormObj.Refresh();
                        message = "Task has been succusfully edited";
                    }
                }
                else
                {
                    message = "All fields must be filled";
                }
            }
            catch
            {
                message = "Error adding task";
            }
            MessageBox.Show(message);
        }
    }
}
