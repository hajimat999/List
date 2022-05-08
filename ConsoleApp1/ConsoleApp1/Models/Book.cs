using ConsoleApp1.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }
        public Genre Genre { get; set; }

        public Book(string name, string author, int pageCount, Genre genre)
        {
            Name = name;
            Author = author;
            PageCount = pageCount;
            Genre = genre;
        }
        public override string ToString()
        {
            return $"Name: {Name} Author: {Author} PageCount: {PageCount} Genre: {Genre}";
        }
    }
}
