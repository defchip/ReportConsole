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

		}

		private void addSourceToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			
		}

		private void addReportToolStripMenuItem_Click(object sender, System.EventArgs e)
		{

		}

		private void editReportToolStripMenuItem_Click(object sender, System.EventArgs e)
		{

		}
	}
}
