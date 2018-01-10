﻿namespace ReportConsole.UI
{
	partial class UIAddSource
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
			this.txtServer = new System.Windows.Forms.TextBox();
			this.cmdAddSource = new System.Windows.Forms.Button();
			this.cmdCheckSource = new System.Windows.Forms.Button();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtDatabase = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtServer
			// 
			this.txtServer.Location = new System.Drawing.Point(152, 40);
			this.txtServer.Name = "txtServer";
			this.txtServer.Size = new System.Drawing.Size(576, 26);
			this.txtServer.TabIndex = 0;
			// 
			// cmdAddSource
			// 
			this.cmdAddSource.Location = new System.Drawing.Point(592, 144);
			this.cmdAddSource.Name = "cmdAddSource";
			this.cmdAddSource.Size = new System.Drawing.Size(136, 32);
			this.cmdAddSource.TabIndex = 1;
			this.cmdAddSource.Text = "Add";
			this.cmdAddSource.UseVisualStyleBackColor = true;
			this.cmdAddSource.Click += new System.EventHandler(this.cmdAddSource_Click);
			// 
			// cmdCheckSource
			// 
			this.cmdCheckSource.Location = new System.Drawing.Point(592, 104);
			this.cmdCheckSource.Name = "cmdCheckSource";
			this.cmdCheckSource.Size = new System.Drawing.Size(136, 32);
			this.cmdCheckSource.TabIndex = 2;
			this.cmdCheckSource.Text = "Check";
			this.cmdCheckSource.UseVisualStyleBackColor = true;
			this.cmdCheckSource.Click += new System.EventHandler(this.cmdCheckSource_Click);
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(152, 8);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(576, 26);
			this.txtName.TabIndex = 3;
			// 
			// txtDatabase
			// 
			this.txtDatabase.Location = new System.Drawing.Point(152, 72);
			this.txtDatabase.Name = "txtDatabase";
			this.txtDatabase.Size = new System.Drawing.Size(576, 26);
			this.txtDatabase.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 20);
			this.label1.TabIndex = 6;
			this.label1.Text = "Source Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "Server";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 20);
			this.label3.TabIndex = 8;
			this.label3.Text = "Database";
			// 
			// UIAddSource
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(737, 564);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtDatabase);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.cmdCheckSource);
			this.Controls.Add(this.cmdAddSource);
			this.Controls.Add(this.txtServer);
			this.Name = "UIAddSource";
			this.Text = "Add Data Source";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtServer;
		private System.Windows.Forms.Button cmdAddSource;
		private System.Windows.Forms.Button cmdCheckSource;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtDatabase;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}