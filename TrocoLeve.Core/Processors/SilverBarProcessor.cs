using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocoLeve.Core.Processors {
	internal class SilverBarProcessor : AbstractProcessor{
		public SilverBarProcessor()
			: base() {
		}

		public override long[] AvailableValueList {
			// Adicione novos valores na lista abaixo.
			get { return new long[] { 100000, 50000 }; }
		}
	}
}
