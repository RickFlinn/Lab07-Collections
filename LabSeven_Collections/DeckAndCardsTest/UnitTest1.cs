using System;
using Xunit;
using LabSeven_Collections.Classes;

namespace DeckAndCardsTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(50)]
        public void AddCards(int num)
        {
            Deck<Card> deck = new Deck<Card>();
            for (int i = 1; i <= num; i++)
            {
                int suit = i % 4 + 1;
                int rank = i % 13 + 1;
                deck.Add(new Card((Suits)suit, (Ranks)rank));
            }
            Assert.Equal(num, deck.CountItems());
            
        }

        [Fact]
        public void SuitGet()
        {
            Card card = new Card(Suits.Clubs, Ranks.Ace);
            Assert.Equal(Suits.Clubs, card.Suit);
        }

        [Fact]
        public void RankGet()
        {
            Card card = new Card(Suits.Clubs, Ranks.Ace);
            Assert.Equal(Ranks.Ace, card.Rank);
        }

        [Fact]
        public void SuitSet()
        {
            Card card = new Card(Suits.Clubs, Ranks.Ace);
            card.Suit = Suits.Hearts;
            Assert.Equal(Suits.Hearts, card.Suit);
        }

        [Fact]
        public void RankSet()
        {
            Card card = new Card(Suits.Clubs, Ranks.Ace);
            card.Rank = Ranks.Four;
            Assert.Equal(Ranks.Four, card.Rank);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(50)]
        public void RemoveCard(int num)
        {
            Deck<Card> deck = new Deck<Card>();
            deck.Add(new Card(Suits.Clubs, Ranks.King));
            for (int i = 1; i <= num; i++)
            {
                int suit = i % 4 + 1;
                int rank = i % 13 + 1;
                deck.Add(new Card((Suits)suit, (Ranks)rank));
            }
            int sizeBefore = deck.CountItems();
            deck.Remove(new Card(Suits.Clubs, Ranks.King));
            Assert.Equal(sizeBefore - 1, deck.CountItems());
        }

        [Fact]
        public void RemovesRightCard()
        {
            Deck<Card> deck = new Deck<Card>();
            deck.Add(new Card(Suits.Clubs, Ranks.King));
            for (int i = 1; i <= 15; i++)
            {
                int suit = i % 4 + 1;
                int rank = i % 13 + 1;
                deck.Add(new Card((Suits)suit, (Ranks)rank));
            }
            Assert.Equal(new Card(Suits.Clubs, Ranks.King), deck.Remove(new Card(Suits.Clubs, Ranks.King)));
        }

        [Fact]
        public void RemoveNonexistent()
        {
            Deck<Card> deck = new Deck<Card>();
            deck.Add(new Card(Suits.Clubs, Ranks.King));

            Assert.Throws<ArgumentOutOfRangeException>(() => deck.Remove(new Card(Suits.Diamonds, Ranks.King)));
        }

    }
}
