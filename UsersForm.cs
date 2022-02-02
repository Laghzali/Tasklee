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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }
        MainForm _MainFormObj = (MainForm)Application.OpenForms["MainForm"];
        Users users = new Users();
        private void UsersForm_Load(object sender, EventArgs e)
        {
            
            UsersGrid.DefaultCellStyle.SelectionBackColor = Color.LightCyan;
            UsersGrid.DefaultCellStyle.SelectionForeColor = Color.Black;

            users.GetUsers(UsersGrid);

        }

        private void ProjectNewButton_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.Show();
        }


        private void UsersGrid_SelectionChanged(object sender, EventArgs e)
        {
            UserDeleteButton.Enabled = true;
            UserEditButton.Enabled = true;
        }

        private void UserDeleteButton_Click(object sender, EventArgs e)
        {
            int uid = Int32.Parse(UsersGrid.CurrentRow.Cells[0].Value.ToString());
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Project?", "Delete Project", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                users.Remove(uid);
                UsersGrid.Rows.Remove(UsersGrid.CurrentRow);

            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void UserEditButton_Click(object sender, EventArgs e)
        {

        }
    }
}
