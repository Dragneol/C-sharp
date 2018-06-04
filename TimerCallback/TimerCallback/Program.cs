using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TimeApp
{
    class TimerPrinter
    {
        public static void PrintTime(object state)
        {
            Console.WriteLine($"Time is {DateTime.Now.ToLongTimeString()}, Param is {state.ToString()}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TimerCallback timerCallback = new TimerCallback(TimerPrinter.PrintTime);
            Timer t = new Timer(
                timerCallback,
                "Hi",
                0, 
                1000);
            Console.WriteLine("Hit to terminate");
            Console.ReadLine();
        }
    }
}
