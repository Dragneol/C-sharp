using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IMath
    {
        int Add(int a, int b);
        void Print();
    }
    interface IYourMath
    {
        void Print();
    }
    class MyMath : IMath, IYourMath
    {
        public int Add(int a, int b) => a + b;
        public void Print()
        {
            Console.WriteLine("This is my math");
        }
        void IMath.Print() => Console.WriteLine("This is IMath");

        void IYourMath.Print() => Console.WriteLine("This is IYourMath");
    }
}
