using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrocoLeve.Core;
using TrocoLeve.Core.DataContracts;
using TrocoLeve.Core.Processors;
using TrocoLeve.Core.Util;

namespace TrocoLeve.Core {
	public class TrocoLeveManager {
		public TrocoLeveManager() { }

		public CalculateResponse Calculate(CalculateRequest calculateRequest) {

			LogManager.WriteLog(calculateRequest);

			CalculateResponse calculateResponse = new CalculateResponse();
			try {
				// Verifica se os dados recebidos são válidos.
				if (calculateRequest.IsValid == false) {
					calculateResponse.OperationReport = calculateRequest.ValidationReport;
					return calculateResponse;
				}
				long changeAmount = calculateRequest.PaidAmount - calculateRequest.ProductAmount;
				long tempChangeAmount = changeAmount;

				List<ChangeData> tempChangeDataList = new List<ChangeData>();

				do {
					AbstractProcessor processor = ProcessorFactory.Create(tempChangeAmount);
					if (processor == null) {
						Report report = new Report();
						report.Field = "";
						report.Message = "The amount could not be calculated on the currency standards.";
						calculateResponse.OperationReport.Add(report);
						return calculateResponse;
					}
					Dictionary<int, long> leastChangeDictionary = processor.CalculateLeastChange(tempChangeAmount);
					tempChangeAmount = tempChangeAmount - (leastChangeDictionary.Sum(k => k.Key * k.Value));

					foreach (KeyValuePair<int, long> item in leastChangeDictionary) {
						ChangeData changeData = new ChangeData();
						changeData.Amount = item.Key;
						changeData.Quantity = item.Value;
						changeData.CurrencyType = processor.GetName();

						tempChangeDataList.Add(changeData);
					}

				} while (tempChangeAmount > 0);

				calculateResponse.ChangeDataList = tempChangeDataList;
				calculateResponse.ChangeAmount = changeAmount;

				calculateResponse.Success = true;
			}
			catch (Exception ex) {
				Report report = new Report();
				report.Field = "";
				report.Message = "An error has occurred. Please try again later. Our team has been contacted.";
				calculateResponse.OperationReport.Add(report);
				LogManager.WriteLog(ex);
			}
			finally {
				LogManager.WriteLog(calculateResponse);				
			}

			return calculateResponse;
		}
	}
}
