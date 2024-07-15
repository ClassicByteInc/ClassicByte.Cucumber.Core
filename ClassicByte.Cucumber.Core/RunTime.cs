/*****************************************
 * ClassicByte Cucumber Core
 * Author: ClassicByte
 * Date: 2023/2/23
 * Version: 1.0.0
 * Description: ClassicByte Cucumber Core
 * ************************************/
using System;

namespace ClassicByte.Cucumber.Core
{
    /// <summary>
    /// 提供了当前 <see href="">Cucumber</see> 的运行时信息
    /// </summary>
    public static class RunTime
    {
#if false
GUID标识符
+71872df1-02d9-4e42-9b07-21459b63dfb3
+c2c3a482-bc67-430a-ae9c-d24312371ded
+3c7d8f6d-4891-4477-9b30-e3a7664a9efd
cd4129b1-2560-43c1-b079-cdbd5b5aec93
fa9f0d7f-e81a-4a25-9913-29276d755bbe
0d7800c6-7b36-489d-88f6-e261b097de67
c0488650-ad58-487b-b83e-1ea0b44db610
4ee7311f-d960-4722-8cd1-25bc05d6ad64
15b020af-d9da-4a60-b7c5-04e28017fa90
bdb67177-87a1-443a-abce-d346e5e36ae1
#endif
        /// <summary>
        /// 当前运行时所在的操作系统名称
        /// </summary>
        public const String OS_NAME = "Cucumber";

        /// <summary>
        /// 当前运行时用户配置的表名称
        /// </summary>
        public const String USER_TABLE_NAME = "71872df1-02d9-4e42-9b07-21459b63dfb3";

        /// <summary>
        /// 当前运行时所安装的包配置的表名称
        /// </summary>
        public const String PM_TABLE_NAME = "c2c3a482-bc67-430a-ae9c-d24312371ded";

        /// <summary>
        /// 当前运行时文件索引的表名称
        /// </summary>
        public const String FILEINDEX_TABLE_NAME = "3c7d8f6d-4891-4477-9b30-e3a7664a9efd";

        /// <summary>
        /// 当前运行时系统配置的表名称
        /// </summary>
        public const String SYSTEMCFG_TABLE_NAME = "cd4129b1-2560-43c1-b079-cdbd5b5aec93";

        /// <summary>
        /// 初始化系统，指定系统工作目录
        /// </summary>
        public static void Init(DirectoryInfo dir)
        {
            #region 初始化文件夹

            Environment.SetEnvironmentVariable(TypeDef.CORE_VAR, dir.FullName, EnvironmentVariableTarget.User);

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
            File.WriteAllText(Config.SystemConfig.FileInfo.FullName, "<SystemConfig>");

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
