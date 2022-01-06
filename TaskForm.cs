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
        private int CheckedRow = 0;

        private void DeleteTaskButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CheckedRow.ToString());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CheckedRow = e.RowIndex;
            if (e.ColumnIndex == 6)
            {
                for(int i =0; i < dataGridView1.Rows.Count; i++)
                {
                    if(e.RowIndex != i)
                    {
                        dataGridView1.Rows[i].Cells[6].Value = false;
                    }
                }

            }
        }
    }
}
