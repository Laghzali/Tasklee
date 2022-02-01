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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
