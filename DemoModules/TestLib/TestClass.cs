using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib
{
    /// <summary>
    /// Basic Math
    /// </summary>
    public class TestClass
    {
        /// <summary>
        /// Add two number
        /// </summary>
        /// <param name="a">First Num</param>
        /// <param name="b">Second Num</param>
        /// <returns></returns>

        public int x;
        public static int y;
        public TestClass()
        {
            x = 1;
            Console.WriteLine("Object Contructor");
        }
        static TestClass()
        {
            y = 2;
            Console.WriteLine("Static Contructor");
        }
        public static int add(int a, int b) => a + b;
    }
}
