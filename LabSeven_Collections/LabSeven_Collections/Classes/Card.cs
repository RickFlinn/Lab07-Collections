using System;
using System.Collections.Generic;
using System.Text;
using LabSeven_Collections.Classes;

namespace LabSeven_Collections.Classes
{

    enum Suits { Diamonds, Clubs, Spades, Hearts }
    enum FaceCards { Jack=11, Queen, King }


    class Card
    {

        public string Rank { get; set; }
        public Suits Suit { get; set; }
        
        public void SetRank(int value)
        {
            if (value > 1 && value <= 10)
            {
                Rank = value.ToString();
            }
            else if (value == 1)
            {
                Rank = "Ace";
            }
            else if ( value < 14 && value > 10)
            {
                Rank = Enum.GetName(typeof(FaceCards), value);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Invalid rank");
            }
        }

        public override string ToString()
        {
            return $"{Rank} of {Suit}";
        }
        


        public Card (Suits givenSuit, int givenRank)
        {
            try
            {
                Suit = givenSuit;
                SetRank(givenRank);
            } catch (Exception e)
            {
                throw e;
            }
        }
    }
}
