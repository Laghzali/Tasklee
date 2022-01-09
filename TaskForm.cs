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
    public partial class TaskForm : Form
        
    {

        public int ProjectTaskID = 0;
        public TaskForm()
        {
            InitializeComponent();
        }
        public static Task _Tasks = new Task();
        private void TaskForm_Load(object sender, EventArgs e)
        {

            DataGridView grid = TasksGrid;
      
            if(ProjectTaskID == 0)
                _Tasks.GetTasks(grid , 0);
            if (ProjectTaskID > 0)
                _Tasks.GetTasks(grid, ProjectTaskID);
            grid.ReadOnly = false;
            TasksGrid.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.FromArgb((int)(1 * 255), Color.FromArgb(TasksGrid.CurrentRow.Cells[3].Style.BackColor.ToArgb()));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ShowAddTask = new AddTaskForm();
            ShowAddTask.Show();
        }

        private void refreshTasksButton_Click(object sender, EventArgs e)
        {
            TasksGrid.Rows.Clear();
            if(ProjectTaskID == 0)
                _Tasks.GetTasks(TasksGrid , 0);
            if(ProjectTaskID > 0)
                _Tasks.GetTasks(TasksGrid, ProjectTaskID);
            TasksGrid.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.FromArgb((int)(1 * 255), Color.FromArgb(TasksGrid.CurrentRow.Cells[3].Style.BackColor.ToArgb()));

        }
        private DataGridViewRow CheckedRow;
        private int CheckedTaskID = 0;

        private void DeleteTaskButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this task?", "Delete Task", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Task delTask = new Task();
                delTask.Remove(CheckedTaskID);
                TasksGrid.Rows.Remove(CheckedRow);
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }


        private void TaskEditButton_Click(object sender, EventArgs e)
        {
            EditTaskForm EditForm = new EditTaskForm();
            EditForm.TaskID = CheckedTaskID;
            EditForm.Show();
        }

        private void TasksGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CheckedTaskID = Int32.Parse(TasksGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            EditTaskForm EditFormEvent = new EditTaskForm();
            EditFormEvent.TaskID = CheckedTaskID;
            EditFormEvent.Show();
        }

        private void TasksGrid_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                CheckedTaskID = Int32.Parse(TasksGrid.CurrentRow.Cells[0].Value.ToString());
                TasksGrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb((int)(1 * 255), Color.FromArgb(TasksGrid.CurrentRow.Cells[3].Style.BackColor.ToArgb()));
                TasksGrid.DefaultCellStyle.SelectionForeColor = Color.Black;
                CheckedRow = TasksGrid.CurrentRow;
                DeleteTaskButton.Enabled = true;
                TaskEditButton.Enabled = true;
            } catch (Exception ){
                MessageBox.Show("x");
            }
        }
    }
}
