using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportConsole
{
	public class QueryProvider
	{
		IDataAccess dataAccess;

		public QueryProvider(IDataAccess dataAccess)
		{
			this.dataAccess = dataAccess;
		}

		public DataTable GetData()
		{
			string query = "";
			return dataAccess.GetDataTable(query);
		}
	}
}
