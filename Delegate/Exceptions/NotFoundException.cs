using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate.Exceptions
{
    internal class NotFoundException:Exception
    {
        public NotFoundException(string message) : base(message)
        {
            Console.WriteLine("yoxdur");
        }
    }
}
