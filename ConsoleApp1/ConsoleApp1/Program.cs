using ConsoleApp1.Enums;
using ConsoleApp1.Models;
using System;
using ConsoleApp1.Services;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Name1", "Author1", 70, Genre.detective);
            Book book2 = new Book("Name2", "Author2", 80, Genre.drama);
            Book book3 = new Book("Name3", "Author3", 90, Genre.scienceFiction);
            Book book4 = new Book("Name4", "Author4", 50, Genre.detective);
            Book book5 = new Book("Name5", "Author5", 880, Genre.drama);
            Book book6 = new Book("Name6", "Author6", 30, Genre.detective);
            Book book7 = new Book("Name7", "Author7", 670, Genre.scienceFiction);

            LibraryManager libraryManager = new LibraryManager();
            libraryManager.Add(book1);
            libraryManager.Add(book2);
            libraryManager.Add(book3);
            libraryManager.Add(book4);
            libraryManager.Add(book5);
            libraryManager.Add(book6);
            libraryManager.Add(book7);

            Console.WriteLine(libraryManager.ShowInfo("Name4"));

            foreach (Book book in libraryManager.Filter("name1", Genre.detective))
            {
                Console.WriteLine(book);
            }

            foreach (Book book in libraryManager.Search("50"))
            {
                Console.WriteLine(book);
            }
        }
    }
}
