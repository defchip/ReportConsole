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
	}
}
