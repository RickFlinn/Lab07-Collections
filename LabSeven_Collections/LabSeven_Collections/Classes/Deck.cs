using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LabSeven_Collections.Classes
{

    class Deck<T> : IEnumerable<T>
    {
        T[] decko = new T[13];
        private int nextIndex = 0;

        public string OwnerName { get; set; }
        
        
        public void Add(T item)
        {
            if (nextIndex >= decko.Length)
            {
                Array.Resize(ref decko, decko.Length*2);
            }

            decko[nextIndex] = item;
            nextIndex++;
        }

        /// <summary>
        ///     Searches for a given item in the deck. If it is found, the item is replaced by the value at the 
        ///     end of the array of items, and 
        /// </summary>
        /// <param name="item"></param>
        public void Remove(T item)
        {
            for (int i = 0; i < nextIndex; i++)
            {
                if (item.Equals(decko[i]))
                {
                    decko[i] = decko[nextIndex - 1];
                    Array.Resize(ref decko, decko.Length - 1);
                    nextIndex--;
                    return;
                }
            }
        }

        public void PrintAllItems()
        {
            Console.WriteLine($"This deck contains: {decko[0].ToString()}");
            for(int i = 1; i < nextIndex; i++)
            {
                if (decko[i] != null)
                {
                    Console.WriteLine($", {decko[i].ToString()}");
                }
            }
        }
        
        public IEnumerator<T> GetEnumerator()
        {
            foreach(T thingy in decko)
            {
                yield return thingy;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        
    }


}
