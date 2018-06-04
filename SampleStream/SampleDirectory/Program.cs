using System;
using System.IO;

class Test 
{
    public static void Main() 
    {
        // Specify the directories you want to manipulate.
        DirectoryInfo di = new DirectoryInfo(@"D:\AAA");
        try 
        {
            // Determine whether the directory exists.
            if (di.Exists) 
            {
                // Indicate that the directory already exists.
                Console.WriteLine("That path exists already.");
                Console.WriteLine(di.CreationTime);
                Console.WriteLine(di.FullName);
                Console.WriteLine(di.LastAccessTime);
                //di.Delete(true);
                return;
            }

            // Try to create the directory.
            di.Create();
            Console.WriteLine("The directory was created successfully.");
           

            Console.ReadLine();
            // Delete the directory.
            di.Delete();
            Console.WriteLine("The directory was deleted successfully.");

        } 
        catch (Exception e) 
        {
            Console.WriteLine("The process failed: {0}", e.ToString());
        } 
        finally {}
    }
}



