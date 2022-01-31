using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    internal class MyListManager<T>
    {
        T[] items;
        T[] tempItems;
        public MyListManager()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            tempItems = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempItems.Length; i++)
            {
                items[i] = tempItems[i];
            }
            items[items.Length - 1] = item;
        }
    }
}
