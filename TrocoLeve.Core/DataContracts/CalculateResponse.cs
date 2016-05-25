using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocoLeve.Core.DataContracts {
	public sealed class CalculateResponse : AbstractResponse {
		public Dictionary<int, long> CoinDictionary { get; set; }
		public List<ChangeData> ChangeDataList { get; set; }

		public long ChangeAmount { get; set; }

		public CalculateResponse()
			: base() {
			this.CoinDictionary = new Dictionary<int, long>();
			this.ChangeDataList = new List<ChangeData>();
		}

		public CalculateResponse(Dictionary<int, long> coinDictionary, long changeAmount)
			: base() {
			this.CoinDictionary = coinDictionary;
			this.ChangeAmount = changeAmount;
		}

	}
}
