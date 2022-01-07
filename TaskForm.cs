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
        
        public TaskForm()
        {
            InitializeComponent();
        }
        public static Task _Tasks = new Task();
        private void TaskForm_Load(object sender, EventArgs e)
        {
            DataGridView grid = dataGridView1;

            _Tasks.GetTasks(grid);
            grid.ReadOnly = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ShowAddTask = new AddTaskForm();
            ShowAddTask.Show();
        }

        private void refreshTasksButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            _Tasks.GetTasks(dataGridView1);
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
                dataGridView1.Rows.Remove(CheckedRow);
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
            
            if (e.ColumnIndex == 7)
            {
                CheckedTaskID = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                CheckedRow = dataGridView1.Rows[e.RowIndex];
                for (int i =0; i < dataGridView1.Rows.Count; i++)
                {
                    if(e.RowIndex != i)
                    {
                        dataGridView1.Rows[i].Cells[7].Value = false;
                        

                    } else
                    {
                        dataGridView1.Rows[i].Cells[7].Value = true;
                        
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

            }
            prevIndex = e.RowIndex;
            DeleteTaskButton.Enabled = DeleteButtonEnabled;
        }

        private void TaskEditButton_Click(object sender, EventArgs e)
        {
            EditTaskForm EditForm = new EditTaskForm();
            EditForm.TaskID = CheckedTaskID;
            EditForm.Show();
        }
    }
}
