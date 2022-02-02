using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Data.Sqlite;


namespace Takliy
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (userInput.Text.Length > 0 && passInput.Text.Length > 0)
            {
                var users = new Users();
                int login = users.Login(userInput.Text, passInput.Text);
                if(login> -1)
                {

                    MainForm main = new MainForm();
                    main.UID = login;
                    main.Show();
                    this.Hide();
                } else
                {
                    MessageBox.Show("Incorrect login data");
                }
            } 
            else
            {
                MessageBox.Show("Please fill all inputs");
            }
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            //CHECK IF DB EXISTS
            string dbPath = @"db\Taskly.db";
            if(!File.Exists(dbPath))
            {
  
                var createDb = new SqliteConnection("Data Source=db/Taskly.db");
                string sql = @"BEGIN TRANSACTION;
                CREATE TABLE IF NOT EXISTS 'Projects' (
	                'id'	INTEGER UNIQUE,
	                'name'	TEXT,
	                'leader'	INTEGER,
	                PRIMARY KEY('id')
                );
                CREATE TABLE IF NOT EXISTS 'PTasks' (
	                'pid'	INTEGER,
	                'tid'	INTEGER
                );
                CREATE TABLE IF NOT EXISTS 'Tasks' (
	                'id'	INTEGER UNIQUE,
	                'name'	TEXT,
	                'stage'	INTEGER,
	                'owner'	INTEGER,
	                'assigne'	INTEGER,
	                'start'	TEXT,
	                'end'	TEXT,
	                'pid'	INTEGER,
	                PRIMARY KEY('id' AUTOINCREMENT)
                );
                CREATE TABLE IF NOT EXISTS 'Posts' (
	                'id'	INTEGER UNIQUE,
	                'post'	TEXT,
	                'userid'	INTEGER,
	                'date'	TEXT,
	                PRIMARY KEY('id' AUTOINCREMENT)
                );
                CREATE TABLE IF NOT EXISTS 'Users' (
	                'id'	INTEGER UNIQUE,
	                'name'	TEXT,
	                'img'	TEXT,
	                'email'	TEXT,
	                'pass'	TEXT,
	                PRIMARY KEY('id' AUTOINCREMENT)
                );
                INSERT INTO 'Users' ('id','name','img','email','pass') VALUES (1,'Administrator','https://img.icons8.com/color/32/000000/user.png','admin','admin');
                COMMIT;
                ";
                createDb.Open();
                var query = new Microsoft.Data.Sqlite.SqliteCommand(sql, createDb);
                if(query.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("New DB has been generated");
                    
                } else
                {
                    MessageBox.Show("Error Generating new DATABASE");
                }
                
                createDb.Close();
            }
        }
    }
}
