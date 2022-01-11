
namespace Takliy
{
    partial class AddProjectForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.ProjectNaneInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LeaderComboBox = new System.Windows.Forms.ComboBox();
            this.AddProjectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Project Name";
            // 
            // ProjectNaneInput
            // 
            this.ProjectNaneInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectNaneInput.BackColor = System.Drawing.SystemColors.Window;
            this.ProjectNaneInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectNaneInput.Location = new System.Drawing.Point(235, 98);
            this.ProjectNaneInput.Margin = new System.Windows.Forms.Padding(0);
            this.ProjectNaneInput.Name = "ProjectNaneInput";
            this.ProjectNaneInput.ShortcutsEnabled = false;
            this.ProjectNaneInput.Size = new System.Drawing.Size(373, 22);
            this.ProjectNaneInput.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Leader";
            // 
            // LeaderComboBox
            // 
            this.LeaderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LeaderComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LeaderComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaderComboBox.FormattingEnabled = true;
            this.LeaderComboBox.Location = new System.Drawing.Point(235, 151);
            this.LeaderComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.LeaderComboBox.Name = "LeaderComboBox";
            this.LeaderComboBox.Size = new System.Drawing.Size(197, 24);
            this.LeaderComboBox.TabIndex = 10;
            // 
            // AddProjectButton
            // 
            this.AddProjectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(187)))), ((int)(((byte)(134)))));
            this.AddProjectButton.FlatAppearance.BorderSize = 0;
            this.AddProjectButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AddProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProjectButton.Location = new System.Drawing.Point(235, 222);
            this.AddProjectButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddProjectButton.Name = "AddProjectButton";
            this.AddProjectButton.Size = new System.Drawing.Size(88, 28);
            this.AddProjectButton.TabIndex = 12;
            this.AddProjectButton.Text = "Done";
            this.AddProjectButton.UseVisualStyleBackColor = false;
            this.AddProjectButton.Click += new System.EventHandler(this.AddProjectButton_Click);
            // 
            // AddProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(648, 292);
            this.Controls.Add(this.AddProjectButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LeaderComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProjectNaneInput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Project";
            this.Load += new System.EventHandler(this.AddProjectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProjectNaneInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox LeaderComboBox;
        private System.Windows.Forms.Button AddProjectButton;
    }
}