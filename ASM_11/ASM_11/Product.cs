using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_11
{
    class Product
    {
        private int ProductID;

        public int Identity
        {
            get { return ProductID; }
            set { ProductID = value; }
        }

        private string ProductName;

        public string Name
        {
            get { return ProductName; }
            set { ProductName = value; }
        }
        private int ProductQuantity;

        public int Quantity
        {
            get { return ProductQuantity; }
            set { ProductQuantity = value; }
        }

        private float UnitPrice;

        public float Price
        {
            get { return UnitPrice; }
            set { UnitPrice = value; }
        }

        public Product()
        {

        }
        public Product(int id, string name, int quantity, float price)
        {
            Identity = id;
            Name = name;
            Quantity = quantity;
            Price = price;
        }

        public float SubTotal
        {
            get => Price * Quantity;
        }

        public void display()
        {
            Console.WriteLine($"" +
                $"ID {Identity}\n" +
                $"Name {Name}\n" +
                $"Unit Price {Price}\n" +
                $"Quantity {Quantity}\n" +
                $"SubTotal {SubTotal}\n" +
                $"----------------------");
        }
    }
}
