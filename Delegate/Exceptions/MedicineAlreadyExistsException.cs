using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate.Exceptions
{
    internal class MedicineAlreadyExistsException:Exception
    {
        public MedicineAlreadyExistsException(string message) : base(message)
        {
            Console.WriteLine("alreadyexception");
        }
    }
}
