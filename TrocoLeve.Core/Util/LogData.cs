using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocoLeve.Core.Util {
	internal class LogData {
		public LogData() {
			this.LogDateTime = DateTime.UtcNow;
		}
		public LogData(string logLevel, string logMethod, string logMessage, string logType) : 
			this() {
				this.LogLevel = logLevel;
				this.LogMethod = logMethod;
				this.LogMessage = logMessage;
				this.LogType = logType;
		}
		public DateTime LogDateTime { get; set; }
		public string LogLevel { get; set; }
		public string LogMethod { get; set; }
		public string LogMessage { get; set; }
		public string LogType { get; set; }

	}
}
