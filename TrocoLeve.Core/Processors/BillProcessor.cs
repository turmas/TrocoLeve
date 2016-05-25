using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocoLeve.Core.Processors {
	internal class BillProcessor : AbstractProcessor {
		public BillProcessor()
			: base() {
		}

		
		public override long[] AvailableValueList {
			// Adicione novos valores na lista abaixo.
			get { return new long[] { 10000, 5000, 2000, 1000, 500, 200 }; }
		}
	}
}
