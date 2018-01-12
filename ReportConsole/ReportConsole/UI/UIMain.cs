using ReportConsole.BusinessObjects;
using System.Data;
using System.Windows.Forms;
using System;

namespace ReportConsole.UI
{
	public partial class UIMain : Form
	{
		QueryProvider queryProvider;
		int sourceId;

		public UIMain(QueryProvider queryProvider)
		{
			InitializeComponent();
			this.queryProvider = queryProvider;
		}



		private void selectSourceToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			using (UISelectSource selectSource = new UISelectSource(queryProvider))
			{
				if (selectSource != null)
				{
					selectSource.ShowDialog();
					sourceId = selectSource.SourceId;
				}
			}

			InitialiseSource();
		}

		private async void InitialiseSource()
		{
			DataTable data = await queryProvider.GetSource(sourceId);
			string sourceName = data.Rows[0][1].ToString();
			this.toolStripStatusLabel1.Text = sourceName;
			statusStrip.Refresh();
		}

		private void addSourceToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			using (UIAddSource addSource = new UIAddSource(queryProvider))
			{
				;
				if (addSource != null)
				{
					addSource.ShowDialog();
				}
			}
		}

		private void addReportToolStripMenuItem_Click(object sender, System.EventArgs e)
		{

		}

		private void editReportToolStripMenuItem_Click(object sender, System.EventArgs e)
		{

		}
	}
}
