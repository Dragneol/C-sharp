using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_6
{
    public class Medicine
    {
        //private string code, name, manufacturer, date, expireDate;
        //private int price, quantity, batchNumber;

        private string code;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string manufacturer;

        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        private string date;

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        private string expireDate;

        public string ExpireDate
        {
            get { return expireDate; }
            set { expireDate = value; }
        }

        private int batchNumber;

        public int BatchNumber
        {
            get { return batchNumber; }
            set { batchNumber = value; }
        }


        public Medicine()
        {
        }
        public Medicine(string code, string name, string manufacturer,
            int price, int quantity, string date, string expireDate, int batchNumber)
        {
            this.code = code;
            this.name = name;
            this.manufacturer = manufacturer;
            this.price = price;
            this.quantity = quantity;
            this.date = date;
            this.expireDate = expireDate;
            this.batchNumber = batchNumber;
        }

        public void Accept()
        {
            bool parsed;
            do
            {
                Console.WriteLine("Enter the medicine code: ");
                code = Console.ReadLine();
                Console.WriteLine("Enter the medicine name: ");
                name = Console.ReadLine();
                Console.WriteLine("Enter the medicine manufacter: ");
                manufacturer = Console.ReadLine();
                Console.WriteLine("Enter the medicine price:");
                parsed = Int32.TryParse(Console.ReadLine(), out price);
                Console.WriteLine("Enter the medicine quantity:");
                parsed = Int32.TryParse(Console.ReadLine(), out quantity);
                Console.WriteLine("Enter the medicine Date:");
                date = Console.ReadLine();
                Console.WriteLine("Enter the medicine ExpireDate:");
                expireDate = Console.ReadLine();
                Console.WriteLine("Enter the medicine BatchNumber:");
                parsed = Int32.TryParse(Console.ReadLine(), out batchNumber);
            } while (parsed.Equals(false) || code.Equals(null) || name.Equals(null) || manufacturer.Equals(null) || date.Equals(null) || expireDate.Equals(null));
        }

        public void info()
        {
            Console.WriteLine($"{name} have {quantity} left");
        }
    }
}
