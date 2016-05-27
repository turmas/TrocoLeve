using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocoLeve.Core.DataContracts {

	public sealed class ChangeData {
		public ChangeData() { }
		public int Amount { get; set; }
		public long Quantity { get; set; }
		public string CurrencyType { get; set; }
	}
}
