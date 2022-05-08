using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Exceptions
{
    class BookNotFoundException : Exception
    {
        public BookNotFoundException(string message) : base(message)
        {

        }
    }
}
