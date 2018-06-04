using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace UsingTextWriter
{
    
    class Test
    {
        public static void Main()
        {
            Console.WriteLine("Create a text file:");
            WriteTextFile();
            Console.WriteLine("Create file successful !");
            Console.WriteLine("Read a text file :");
            //ReadTextFile();
            //Console.ReadLine();
        }

        static void WriteTextFile()
        {
            // Create an instance of StreamWriter to write text to a file.
            // The using statement also closes the StreamWriter.
            using (StreamWriter sw = new StreamWriter(@"..\..\TestFile.txt"))
            {
                // Add some text to the file.
                sw.Write("This is the ");
                sw.WriteLine("header for the file.");
                sw.WriteLine("-------------------");
                // Arbitrary objects can also be written to the file.
                sw.Write("The date is: ");
                sw.WriteLine(DateTime.Now);
            }
        }

        static void ReadTextFile()
        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(@"..\..\TestFile.txt"))
                {
                    String line;
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

        }


    }
}
