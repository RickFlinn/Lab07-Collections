using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LabSeven_Collections.Classes
{
    enum Suit { Diamonds, Clubs, Spades, Hearts }


    class Deck<T> : IEnumerable<T>
    {
        private T[] decko = new T[3];
        private int nextIndex = 0;
        
        public void Add(T thing)
        {
            if (nextIndex == decko.Length)
            {
                Array.Resize<T>(ref decko, decko.Length*2);
            }

            decko[nextIndex] = thing;
            nextIndex++;
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
