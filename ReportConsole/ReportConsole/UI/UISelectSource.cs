using ReportConsole.BusinessObjects;
using ReportConsole.HelperClasses;
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
	public partial class UISelectSource : Form
	{
		QueryProvider queryProvider;
		Source source;
		System.Drawing.Color invalidColour = Color.Yellow;
		System.Drawing.Color validColour = Color.White;

		public UISelectSource(QueryProvider queryProvider)
		{
			this.queryProvider = queryProvider;
			InitializeComponent();
			InitialiseFormControls();
		}

		private void InitialiseFormControls()
		{
			source = null;
			PopulateSources();
			this.cmdOpenSource.Enabled = false;
		}

		private void PopulateSources()
		{
			DataTable data = queryProvider.GetSources();
			ComboBoxHelper cbo = new ComboBoxHelper(this.cboSources, data);
			this.cboSources.SelectedIndex = -1;
		}

		private void cmdReset_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(this.cboSources.Text = null))
			{
				MessageBox.Show("Please select a source.");
				this.cboSources.BackColor = invalidColour;
				return;
			}
		}

		private void cmdClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
