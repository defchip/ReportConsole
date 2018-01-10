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
		System.Drawing.Color validColour = Color.White;
		Source source = new Source();

		public UIAddSource(QueryProvider queryProvider)
		{
			this.queryProvider = queryProvider;
			InitializeComponent();
			InitialiseFormControls();
		}

		private void InitialiseFormControls()
		{
			this.cboDatabases.Enabled = false;
			this.cmdCheckSource.Enabled = false;
			this.cmdAddSource.Enabled = false;
		}

		private void cmdFetch_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(this.txtName.Text))
			{
				MessageBox.Show("Please provide a name for the new source.");
				this.txtName.BackColor = invalidColour;
				return;
			} else
			{
				source.Name = this.txtName.Text;
				this.txtName.BackColor = validColour;
			}

			if (String.IsNullOrEmpty(this.txtServer.Text))
			{
				MessageBox.Show("Please provide a server name.");
				this.txtServer.BackColor = invalidColour;
				return;
			} else
			{
				source.Server = this.txtServer.Text;
				this.txtServer.BackColor = validColour;
			}

			source.IsIntegratedSecurity = true;

			DataTable databases = queryProvider.GetServers(source.ServerConnection());
			if (databases != null)
			{
				IList<string> dbList = new List<string>();

				foreach (DataRow item in databases.Rows)
				{
					dbList.Add(item[0].ToString());
					MessageBox.Show(item[0].ToString());

				}

				if (databases.Rows.Count > 0)
				{
					this.cboDatabases.DataSource = dbList;
					this.cboDatabases.Enabled = true;
					this.cboDatabases.SelectedIndex = -1;
				}

				this.cmdCheckSource.Enabled = true;
			}

		}

		private void cmdCheckSource_Click(object sender, EventArgs e)
		{
			//Data Source = THINKPAD; Initial Catalog = DEV_REPORT_CONSOLE_01; Integrated Security = True"

			if (String.IsNullOrEmpty(this.cboDatabases.Text))
			{
				MessageBox.Show("Please provide a database name.");
				this.cboDatabases.BackColor = invalidColour;
				return;
			} else
			{
				source.Database = this.cboDatabases.Text;
				this.cboDatabases.BackColor = validColour;
			}

			try
			{
				queryProvider.AddSource(source);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			MessageBox.Show("Source successfully added.");
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
