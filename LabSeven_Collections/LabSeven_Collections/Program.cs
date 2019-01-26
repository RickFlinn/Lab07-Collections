using System;
using LabSeven_Collections.Classes;

namespace LabSeven_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Deck<Card> dealer = new Deck<Card> { OwnerName = "Dealer" };
                Deck<Card> playerOne = new Deck<Card> { OwnerName = "Player One" };
                Deck<Card> playerTwo = new Deck<Card> { OwnerName = "Player Two" };

                dealer.Add(new Card(Suits.Clubs, (Ranks)7));
                dealer.Add(new Card(Suits.Diamonds, (Ranks)11));
                dealer.Add(new Card(Suits.Hearts, (Ranks)12));
                dealer.Add(new Card(Suits.Spades, (Ranks)13));

                Console.WriteLine();
                dealer.PrintAllItems();
                dealer.CountItems();
                Console.WriteLine();
                Console.Write("foreach loop over Dealer's deck yields: ");
                foreach(Card card in dealer)
                {
                    Console.Write($"{card.ToString()}  ");
                }
                Console.WriteLine();
                Console.WriteLine();


                dealer.Add(new Card(Suits.Clubs, (Ranks)2));
                dealer.Add(new Card(Suits.Clubs, (Ranks)4));
                dealer.Add(new Card(Suits.Hearts, (Ranks)6));
                dealer.Add(new Card(Suits.Spades, (Ranks)1));
                dealer.Add(new Card(Suits.Diamonds, (Ranks)9));
                dealer.Remove(new Card(Suits.Clubs, (Ranks)7));

                Console.WriteLine();
                dealer.PrintAllItems();
                dealer.CountItems();
                Console.WriteLine();

                Deal(dealer, playerOne, playerTwo);

            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
                

        }

        public static void Deal(Deck<Card> dealer, Deck<Card> playerOne, Deck<Card> playerTwo)
        {
            dealer.PrintAllItems();
            playerOne.PrintAllItems();
            playerTwo.PrintAllItems();
            

            int evenCards = (dealer.CountItems() / 2) * 2; // because uneven quotients of int round down, this will always round the dealer's deck size down to the nearest even number of cards. 
            Card[] cahds = dealer.decko;
            for (int i = 0; i < evenCards; i++)
            {
                if (i % 2 == 0)
                {
                    playerOne.Add(dealer.Remove(cahds[i]));
                } else
                {
                    playerTwo.Add(dealer.Remove(cahds[i]));
                }
            }

            dealer.PrintAllItems();
            playerOne.PrintAllItems();
            playerTwo.PrintAllItems();
        }
    }
}
