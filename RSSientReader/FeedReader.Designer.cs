namespace RSSientReader
{
    partial class FeedReader
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
            this.FeedsTreeView = new System.Windows.Forms.TreeView();
            this.feedText = new System.Windows.Forms.TextBox();
            this.feedPicture = new System.Windows.Forms.PictureBox();
            this.feedCaption = new System.Windows.Forms.TextBox();
            this.feedPublicationDate = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setFeedsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.feedPicture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FeedsTreeView
            // 
            this.FeedsTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FeedsTreeView.Location = new System.Drawing.Point(0, 0);
            this.FeedsTreeView.Margin = new System.Windows.Forms.Padding(4);
            this.FeedsTreeView.Name = "FeedsTreeView";
            this.FeedsTreeView.Size = new System.Drawing.Size(355, 507);
            this.FeedsTreeView.TabIndex = 0;
            this.FeedsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.FeedsTreeView_AfterSelect);
            // 
            // feedText
            // 
            this.feedText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.feedText.Dock = System.Windows.Forms.DockStyle.Right;
            this.feedText.Location = new System.Drawing.Point(794, 30);
            this.feedText.Margin = new System.Windows.Forms.Padding(4);
            this.feedText.Multiline = true;
            this.feedText.Name = "feedText";
            this.feedText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.feedText.Size = new System.Drawing.Size(273, 524);
            this.feedText.TabIndex = 1;
            // 
            // feedPicture
            // 
            this.feedPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.feedPicture.Location = new System.Drawing.Point(4, 0);
            this.feedPicture.Margin = new System.Windows.Forms.Padding(4);
            this.feedPicture.Name = "feedPicture";
            this.feedPicture.Size = new System.Drawing.Size(359, 217);
            this.feedPicture.TabIndex = 2;
            this.feedPicture.TabStop = false;
            // 
            // feedCaption
            // 
            this.feedCaption.Location = new System.Drawing.Point(4, 235);
            this.feedCaption.Margin = new System.Windows.Forms.Padding(4);
            this.feedCaption.Multiline = true;
            this.feedCaption.Name = "feedCaption";
            this.feedCaption.Size = new System.Drawing.Size(364, 50);
            this.feedCaption.TabIndex = 3;
            // 
            // feedPublicationDate
            // 
            this.feedPublicationDate.Location = new System.Drawing.Point(4, 293);
            this.feedPublicationDate.Margin = new System.Windows.Forms.Padding(4);
            this.feedPublicationDate.Name = "feedPublicationDate";
            this.feedPublicationDate.Size = new System.Drawing.Size(367, 22);
            this.feedPublicationDate.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setFeedsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 30);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // setFeedsToolStripMenuItem
            // 
            this.setFeedsToolStripMenuItem.Name = "setFeedsToolStripMenuItem";
            this.setFeedsToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.setFeedsToolStripMenuItem.Text = "Set feeds";
            this.setFeedsToolStripMenuItem.Click += new System.EventHandler(this.setFeedsToolStripMenuItem_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linkLabel1.Location = new System.Drawing.Point(0, 507);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(60, 17);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Visit site";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(12, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(359, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Refresh feeeds";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 30);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.FeedsTreeView);
            this.splitContainer1.Panel1.Controls.Add(this.linkLabel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.feedPicture);
            this.splitContainer1.Panel2.Controls.Add(this.feedCaption);
            this.splitContainer1.Panel2.Controls.Add(this.feedPublicationDate);
            this.splitContainer1.Size = new System.Drawing.Size(1067, 524);
            this.splitContainer1.SplitterDistance = 355;
            this.splitContainer1.TabIndex = 8;
            // 
            // FeedReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.feedText);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FeedReader";
            this.Text = "Feed reader";
            ((System.ComponentModel.ISupportInitialize)(this.feedPicture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView FeedsTreeView;
        private System.Windows.Forms.TextBox feedText;
        private System.Windows.Forms.PictureBox feedPicture;
        private System.Windows.Forms.TextBox feedCaption;
        private System.Windows.Forms.TextBox feedPublicationDate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setFeedsToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

