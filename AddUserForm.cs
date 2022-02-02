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
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Users addUser = new Users();
            if (addUser.add(UserFullName.Text, UserEmail.Text, UserPhone.Text, UserPassword.Text) > 0) 
            {
                MessageBox.Show("User has been added");
                this.Close();
            } else
            {
                MessageBox.Show("Error adding user");
                this.Close();
            }
        }
    }
}
