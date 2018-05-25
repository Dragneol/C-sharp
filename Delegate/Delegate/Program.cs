using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    delegate int FirstDelegate(int x);
    delegate void SecondDelegate();
    class Program
    {
        static int Square(int x) => x * x;
        static void Print()
        {
            Console.WriteLine("Hello");
        }
        static void Display() => Console.WriteLine("World");
        static void Execute(SecondDelegate d) => d.Invoke();
        static void Main(string[] args)
        {
            #region
            //DotNET 1.0
            FirstDelegate first = new FirstDelegate(Square);
            Console.WriteLine(first(3));
            //4.0
            SecondDelegate second = Print;
            second += Display;
            Execute(second);
            //second.Invoke();
            #endregion

            /*
             * Anonymous method
             */
            //2
            FirstDelegate df = delegate (int a)
            {
                return a * a;
            };
            Console.WriteLine(df(6));

            //3.5
            df = (a => a * a * a);
            Console.WriteLine(df(3));

            Console.WriteLine(func("duong", 20));

            //Func<int, int, int> f = ((a, b) => {
            //    return a + b;
            //});
            //Console.WriteLine(f(7,3));
            Run(func, "phat", 100);
            Console.ReadLine();
        }
        static Func<string, int, string> func = ((name, age) => $"{name} is {age} year olds");

        public static void Run(dynamic d, string name, int age)
        {
            Console.WriteLine(func(name, age));
        }
    }
}
