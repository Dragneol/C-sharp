using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookLibrary
{
    public class Book
    {
        private string id;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string publisher;

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        public void display()
        {
            Console.WriteLine($"--" +
                $"{ID}\n" +
                $"{Name}\n" +
                $"{Publisher}\n" +
                $"{Price}\n" +
                $"--");
        }
    }

    public class Library
    {
        private List<Book> list;

        public List<Book> List { get => list; set => list = value; }

        public void storeAllBooks(List<Book> books)
        {
            List = books;
        }

        public void listAllBooks()
        {
            foreach (Book book in List)
            {
                book.display();
            }
        }

        public void addBook()
        {
            string id = readID("Book ID : ");
            string name = readString("Name : ");
            string publisher = readString("Publisher : ");
            float price = readFloat("Price : "); 
        }

        private string readString(string msg)
        {
            Console.Write(msg);
            return Console.ReadLine();
        }

        private string readID(string msg)
        {
            do
            {
                Console.Write(msg);
                string id = Console.ReadLine();
                Book book = List.Where(b => b.ID == id).First();
                #region explain lamda
                /*
                 * similar with
                 * Book book;
                 * foreach(Book b : List) 
                 * if (b.ID == id) {
                 * book = b;
                 * }
                 */
                #endregion
                if (book == null)
                {
                    return id;
                }
            } while (true);

        }

        private float readFloat(string msg)
        {
            bool parsed = false;
            float num;
            do
            {
                Console.Write(msg);
                parsed = float.TryParse(Console.ReadLine(),out num);
                if (parsed) return num;
            } while (true);
            
        }
    }
}
