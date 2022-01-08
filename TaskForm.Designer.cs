
namespace Takliy
{
    partial class TaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.TaskEditButton = new System.Windows.Forms.Button();
            this.DeleteTaskButton = new System.Windows.Forms.Button();
            this.refreshTasksButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TasksGrid = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TaskID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_cell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Assigne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Startdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AactionsCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TasksGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TaskEditButton);
            this.panel1.Controls.Add(this.DeleteTaskButton);
            this.panel1.Controls.Add(this.refreshTasksButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 33);
            this.panel1.TabIndex = 0;
            // 
            // TaskEditButton
            // 
            this.TaskEditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskEditButton.BackgroundImage = global::Takliy.Properties.Resources.edit;
            this.TaskEditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TaskEditButton.Enabled = false;
            this.TaskEditButton.FlatAppearance.BorderSize = 0;
            this.TaskEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TaskEditButton.Location = new System.Drawing.Point(669, 3);
            this.TaskEditButton.Margin = new System.Windows.Forms.Padding(0);
            this.TaskEditButton.Name = "TaskEditButton";
            this.TaskEditButton.Size = new System.Drawing.Size(31, 27);
            this.TaskEditButton.TabIndex = 3;
            this.TaskEditButton.UseVisualStyleBackColor = true;
            this.TaskEditButton.Click += new System.EventHandler(this.TaskEditButton_Click);
            // 
            // DeleteTaskButton
            // 
            this.DeleteTaskButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteTaskButton.BackgroundImage = global::Takliy.Properties.Resources.delete;
            this.DeleteTaskButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DeleteTaskButton.Enabled = false;
            this.DeleteTaskButton.FlatAppearance.BorderSize = 0;
            this.DeleteTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteTaskButton.Location = new System.Drawing.Point(700, 5);
            this.DeleteTaskButton.Margin = new System.Windows.Forms.Padding(0);
            this.DeleteTaskButton.Name = "DeleteTaskButton";
            this.DeleteTaskButton.Size = new System.Drawing.Size(25, 23);
            this.DeleteTaskButton.TabIndex = 2;
            this.DeleteTaskButton.UseVisualStyleBackColor = true;
            this.DeleteTaskButton.Click += new System.EventHandler(this.DeleteTaskButton_Click);
            // 
            // refreshTasksButton
            // 
            this.refreshTasksButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshTasksButton.BackgroundImage = global::Takliy.Properties.Resources.refresh;
            this.refreshTasksButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.refreshTasksButton.FlatAppearance.BorderSize = 0;
            this.refreshTasksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshTasksButton.Location = new System.Drawing.Point(729, 5);
            this.refreshTasksButton.Margin = new System.Windows.Forms.Padding(0);
            this.refreshTasksButton.Name = "refreshTasksButton";
            this.refreshTasksButton.Size = new System.Drawing.Size(33, 25);
            this.refreshTasksButton.TabIndex = 1;
            this.refreshTasksButton.UseVisualStyleBackColor = true;
            this.refreshTasksButton.Click += new System.EventHandler(this.refreshTasksButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tasks";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImage = global::Takliy.Properties.Resources.new_document;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(765, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 33);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TasksGrid);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 417);
            this.panel2.TabIndex = 1;
            // 
            // TasksGrid
            // 
            this.TasksGrid.AllowUserToAddRows = false;
            this.TasksGrid.AllowUserToDeleteRows = false;
            this.TasksGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TasksGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.TasksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TasksGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Project,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.TasksGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TasksGrid.Location = new System.Drawing.Point(0, 0);
            this.TasksGrid.MultiSelect = false;
            this.TasksGrid.Name = "TasksGrid";
            this.TasksGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TasksGrid.Size = new System.Drawing.Size(800, 417);
            this.TasksGrid.TabIndex = 1;
            this.TasksGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TasksGrid_CellContentDoubleClick);
            this.TasksGrid.SelectionChanged += new System.EventHandler(this.TasksGrid_SelectionChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskID,
            this.Name_cell,
            this.Stage,
            this.Owner,
            this.Assigne,
            this.Startdate,
            this.Deadline,
            this.AactionsCheckBox});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(800, 417);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TasksGrid_CellContentDoubleClick);
            // 
            // TaskID
            // 
            this.TaskID.DataPropertyName = "TaskID";
            this.TaskID.HeaderText = "TaskID";
            this.TaskID.Name = "TaskID";
            this.TaskID.ReadOnly = true;
            this.TaskID.Visible = false;
            // 
            // Name_cell
            // 
            this.Name_cell.DataPropertyName = "Name";
            this.Name_cell.FillWeight = 70F;
            this.Name_cell.HeaderText = "Name";
            this.Name_cell.Name = "Name_cell";
            this.Name_cell.ReadOnly = true;
            this.Name_cell.ToolTipText = "Task Name";
            // 
            // Stage
            // 
            this.Stage.DataPropertyName = "Stage";
            this.Stage.FillWeight = 24.50678F;
            this.Stage.HeaderText = "Stage";
            this.Stage.Name = "Stage";
            this.Stage.ReadOnly = true;
            // 
            // Owner
            // 
            this.Owner.DataPropertyName = "Owner";
            this.Owner.FillWeight = 40F;
            this.Owner.HeaderText = "Owner";
            this.Owner.Name = "Owner";
            this.Owner.ReadOnly = true;
            // 
            // Assigne
            // 
            this.Assigne.DataPropertyName = "Assigne";
            this.Assigne.FillWeight = 40F;
            this.Assigne.HeaderText = "Assigne";
            this.Assigne.Name = "Assigne";
            this.Assigne.ReadOnly = true;
            // 
            // Startdate
            // 
            this.Startdate.DataPropertyName = "Startdate";
            this.Startdate.FillWeight = 54.49638F;
            this.Startdate.HeaderText = "Start Date";
            this.Startdate.Name = "Startdate";
            this.Startdate.ReadOnly = true;
            // 
            // Deadline
            // 
            this.Deadline.DataPropertyName = "Deadline";
            this.Deadline.FillWeight = 54.49638F;
            this.Deadline.HeaderText = "Deadline";
            this.Deadline.Name = "Deadline";
            this.Deadline.ReadOnly = true;
            // 
            // AactionsCheckBox
            // 
            this.AactionsCheckBox.DataPropertyName = "AactionsCheckBox";
            this.AactionsCheckBox.FalseValue = "False";
            this.AactionsCheckBox.FillWeight = 16.46514F;
            this.AactionsCheckBox.HeaderText = "Actions";
            this.AactionsCheckBox.IndeterminateValue = "False";
            this.AactionsCheckBox.Name = "AactionsCheckBox";
            this.AactionsCheckBox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AactionsCheckBox.ToolTipText = "Select this task";
            this.AactionsCheckBox.TrueValue = "True";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TaskID";
            this.dataGridViewTextBoxColumn1.HeaderText = "TaskID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.FillWeight = 40F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.ToolTipText = "Task Name";
            // 
            // Project
            // 
            this.Project.FillWeight = 40F;
            this.Project.HeaderText = "Project";
            this.Project.Name = "Project";
            this.Project.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Stage";
            this.dataGridViewTextBoxColumn3.FillWeight = 10F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Stage";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Owner";
            this.dataGridViewTextBoxColumn4.FillWeight = 20F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Owner";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Assigne";
            this.dataGridViewTextBoxColumn5.FillWeight = 20F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Assigne";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Startdate";
            this.dataGridViewTextBoxColumn6.FillWeight = 22F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Start Date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Deadline";
            this.dataGridViewTextBoxColumn7.FillWeight = 22F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Deadline";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaskForm";
            this.Text = "TaskForm";
            this.Load += new System.EventHandler(this.TaskForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TasksGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button refreshTasksButton;
        private System.Windows.Forms.Button DeleteTaskButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_cell;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assigne;
        private System.Windows.Forms.DataGridViewTextBoxColumn Startdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deadline;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AactionsCheckBox;
        private System.Windows.Forms.Button TaskEditButton;
        private System.Windows.Forms.DataGridView TasksGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}