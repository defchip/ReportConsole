using System;
using System.Data;

namespace ReportConsole
{
	public interface ISourceAccess
	{
		#region Method Signatures
		bool DatabaseItemExists(string query);
		bool HasOpened { get; set; }
		DataTable GetDataTable(string query);
		object GetDataItem(string query);
		string ErrMessage { get; set; }
		void ExecuteParameterisedSproc(string sprocName, object[,] fieldAndValue);
		void ExecuteSproc(string sprocName);
		string ToString();
		DataTable ExecuteSchemaQuery(string x, string y);
		#endregion
	}
}
