using ReportConsole.BusinessObjects;
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



		//Sample method illustrating use of generic parameterised stored procedure method
		//in data access layer
		public void AddSource(Source source)
		{
			dataAccess.ExecuteParameterisedSproc("USP_INS_SOURCE",
				new object[,]{
				{"SOURCE_NAME",source.SourceName },
				{"SOURCE_CONN",source.SourceConn}});
		}
	}
}
