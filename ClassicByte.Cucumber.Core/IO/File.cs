#nullable enable

using System.Xml;
using static ClassicByte.Cucumber.Core.TypeDef;
namespace ClassicByte.Cucumber.Core.IO
{
    /// <summary>
    /// 表示磁盘中的一个文件。
    /// </summary>
    /// <seealso cref="ClassicByte.Cucumber.Core.IO.FileSystem" />
    public class File : FileSystem
    {
        public override string Name
        {
            get
            {
                var ft = Config.FileIndexConfig.XmlDocument;
                var files = ft.DocumentElement.SelectNodes(File_T_FileItem);
                foreach (XmlNode item in files)
                {
                    if (item.Attributes[File_T_FID].Value == FID)
                    {
                        return item.Attributes[File_T_Name].Value;
                    }
                    continue;
                }
                throw new Exception.FileNotFoundException($"此文件不存在，无法获取其名称。");
            }
        }

        public override string Path { get; }

        public override int Size { get; }

        public override long LongSize { get; }

        public override bool Exists { get; }

        public override FileSystemType FileSystemType => FileSystemType.File;

        private String _file_path => $"{ClassicByte.Cucumber.Core.Path.FileSystemCoreDir.FullName}\\{FID}";

        internal override string FID
        {
            get; set;
        }
        /// <summary>
        /// 文件中的数据
        /// </summary>
        public byte[] Data => System.IO.File.ReadAllBytes(_file_path);

        /// <summary>
        /// 复制一个文件
        /// </summary>
        /// <param name="sourcePath"></param>
        /// <param name="destinationPath"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Copy(string sourcePath, string destinationPath)
        {
            (new File(destinationPath)).Create();
        }


        public override void Create()
        {

            var ft = Config.FileIndexConfig.XmlDocument;
            var fid = Guid.NewGuid().ToString();
            var newFile = ft.CreateElement(File_T_FileItem);
            newFile.SetAttribute(File_T_FID, fid);
            FID = fid;
            newFile.SetAttribute(File_T_Name, Name);
            newFile.SetAttribute(File_T_Type, FileSystemType.ToString());
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override void Move(string sourcePath, string destinationPath)
        {
            throw new NotImplementedException();
        }

        public override void Rename(string newName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 读取文件中的所有字节
        /// </summary>
        /// <returns></returns>
        public byte[] ReadAllBytes()
        {
            return System.IO.File.ReadAllBytes(_file_path);
        }

        /// <summary>
        /// 写入字节，覆盖原始内容
        /// </summary>
        /// <param name="data"></param>
        public void WriteAllBytes(byte[] data)
        {
            System.IO.File.WriteAllBytes(_file_path, data);
        }

        /// <summary>
        /// 初始化 <see cref="File"/> 类的新实例
        /// </summary>
        /// <param name="path"></param>
        public File(String path)
        {
            Path = path;
            var ft = Config.FileIndexConfig.XmlDocument;
            try
            {
                var files = ft.DocumentElement.SelectNodes(File_T_FileItem);
                foreach (XmlNode item in files)
                {
                    if (item.Attributes[File_T_Path].Value == Path)
                    {
                        FID = item.Attributes[File_T_FID].Value;
                    }
                }
            }
            catch
            {
            }
        }
    }
}
