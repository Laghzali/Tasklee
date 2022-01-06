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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ShowAddTask = new AddTaskForm();
            ShowAddTask.Show();
        }

    }
}
