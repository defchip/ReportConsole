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

		private int _sourceId;

		public int SourceId { get { return _sourceId; } set { _sourceId = value; } }

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
			PopulateSources();
		}

		private void PopulateSources()
		{
			DataTable data = queryProvider.GetSources();
			ComboBoxHelper cbo = new ComboBoxHelper(this.cboSources, data);
			this.cboSources.SelectedIndex = -1;
		}


		private void cmdClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cmdOpenSource_Click(object sender, EventArgs e)
		{
			if (this.cboSources.SelectedItem == null)
			{
				MessageBox.Show("Please select a source.");
				this.cboSources.BackColor = invalidColour;
				return;
			}
			else
			{
				this.cboSources.BackColor = validColour;
			}

			MessageBox.Show("Source Selected.");

			_sourceId = (int)this.cboSources.SelectedValue;

			this.Close();
		}


	}
}
