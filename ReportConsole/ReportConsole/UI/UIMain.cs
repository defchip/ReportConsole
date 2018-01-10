using System.Windows.Forms;

namespace ReportConsole.UI
{
	public partial class UIMain : Form
	{
		QueryProvider queryProvider;

		public UIMain(QueryProvider queryProvider)
		{
			InitializeComponent();
			this.queryProvider = queryProvider;
		}



		private void selectSourceToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			Form selectSource = new UISelectSource(queryProvider);
			if (selectSource != null)
			{
				selectSource.ShowDialog();
			}
		}

		private void addSourceToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			Form addSource = new UIAddSource(queryProvider);
			if (addSource != null)
			{
				addSource.ShowDialog();
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
