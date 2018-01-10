using System;
using System.Data;
using System.Windows.Forms;

namespace ReportConsole.HelperClasses
{
	public class ListViewHelper
	{
		ListView listView;
		DataTable dataTable;

		public ListViewHelper(ListView listView, DataTable dataTable)
		{
			this.listView = listView;
			this.dataTable = dataTable;
			PopulateControl();
		}

		public void PopulateControl()
		{
			listView.Items.Clear();
			listView.Columns.Clear();

			foreach (DataColumn dc in dataTable.Columns)
			{
				this.listView.Text = dc.ColumnName;
				this.listView.Columns.Add(dc.ColumnName);
			}

			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				DataRow row = dataTable.Rows[i];
				ListViewItem listViewItem = new ListViewItem(row[0].ToString().Trim());
				for (int c = 1; c < dataTable.Columns.Count; c++)
				{
					listViewItem.SubItems.Add(row[c].ToString());
				}
				listView.Items.Add(listViewItem);
			}
		}
	}
}
