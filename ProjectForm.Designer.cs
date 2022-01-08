
namespace Takliy
{
    partial class ProjectForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProjectEditButton = new System.Windows.Forms.Button();
            this.ProjectDeleteButton = new System.Windows.Forms.Button();
            this.ProjectRefreshButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ProjectNewButton = new System.Windows.Forms.Button();
            this.ProjectsGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tasks = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ProjectEditButton);
            this.panel1.Controls.Add(this.ProjectDeleteButton);
            this.panel1.Controls.Add(this.ProjectRefreshButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ProjectNewButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 33);
            this.panel1.TabIndex = 1;
            // 
            // ProjectEditButton
            // 
            this.ProjectEditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectEditButton.BackgroundImage = global::Takliy.Properties.Resources.edit;
            this.ProjectEditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ProjectEditButton.Enabled = false;
            this.ProjectEditButton.FlatAppearance.BorderSize = 0;
            this.ProjectEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProjectEditButton.Location = new System.Drawing.Point(669, 3);
            this.ProjectEditButton.Margin = new System.Windows.Forms.Padding(0);
            this.ProjectEditButton.Name = "ProjectEditButton";
            this.ProjectEditButton.Size = new System.Drawing.Size(31, 27);
            this.ProjectEditButton.TabIndex = 3;
            this.ProjectEditButton.UseVisualStyleBackColor = true;
            // 
            // ProjectDeleteButton
            // 
            this.ProjectDeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectDeleteButton.BackgroundImage = global::Takliy.Properties.Resources.delete;
            this.ProjectDeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ProjectDeleteButton.Enabled = false;
            this.ProjectDeleteButton.FlatAppearance.BorderSize = 0;
            this.ProjectDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProjectDeleteButton.Location = new System.Drawing.Point(700, 5);
            this.ProjectDeleteButton.Margin = new System.Windows.Forms.Padding(0);
            this.ProjectDeleteButton.Name = "ProjectDeleteButton";
            this.ProjectDeleteButton.Size = new System.Drawing.Size(25, 23);
            this.ProjectDeleteButton.TabIndex = 2;
            this.ProjectDeleteButton.UseVisualStyleBackColor = true;
            // 
            // ProjectRefreshButton
            // 
            this.ProjectRefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectRefreshButton.BackgroundImage = global::Takliy.Properties.Resources.refresh;
            this.ProjectRefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ProjectRefreshButton.FlatAppearance.BorderSize = 0;
            this.ProjectRefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProjectRefreshButton.Location = new System.Drawing.Point(729, 5);
            this.ProjectRefreshButton.Margin = new System.Windows.Forms.Padding(0);
            this.ProjectRefreshButton.Name = "ProjectRefreshButton";
            this.ProjectRefreshButton.Size = new System.Drawing.Size(33, 25);
            this.ProjectRefreshButton.TabIndex = 1;
            this.ProjectRefreshButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Projects";
            // 
            // ProjectNewButton
            // 
            this.ProjectNewButton.BackColor = System.Drawing.SystemColors.Control;
            this.ProjectNewButton.BackgroundImage = global::Takliy.Properties.Resources.new_document;
            this.ProjectNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ProjectNewButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ProjectNewButton.FlatAppearance.BorderSize = 0;
            this.ProjectNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProjectNewButton.Location = new System.Drawing.Point(765, 0);
            this.ProjectNewButton.Name = "ProjectNewButton";
            this.ProjectNewButton.Size = new System.Drawing.Size(35, 33);
            this.ProjectNewButton.TabIndex = 0;
            this.ProjectNewButton.UseVisualStyleBackColor = false;
            this.ProjectNewButton.Click += new System.EventHandler(this.ProjectNewButton_Click);
            // 
            // ProjectsGrid
            // 
            this.ProjectsGrid.AllowUserToAddRows = false;
            this.ProjectsGrid.AllowUserToDeleteRows = false;
            this.ProjectsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProjectsGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ProjectsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.ProjectsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lato Semibold", 9.749999F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProjectsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProjectsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjectsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.Tasks});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lato Semibold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProjectsGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProjectsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectsGrid.Location = new System.Drawing.Point(0, 33);
            this.ProjectsGrid.MultiSelect = false;
            this.ProjectsGrid.Name = "ProjectsGrid";
            this.ProjectsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProjectsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            this.ProjectsGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ProjectsGrid.RowTemplate.Height = 30;
            this.ProjectsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProjectsGrid.Size = new System.Drawing.Size(800, 417);
            this.ProjectsGrid.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProjectID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProjectID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.FillWeight = 70F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.ToolTipText = "Task Name";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ProjectLeader";
            this.dataGridViewTextBoxColumn4.FillWeight = 70F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Project leader";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Tasks
            // 
            this.Tasks.FillWeight = 15F;
            this.Tasks.HeaderText = "Tasks";
            this.Tasks.Name = "Tasks";
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProjectsGrid);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProjectForm";
            this.Text = "ProjectForm";
            this.Load += new System.EventHandler(this.ProjectForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ProjectEditButton;
        private System.Windows.Forms.Button ProjectDeleteButton;
        private System.Windows.Forms.Button ProjectRefreshButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ProjectNewButton;
        private System.Windows.Forms.DataGridView ProjectsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewButtonColumn Tasks;
    }
}