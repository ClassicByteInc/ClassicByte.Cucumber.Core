namespace ClassicByte.Cucumber.Core.IO.Exceptions
{
    /// <summary>
    /// 表示在IO过程中引发的异常。
    /// </summary>
    [Serializable]
    public class IOException : System.Exception
    {
        /// <summary>
        /// 初始化 <see cref="IOException"/> 类的新实例
        /// </summary>
        public IOException() { }
        /// <summary>
        /// 初始化 <see cref="IOException"/> 类的新实例，并指定错误消息
        /// </summary>
        /// <param name="message"></param>
        public IOException(string message) : base(message) { }

        /// <summary>
        /// 初始化 <see cref="IOException"/> 类的新实例，并指定错误消息和内部异常
        /// </summary>
        /// <param name="message"></param>
        /// <param name="inner"></param>
        public IOException(string message, System.Exception inner) : base(message, inner) { }

        /// <summary>
        /// 初始化 <see cref="IOException"/> 类的新实例，并指定序列化信息
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected IOException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
