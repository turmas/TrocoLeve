using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TrocoLeve.Core.DataContracts;

namespace TrocoLeve.Core {
	internal abstract class AbstractLogProcessor {

		internal AbstractLogProcessor() { }

		internal void Write(Object logObject, [CallerMemberName]string logMethod = null) {

			this.WriteLog(logObject, logMethod);
		}

		protected internal abstract void WriteLog(Object logObject, string logMethod);
	}
}
