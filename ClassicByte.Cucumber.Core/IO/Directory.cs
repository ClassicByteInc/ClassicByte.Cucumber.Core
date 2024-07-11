using System;
using System.Collections.Generic;
using System.Text;

namespace ClassicByte.Cucumber.Core.IO
{
    public class Directory : FileSystem
    {
        public override string Name => throw new NotImplementedException();

        public override string Path => throw new NotImplementedException();

        public override int Size => throw new NotImplementedException();

        public override long LongSize => throw new NotImplementedException();

        public override bool Exists => throw new NotImplementedException();

        public override FileSystemType FileSystemType => throw new NotImplementedException();

        internal override string FID { get; set; }

        public override void Copy(string sourcePath, string destinationPath)
        {
            throw new NotImplementedException();
        }

        public override void Create()
        {
            throw new NotImplementedException();
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
    }
}
