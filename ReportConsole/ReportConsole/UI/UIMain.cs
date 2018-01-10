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
	}
}
