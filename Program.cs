using System;
using System.Collections.Generic;

namespace AllCardsOnDeck
{
    class Program
    {
        static void Main(string[] args)
        {
            //ALGORITHM A
            //             var deck = new List<string>() {
            // "Ace of Clubs",
            // "1 of Clubs",
            // "2 of Clubs",
            // "3 of Clubs",
            // "4 of Clubs",
            // "5 of Clubs",
            // "6 of Clubs",
            // "7 of Clubs",
            // "8 of Clubs",
            // "9 of Clubs",
            // "10 of Clubs",
            // "Jack of Clubs",
            // "Queen of Clubs",
            // "King of Clubs",
            // "Ace of Hearts",
            // "1 of Hearts",
            // "2 of Hearts",
            // "3 of Hearts",
            // "4 of Hearts",
            // "5 of Hearts",
            // "6 of Hearts",
            // "7 of Hearts",
            // "8 of Hearts",
            // "9 of Hearts",
            // "10 of Hearts",
            // "Jack of Hearts",
            // "Queen of Hearts",
            // "King of Hearts",
            // "Ace of Spades",
            // "1 of Spades",
            // "2 of Spades",
            // "3 of Spades",
            // "4 of Spades",
            // "5 of Spades",
            // "6 of Spades",
            // "7 of Spades",
            // "8 of Spades",
            // "9 of Spades",
            // "10 of Spades",
            // "Jack of Spades",
            // "Queen of Spades",
            // "King of Spades",
            // "Ace of Diamonds",
            // "1 of Diamonds",
            // "2 of Diamonds",
            // "3 of Diamonds",
            // "4 of Diamonds",
            // "5 of Diamonds",
            // "6 of Diamonds",
            // "7 of Diamonds",
            // "8 of Diamonds",
            // "9 of Diamonds",
            // "10 of Diamonds",
            // "Jack of Diamonds",
            // "Queen of Diamonds",
            // "King of Diamonds"
            // };
            //             // numberOfCards = length of our deck
            //             var numberOfCards = deck.Count;
            //             // for rightIndex from numberOfCards - 1 down to 1 do:
            //             for (var rightIndex = numberOfCards - 1; rightIndex >= 1; rightIndex--)
            //             {
            //                 // leftIndex = random integer that is greater than or equal to 0 and LESS than rightIndex. See the section "How do we get a random integer")
            //                 var randomNumberGenerator = new Random();
            //                 var leftIndex = randomNumberGenerator.Next(rightIndex);
            //                 // Now swap the values at rightIndex and leftIndex by doing this:
            //                 // leftCard = the value from deck[leftIndex]
            //                 var leftCard = deck[leftIndex];
            //                 // rightCard = the value from deck[rightIndex]
            //                 var rightCard = deck[rightIndex];
            //                 // deck[rightIndex] = leftCard
            //                 deck[rightIndex] = leftCard;
            //                 // deck[leftIndex] = rightCard
            //                 deck[leftIndex] = rightCard;
            //                 //first card = deck[0]
            //                 var firstCard = deck[0];
            //                 //second card = deck[1];
            //                 var secondCard = deck[1];
            //                 System.Console.WriteLine($"The first card is {firstCard}. \n");
            //                 System.Console.WriteLine($"The second card is {secondCard}.\n");
            //             }



            //ALGO B

            // Console.WriteLine("Welcome to All Cards On Deck.");
            // Requirements
            // create a deck variable as a list and initialize as empty
            var deck = new List<string>();
            // create a card variable as a list and initialize as empty
            var card = new List<string>();
            // All cards should be represented as a string such as "Ace of Hearts"
            // There are four suits: "Clubs", "Diamonds", "Hearts", and "Spades".
            var suits = new List<string>() { "Clubs", "Diamonds", "Hearts", "Spades" };
            //length of suits
            var suitsLength = suits.Count;
            // There are 13 ranks: "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", and "King".
            var ranks = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            //length of ranks
            var ranksLength = ranks.Count;
            //these nested foreach loops is like having many loops but with a multiplication effect! :-0 DRY \0/
            //Make a loop that goes through the list of ranks
            foreach (var suit in suits)
            {
                //Make a loop that goes through the list of ranks
                // Console.WriteLine($"SuitsLength: {suitsLength}.");
                foreach (var rank in ranks)
                {
                    //displaying the cards each of the 52
                    var cards = $"{rank} of {suit}";
                    //printing the cards
                    Console.WriteLine($"and it's a: {cards}");
                    deck.Add(cards);
                    //this makes the loop go as many times as there are elements on the rank
                    // Console.WriteLine("\n");
                }
                Console.Write($"Total of cards : {deck.Count} \n ");
                // Console.WriteLine("Counting my suits and there are : " + deck.Count + " of them at this point.");
            };
            var allCardsOnTheDeck = deck.Count;
            //How do we shuffle?
            //for rightIndex from numberOfCards - 1 down to 1 do:
            for (var rightIndex = allCardsOnTheDeck - 1; rightIndex >= 1; rightIndex--)
            {
                //leftIndex = random integer that is greater than or equal to 0 and LESS than rightIndex. 
                var randomNumberGenerator = new Random();//using method Random
                var leftIndex = randomNumberGenerator.Next(rightIndex);
                // Now swap the values at rightIndex and leftIndex by doing this:
                var leftCard = deck[leftIndex];
                var rightCard = deck[rightIndex];
                deck[rightIndex] = leftCard;
                deck[leftIndex] = rightCard;
                // After the deck is shuffled, display the top two cards.
                //Showing firstCard
                var firstCard = deck[0];
                //Showing SecondCard
                var secondCard = deck[1];
                Console.WriteLine($"The first card is: {firstCard}, the second card is: {secondCard}.\n");
                // System.Console.WriteLine($"How many cards I have: {allCardsOnTheDeck}. \n");
            };
            Console.WriteLine("End of Shuffle");
        }
    }
}
