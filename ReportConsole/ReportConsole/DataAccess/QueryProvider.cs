using System.Data;
using System.Threading.Tasks;
using ReportConsole.BusinessObjects;

namespace ReportConsole
{
	public class QueryProvider
	{
		IDataAccess dataAccess;

		public QueryProvider(IDataAccess dataAccess)
		{
			this.dataAccess = dataAccess;
		}

		public async Task<DataTable> GetData()
		{
			string query = "SELECT * FROM SOURCES";
			return await dataAccess.GetDataTableAsync(query);
		}

		public async Task<DataTable> GetSources()
		{
			string query = "SELECT * FROM SOURCES";
			//DataTable data = await dataAccess.GetDataTableAsync(query);
			return await dataAccess.GetDataTableAsync(query);
		}

		public async Task<DataTable> GetSource(int sourceId)
		{
			string query = "SELECT * FROM SOURCES WHERE SOURCE_ID = " + sourceId.ToString();
			return await dataAccess.GetDataTableAsync(query);
		}


		//Sample method illustrating use of generic parameterised stored procedure method
		//in data access layer
		public void AddSource(Source source)
		{
			dataAccess.ExecuteParameterisedSprocAsync("USP_INS_SOURCE",
				new object[,]{
				{"SOURCE_NAME",source.Name },
				{"SOURCE_CONN",source.DatabaseConnection()} });
		}

		public DataTable GetServers(string conn)
		{
			string query = "select name from sys.databases WHERE database_id > 4";
			return dataAccess.ExecuteSchemaQuery(query, conn);
		}

	}
}
//select name from sys.databases WHERE database_id > 4