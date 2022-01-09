
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.FeedPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PostText = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PostButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.FeedPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 33);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.FeedPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1180, 545);
            this.panel2.TabIndex = 2;
            // 
            // FeedPanel
            // 
            this.FeedPanel.BackColor = System.Drawing.Color.White;
            this.FeedPanel.Controls.Add(this.flowLayoutPanel1);
            this.FeedPanel.Controls.Add(this.panel4);
            this.FeedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FeedPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FeedPanel.Location = new System.Drawing.Point(0, 0);
            this.FeedPanel.Name = "FeedPanel";
            this.FeedPanel.Size = new System.Drawing.Size(1180, 545);
            this.FeedPanel.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 112);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(562, 433);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.PostText);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.PostButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1180, 112);
            this.panel4.TabIndex = 4;
            // 
            // PostText
            // 
            this.PostText.AutoWordSelection = true;
            this.PostText.Location = new System.Drawing.Point(16, 32);
            this.PostText.MaxLength = 100;
            this.PostText.Name = "PostText";
            this.PostText.Size = new System.Drawing.Size(522, 42);
            this.PostText.TabIndex = 0;
            this.PostText.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "New post";
            // 
            // PostButton
            // 
            this.PostButton.Location = new System.Drawing.Point(16, 80);
            this.PostButton.Name = "PostButton";
            this.PostButton.Size = new System.Drawing.Size(75, 23);
            this.PostButton.TabIndex = 2;
            this.PostButton.Text = "Post";
            this.PostButton.UseVisualStyleBackColor = true;
            this.PostButton.Click += new System.EventHandler(this.PostButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Feed";
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel FeedPanel;
        private System.Windows.Forms.Button PostButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox PostText;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
    }
}