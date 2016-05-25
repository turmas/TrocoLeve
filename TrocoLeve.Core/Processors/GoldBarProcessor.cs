using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocoLeve.Core.Processors {
	internal class GoldBarProcessor : AbstractProcessor {
		internal GoldBarProcessor() : base() { }
		public override long[] AvailableValueList {
			get { return new long[] {500000, 1000000, 2000000 }; }
		}
	}
}
