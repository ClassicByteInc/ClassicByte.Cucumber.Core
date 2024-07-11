using System;
using System.Collections.Generic;
using System.Text;

namespace ClassicByte.Cucumber.Core.IO.Exception
{
	/// <summary>
	/// 找不到指定文件所引发的异常。
	/// </summary>
	[Serializable]
	public class FileNotFoundException : IOException
	{
		/// <summary>
		/// 初始化 <see cref="FileNotFoundException"/> 类的新实例
		/// </summary>
		public FileNotFoundException() { }

		/// <summary>
		/// 初始化 <see cref="FileNotFoundException"/> 类的新实例，并指定错误消息
		/// </summary>
		/// <param name="message"></param>
		public FileNotFoundException(string message) : base(message) { }

		/// <summary>
		///	初始化 <see cref="FileNotFoundException"/> 类的新实例，并指定错误消息和内部异常
		/// </summary>
		/// <param name="message"></param>
		/// <param name="inner"></param>
		public FileNotFoundException(string message, System.Exception inner) : base(message, inner) { }
		
		/// <summary>
		/// 初始化 <see cref="FileNotFoundException"/> 类的新实例。
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected FileNotFoundException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
