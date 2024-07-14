using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassicByte.Cucumber.Core;
using ClassicByte.Cucumber.Core.IO;

namespace ClassicByte.Cucumber.Core.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cucumber.Init(new System.IO.DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory));
            var file = new File("wdnmd");
            file.Create();
            Process.Start("notepad.exe",Config.FileIndexConfig.FileInfo.FullName);
        }
    }
}