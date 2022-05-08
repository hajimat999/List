using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Models
{
    class Library
    {
        List<Book> Books;
        public Library()
        {
            Books = new List<Book>();
        }
        public void Add(Book book)
        {
            Books.Add(book);
        }

        public List<Book> FindAllBooksByName(string name)
        {
            return Books.FindAll(b => b.Name == name);
        }
        public void RemoveAllBookByName(string name)
        {
            Books.RemoveAll(b=>b.Name == name);
        }

        public List<Book> SearchBooks(string value)
        {
            return Books.FindAll(b => b.Name.Contains(value) || b.AuthorName.Contains(value) || b.PageCount.ToString().Contains(value));
        }

        public List<Book> FindAllBooksByPageCountRange(int minPageCount, int maxPageCount)
        {
            return Books.FindAll(b => b.PageCount >= minPageCount && b.PageCount <= maxPageCount);           
        }
        public void RemoveByNo(string code)
        {
            if(Books.Exists(b => b.Code==code))
            Books.RemoveAll(b => b.Code == code);
            Console.WriteLine("Duzgun Code Daxil Et");
        }
    }
}
