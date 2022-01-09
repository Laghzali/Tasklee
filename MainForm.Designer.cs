
namespace Takliy
{
    partial class MainForm
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
            this.headerPanel = new System.Windows.Forms.Panel();
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tasksButton = new System.Windows.Forms.Button();
            this.dashButton = new System.Windows.Forms.Button();
            this.sidebarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1455, 50);
            this.headerPanel.TabIndex = 0;
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sidebarPanel.Controls.Add(this.button1);
            this.sidebarPanel.Controls.Add(this.tasksButton);
            this.sidebarPanel.Controls.Add(this.dashButton);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 50);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(176, 755);
            this.sidebarPanel.TabIndex = 1;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(176, 50);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1279, 755);
            this.mainPanel.TabIndex = 2;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Image = global::Takliy.Properties.Resources.settings;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "PROJECTS";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tasksButton
            // 
            this.tasksButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tasksButton.FlatAppearance.BorderSize = 0;
            this.tasksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tasksButton.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasksButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tasksButton.Image = global::Takliy.Properties.Resources.task2;
            this.tasksButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tasksButton.Location = new System.Drawing.Point(3, 168);
            this.tasksButton.Name = "tasksButton";
            this.tasksButton.Size = new System.Drawing.Size(173, 48);
            this.tasksButton.TabIndex = 2;
            this.tasksButton.Text = "TASKS";
            this.tasksButton.UseVisualStyleBackColor = true;
            this.tasksButton.Click += new System.EventHandler(this.tasksButton_Click);
            // 
            // dashButton
            // 
            this.dashButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dashButton.FlatAppearance.BorderSize = 0;
            this.dashButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashButton.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dashButton.Image = global::Takliy.Properties.Resources.feedback3;
            this.dashButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashButton.Location = new System.Drawing.Point(0, 60);
            this.dashButton.Name = "dashButton";
            this.dashButton.Size = new System.Drawing.Size(182, 48);
            this.dashButton.TabIndex = 0;
            this.dashButton.Text = "FEED";
            this.dashButton.UseVisualStyleBackColor = true;
            this.dashButton.Click += new System.EventHandler(this.dashButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 805);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taskly";
            this.sidebarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button dashButton;
        private System.Windows.Forms.Button tasksButton;
        private System.Windows.Forms.Button button1;
    }
}

