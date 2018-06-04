using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace ThreadProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Khoi tao 1 tien trinh 
           // Console.WriteLine("Thread 1");
            ThreadStart ts = new ThreadStart(Run);
            Thread t = new Thread(ts);
            t.Start();

            //Goi phuong thuc Run                       
            Run();
        }
        static void  Run()
        {
            for (int i = 0; i < 50; i++)
            {
                //Thread.Sleep(1000);
                Console.WriteLine("  {0}  ", i);
            }
            
        }
    }
}
