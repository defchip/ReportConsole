namespace ReportConsole.UI
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
			this.txtName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cmdFetch = new System.Windows.Forms.Button();
			this.cboDatabases = new System.Windows.Forms.ComboBox();
			this.cmdClose = new System.Windows.Forms.Button();
			this.cmdReset = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtServer
			// 
			this.txtServer.Location = new System.Drawing.Point(152, 48);
			this.txtServer.Name = "txtServer";
			this.txtServer.Size = new System.Drawing.Size(440, 26);
			this.txtServer.TabIndex = 0;
			// 
			// cmdAddSource
			// 
			this.cmdAddSource.Location = new System.Drawing.Point(152, 176);
			this.cmdAddSource.Name = "cmdAddSource";
			this.cmdAddSource.Size = new System.Drawing.Size(160, 32);
			this.cmdAddSource.TabIndex = 1;
			this.cmdAddSource.Text = "Add Source";
			this.cmdAddSource.UseVisualStyleBackColor = true;
			this.cmdAddSource.Click += new System.EventHandler(this.cmdAddSource_Click);
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(152, 8);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(440, 26);
			this.txtName.TabIndex = 3;
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
			this.label2.Location = new System.Drawing.Point(8, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "Server";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 136);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(128, 20);
			this.label3.TabIndex = 8;
			this.label3.Text = "Select Database";
			// 
			// cmdFetch
			// 
			this.cmdFetch.Location = new System.Drawing.Point(152, 88);
			this.cmdFetch.Name = "cmdFetch";
			this.cmdFetch.Size = new System.Drawing.Size(160, 32);
			this.cmdFetch.TabIndex = 10;
			this.cmdFetch.Text = "Fetch Databases";
			this.cmdFetch.UseVisualStyleBackColor = true;
			this.cmdFetch.Click += new System.EventHandler(this.cmdFetch_Click);
			// 
			// cboDatabases
			// 
			this.cboDatabases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboDatabases.FormattingEnabled = true;
			this.cboDatabases.Location = new System.Drawing.Point(152, 136);
			this.cboDatabases.Name = "cboDatabases";
			this.cboDatabases.Size = new System.Drawing.Size(440, 28);
			this.cboDatabases.TabIndex = 11;
			// 
			// cmdClose
			// 
			this.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cmdClose.Location = new System.Drawing.Point(432, 320);
			this.cmdClose.Name = "cmdClose";
			this.cmdClose.Size = new System.Drawing.Size(160, 32);
			this.cmdClose.TabIndex = 12;
			this.cmdClose.Text = "Close";
			this.cmdClose.UseVisualStyleBackColor = true;
			this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
			// 
			// cmdReset
			// 
			this.cmdReset.Location = new System.Drawing.Point(8, 320);
			this.cmdReset.Name = "cmdReset";
			this.cmdReset.Size = new System.Drawing.Size(160, 32);
			this.cmdReset.TabIndex = 13;
			this.cmdReset.Text = "Reset";
			this.cmdReset.UseVisualStyleBackColor = true;
			this.cmdReset.Click += new System.EventHandler(this.cmdReset_Click);
			// 
			// UIAddSource
			// 
			this.AcceptButton = this.cmdAddSource;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cmdClose;
			this.ClientSize = new System.Drawing.Size(603, 360);
			this.ControlBox = false;
			this.Controls.Add(this.cmdReset);
			this.Controls.Add(this.cmdClose);
			this.Controls.Add(this.cboDatabases);
			this.Controls.Add(this.cmdFetch);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.cmdAddSource);
			this.Controls.Add(this.txtServer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "UIAddSource";
			this.ShowIcon = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Add Data Source";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtServer;
		private System.Windows.Forms.Button cmdAddSource;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button cmdFetch;
		private System.Windows.Forms.ComboBox cboDatabases;
		private System.Windows.Forms.Button cmdClose;
		private System.Windows.Forms.Button cmdReset;
	}
}