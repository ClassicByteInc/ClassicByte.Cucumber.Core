#nullable enable

using System.Xml;
using System.Xml.Linq;
using static ClassicByte.Cucumber.Core.TypeDef;
namespace ClassicByte.Cucumber.Core.IO
{
    /// <summary>
    /// 表示磁盘中的一个文件。
    /// </summary>
    /// <seealso cref="ClassicByte.Cucumber.Core.IO.FileSystem" />
    public class File : FileSystem
    {
        private string _Name;

        public override string Name
        {
            get
            {
                if (!string.IsNullOrEmpty(_Name))
                {
                    return _Name;
                }
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
            //获取文件索引表
            var ft = Config.FileIndexConfig.XmlDocument;

            //生成FID（GUID）
            var fid = Guid.NewGuid().ToString();

            //创建文件节点
            var newFile = ft.CreateElement(File_T_FileItem);

            //设置文件的FID属性
            newFile.SetAttribute(File_T_FID, fid);

            //指定文件对象的FID
            FID = fid;

            //指定文件对象的名称
            newFile.SetAttribute(File_T_Name, Name);
            newFile.SetAttribute(File_T_Path, Path);

            //指定文件对象的类型枚举字符串
            newFile.SetAttribute(File_T_Type, FileSystemType.ToString());

            System.IO.File.Create(_file_path).Close();

            //将文件节点添加到文件索引表
            ft.DocumentElement.AppendChild(newFile);
            Config.FileIndexConfig.Save(ft);
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
            //指定路径
            Path = path;
            {
                var name = path.Split('/').Last();
                _Name = name;
            }
            //获取文件索引表
            var ft = Config.FileIndexConfig.XmlDocument;
            try
            {
                //获取文件索引表中的所有文件
                var files = ft.DocumentElement.SelectNodes(File_T_FileItem);

                //遍历文件
                foreach (XmlNode item in files)
                {
                    //如果文件索引表中的某个文件的路径与指定的路径相同
                    if (item.Attributes[File_T_Path].Value == Path)
                    {

                        //指定FID
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
