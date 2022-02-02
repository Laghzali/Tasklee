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
	                'phone'	TEXT,
	                PRIMARY KEY('id' AUTOINCREMENT)
                );
                INSERT INTO 'Projects' ('id','name','leader') VALUES (1,'Tasklee OOP School project',1),
                 (2,'SpaceX rocket booster engine optimization project',2);
                INSERT INTO 'Tasks' ('id','name','stage','owner','assigne','start','end','pid') VALUES (47,'Research winforms / UWP technology','Done',1,1,'2/2/2022 1:19:42 PM','2/3/2022 1:19:42 PM',1),
                 (48,'Research .NET database integration','Done',2,2,'2/2/2022 1:20:50 PM','2/3/2022 1:20:50 PM',1),
                 (49,'Research CRM solutions and basisc CRM features','Done',2,2,'2/2/2022 1:21:24 PM','2/3/2022 1:21:24 PM',1),
                 (50,'Design a basic interface (DEMO) using Figma','Done',1,1,'2/2/2022 1:23:01 PM','2/3/2022 1:23:01 PM',1),
                 (51,'Discuss previous research outcomes','Done',1,2,'2/2/2022 1:24:12 PM','2/3/2022 1:24:12 PM',1),
                 (52,'Design initial WinForms','Done',2,2,'2/2/2022 1:25:12 PM','2/3/2022 1:25:12 PM',1),
                 (53,'Create Task Class','Done',1,1,'2/2/2022 1:25:35 PM','2/3/2022 1:25:35 PM',1),
                 (54,'Create Users class','Done',1,1,'2/2/2022 1:26:01 PM','2/3/2022 1:26:01 PM',1),
                 (55,'Create Project Class','Done',1,1,'2/2/2022 1:26:15 PM','2/3/2022 1:26:15 PM',1),
                 (56,'Create Feed Class','Done',1,1,'2/2/2022 1:26:30 PM','2/3/2022 1:26:30 PM',1),
                 (57,'GITHUB 3rd COMMIT','Done',1,1,'2/2/2022 1:27:47 PM','2/3/2022 1:27:47 PM',1),
                 (58,'Create and design task form','Done',1,1,'2/2/2022 1:29:13 PM','2/3/2022 1:29:13 PM',1),
                 (59,'Fix DataGridView StackOverflow exception','Done',1,1,'2/2/2022 1:30:17 PM','2/3/2022 1:30:17 PM',1);
                INSERT INTO 'Posts' ('id','post','userid','date') VALUES (113,'Some post from john doe',1,'2/2/2022 2:23:20 PM'),
                 (114,'Whats on your mind?',1,'2/2/2022 2:23:27 PM'),
                 (115,'Added new Project SpaceX rocket booster engine optimization project, Leader is Elon Tusk',1,'2/2/2022 2:26:10 PM'),
                 (116,'Im ELON Tusk and i have came to work today !',2,'2/2/2022 2:27:11 PM'),
                 (119,'John doe has came to work',1,'2/2/2022 2:29:40 PM'),
                 (120,'elon tusk out for dinner',2,'2/2/2022 2:29:59 PM'),
                 (134,'Edited task nameCreate Task Class, Project  Tasklee OOP School project',1,'2/2/2022 2:52:28 PM'),
                 (135,'Edited task nameCreate Users class, Project  Tasklee OOP School project',1,'2/2/2022 2:52:33 PM'),
                 (136,'Edited task nameCreate Project Class, Project  Tasklee OOP School project',1,'2/2/2022 2:52:40 PM'),
                 (137,'Edited task nameCreate Feed Class, Project  Tasklee OOP School project',1,'2/2/2022 2:52:48 PM'),
                 (138,'Edited task nameCreate and design task form, Project  Tasklee OOP School project',1,'2/2/2022 2:52:53 PM'),
                 (139,'Edited task nameFix DataGridView StackOverflow exception, Project  Tasklee OOP School project',1,'2/2/2022 2:52:57 PM');
                INSERT INTO 'Users' ('id','name','img','email','pass','phone') VALUES (1,'John Doe','https://img.icons8.com/color/32/000000/user.png','ml@taskly.com','pass',NULL),
                 (2,'Elon Tusk','https://img.icons8.com/doodle/32/000000/user.png','im@taskly.com','pass',NULL);
                COMMIT;";
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
