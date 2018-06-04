using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStream
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Directory Info
            //Console.WriteLine("*** Fun with file directory *** \n");
            //DirectoryInfo dir = new DirectoryInfo(@"D:\Visual-C#");
            //Console.WriteLine("** Directory Info **");
            //Console.WriteLine($"Fullname {dir.FullName}");
            //Console.WriteLine($"Name {dir.Name}");
            //Console.WriteLine($"Parent {dir.Parent}");
            //Console.WriteLine($"Creation {dir.CreationTime}");
            //Console.WriteLine($"Attribute {dir.Attributes}");
            //Console.WriteLine($"Root {dir.Root}");
            #endregion

            #region List All File
            //FileInfo[] fileInfo = dir.GetFiles("*.bmp");
            //foreach (FileInfo file in fileInfo)
            //{
            //    Console.WriteLine("** File Info **");
            //    Console.WriteLine($"Fullname {file.FullName}");
            //    Console.WriteLine($"Name {file.Name}");
            //    Console.WriteLine($"Size {file.Length}");
            //    Console.WriteLine($"Creation {file.CreationTime}");
            //    Console.WriteLine($"Attribute {file.Attributes}");
            //}

            //Console.WriteLine($"Found {fileInfo.Length}");
            #endregion

            #region Create Directories
            //DirectoryInfo foo = dir.CreateSubdirectory("TestingFileC#");
            //Console.WriteLine($"Create {foo.FullName}");

            //foo = dir.CreateSubdirectory(@"Foo\Bar");
            //Console.WriteLine($"Created {foo.FullName}");
            #endregion

            #region Create File & Read
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            sb.AppendLine("World");

            #endregion
        }
    }
}
