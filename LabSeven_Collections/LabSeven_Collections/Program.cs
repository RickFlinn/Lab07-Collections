using System;
using LabSeven_Collections.Classes;

namespace LabSeven_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int four = 4;
            Card[] derp = { new Card(Suits.Diamonds, 3), new Card(Suits.Spades, 4), null, new Card(Suits.Hearts, 11)};
            Array.Resize(ref derp, 3);
            foreach(Card thing in derp)
            {
                if (thing != null)
                {
                    Console.Write($"{thing.ToString()} ");

                }
            }
        }
    }
}
