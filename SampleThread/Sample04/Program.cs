using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Sample04
{
    public class PrintWorker
    {
        private object thisLock = new object();
        public void DoPrint(object s)
        {
            lock (thisLock)
            {
                Console.WriteLine("Doing print job :" + s);
                Thread.Sleep(1000);
                Console.WriteLine("Complete !");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PrintWorker pw = new PrintWorker();
            Thread t1 = new Thread(new ParameterizedThreadStart(pw.DoPrint));
            Thread t2 = new Thread(new ParameterizedThreadStart(pw.DoPrint));
            t1.Start("Hello");
            t2.Start("How are you !");
            //t1.Join();
            //t2.Join();
            Console.WriteLine("End ....");
        }
    }
}
