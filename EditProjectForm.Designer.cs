
namespace Takliy
{
    partial class EditProjectForm
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
            this.EditProjectButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LeaderComboBoxEdit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProjectNaneInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EditProjectButton
            // 
            this.EditProjectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(187)))), ((int)(((byte)(134)))));
            this.EditProjectButton.FlatAppearance.BorderSize = 0;
            this.EditProjectButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.EditProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditProjectButton.Location = new System.Drawing.Point(238, 203);
            this.EditProjectButton.Margin = new System.Windows.Forms.Padding(4);
            this.EditProjectButton.Name = "EditProjectButton";
            this.EditProjectButton.Size = new System.Drawing.Size(88, 28);
            this.EditProjectButton.TabIndex = 17;
            this.EditProjectButton.Text = "Done";
            this.EditProjectButton.UseVisualStyleBackColor = false;
            this.EditProjectButton.Click += new System.EventHandler(this.EditProjectButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato Semibold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Leader";
            // 
            // LeaderComboBoxEdit
            // 
            this.LeaderComboBoxEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LeaderComboBoxEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LeaderComboBoxEdit.Font = new System.Drawing.Font("Lato Semibold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaderComboBoxEdit.FormattingEnabled = true;
            this.LeaderComboBoxEdit.Location = new System.Drawing.Point(238, 132);
            this.LeaderComboBoxEdit.Margin = new System.Windows.Forms.Padding(4);
            this.LeaderComboBoxEdit.Name = "LeaderComboBoxEdit";
            this.LeaderComboBoxEdit.Size = new System.Drawing.Size(197, 24);
            this.LeaderComboBoxEdit.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato Semibold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Project Name";
            // 
            // ProjectNaneInput
            // 
            this.ProjectNaneInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectNaneInput.BackColor = System.Drawing.SystemColors.Window;
            this.ProjectNaneInput.Font = new System.Drawing.Font("Lato Semibold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectNaneInput.Location = new System.Drawing.Point(238, 79);
            this.ProjectNaneInput.Margin = new System.Windows.Forms.Padding(0);
            this.ProjectNaneInput.Name = "ProjectNaneInput";
            this.ProjectNaneInput.ShortcutsEnabled = false;
            this.ProjectNaneInput.Size = new System.Drawing.Size(363, 23);
            this.ProjectNaneInput.TabIndex = 13;
            // 
            // EditProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 278);
            this.Controls.Add(this.EditProjectButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LeaderComboBoxEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProjectNaneInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditProjectForm";
            this.Text = "EditProjectForm";
            this.Load += new System.EventHandler(this.EditProjectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditProjectButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox LeaderComboBoxEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProjectNaneInput;
    }
}