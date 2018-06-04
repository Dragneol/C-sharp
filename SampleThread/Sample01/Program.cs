using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Sample01
{
    public class Worker
    {
        private string m_Name;
        public Worker(string name)
        {
            m_Name = name;
        }
        public void DoWork()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(m_Name + " - "+i);
                Thread.Sleep(1000);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Worker w1 = new Worker("Worker #1");
            Worker w2 = new Worker("Worker #2");
            Thread wt1 = new Thread(w1.DoWork);
            Thread wt2 = new Thread(w2.DoWork);

            wt1.Start();
            wt2.Start();
            wt1.Join();
            wt2.Join();
            Console.WriteLine("End ....");
        }
    }
}
