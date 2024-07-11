using System;

namespace ClassicByte.Cucumber.Core.IO
{
    /// <summary>
    /// 表示一个文件系统的抽象类，它可以是文件，也可以是目录。
    /// </summary>
    public abstract class FileSystem
    {
        /// <summary>
        /// 名称
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public abstract String Name { get; }

        /// <summary>
        /// 路径
        /// </summary>
        /// <value>
        /// The path.
        /// </value>
        public abstract String Path { get; }

        /// <summary>
        /// 文件大小（<see cref="System.Int32"/>）
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        public abstract int Size { get; }

        /// <summary>
        /// 文件大小（<see cref="System.Int64"/>）
        /// </summary>
        /// <value>
        /// The long size.
        /// </value>
        public abstract long LongSize { get; }

        /// <summary>
        /// 该<see cref="FileSystem"/>文件系统是否存在于文件系统中
        /// </summary>
        /// <value>
        ///   <c>true</c> if exists; otherwise, <c>false</c>.
        /// </value>
        public abstract bool Exists { get; }

        /// <summary>
        /// 获取此文件系统对象的类型
        /// </summary>
        /// <value>
        /// The type of the file system.
        /// </value>
        public abstract FileSystemType FileSystemType { get; }

        /// <summary>
        /// 在磁盘中删除此文件系统对象
        /// </summary>
        public abstract void Delete();

        /// <summary>
        /// 重命名此文件系统对象
        /// </summary>
        /// <param name="newName">The new name.</param>
        public abstract void Rename(String newName);

        /// <summary>
        /// 移动此文件系统对象到指定路径
        /// </summary>
        /// <param name="sourcePath">The source path.</param>
        /// <param name="destinationPath">The destination path.</param>
        public abstract void Move(String sourcePath, String destinationPath);

        /// <summary>
        /// 复制此文件系统对象到指定路径
        /// </summary>
        /// <param name="sourcePath">The source path.</param>
        /// <param name="destinationPath">The destination path.</param>
        public abstract void Copy(String sourcePath, String destinationPath);

        /// <summary>
        /// 创建此文件系统对象
        /// </summary>
        public abstract void Create();

        /// <summary>
        /// 获取此文件系统对象的唯一标识符
        /// </summary>
        /// <value>
        /// 唯一标识符。
        /// </value>
        internal abstract String FID { get; set; }
    }
    /// <summary>
    /// 表示文件系统类型的枚举。
    /// </summary>
    [Flags]
    public enum FileSystemType
    {
        /// <summary>
        /// 文件
        /// </summary>
        File,
        /// <summary>
        /// 文件夹
        /// </summary>
        Directory
    }
}
