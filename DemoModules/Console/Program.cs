using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLib;

namespace Console
{
    class Program
    {
        static void A(int a, ref int b, out int c, params int[] arr)
        {
            a = 1;
            b = 2;
            c = 3;
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.WriteLine(arr[i]);
            }
        }
        static void Main(string[] args)
        {
            //System.Console.WriteLine(TestClass.add(7,8));

            #region
            //TestClass obj1 = new TestClass();
            //TestClass obj2 = new TestClass();
            //System.Console.WriteLine(obj1.x);
            //System.Console.WriteLine(obj2.x);
            //System.Console.WriteLine(TestClass.y);
            //System.Console.ReadLine();
            #endregion

            int x = 10, y = 11, z = 12;
            A(x, ref y, out z, 5,6,7,8);
            System.Console.WriteLine($"{x}, {y}, {z}");
        }
    }
}
