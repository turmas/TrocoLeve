using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocoLeve.Core.Processors {
	internal abstract class AbstractProcessor {

		public AbstractProcessor() { }
		public virtual string GetName() {
			return this.GetType().Name.Replace("Processor", "");
		}
		public virtual Dictionary<int, long> CalculateLeastChange(long totalAmount) {
			Dictionary<int, long> changeDictionary = new Dictionary<int, long>();
			long quotient = 0;
			long remainder = 0;

			foreach (int values in AvailableValueList.OrderByDescending(p => p)) {
				quotient = totalAmount / values;
				remainder = totalAmount % values;
				totalAmount = remainder;
				if (quotient > 0) {
					changeDictionary.Add(values, quotient);
				}
			}
			return changeDictionary;
		}
		public abstract long[] AvailableValueList { get; }
	}
}
