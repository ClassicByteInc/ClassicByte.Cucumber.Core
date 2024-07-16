using System.Diagnostics;

namespace ClassicByte.Cucumber.Core
{
    /// <summary>
    /// 定义一些常量。
    /// </summary>
    [DebuggerNonUserCode]
    public static class TypeDef
    {
        /// <summary>
        /// 在<see cref="Config.FileIndexConfig"/> 中定义的文件索引表中一项的FID属性名称
        /// </summary>
        /// <remarks>
        ///     <![CDATA[<FileItem FID=""/> 中的“FID”]]>
        /// </remarks>
        public const string FileIndexTableItemFID = "FID";

        /// <summary>
        /// 在<see cref="Config.FileIndexConfig"/> 中定义的文件索引表中一项的文件元素名称
        /// </summary>
        /// <remarks>
        ///     <![CDATA[<FileItem FID=""/> 中的“FileItem”]]>
        /// </remarks>
        public const string FileIndexTableFileItem = "FileItem";

        /// <summary>
        /// 在<see cref="Config.FileIndexConfig"/> 中定义的文件索引表中一项的文件元素属性的 <c>Name</c> 属性的名称
        /// </summary>
        public const string FileIndexTableItemName = "Name";

        /// <summary>
        /// 在<see cref="Config.FileIndexConfig"/> 中定义的文件索引表中一项的文件元素属性的 <c>Path</c> 属性的名称
        /// </summary>
        public const string FileIndexTableItemPath = "Path";

        /// <summary>
        /// 在<see cref="Config.FileIndexConfig"/> 中定义的文件索引表中一项的文件元素属性的 <c>Type</c> 属性的名称
        /// </summary>
        public const string FileIndexTableItemType = "Type";


        /// <summary>
        /// 在<see cref="Config.UserConfig"/> 中定义的用户表中一项的UID属性名称
        /// </summary>
        public const string UserTableItemUID = "UID";

        /// <summary>
        /// 在<see cref="Config.UserConfig"/> 中定义的用户表中一项的用户元素名称
        /// </summary>
        public const string UserTableItem = "User";

        /// <summary>
        /// 储存在托管操作系统中的环境变量中系统根目录的路径变量名称
        /// </summary>
        public const string SystemCoreRootPathVariableName = "CLASSICBYTE_CUCUMBER_CORE";

        /// <summary>
        /// 在<see cref="Config.SystemConfig"/> 中定义的系统配置文件中环境变量元素的名称
        /// </summary>
        public const string EnvironmentVariableNode = "EnvironmentVariableNode";

        /// <summary>
        /// 在<see cref="Config.SystemConfig"/> 中定义的系统配置文件中一个配置项元素的名称
        /// </summary>
        public const string SystemConfigItem = "ConfigItem";
    }
}
