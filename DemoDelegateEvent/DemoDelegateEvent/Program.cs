using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegateEvent
{
    public delegate void MyDele1();
    public delegate int MyDele2(int a, int b);
    class Program    {
        static void Print() {
            Console.WriteLine("Hello world");
        }
        static void GetDate() {
            System.Threading.Thread.Sleep(10000);
            Console.WriteLine(DateTime.Now);
        }
        static int Add(int a, int b)
        {
            System.Threading.Thread.Sleep(10000);
            return a + b;
        }
        static void Execute(MyDele1 d){
            d();
        }
        private static void GetResult(IAsyncResult ar)
        {
            AsyncResult a = ar as AsyncResult;
            MyDele2 d = a.AsyncDelegate as MyDele2;
            int kq = d.EndInvoke(ar);
            Console.WriteLine(kq);
        }
        static void Main(string[] args)
        {
            //.Net 1.0
            MyDele2 d = new MyDele2(Add);
            AsyncCallback ac = new AsyncCallback(GetResult);
            d.BeginInvoke(2,3,ac, null);
            Print();
            Console.ReadLine();
            //MyDele2 d2 = new MyDele2(Add);
            //int kq = d2.Invoke(2, 4);
            //Console.WriteLine(kq);




            //.NET 2.0
            //Anonymous Method
            MyDele2 d2 = delegate (int a, int b)
            {
                return a * b;
            };
            int r = d2(2, 3);

            //.NET 3.5 or later
            //Lambda Expression
            MyDele2 d3 = ((a, b) => a + b);
            int r3 = d3(2, 3);
            Console.WriteLine(r3);

            Func<int, int, int> d4 = ((a, b) => a + b);
            r = d4(2, 3);
            Console.WriteLine(r);

            //MyDele2 d2 = new MyDele2(Add);
            //int r = d2(2, 3);
            //Console.WriteLine(r);

        }

      
    }
}
