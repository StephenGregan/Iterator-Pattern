using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class BreakfastMenu
    {
        private ArrayList _items;

        public IEnumerable Items
        {
            get
            {
                return new BreakfastMenuIterator(_items);
            }
        }

        public BreakfastMenu()
        {
            _items = new ArrayList();

            AddItem("Waffle", "Blueberry sauce topped breafast waffles", 125, false);
            AddItem("Sandwich", "Veggie sandwich with tomato and cucumber", 75, true);
            AddItem("Pankcakes", "Maple syrup pankcakes", 110, false);
            AddItem("Corn Flakes", "Cornflakes with fruits and nuts", 60, true);
        }

        private void AddItem(string name, string description, int price, bool veg)
        {
            var item = new Menu(name, description, price, veg);
            _items.Add(item);
        }
    }
}
