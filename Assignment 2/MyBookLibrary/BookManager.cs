using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookLibrary
{
    public class BookManager
    {
        public List<Book> Books { get; set; } = new List<Book>();

        private string ReadString(string msg)
        {
            Console.Write(msg);
            return Console.ReadLine();
        }

        private int ReadInt(string msg)
        {
            while (true)
            {
                try
                {
                    Console.Write(msg);
                    return int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid number");
                }
            }
        }

        private void AttachInfo(Book book)
        {
            book.Name = ReadString("Book name: ");
            book.Publisher = ReadString("Publisher: ");
            book.Price = ReadInt("Price: ");
        }

        public void AddNewBook()
        {
            string id = ReadString("Book ID: ");
            Book book = Books.Where(b => b.ID == id).FirstOrDefault();
            if (book == null)
            {
                book = new Book { ID = id };
                AttachInfo(book);
                Books.Add(book);
                Console.WriteLine("Book add into list successfuly!");
            }
            else
            {
                Console.WriteLine("ID existed!");
            }
        }

        public void UpdateBook()
        {
            string id = ReadString("Book ID: ");
            Book book = Books.Where(b => b.ID == id).FirstOrDefault();
            if (book == null)
            {
                Console.WriteLine("Book not exist!");
            } else
            {
                AttachInfo(book);
                Console.WriteLine("Info updated successfully");
            }
        }

        public void DeleteBook()
        {
            string id = ReadString("Book ID: ");
            Book book = Books.Where(b => b.ID == id).FirstOrDefault();
            if (book == null)
            {
                Console.WriteLine("Book not found!");
            } else
            {
                Console.WriteLine("Are you sure you want to delete this book?");
                Console.WriteLine(book);
                string answer = ReadString("Type 'yes' to accept, others to cancel: ");
                if (answer.Equals("yes"))
                {
                    Books.Remove(book);
                    Console.WriteLine("Book deleted!");
                } else
                {
                    Console.WriteLine("Operation canceled!");
                }
            }
        }

        public void ListAllBooks()
        {
            Console.WriteLine($"{"ID", 10}{"Name", 10}{"Publisher", 15}{"Price", 10}");
            foreach (Book book in Books)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("Total: " + Books.Count);
        }
    }
}
