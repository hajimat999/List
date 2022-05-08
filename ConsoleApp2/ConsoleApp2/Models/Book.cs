using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Models
{
    class Book
    {
        private static int _count; 
        public readonly string Code;
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }

        static Book()
        {
            _count = 1;
        }
        public Book(string name, string authorName, int pageCount)
        {
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
            Code = $"{Name.Substring(0, 2).ToUpper()}{_count}";
        }
        public override string ToString()
        {
            return $"Name: {Name} AuthorName: {AuthorName} PageCount: {PageCount} Code: {Code}";
        }
    }
}
