namespace ReportConsole.UI
{
	partial class UISelectSource
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
			this.cboSources = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmdClose = new System.Windows.Forms.Button();
			this.cmdOpenSource = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cboSources
			// 
			this.cboSources.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboSources.FormattingEnabled = true;
			this.cboSources.Location = new System.Drawing.Point(128, 8);
			this.cboSources.Name = "cboSources";
			this.cboSources.Size = new System.Drawing.Size(464, 28);
			this.cboSources.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Select Source";
			// 
			// cmdClose
			// 
			this.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cmdClose.Location = new System.Drawing.Point(432, 176);
			this.cmdClose.Name = "cmdClose";
			this.cmdClose.Size = new System.Drawing.Size(160, 32);
			this.cmdClose.TabIndex = 16;
			this.cmdClose.Text = "Close";
			this.cmdClose.UseVisualStyleBackColor = true;
			this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
			// 
			// cmdOpenSource
			// 
			this.cmdOpenSource.Location = new System.Drawing.Point(432, 48);
			this.cmdOpenSource.Name = "cmdOpenSource";
			this.cmdOpenSource.Size = new System.Drawing.Size(160, 32);
			this.cmdOpenSource.TabIndex = 17;
			this.cmdOpenSource.Text = "Open Source";
			this.cmdOpenSource.UseVisualStyleBackColor = true;
			this.cmdOpenSource.Click += new System.EventHandler(this.cmdOpenSource_Click);
			// 
			// UISelectSource
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(603, 218);
			this.ControlBox = false;
			this.Controls.Add(this.cmdOpenSource);
			this.Controls.Add(this.cmdClose);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cboSources);
			this.Name = "UISelectSource";
			this.Text = "Select Source";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cboSources;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button cmdClose;
		private System.Windows.Forms.Button cmdOpenSource;
	}
}