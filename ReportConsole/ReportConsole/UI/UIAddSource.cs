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

		public UIAddSource(QueryProvider queryProvider)
		{
			this.queryProvider = queryProvider;
			InitializeComponent();
		}

		private void cmdCheckSource_Click(object sender, EventArgs e)
		{
			this.sourceName = this.txtName.Text;
			this.sourceConn = this.txtConn.Text;

			var source = new Source();
			source.SourceName = sourceName;
			source.SourceConn = sourceConn;


			if (String.IsNullOrEmpty(sourceName))
			{
				return;
			}
			if (String.IsNullOrEmpty(sourceConn))
			{
				return;
			}

			queryProvider.AddSource(source);
		}

		private void cmdAddSource_Click(object sender, EventArgs e)
		{

		}
	}
}
