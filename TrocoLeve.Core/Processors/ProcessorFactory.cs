using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocoLeve.Core.Processors {
	internal static class ProcessorFactory {
		internal static AbstractProcessor Create(long changeAmount) {

			AbstractProcessor[] processorCollection = new AbstractProcessor[] { 
			new SilverBarProcessor(), 
			new BillProcessor(), 
			new CoinProcessor(),
			new CandyProcessor(),
			new GoldBarProcessor()
			// Adicionar novos processadores acima desta linha.
			};
			// Processadores ordenados pelo valor mínimo desc
			processorCollection = processorCollection.OrderByDescending(e => e.AvailableValueList.Min()).ToArray();
			foreach (AbstractProcessor processor in processorCollection) {
				if (processor.AvailableValueList.Min() <= changeAmount) {
					return processor;
				}
			}
			return null;
		}
	}
}
