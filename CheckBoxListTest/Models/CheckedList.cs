using System.Collections.Generic;

namespace CheckBoxListTest.Models
{
    public class CheckedList<T> : Dictionary<T, bool>
    {
        public static CheckedList<Product> GetList()
        {
            return new CheckedList<Product> { { new Product { Name = "John", Id = 1 }, true }, { new Product { Name = "Stephen", Id = 2 }, false }, { new Product { Name = "Bob", Id = 3 }, true } };
        }
    }
}