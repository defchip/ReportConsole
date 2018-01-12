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
		Task<object> GetDataItemAsync(string query);
		string ErrMessage { get; set; }
		void ExecuteParameterisedSprocAsync(string sprocName, object[,] fieldAndValue);
		void ExecuteSproc(string sprocName);
		string ToString();
		DataTable ExecuteSchemaQuery(string query, string conn);
		#endregion
	}
}