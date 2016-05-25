using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocoLeve.Core.Processors {
	internal class CandyProcessor : AbstractProcessor {
		public CandyProcessor() : base() { }

		public override long[] AvailableValueList {
			get { return new long[] { 3, 1 }; }
		}
	}
}
