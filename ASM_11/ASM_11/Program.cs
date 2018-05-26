using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_11
{
    class Program
    {
        static void PrintProduct(ArrayList list)
        {
            foreach (Product p in list)
            {
                p.display();
            }
        }
        static void DisplayMessageForRemoveProduct(string mess)
        {
            Console.WriteLine(mess);
        }
        static void Main(string[] args)
        {
            Product coffe = new Product
            {
                Identity = 1,
                Name = "Coffe",
                Quantity = 12,
                Price = 3
            };

            Product coffe = new Product
            {
                Identity = 1,
                Name = "Coffe",
                Quantity = 12,
                Price = 3
            }
        }
    }
}