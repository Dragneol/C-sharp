using MyBookLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BookManager bm = new BookManager();
            int choice;
            bool check;
            while (true)
            {
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("What would you want to do?");
                    Console.WriteLine("1. Add new book");
                    Console.WriteLine("2. Update a book");
                    Console.WriteLine("3. Delete a book");
                    Console.WriteLine("4. List all book");
                    Console.WriteLine("5. Quit");
                    Console.Write("Your choice: ");
                    check = int.TryParse(Console.ReadLine(), out choice);
                    if (!check)
                    {
                        Console.WriteLine("Choice is a number");
                    }
                    if (choice < 1 || choice > 5)
                    {
                        Console.WriteLine("Choice from 0 - 5 only");
                    }
                } while (!check || choice < 1 || choice > 5);
                switch (choice)
                {
                    case 1:
                        bm.AddNewBook();
                        break;

                    case 2:
                        bm.UpdateBook();
                        break;

                    case 3:
                        bm.DeleteBook();
                        break;

                    case 4:
                        bm.ListAllBooks();
                        break;

                    case 5:
                        Console.WriteLine("Thanks for using the system!");
                        return;
                }
            }
        }
    }
}
