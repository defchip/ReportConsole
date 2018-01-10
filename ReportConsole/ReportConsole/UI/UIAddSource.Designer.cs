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
			this.txtConn = new System.Windows.Forms.TextBox();
			this.cmdAddSource = new System.Windows.Forms.Button();
			this.cmdCheckSource = new System.Windows.Forms.Button();
			this.txtName = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtConn
			// 
			this.txtConn.Location = new System.Drawing.Point(8, 40);
			this.txtConn.Name = "txtConn";
			this.txtConn.Size = new System.Drawing.Size(720, 26);
			this.txtConn.TabIndex = 0;
			// 
			// cmdAddSource
			// 
			this.cmdAddSource.Location = new System.Drawing.Point(8, 112);
			this.cmdAddSource.Name = "cmdAddSource";
			this.cmdAddSource.Size = new System.Drawing.Size(136, 32);
			this.cmdAddSource.TabIndex = 1;
			this.cmdAddSource.Text = "Add";
			this.cmdAddSource.UseVisualStyleBackColor = true;
			this.cmdAddSource.Click += new System.EventHandler(this.cmdAddSource_Click);
			// 
			// cmdCheckSource
			// 
			this.cmdCheckSource.Location = new System.Drawing.Point(8, 72);
			this.cmdCheckSource.Name = "cmdCheckSource";
			this.cmdCheckSource.Size = new System.Drawing.Size(136, 32);
			this.cmdCheckSource.TabIndex = 2;
			this.cmdCheckSource.Text = "Check";
			this.cmdCheckSource.UseVisualStyleBackColor = true;
			this.cmdCheckSource.Click += new System.EventHandler(this.cmdCheckSource_Click);
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(8, 8);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(720, 26);
			this.txtName.TabIndex = 3;
			// 
			// UIAddSource
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(737, 564);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.cmdCheckSource);
			this.Controls.Add(this.cmdAddSource);
			this.Controls.Add(this.txtConn);
			this.Name = "UIAddSource";
			this.Text = "Add Data Source";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtConn;
		private System.Windows.Forms.Button cmdAddSource;
		private System.Windows.Forms.Button cmdCheckSource;
		private System.Windows.Forms.TextBox txtName;
	}
}