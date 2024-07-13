/*****************************************
 * ClassicByte Cucumber Core
 * Author: ClassicByte
 * Date: 2023/2/23
 * Version: 1.0.0
 * Description: ClassicByte Cucumber Core
 * ************************************/
using System.Diagnostics;
using static ClassicByte.Cucumber.Core.TypeDef;

namespace ClassicByte.Cucumber.Core
{
    /// <summary>
    /// 表示Cucumber常用路径的静态类。
    /// </summary>
    public static class Path
    {
        

        /// <summary>
        /// 获取系统根目录的路径。
        /// </summary>
        public static DirectoryInfo SystemRootDir
        {
            get;
        }

        /// <summary>
        /// 获取系统核心目录的路径。
        /// </summary>
        public static DirectoryInfo SystemCoreDir => new DirectoryInfo(System.IO.Path.Combine(SystemRootDir.FullName, "Core"));


        /// <summary>
        /// 获取系统配置目录的路径。
        /// </summary>
        public static DirectoryInfo SystemConfigDir => new DirectoryInfo(System.IO.Path.Combine(SystemRootDir.FullName, "Config"));

        internal static DirectoryInfo FileSystemCoreDir => new DirectoryInfo(System.IO.Path.Combine(SystemRootDir.FullName, "File"));
        /// <summary>
        /// 初始化 <see cref="Path"/> 类的新实例。
        /// </summary>
        static Path()
        {
            var currentDir  = new DirectoryInfo(new FileInfo(Process.GetCurrentProcess().MainModule.FileName).DirectoryName);
            if (Environment.GetEnvironmentVariable(CORE_VAR) is null)
            {
                SystemRootDir = currentDir.Parent.Parent;
            }
            else
            {
                SystemRootDir = new DirectoryInfo(Environment.GetEnvironmentVariable(CORE_VAR));
            }
        }
    }
}
