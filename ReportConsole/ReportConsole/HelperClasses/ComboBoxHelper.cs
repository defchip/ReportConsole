using System;
using System.Data;
using System.Windows.Forms;

namespace ReportConsole.HelperClasses
{
	/// <summary>
	/// Populates a WinForms combobox with data from a System.Data.DataTable.
	/// </summary>
	public class ComboBoxHelper
	{
		ComboBox cbo;
		DataTable datatable;

		public ComboBoxHelper(ComboBox cbo, DataTable datatable)
		{
			this.cbo = cbo;
			this.datatable = datatable;
			PopulateControl();
		}

		public void PopulateControl()
		{
			cbo.DataSource = datatable;
			foreach (DataColumn c in datatable.Columns)
			{
				switch (c.Ordinal)
				{
					case 0:
						cbo.ValueMember = c.ColumnName;
						break;
					case 1:
						cbo.DisplayMember = c.ColumnName;
						break;
					default:
						break;
				}
			}
		}
	}
}

