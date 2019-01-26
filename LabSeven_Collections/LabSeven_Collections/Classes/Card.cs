using System;
using System.Collections.Generic;
using System.Text;
using LabSeven_Collections.Classes;

namespace LabSeven_Collections.Classes
{

    public enum Suits { Diamonds, Clubs, Spades, Hearts }
    public enum Ranks { Ace=1, One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King }
    
    public class Card
    {
        public Ranks Rank { get; set; }
        public Suits Suit { get; set; }
        

        public override string ToString()
        {
            return $"{Rank} of {Suit}";
        }
        
        public Card (Suits givenSuit, Ranks givenRank)
        {
            try
            {
                Suit = givenSuit;
                Rank = givenRank;
            } catch (Exception e)
            {
                throw e;
            }
        }

        public override bool Equals(object obj)
        {
            return obj.ToString() == ToString();
        }
    }
}
