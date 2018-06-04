using System;
using System.IO;

class Test
{
    public static void Main()
    {
        string path1 = @"c:\MyFile.txt";
        string path2 = @"d:\Test.txt" ;
        
        try
        {
            #region File
            //File.Copy(path1, path2);
            //Console.WriteLine("{0} copied to {1}", path1, path2);

            //File.Delete(path2);

            //File.Move(path1, path2);

            //File.Move(path2, @"d:\aaa.txt"); //Rename

            //FileInfo fin = new FileInfo(path2);
            //Console.WriteLine(fin.Extension);
            //Console.WriteLine(fin.Length);
            //Console.WriteLine(fin.LastAccessTime.ToString());
            #endregion

            //Directory.CreateDirectory("d:\\aaa");

            //string[] arr = Directory.GetDirectories("d:\\");
            string[] arr = Directory.GetLogicalDrives();
            foreach (string folder in arr)
            {
                Console.WriteLine(folder);
            }

            Console.ReadLine();
        }

        catch (Exception e)
        {           
            Console.WriteLine(e.Message);
        }
    }
}