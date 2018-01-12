using System;
using System.Configuration;
using System.Windows.Forms;

namespace ReportConsole
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			var conn = ConfigurationManager.ConnectionStrings["reportConsole"].ConnectionString;

			IDataAccess dataAccess = new DataAccess(conn);
			if (!dataAccess.HasOpened)
			{
				MessageBox.Show("Fail!");
				return;
			}

			QueryProvider queryProvider = new QueryProvider(dataAccess);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new UI.UIMain(queryProvider));
		}
	}
}
