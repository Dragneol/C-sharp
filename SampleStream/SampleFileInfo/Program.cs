using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo din = new DirectoryInfo(@"D:\TestCode");
            FileInfo[] arrf = din.GetFiles();
            foreach (var f in arrf)
            {
                Console.WriteLine("FullName : " + f.FullName);
                Console.WriteLine("CreationTime : " + f.CreationTime);
                Console.WriteLine("DirectoryName : " + f.DirectoryName);
                Console.WriteLine("Extension : " + f.Extension);
                Console.WriteLine("Attributes : " + f.Attributes);
                Console.WriteLine("--------------------***------------");
            }
            Console.WriteLine(arrf.Length+" files");
            Console.ReadLine();
        }
    }
}
