using ConsoleApp2.Models;
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("name", "athor", 70);
            Book book1 = new Book("name1", "athor1", 60);
            Book book2 = new Book("name2", "athor2", 60);
            Book book3 = new Book("name3", "athor3", 60);
            Book book4 = new Book("name4", "athor4", 20);

            Library library = new Library();

            library.Add(book);
            library.Add(book1);
            library.Add(book2);
            library.Add(book3);
            library.Add(book4);

            foreach (Book item in library.FindAllBooksByName("name1"))
            {
                Console.WriteLine(item);
            }

            library.RemoveAllBookByName("name1");
            foreach (Book item in library.SearchBooks("60"))
            {
                Console.WriteLine(item);
            }
            foreach (Book item in library.FindAllBooksByPageCountRange(30, 100))
            {
                Console.WriteLine(item);
            }
        }
    }
}
