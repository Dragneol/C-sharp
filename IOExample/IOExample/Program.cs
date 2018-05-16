using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOExample
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            Console.WriteLine("Testting");
            Console.WriteLine(10);
            Console.WriteLine(10.9f);
            Console.Write("Testting New Line" + "\n");
            Console.Write(10.9f + "\n");
            #endregion

            DateTime today = new DateTime();
            

            int test_value = 5;

            Console.WriteLine("test value : " + test_value);
            Console.WriteLine("Today is {0}", today);
            //Console.ReadLine();
        }
    }
}
