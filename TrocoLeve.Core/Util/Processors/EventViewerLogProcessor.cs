using Dlp.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrocoLeve.Core.DataContracts;

namespace TrocoLeve.Core.Util.Processors {
	internal class EventViewerLogProcessor : AbstractLogProcessor {
		internal EventViewerLogProcessor()
			: base() {

		}
		protected internal override void WriteLog(object logObject, string logMethod = null) {
			string logType = "Undefined";
			EventLogEntryType logEntryType = EventLogEntryType.Information;

			if (logObject is Exception) {
				logType = "Exception";
				logEntryType = EventLogEntryType.Error;
			}
			else if (logObject is AbstractRequest) {
				logType = "Request";
				logEntryType = EventLogEntryType.Information;
			}
			else if (logObject is AbstractResponse) {
				logType = "Response";
				logEntryType = EventLogEntryType.Information;
			}

			string messageToWrite;
			messageToWrite = string.Format("[{0}] | {1} | {2} | {3}{4}",
				DateTime.UtcNow,
				logType,
				logMethod,
				Serializer.NewtonsoftSerialize(logObject),
				Environment.NewLine
				);

			EventLog appLog = new EventLog();
			appLog.Source = "TrocoLeve";
			appLog.WriteEntry(messageToWrite, logEntryType);
		}
	}
}
