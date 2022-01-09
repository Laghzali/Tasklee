
namespace Takliy
{
    partial class FeedForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.FeedPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PostText = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PostButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.FeedPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 33);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Feed";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.FeedPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1180, 545);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(797, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(383, 545);
            this.panel3.TabIndex = 1;
            // 
            // FeedPanel
            // 
            this.FeedPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.FeedPanel.Controls.Add(this.panel4);
            this.FeedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FeedPanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FeedPanel.Location = new System.Drawing.Point(0, 0);
            this.FeedPanel.Name = "FeedPanel";
            this.FeedPanel.Size = new System.Drawing.Size(1180, 545);
            this.FeedPanel.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.PostText);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.PostButton);
            this.panel4.Location = new System.Drawing.Point(12, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(775, 112);
            this.panel4.TabIndex = 4;
            // 
            // PostText
            // 
            this.PostText.AutoWordSelection = true;
            this.PostText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PostText.Location = new System.Drawing.Point(3, 29);
            this.PostText.Name = "PostText";
            this.PostText.Size = new System.Drawing.Size(522, 45);
            this.PostText.TabIndex = 0;
            this.PostText.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "New post";
            // 
            // PostButton
            // 
            this.PostButton.Location = new System.Drawing.Point(3, 80);
            this.PostButton.Name = "PostButton";
            this.PostButton.Size = new System.Drawing.Size(75, 23);
            this.PostButton.TabIndex = 2;
            this.PostButton.Text = "Post";
            this.PostButton.UseVisualStyleBackColor = true;
            this.PostButton.Click += new System.EventHandler(this.PostButton_Click);
            // 
            // FeedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1180, 578);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FeedForm";
            this.Text = "FeedForm";
            this.Load += new System.EventHandler(this.FeedForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.FeedPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel FeedPanel;
        private System.Windows.Forms.Button PostButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox PostText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}