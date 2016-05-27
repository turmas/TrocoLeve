using Dlp.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TrocoLeve.Core.DataContracts;
using TrocoLeve.Core.Util.Processors;

namespace TrocoLeve.Core.Util {
	static internal class LogManager {
		static LogManager() { }

		internal static void Write(Object logObject, [CallerMemberName]string logMethod = null) {

			try {
				string logTypeCollection = ConfigurationManager.AppSettings["logType"];

				string[] logTypeArray = logTypeCollection.Split(',', ';', '|');

				Parallel.ForEach<string>(logTypeArray, p => {

					AbstractLogProcessor logProcessor = LogProcessorFactory.Create(p);

					logProcessor.WriteLog(logObject, logMethod);
				});
			}
			catch (Exception) { }
		}
	}
}
