using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    static class Program
    {
        private static void Main(string[] args)
        {
            var breakfast = new BreakfastMenu();
            var dinner = new DinnerMenu();
            var waiter = new Client(breakfast, dinner);
            waiter.PrintMenu();

            Console.ReadLine();
        }
    }
}
