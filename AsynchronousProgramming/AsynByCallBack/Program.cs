using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsynByCallBack
{
    public delegate int MyDele(int a, int b);
    class Program
    {
        static int Add(int a, int b)
        {
            Console.WriteLine("Add thread : " + Thread.CurrentThread.GetHashCode());
            Thread.Sleep(5000);
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread : " + Thread.CurrentThread.GetHashCode());
            MyDele d = new MyDele(Add);
            AsyncCallback acb = new AsyncCallback(GetReturnValue);
            IAsyncResult isr = d.BeginInvoke(1, 2, acb, "CallBackTest");
            //while (!isr.IsCompleted)
            //{
            //    Console.WriteLine("Doing more work in Main");
            //    Thread.Sleep(1000);
            //}
            Console.WriteLine("Main completed.");
            Console.ReadLine();
        }

        static void GetReturnValue(IAsyncResult res)
        {
            AsyncResult ar = (AsyncResult)res;         
            MyDele d = (MyDele)ar.AsyncDelegate;
            int kq = d.EndInvoke(res);
            Console.WriteLine(res.AsyncState.ToString());
            Console.WriteLine("1+2={0}", kq);
        }
    }
}
