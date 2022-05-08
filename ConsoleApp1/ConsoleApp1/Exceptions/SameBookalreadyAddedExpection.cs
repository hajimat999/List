using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Exceptions
{
    class SameBookalreadyAddedExpection : Exception
    {
        public SameBookalreadyAddedExpection(string message) : base(message)
        {

        }
    }
}
