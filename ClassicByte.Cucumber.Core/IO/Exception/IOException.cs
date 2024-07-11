using System;
using System.Collections.Generic;
using System.Text;

namespace ClassicByte.Cucumber.Core.IO.Exception
{
	/// <summary>
	/// 表示在IO过程中引发的异常。
	/// </summary>
	[Serializable]
	public class IOException : System.Exception
	{
		public IOException() { }
		public IOException(string message) : base(message) { }
		public IOException(string message, System.Exception inner) : base(message, inner) { }
		protected IOException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
