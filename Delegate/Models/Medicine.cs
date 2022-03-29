using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate.Models
{
    internal class Medicine
    {
        public int Id { get; }
        private static int _id;
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public bool IsDeleted { get; set; }
        public Medicine( string name, double price,int count)
        {
            _id++;
            Id = _id;
            Name = name;
            Price = price;
            Count = count;

        }
        public  void ShowInfo()
        {
            Console.WriteLine($"Id:{Id} - Name:{Name} - Price:{Price} - Count:{Count} ");
        }
        public void sell()
        {
            Count--;
        }
    }
}
