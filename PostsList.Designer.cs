﻿
namespace Takliy
{
    partial class PostsList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PostContent = new System.Windows.Forms.RichTextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(41, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(50, 18);
            this.UserNameLabel.TabIndex = 1;
            this.UserNameLabel.Text = "label1";
            // 
            // PostContent
            // 
            this.PostContent.BackColor = System.Drawing.Color.White;
            this.PostContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PostContent.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostContent.Location = new System.Drawing.Point(41, 33);
            this.PostContent.Name = "PostContent";
            this.PostContent.ReadOnly = true;
            this.PostContent.Size = new System.Drawing.Size(410, 47);
            this.PostContent.TabIndex = 2;
            this.PostContent.Text = "Lorem ipsum namporte de qiu";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(41, 18);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(34, 13);
            this.DateLabel.TabIndex = 3;
            this.DateLabel.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = global::Takliy.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(-1, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 10);
            this.label1.TabIndex = 4;
            // 
            // PostsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.PostContent);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(20);
            this.Name = "PostsList";
            this.Size = new System.Drawing.Size(497, 92);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.RichTextBox PostContent;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label label1;
    }
}
