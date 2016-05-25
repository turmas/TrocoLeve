using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocoLeve.Core.DataContracts {
	public sealed class CalculateRequest : AbstractRequest {
		public long ProductAmount { get; set; }

		public long PaidAmount { get; set; }

		public CalculateRequest() { }

		public CalculateRequest(long productAmount, long paidAmount) {
			this.PaidAmount = paidAmount;
			this.ProductAmount = productAmount;
		}

		protected override void Validate() {

			if (this.PaidAmount <= 0) {
				base.AddError("PaidAmount", "PaidAmount must be greater than 0");
			}

			if (this.ProductAmount <= 0) {
				base.AddError("ProductAmount", "ProductAmount must be greater than 0");
			}

			if (this.ProductAmount > this.PaidAmount) {
				base.AddError("PaidAmount", "PaidAmount must be greater than ProductAmount");
			}
		}
	}
}
