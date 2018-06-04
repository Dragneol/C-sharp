using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookLibrary
{
    public class Book
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public int Price { get; set; }

        public Book() {}

        public Book(string iD, string name, string publisher, int price)
        {
            ID = iD;
            Name = name;
            Publisher = publisher;
            Price = price;
        }

        public override string ToString()
        {
            return $"{ID, 10}{Name, 10}{Publisher, 15}{Price, 10}";
        }
    }
}
