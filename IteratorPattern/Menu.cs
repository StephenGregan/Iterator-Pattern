using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class Menu
    {
        public string Name { get; }
        public string Description { get; }
        public double Price { get; }
        public bool Vegertarian { get; }

        public Menu(string name, string description, double price, bool vegetarian)
        {
            Name = name;
            Description = description;
            Price = price;
            Vegertarian = vegetarian;
        }
    }
}
