#region Using Directives
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
#endregion

namespace ReportConsole
{
	/// <summary>
	/// Assembly implements ADO.NET database access methods to SQL database. 
	/// </summary>
	public class DataAccess : IDataAccess
	{
		#region class-level declarations
		private bool hasOpened = true;
		private string errMessage;
		private readonly string DATA_CONNECTION_STRING;
		IDictionary<System.Type, DbType> typeDict = new Dictionary<System.Type, DbType>();
		#endregion
		public bool HasOpened
		{
			get { return hasOpened; }
			set { hasOpened = value; }
		}
		public string ErrMessage
		{
			get { return errMessage; }
			set { errMessage = value; }
		}
		/// <summary>
		/// Show connection string.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return DATA_CONNECTION_STRING;
		}
		/// <summary>
		/// Implements ADO.NET database access methods to SQL database. 
		/// </summary>
		/// <param name="connectionString"></param>
		/// <param name="loginRejectedMessage"></param>
		/// <param name="serverInaccessibleMessage"></param>
		public DataAccess(string connectionString)
		{
			typeDict.Add(typeof(String), DbType.AnsiString);
			typeDict.Add(typeof(DateTime), DbType.DateTime2);
			typeDict.Add(typeof(Int32), DbType.Int32);
			DATA_CONNECTION_STRING = connectionString;
			using (SqlConnection cnData = new SqlConnection(DATA_CONNECTION_STRING))
				try
				{
					cnData.Open();
					if (cnData != null)
					{
						cnData.Close();
					}
				}
				catch (SqlException sx)
				{
					this.hasOpened = false;
					switch (sx.Number)
					{
						case 4060:
							errMessage = "Sorry, the application could not validate user access to the database. Contact your administrator.";
							break;
						case -1:
							errMessage = "Sorry, the application could not establish a connection to the database. Contact your administrator.";
							break;
						default:
							errMessage = "Application Error. Please contact an administrator. " + Environment.NewLine +
							"SqlException Number: " + sx.Number + Environment.NewLine +
							"SqlException Message: " + sx.Message + Environment.NewLine +
							"SqlException State: " + sx.State + Environment.NewLine +
							"SqlException TargetSite: " + sx.TargetSite + Environment.NewLine +
							"SqlException Server: " + sx.Server + Environment.NewLine +
							"SqlException ErrorCode: " + sx.ErrorCode + Environment.NewLine +
							"SqlException Source: " + sx.Source;
							break;
					}
				}
		}
		/// <summary>
		/// Returns a System.Data.DataTable.
		/// </summary>
		/// <param name="query">SQL SELECT query.</param>
		/// <returns></returns>
		public DataTable GetDataTable(string query)
		{
			using (DataTable dt = new DataTable())
			using (SqlConnection cnData = new SqlConnection(DATA_CONNECTION_STRING))
			using (SqlCommand cmd = new SqlCommand(query, cnData))
			{
				try
				{
					cnData.Open();
					dt.Load(cmd.ExecuteReader());
					if (cnData != null)
					{
						cnData.Close();
					}
					return dt;
				}
				catch
				{
					throw;
				}
			}
		}
		/// <summary>
		/// Returns a database value cast as an object.
		/// </summary>
		/// <param name="query">SQL SELECT query.</param>
		/// <returns></returns>
		public object GetDataItem(string query)
		{
			using (SqlConnection cnData = new SqlConnection(DATA_CONNECTION_STRING))
			using (SqlCommand cmd = new SqlCommand(query, cnData))
			{
				try
				{
					cnData.Open();
					object item = cmd.ExecuteScalar();
					if (cnData != null)
					{
						cnData.Close();
					}
					return item;
				}
				catch
				{
					throw;
				}
			}
		}
		/// <summary>
		/// Returns true when query fetches a non-null value.
		/// </summary>
		/// <param name="query">SQL SELECT query.</param>
		/// <returns></returns>
		public bool DatabaseItemExists(string query)
		{
			using (SqlConnection cnData = new SqlConnection(DATA_CONNECTION_STRING))
			using (SqlCommand cmd = new SqlCommand(query, cnData))
			{
				try
				{
					cnData.Open();
					if (cmd.ExecuteScalar() == null)
					{
						if (cnData != null)
						{
							cnData.Close();
						}
						return false;
					}
					else
					{
						if (cnData != null)
						{
							cnData.Close();
						}
						return true;
					}
				}
				catch
				{
					throw;
				}
			}
		}
		/// <summary>
		/// Executes a named, parameterless stored procedure.
		/// </summary>
		/// <param name="sprocName">Stored procedure name.</param>
		public void ExecuteSproc(string sprocName)
		{
			using (SqlConnection cnData = new SqlConnection(DATA_CONNECTION_STRING))
			{
				cnData.Open();
				using (SqlTransaction trans = cnData.BeginTransaction())
				using (SqlCommand cmd = cnData.CreateCommand())
				{
					try
					{
						cmd.Transaction = trans;
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.CommandText = sprocName;
						cmd.Prepare();
						cmd.ExecuteNonQuery();
						trans.Commit();
					}
					catch (Exception ex)
					{
						trans.Rollback();
						throw new ApplicationException("Something wrong happened in the data access layer: ", ex);
					}
				}
				if (cnData != null)
				{
					cnData.Close();
				}
			}
		}
		public void ExecuteParameterisedSproc(string sprocName, object[,] fieldAndValue)
		{
			string sqlVariablePrefix = "@";
			using (SqlConnection cnData = new SqlConnection(DATA_CONNECTION_STRING))
			{
				cnData.Open();
				using (SqlTransaction trans = cnData.BeginTransaction())
				using (SqlCommand cmd = new SqlCommand(sprocName, cnData))
				{
					try
					{
						cmd.Transaction = trans;
						cmd.CommandType = CommandType.StoredProcedure;
						for (int fieldIndex = 0; fieldIndex <= fieldAndValue.GetUpperBound(0); fieldIndex++)
						{
							string fieldName = fieldAndValue[fieldIndex, 0].ToString();
							string fieldValue = fieldAndValue[fieldIndex, 1].ToString();
							int fieldLength = fieldValue.Length;
							string fieldDataType = fieldAndValue[fieldIndex, 1].GetType().ToString();
							SqlParameter parameter = cmd.CreateParameter();
							parameter.ParameterName = sqlVariablePrefix + fieldName;
							parameter.Value = fieldValue;
							parameter.DbType = typeDict[fieldAndValue[fieldIndex, 1].GetType()];
							parameter.Size = fieldLength;
							cmd.Parameters.Add(parameter);
							//Debug.Print(fieldName + ":" + fieldValue + ":" + fieldDataType);
						}
						cmd.Prepare();
						cmd.ExecuteNonQuery();
						trans.Commit();
					}
					catch (Exception ex)
					{
						trans.Rollback();
						throw new ApplicationException("Something wrong happened in the data access layer: ", ex);
					}
				}
				if (cnData != null)
				{
					cnData.Close();
				}
			}
		}
	}
}

