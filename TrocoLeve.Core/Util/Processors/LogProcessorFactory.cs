using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocoLeve.Core.Util.Processors {
	internal static class LogProcessorFactory {

		internal static AbstractLogProcessor Create(string logType) {

			if ("EventViewer".Equals(logType, StringComparison.OrdinalIgnoreCase) == true) {
				return new EventViewerLogProcessor();
			}

			return new FileLogProcessor();
		}
	}
}
