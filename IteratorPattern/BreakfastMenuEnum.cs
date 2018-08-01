using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class BreakfastMenuEnum : IEnumerator
    {
        private readonly ArrayList _items;
        private int _position = -1;

        public BreakfastMenuEnum(ArrayList items)
        {
            _items = items;
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public bool MoveNext()
        {
            _position++;
            return (_position < _items.Count);
        }

        public void Reset()
        {
            _position = -1;
        }

        object IEnumerator.Current => Current;

        public Menu Current
        {
            get
            {
                try
                {
                    return (Menu)_items[_position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }

        }
    }
}
