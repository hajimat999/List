using ConsoleApp1.Enums;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Interfaces
{
    interface ILibraryManager
    {
        List<Book> Books { get; }
        void Add(Book book);
        Book ShowInfo(string bookName);
        List<Book> Search(string value);
        List<Book> Filter(string author, Genre genre);      
    }
}
