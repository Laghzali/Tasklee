
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.refreshTasksButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Name_cell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Assigne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Startdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AactionsCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DeleteTaskButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
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
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 417);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_cell,
            this.Stage,
            this.Owner,
            this.Assigne,
            this.Startdate,
            this.Deadline,
            this.AactionsCheckBox});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(800, 417);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // refreshTasksButton
            // 
            this.refreshTasksButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshTasksButton.BackgroundImage = global::Takliy.Properties.Resources.refresh_button__1_;
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
            this.AactionsCheckBox.Name = "AactionsCheckBox";
            this.AactionsCheckBox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AactionsCheckBox.ToolTipText = "Select this task";
            this.AactionsCheckBox.TrueValue = "True";
            // 
            // DeleteTaskButton
            // 
            this.DeleteTaskButton.Location = new System.Drawing.Point(651, 5);
            this.DeleteTaskButton.Name = "DeleteTaskButton";
            this.DeleteTaskButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteTaskButton.TabIndex = 2;
            this.DeleteTaskButton.Text = "button2";
            this.DeleteTaskButton.UseVisualStyleBackColor = true;
            this.DeleteTaskButton.Click += new System.EventHandler(this.DeleteTaskButton_Click);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_cell;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assigne;
        private System.Windows.Forms.DataGridViewTextBoxColumn Startdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deadline;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AactionsCheckBox;
        private System.Windows.Forms.Button DeleteTaskButton;
    }
}