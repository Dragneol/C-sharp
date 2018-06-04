using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace UsingBinaryStream
{  

class MyStream 
{
    private static string FILE_NAME = @"d:\Test.data";
    public static void Main(String[] args) 
    {
        // Create the new, empty data file.
        if (File.Exists(FILE_NAME)) 
        {
            Console.WriteLine("{0} already exists!", FILE_NAME);
            return;
        }
        FileStream fs = new FileStream(FILE_NAME,
            FileMode.CreateNew);
        // Create the writer for data.
        BinaryWriter w = new BinaryWriter(fs);
        // Write data to Test.data.
        w.Write("Hello");
        w.Write(100);
        w.Write("Welcome");

        w.Close();
        fs.Close();
        Console.WriteLine("Create file successful !");
        Console.ReadLine();
        Console.WriteLine("Now read file  !");
        // Create the reader for data.
        fs = new FileStream(FILE_NAME,FileMode.Open, 
            FileAccess.Read);
        BinaryReader r = new BinaryReader(fs);
        // Read data from Test.data.
        Console.WriteLine(" {0} ",r.ReadString());
        Console.WriteLine(" {0} ",r.ReadInt32());
        Console.WriteLine(" {0} ",r.ReadString());
        r.Close();
        fs.Close();
        Console.WriteLine();
        Console.ReadLine();
    }

    }
}
