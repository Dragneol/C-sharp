using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Sample02
{
    class ThreadExample
    {
        public static void ThreadProc()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc " + i);
                Thread.Sleep(1000);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread: Start a second thread.");
            Thread t = new Thread(new ThreadStart(ThreadExample.ThreadProc));
            t.Start();
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Main thread : Do some work.");
                Thread.Sleep(1000);
            }
            t.Join();
            Console.WriteLine("Main Thread : ThreadProc.Join has returned");
        }
    }
}
