using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocoLeve.Core.DataContracts
{
	public sealed class Report
	{
		public Report() { }

		public string Field { get; set; }
		public string Message { get; set; }
	}
}
