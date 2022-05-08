using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.Enums;
using ConsoleApp1.Exceptions;
using ConsoleApp1.Interfaces;
using ConsoleApp1.Models;

namespace ConsoleApp1.Services
{
    class LibraryManager : ILibraryManager

    {
        private List<Book> _books;
        public List<Book> Books { get => _books; }
        public LibraryManager()
        {
            _books = new List<Book>();
        }

        public void Add(Book book)
        {
            if (_books.Count > 0 && _books.Exists(b => b.Name == book.Name))
                throw new SameBookalreadyAddedExpection($"{book.Name} Adinda Kitab Movcudur");
            _books.Add(book);
        }

        public List<Book> Filter(string author, Genre genre)
        {
            return _books.FindAll(b => b.Author == author || genre == b.Genre);
        }

        public List<Book> Search(string value)
        {
            return _books.FindAll(b => b.Author.Contains(value) || b.Genre.ToString().Contains(value) || b.PageCount.ToString().Contains(value));
        }

        public Book ShowInfo(string bookName)
        {
            Book book = _books.Find(b => b.Name == bookName);
            if(book != null)
            {
                return book;
            }
            throw new BookNotFoundException($"Daxil Edilen {bookName} Adinda Kitab Sistemde Yoxdur");
        }

    }
}
