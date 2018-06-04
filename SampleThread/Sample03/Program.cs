using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace Sample03
{
    public class PrintWorker
    {        
        public static void DoPrint(object s)
        {
            Console.WriteLine("Doing print job :" + s);
            Thread.Sleep(1000);
            Console.WriteLine("Complete !");        
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //PrintWorker w1 = new PrintWorker();
            
            Thread t1 = new Thread(new ParameterizedThreadStart
                (PrintWorker.DoPrint));
            Thread t2 = new Thread(new ParameterizedThreadStart
                (PrintWorker.DoPrint));
            t1.Start("Hello");
            t2.Start("How are you !");
            t1.Join();
            t2.Join();
            Console.WriteLine("End ....");
        }
    }
}
