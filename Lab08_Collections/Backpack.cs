using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab08_BookLibrary
{
    public class BackPack<T> : IBag<T>
    {
        private List<T> pack;

        public BackPack()
        {
            pack = new List<T>();
        }
        public void Pack(T item)
        {
            if (item == null)
                return;

            pack.Add(item);
        }

        public T Unpack(int index)
        {
            T x = pack[index];
            pack.RemoveAt(index);
            return x;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return pack.GetEnumerator();
        }
       
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
    }
}

