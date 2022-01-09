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
    public partial class ProjectForm : Form
    {
        public ProjectForm()
        {
            InitializeComponent();
        }
        MainForm _MainFormObj = (MainForm)Application.OpenForms["MainForm"];
        Project GetProjects = new Project();
        private void ProjectForm_Load(object sender, EventArgs e)
        {
            
            ProjectsGrid.DefaultCellStyle.SelectionBackColor = Color.LightCyan;
            ProjectsGrid.DefaultCellStyle.SelectionForeColor = Color.Black;
            ProjectsGrid.CellClick +=
                new DataGridViewCellEventHandler(ProjectsGrid_CellClick);
            GetProjects.GetProjects(ProjectsGrid);

        }
        void ProjectsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int pid = 0;
            if (e.RowIndex >= 0 && e.ColumnIndex == 3)
            {
                pid = Int32.Parse(ProjectsGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                
                TaskForm _TaskFormObj = new TaskForm();
                _TaskFormObj.ProjectTaskID = pid;
                _MainFormObj.loadform(_TaskFormObj);
            }
        }

        private void ProjectNewButton_Click(object sender, EventArgs e)
        {
            AddProjectForm AddProject = new AddProjectForm();
            AddProject.Show();
        }

        private void ProjectEditButton_Click(object sender, EventArgs e)
        {
            EditProjectForm editPF = new EditProjectForm();
            editPF.PID = Int32.Parse(ProjectsGrid.CurrentRow.Cells[0].Value.ToString());
            editPF.Show();
        }

        private void ProjectsGrid_SelectionChanged(object sender, EventArgs e)
        {
            ProjectEditButton.Enabled = true;
            ProjectDeleteButton.Enabled = true;

        }

        private void ProjectRefreshButton_Click(object sender, EventArgs e)
        {
            ProjectsGrid.Rows.Clear();
            GetProjects.GetProjects(ProjectsGrid);

        }

        private void ProjectDeleteButton_Click(object sender, EventArgs e)
        {
            int PID = Int32.Parse(ProjectsGrid.CurrentRow.Cells[0].Value.ToString());
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Project?", "Delete Project", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                GetProjects.Remove(PID);
                ProjectsGrid.Rows.Remove(ProjectsGrid.CurrentRow);

            }
            else if (dialogResult == DialogResult.No)
            {

            }

        }
    }
}