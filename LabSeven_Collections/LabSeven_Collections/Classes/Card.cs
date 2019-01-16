using System;
using System.Collections.Generic;
using System.Text;
using LabSeven_Collections.Classes;

namespace LabSeven_Collections.Classes
{
    class Card
    {

        private int rank;


        public int Rank
        {
            get => rank;
            set
            {
                if (value >= 1 && value <= 13)
                {
                    rank = value;
                } else
                {
                    rank = 0;
                }
            }
        }

        public Suit Suit { get; set; }


        public Card (Suit givenSuit, int givenRank)
        {
            Suit = givenSuit;
            Rank = givenRank;
        }
    }
}
