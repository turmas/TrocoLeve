using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocoLeve.Core.DataContracts {
	public sealed class CalculateResponse : AbstractResponse {
		
		public List<ChangeData> ChangeDataList { get; set; }

		public long ChangeAmount { get; set; }

		public CalculateResponse()
			: base() {
			
			this.ChangeDataList = new List<ChangeData>();
		}

		public CalculateResponse(long changeAmount)
			: base() {
			
			this.ChangeAmount = changeAmount;
		}

	}
}
