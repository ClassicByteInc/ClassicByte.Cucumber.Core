/*****************************************
 * ClassicByte Cucumber Core
 * Author: ClassicByte
 * Date: 2023/2/23
 * Version: 1.0.0
 * Description: ClassicByte Cucumber Core
 * ************************************/
using System.IO;
using System.Xml;

namespace ClassicByte.Cucumber.Core
{
    /// <summary>
    /// 表示一个配置文件对象
    /// </summary>
    public class Config
    {
        /// <summary>
        /// 配置文件的<see cref="System.IO.FileInfo"/>对象
        /// </summary>
        public FileInfo FileInfo { get; set; }

        /// <summary>
        /// 配置文件的<see cref="System.Xml.XmlDocument"/>对象
        /// </summary>
        public XmlDocument XmlDocument
        {
            get
            {
                var xmlDocument = new XmlDocument();
                xmlDocument.Load(FileInfo.FullName);
                return xmlDocument;
            }
        }

        /// <summary>
        /// 保存配置文件
        /// </summary>
        /// <param name="xml">The XML.</param>
        public void Save(XmlDocument xml)
        {
            xml.Save(FileInfo.FullName);
        }

        /// <summary>
        /// 实例化一个 <see cref="ClassicByte.Cucumber.Core.Config"/> 对象
        /// </summary>
        /// <param name="fileInfo"></param>
        private Config(FileInfo fileInfo)
        {
            FileInfo = fileInfo;
        }

        #region 预定义配置文件
        /// <summary>
        /// 系统配置文件
        /// </summary>
        public static Config SystemConfig
        {
            get
            {
                return new Config(new FileInfo(System.IO.Path.Combine(Path.SystemCoreDir.FullName,RunTime.SYSTEMCFG_TABLE_NAME)));
            }
        }

        /// <summary>
        /// 用户配置文件
        /// </summary>
        public static Config UserConfig
        {
            get
            {
                return new Config(new FileInfo(System.IO.Path.Combine(Path.SystemConfigDir.FullName, RunTime.USER_TABLE_NAME)));
            }
        }

        /// <summary>
        /// 文件索引配置文件
        /// </summary>
        public static Config FileIndexConfig
        {
            get
            {
                return new Config(new FileInfo(System.IO.Path.Combine(Path.SystemConfigDir.FullName, RunTime.FILEINDEX_TABLE_NAME)));
            }
        }

        /// <summary>
        /// 本机包的配置文件
        /// </summary>
        public static Config PackageManagerConfig
        {
            get
            {
                return new Config(new FileInfo(System.IO.Path.Combine(Path.SystemConfigDir.FullName, RunTime.PM_TABLE_NAME)));
            }
        }
        #endregion
    }
}
