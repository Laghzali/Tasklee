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
        private EditTaskForm EditForm = new EditTaskForm();
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
        }
        private DataGridViewRow CheckedRow;
        private int CheckedTaskID = 0;
        //delete button checkbox logic
        private int prevIndex = -1;
        private bool DeleteButtonEnabled = true;
        //
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

        private void TasksGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                CheckedTaskID = Int32.Parse(TasksGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                CheckedRow = TasksGrid.Rows[e.RowIndex];

                for (int i =0; i < TasksGrid.Rows.Count; i++)
                {
                    if(e.RowIndex != i)
                    {
                        TasksGrid.Rows[i].Cells[7].Value = false;
                        

                    } else
                    {
                        TasksGrid.Rows[i].Cells[7].Value = true;
                        
                    }
                }

                    if (prevIndex == e.RowIndex)
                    {
                       // MessageBox.Show("same one");
                         DeleteButtonEnabled = !DeleteButtonEnabled;
                    } else
                    {
                       // MessageBox.Show("another one");
                        DeleteButtonEnabled = true;
                    }
                prevIndex = e.RowIndex;
                DeleteTaskButton.Enabled = DeleteButtonEnabled;
                TaskEditButton.Enabled = DeleteButtonEnabled;
            }

        }

        private void TaskEditButton_Click(object sender, EventArgs e)
        {
            
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
    }
}
