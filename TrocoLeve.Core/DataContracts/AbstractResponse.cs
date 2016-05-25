using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocoLeve.Core.DataContracts
{
	public abstract class AbstractResponse
	{
		public AbstractResponse()
		{
			this.OperationReport = new List<Report>();
		}

		public bool Success { get; set; }

		public List<Report> OperationReport { get; set; }
	}
}
