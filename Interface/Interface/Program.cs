using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath math = new MyMath();
            Console.WriteLine(math.Add(2,3));
            math.Print();
            IMath m = math;
            m.Print();
            IYourMath y = math;
            y.Print();
        }
    }
}
