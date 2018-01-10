namespace ReportConsole.UI
{
	partial class UIMain
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.panel1 = new System.Windows.Forms.Panel();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.selectSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(961, 33);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.treeView1);
			this.panel1.Location = new System.Drawing.Point(0, 40);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(960, 600);
			this.panel1.TabIndex = 1;
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(0, 0);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(960, 600);
			this.treeView1.TabIndex = 0;
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectSourceToolStripMenuItem,
            this.addSourceToolStripMenuItem,
            this.addReportToolStripMenuItem,
            this.editReportToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(66, 29);
			this.toolStripMenuItem1.Text = "Edit...";
			// 
			// selectSourceToolStripMenuItem
			// 
			this.selectSourceToolStripMenuItem.Name = "selectSourceToolStripMenuItem";
			this.selectSourceToolStripMenuItem.Size = new System.Drawing.Size(213, 30);
			this.selectSourceToolStripMenuItem.Text = "Select Source...";
			this.selectSourceToolStripMenuItem.Click += new System.EventHandler(this.selectSourceToolStripMenuItem_Click);
			// 
			// addSourceToolStripMenuItem
			// 
			this.addSourceToolStripMenuItem.Name = "addSourceToolStripMenuItem";
			this.addSourceToolStripMenuItem.Size = new System.Drawing.Size(213, 30);
			this.addSourceToolStripMenuItem.Text = "Add Source...";
			this.addSourceToolStripMenuItem.Click += new System.EventHandler(this.addSourceToolStripMenuItem_Click);
			// 
			// addReportToolStripMenuItem
			// 
			this.addReportToolStripMenuItem.Name = "addReportToolStripMenuItem";
			this.addReportToolStripMenuItem.Size = new System.Drawing.Size(213, 30);
			this.addReportToolStripMenuItem.Text = "Add Report...";
			this.addReportToolStripMenuItem.Click += new System.EventHandler(this.addReportToolStripMenuItem_Click);
			// 
			// editReportToolStripMenuItem
			// 
			this.editReportToolStripMenuItem.Name = "editReportToolStripMenuItem";
			this.editReportToolStripMenuItem.Size = new System.Drawing.Size(213, 30);
			this.editReportToolStripMenuItem.Text = "Edit Report...";
			this.editReportToolStripMenuItem.Click += new System.EventHandler(this.editReportToolStripMenuItem_Click);
			// 
			// UIMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(961, 637);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "UIMain";
			this.Text = "Report Console";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem selectSourceToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addSourceToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addReportToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editReportToolStripMenuItem;
	}
}