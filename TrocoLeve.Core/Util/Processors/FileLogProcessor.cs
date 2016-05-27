using Dlp.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrocoLeve.Core.DataContracts;

namespace TrocoLeve.Core.Util.Processors {
	internal class FileLogProcessor : AbstractLogProcessor {
		internal FileLogProcessor() : base() { }
		private static string fileName = @"c:\Logs\TrocoLeve.log";

		protected internal override void WriteLog(object logObject, string logMethod = null) {
			string logType = "Undefined";

			if (logObject is Exception) {
				logType = "Exception";
			}
			else if (logObject is AbstractRequest) {
				logType = "Request";
			}
			else if (logObject is AbstractResponse) {
				logType = "Response";
			}

			string messageToWrite;
			messageToWrite = string.Format("[{0}] | {1} | {2} | {3}{4}",
				DateTime.UtcNow,
				logType,
				logMethod,
				Serializer.NewtonsoftSerialize(logObject),
				Environment.NewLine
				);

			string directoryPath = Path.GetDirectoryName(fileName);

			if (Directory.Exists(directoryPath) == false) {
				Directory.CreateDirectory(directoryPath);
			}

			File.AppendAllText(fileName, messageToWrite);
		}
	}
}
