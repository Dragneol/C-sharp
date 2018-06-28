using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    public class Book
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public float BookPrice { get; set; }

        public Book()
        {

        }

        public Book(int bookID, string bookName, float bookPrice)
        {
            BookID = bookID;
            BookName = bookName;
            BookPrice = bookPrice;
        }
    }
}
