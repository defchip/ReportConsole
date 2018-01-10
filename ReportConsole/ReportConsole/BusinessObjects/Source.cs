using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportConsole.BusinessObjects
{
	public class Source
	{
		public string Name { get; set; }
		public string Server { get; set; }
		public string Database { get; set; }
		public bool IsIntegratedSecurity { get; set; }

		public string DatabaseConnection()
		{
			StringBuilder s = new StringBuilder();
			s.Append("Data Source = ");
			s.Append(Server);
			s.Append(";");
			s.Append(" Initial Catalog = ");
			s.Append(Database);
			s.Append(";");
			s.Append(" Integrated Security = ");
			s.Append(IsIntegratedSecurity.ToString());

			return s.ToString();
		}

		public string ServerConnection()
		{
			StringBuilder s = new StringBuilder();
			s.Append("Data Source = ");
			s.Append(Server);
			s.Append(";");
			s.Append(" Integrated Security = ");
			s.Append(IsIntegratedSecurity.ToString());

			return s.ToString();
		}
	}
}


//Data Source = THINKPAD; Initial Catalog = DEV_REPORT_CONSOLE_01;CTrue"

//Data Source = THINKPAD; Initial Catalog = DEV_REPORT_CONSOLE_01; Integrated Security = True