using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class Books
    {
        private int BookID;

        public int ID
        {
            get { return BookID; }
            set { BookID = value; }
        }

        private string BookTitle;

        public string Title
        {
            get { return BookTitle; }
            set { BookTitle = value; }
        }

        private int BookQuantity;

        public int Quantity
        {
            get { return BookQuantity; }
            set { BookQuantity = value; }
        }
        private double BookPrice;

        public double Price
        {
            get { return BookPrice; }
            set { BookPrice = value; }
        }


    }
}
