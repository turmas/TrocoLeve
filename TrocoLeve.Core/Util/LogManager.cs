using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocoLeve.Core.Util {
	internal class LogManager {
		public LogManager() { }

		static void error(string message) {
			WriteLog(message);
		}

		static private void WriteLog(string message) {
			string dateTime = DateTime.Now.ToString();
			string fileName = "TrocoLeve.log";

			// Criar file
			// 
		}

	}
}
