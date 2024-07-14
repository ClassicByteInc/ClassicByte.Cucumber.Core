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
            while (true)
            {
                //Cucumber.Init(new System.IO.DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory));
                var file = new File("system/ect/text.txt");
                file.Create();
                
                Console.WriteLine(file.Name);
                Console.WriteLine(file.Path);

                file.WriteAllBytes(Encoding.UTF8.GetBytes("wdnmd"));
                Process.Start("notepad.exe", Config.FileIndexConfig.FileInfo.FullName);

                var data = file.ReadAllBytes();
                Console.WriteLine($"[{file.Path}]{Encoding.UTF8.GetString(data)}");
                //file.Delete();
                
                Console.ReadLine();
            }
        }
    }
}