# Lab07-Collections

This project provides a set of two new classes, Deck and Card.
When run, the program writes to console to demonstrate the correct functionality of Deck and Card, as well as a method, 
Deal, that takes in three Decks and distributes the cards from the first Deck evenly among the second two Decks (keeping the remaining card, if they cannot be split evenly).


## Card
Card is a simple Class designed to use with Deck. It has two properties, Suit and Rank; like an ordinary playing card, 
Card may only have a Suit of Diamonds, Clubs, Hearts, or Spades, and a Rank of Ace, 2-10, Jack, Queen, and King. 


## Deck
Deck is a `Collection` that accepts items of any type. It maintains an internal array of items `decko`, resizing the array as needed to accommodate more items, or to destroy items when they are removed. It also has an internal property of OwnerName; setting OwnerName
is necessary for some messages written to Console to display correctly. Deck relies on an internal field `nextindex` to track the last occupied index of `decko` to make insertion and deletion operations.

Deck has the following methods:

### `public void PrintAllItems()`
PrintAllItems iterates over the Deck and prints to Console a description of the Deck's contents.


### `public void Add(T item)`
This method adds an item of type T to the end of the `decko` array field stored in our Deck; if `decko` is not large enough to store the additional value, it is first resized.

### `public T Remove(T item)`
This method takes in an item of type T, and looks for it within the Deck. If it is found, it is removed from the Deck, and returned. 
If there is no `item` in the deck, throws an ArgumentOutOfRangeException. 


```C#
bobsDeck.PrintAllItems();                   // CONSOLE: Bob's deck contains: Two of Spades, Ace of Hearts
bobsDeck.Add(new Card(Suits.Diamonds, 12)); // CONSOLE: Queen of Diamonds added to Bob's deck.
bobsDeck.PrintAllItems();                   // CONSOLE: Bob's deck contains: Two of Spades, Ace of Hearts, Queen of Diamonds
bobsDeck.Remove(new Card(Suits.Spades, 2)); // CONSOLE: Removed Two of Spades from Bob's deck.
bobsDeck.PrintAllItems();                   // CONSOLE: Bob's deck contains: Ace of Hearts, Queen of Diamonds

```

### `Deal(Deck<Card> dealer, Deck<Card> playerOne, Deck<Card> playerTwo)`
Takes in three decks of cards are parameters. This method tries distribute the cards from the dealer's deck into each player's deck evenly (keeping the remainder if it cannot split an odd number of cards). A call to this method displays the initial contents of each deck, each addition and removal, and the final state of each deck in the `Console`.

```
Dealer's deck contains: 9 of Diamonds, Jack of Diamonds, Queen of Hearts, King of Spades, 2 of Clubs, 4 of Clubs, 6 of Hearts, Ace of Spades
Player One's deck contains: nuffin.
Player Two's deck contains: nuffin.
Dealer's deck has 8 thangs.
Removed 9 of Diamonds from Dealer's deck.
Added 9 of Diamonds to Player One's deck.
Removed Jack of Diamonds from Dealer's deck.
Added Jack of Diamonds to Player Two's deck.
Removed Queen of Hearts from Dealer's deck.
Added Queen of Hearts to Player One's deck.
Removed King of Spades from Dealer's deck.
Added King of Spades to Player Two's deck.
Removed 2 of Clubs from Dealer's deck.
Added 2 of Clubs to Player One's deck.
Removed 4 of Clubs from Dealer's deck.
Added 4 of Clubs to Player Two's deck.
Removed 6 of Hearts from Dealer's deck.
Added 6 of Hearts to Player One's deck.
Removed Ace of Spades from Dealer's deck.
Added Ace of Spades to Player Two's deck.
Dealer's deck contains: nuffin.
Player One's deck contains: 9 of Diamonds, Queen of Hearts, 2 of Clubs, 6 of Hearts
Player Two's deck contains: Jack of Diamonds, King of Spades, 4 of Clubs, Ace of Spades
```
