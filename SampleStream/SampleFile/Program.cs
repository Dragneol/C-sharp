using System;

using System.IO;

class Test 
{
    
    private static void CreateFile(string path)
    {   //string  path = @"c:\a.txt"
        //kiem tra tap tin co ton tai ?
        if (!File.Exists(path))
        {
            // Create StreamWriter to write to text file.
            StreamWriter sw = File.CreateText(path);
            sw.WriteLine("Hello");
            sw.WriteLine("And");
            sw.WriteLine("Welcome");
            sw.Close();
        }
    }
    private static void ReadFile(string path)
    {
        // Open the file to read from.
        StreamReader sr = File.OpenText(path);        
        string s = "";
        while ((s = sr.ReadLine()) != null)
        {
            Console.WriteLine(s);
        }
        sr.Close();
    }
    //Viet chuong trinh thuc hien chuc nang sau:
    //-Nhap vao thong tin cua Sinh vien (MaSV, TenSV, NgaySinh,
    // DiaChi) tu ban phim va ghi cac thong tin nay vao tap tin
    //ten SinhVien.txt , sau do doc  va xuat ra man hinh.
    public static void Main() 
    {
        string path = @"D:\MyFile.txt";
        Console.WriteLine("MyFile.txt is created. Press Enter to read.");
        CreateFile(path);
        Console.ReadLine();
        ReadFile(path);

    //    try 
    //    {
    //        string path2 = @"D:\Demo\MyCopyTest.txt";
    //        // Ensure that the target does not exist.
    //        File.Delete(path2);

    //        // Copy the file.
    //        File.Copy(path, path2);
    //        Console.WriteLine("{0} was copied to {1}.", path, path2);

    //        // Delete the newly created file.
    //        Console.ReadLine();
    //        File.Delete(path2);
    //        Console.WriteLine("{0} was successfully deleted.", path2);
    //    } 
    //    catch (Exception e) 
    //    {
    //        Console.WriteLine("The process failed: {0}", e.ToString());
    //    }
    }

  
}

