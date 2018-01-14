using System;
using System.Data;
using System.Threading.Tasks;

namespace ReportConsole
{
	public interface IDataAccess
	{
		#region Method Signatures
		bool DatabaseItemExists(string query);
		bool HasOpened { get; set; }

		Task<DataTable> GetDataTableAsync(string query);
		DataTable GetDataTable(string query);

		Task<object> GetDataItemAsync(string query);
		object GetDataItem(string query);

		void ExecuteSprocAsync(string sprocName);
		void ExecuteSproc(string sprocName);

		void ExecuteParameterisedSprocAsync(string sprocName, object[,] fieldAndValue);
		void ExecuteParameterisedSproc(string sprocName, object[,] fieldAndValue);

		string ErrMessage { get; set; }
		string ToString();

		DataTable ExecuteSchemaQuery(string query, string conn);
		#endregion
	}
}