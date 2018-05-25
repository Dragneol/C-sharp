using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void swap<T>(ref T obj1, ref T obj2)
        {
            Console.WriteLine($"Before swap {obj1} {obj2}");
            T temp = obj1;
            obj1 = obj2;
            obj2 = temp;
            Console.WriteLine($"After swap {obj1} {obj2}");
        }
        static void Main(string[] args)
        {
            string s1 = "Hoang", s2 = "Duong";
            swap<string>(ref s1,ref s2);
            int day = 16, month = 2;
            swap<int>(ref day, ref month);
        }
    }
}
