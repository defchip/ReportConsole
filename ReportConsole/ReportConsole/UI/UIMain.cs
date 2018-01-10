using ReportConsole.BusinessObjects;
using System.Windows.Forms;

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
