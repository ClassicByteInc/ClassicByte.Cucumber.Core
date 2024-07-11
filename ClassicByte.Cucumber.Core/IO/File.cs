#nullable enable

using System.Xml;

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
                var files = ft.DocumentElement.SelectNodes("FileItem");
                foreach (XmlNode item in files)
                {
                    if (item.Attributes["FID"].Value == FID)
                    {
                        return item.Attributes["Name"].Value;
                    }
                    continue;
                }
                
            }
        }

        public override string Path { get; }

        public override int Size { get; }

        public override long LongSize { get; }

        public override bool Exists { get; }

        public override FileSystemType FileSystemType => FileSystemType.File;

        internal override string FID { get; }
        /// <summary>
        /// 文件中的数据
        /// </summary>
        public byte[] Data => throw new NotImplementedException();//TODO 读取 fid 的文件

        /// <summary>
        /// 复制一个文件
        /// </summary>
        /// <param name="sourcePath"></param>
        /// <param name="destinationPath"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Copy(string sourcePath, string destinationPath)
        {
            throw new NotImplementedException();
        }

        public override void Create()
        {

            var ft = Config.FileIndexConfig.XmlDocument;
            var fid = FID;
            var newFile = ft.CreateElement("FileItem");
            newFile.SetAttribute("FID", fid);
            newFile.SetAttribute("Name", Name);
            newFile.SetAttribute("Type", FileSystemType.ToString());
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

        public File(String path)
        {
            var fid = new Guid().ToString();
            Path = path;
            FID = fid;
        }
    }
}
