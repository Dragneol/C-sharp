using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEvent
{
    public delegate void XuLyHetXang(string msg);

    public class Xe
    {
        public event XuLyHetXang evtHetXang;
        public string TenXe { get; set; }
        public void Chay(){
            Console.WriteLine("Xe "+TenXe+" dang chay.");
           // System.Threading.Thread.Sleep(15000);
           // HetXang();
        }
        //ham phat sinh su kien evtHetXang
        public void HetXang() {
            if (evtHetXang != null)
            {
                evtHetXang("Xe het xang , can do gap.");
                //....
                //...
            }
        }
    }
}
