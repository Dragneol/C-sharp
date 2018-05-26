using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            Xe sh = new Xe();
            sh.TenXe = "SH 150i";           
            sh.evtHetXang += new XuLyHetXang(DoXang);
            sh.Chay();
            //Console.ReadLine();
            sh.HetXang();
        }
        public static void DoXang(string msg)
        {
            Console.WriteLine(msg);
            Console.WriteLine("Do cho SH 10 lit");
        }
    }
}
