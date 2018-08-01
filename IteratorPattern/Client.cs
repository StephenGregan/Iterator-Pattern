using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class Client
    {
        private IEnumerable _breakfast;
        private IEnumerable _dinner;

        public Client(BreakfastMenu breakfast, DinnerMenu dinner)
        {
            this._breakfast = breakfast.Items;
            this._dinner = dinner.Items;
        }

        public void PrintMenu()
        {
            var breakfast = _breakfast;
            PrintMenu(breakfast);
            var dinner = _dinner;
            PrintMenu(dinner);
        }

        private void PrintMenu(IEnumerable iter)
        {
            foreach (var item in iter)
            {
                var i = (Menu)item;
                Console.WriteLine($"{i.Name} Rs. {i.Price} { (i.Vegertarian ? "*" : "x") } \n {i.Description} ");
            }
        }
    }
}
