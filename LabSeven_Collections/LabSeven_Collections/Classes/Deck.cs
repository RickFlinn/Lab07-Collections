using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LabSeven_Collections.Classes
{

    public class Deck<T> : IEnumerable<T>
    {
        public T[] decko = new T[13];
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
            Console.WriteLine($"Added {item} to {OwnerName}'s deck.");
        }

        /// <summary>
        ///     Searches for a given item in the deck. If it is found, the item is replaced by the last item in the deck,
        ///     and the array is resized. 
        /// </summary>
        /// <param name="item"></param>
        public T Remove(T item)
        {
            try
            {
                for (int i = 0; i < nextIndex; i++)
                {
                    if (item.Equals(decko[i]))
                    {
                        Console.WriteLine($"Removed {decko[i].ToString()} from {OwnerName}'s deck.");
                        T removedItem = decko[i];
                        decko[i] = decko[nextIndex - 1];
                        if (decko.Length > 1)
                        {
                            Array.Resize(ref decko, nextIndex - 1); // destroys duplicate value
                            nextIndex--;
                        }
                        else
                        {
                            decko[0] = default(T);
                        }
                        return removedItem;
                    }
                }
                throw new ArgumentOutOfRangeException("Item not found in stack");
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        public void PrintAllItems()
        {
            Console.Write($"{OwnerName}'s deck contains: ");
            if (decko[0] == null)
            {
                Console.Write("nuffin.");
            }
            else
            {
                Console.Write($"{decko[0]}");
                for(int i = 1; i < nextIndex; i++)
                {
                    if (decko[i] != null)
                    {
                        Console.Write($", {decko[i].ToString()}");
                    }
                }
            }
            Console.WriteLine();
        }

        public int CountItems()
        {
            int counter = 0;
            foreach(T item in decko)
            {
                if (item != null)
                {
                    counter++;
                }
            }
            Console.WriteLine($"{OwnerName}'s deck has {counter} thangs.");
            return counter;
        }
        
        public IEnumerator<T> GetEnumerator()
        {
            foreach(T thingy in decko)
            {
                if (thingy != null)
                {
                    yield return thingy;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        
    }


}
