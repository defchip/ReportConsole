using ReportConsole.BusinessObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportConsole.UI
{
	public partial class UIAddSource : Form
	{
		QueryProvider queryProvider;
		string sourceName, sourceConn;
		System.Drawing.Color invalidColour = Color.Yellow;

		public UIAddSource(QueryProvider queryProvider)
		{
			this.queryProvider = queryProvider;
			InitializeComponent();
		}

		private void cmdCheckSource_Click(object sender, EventArgs e)
		{
			//Data Source = THINKPAD; Initial Catalog = DEV_REPORT_CONSOLE_01; Integrated Security = True"

			if (String.IsNullOrEmpty(this.txtName.Text))
			{
				MessageBox.Show("Please provide a name for the new source.");
				this.txtName.BackColor = invalidColour;
				return;
			}
			if (String.IsNullOrEmpty(this.txtServer.Text))
			{
				MessageBox.Show("Please provide a server name.");
				this.txtServer.BackColor = invalidColour;
				return;
			}
			if (String.IsNullOrEmpty(this.txtDatabase.Text))
			{
				MessageBox.Show("Please provide a database name.");
				this.txtDatabase.BackColor = invalidColour;
				return;
			}

			var source = new Source();

			source.Name = this.txtName.Text;
			source.Server = this.txtServer.Text;
			source.Database = this.txtDatabase.Text;

			try
			{
				queryProvider.AddSource(source);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void cmdAddSource_Click(object sender, EventArgs e)
		{
			var data = queryProvider.GetData();

			foreach (var item in data.Columns)
			{
				MessageBox.Show(item.ToString());
			}

		}
	}
}
