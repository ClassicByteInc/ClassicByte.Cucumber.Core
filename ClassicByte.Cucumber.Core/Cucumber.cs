using System;
using System.Collections.Generic;
using System.Text;

namespace ClassicByte.Cucumber.Core
{
    /// <summary>
    /// 提供系统操作函数。
    /// </summary>
    public class Cucumber
    {
        /// <summary>
        /// 初始化系统，指定系统工作目录
        /// </summary>
        public static void Init(DirectoryInfo dir)
        {
            #region 初始化文件夹

            Environment.SetEnvironmentVariable(TypeDef.CORE_VAR, dir.FullName,EnvironmentVariableTarget.User);

            dir.Create();
            var coreDir = Directory.CreateDirectory($"{dir.FullName}\\Core\\");
            var configDir = Directory.CreateDirectory($"{dir.FullName}\\Config\\");
            var fileDir = Directory.CreateDirectory($"{dir.FullName}\\File\\");
            var logDir = Directory.CreateDirectory($"{dir.FullName}\\Log\\");
            #endregion

            #region 初始化配置文件

            File.WriteAllText(Config.PackageManagerConfig.FileInfo.FullName, "<PackageManagerConfig />");
            File.WriteAllText(Config.FileIndexConfig.FileInfo.FullName, "<FileIndexTable />");
            File.WriteAllText(Config.UserConfig.FileInfo.FullName, "<UserTable />");
            File.WriteAllText(Config.SystemConfig.FileInfo.FullName,"<SystemConfig>");

            #endregion
        }

        /// <summary>
        /// 关闭系统，释放所有资源。
        /// </summary>
        public static void Shutdown()
        {

        }

        /// <summary>
        /// 启动系统。
        /// </summary>
        public static void Open()
        {

        }
    }
}
