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
        private void ProjectForm_Load(object sender, EventArgs e)
        {
            Project GetProjects = new Project();
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
    }
}