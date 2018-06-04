using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsynByDelegate{
    public delegate int MyDele(int a, int b);
    class Program{
        static int Add(int a, int b)
        {
            Console.WriteLine("Add thread : " + 
                Thread.CurrentThread.GetHashCode());
            Thread.Sleep(5000);
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread : "+ 
                Thread.CurrentThread.GetHashCode());
            MyDele d = new MyDele(Add);
            IAsyncResult isr = d.BeginInvoke(1, 2, null, null);
          
            Console.WriteLine("Main completed.");
            int kq = d.EndInvoke(isr);          
            Console.WriteLine("1+2={0}", kq);
            Console.ReadLine();
        }
    }
}
