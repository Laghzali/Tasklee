﻿using System;
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

        private void AddTask_Load(object sender, EventArgs e)
        {
            Users users = new Users();
            SqliteDataReader UsersReader = users.GetAll();
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            while (UsersReader.Read())
            {


                
                comboSource.Add(UsersReader.GetValue(1).ToString(), UsersReader.GetValue(0).ToString());
                OwnerComboBox.DataSource = new BindingSource(comboSource, null);
                AssigneComboBox.DataSource = new BindingSource(comboSource, null);
                OwnerComboBox.DisplayMember = "Key";
                OwnerComboBox.ValueMember = "Value";
                AssigneComboBox.DisplayMember = "Key";
                AssigneComboBox.ValueMember = "Value";
                

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Task task = new Task();
            string message = "";
            try
            {
                task.Add(
                    TaskNameInput.Text,
                    StageComboBox.Text,
                    Int32.Parse(OwnerComboBox.SelectedValue.ToString()),
                    Int32.Parse(AssigneComboBox.SelectedValue.ToString()),
                    StartDatePicker.Value.ToString(),
                    EndDatePicker.Value.ToString()
                    );
                message = "Task has been added succusfully";

            } catch
            {
                message = "Error adding task";
            }
            MessageBox.Show(message);
        }

        private void AddTaskForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm._MainForm.Close();
            Form newTaskForm = new TaskForm();
            newTaskForm.Show();
        }
    }
}
