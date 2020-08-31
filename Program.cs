using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJackCS
{
    class Cards
    {
        public string Suit { get; set; }
        public string Rank { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {

            // List of Cards with faces and suits.
            var deck = new List<Cards>();
            var suits = new List<string>() { "Hearts", "Diamonds", "Spades", "Clubs" };
            var ranks = new List<string>() { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };
            // Link the lists of face and suits to make one card.


            //THIS LOOP IS NOT WORKING FOR SOME REASON 😡

            // for (var suitIndex = 0; suitIndex < suits.Count; suitIndex++)
            // {
            //     Console.Write(suits[suitIndex]);

            //     for (var rankIndex = 0; rankIndex < ranks.Count; rankIndex++)
            //     {
            //         Console.WriteLine(ranks[rankIndex]);
            //     }

            // }

            foreach (var suit in suits)
            {
                foreach (var rank in ranks)
                {

                    var newCard = new Cards()
                    {
                        Suit = suit,
                        Rank = rank,

                    };

                    deck.Add(newCard);

                }
            }

            var n = deck.Count();
            var randomNumberGenerator = new Random();


            // for rightIndex from n - 1 down to 1 do:
            for (var rightIndex = n - 1; rightIndex > 1; rightIndex--)
            {
                //   leftIndex = random integer that is greater than or equal to 0 and LESS than rightIndex
                var leftIndex = randomNumberGenerator.Next(rightIndex);

                //   Now swap the values at rightIndex and leftIndex by doing this:



                //  leftCard = the value from deck[rightIndex]
                var leftCard = deck[rightIndex];
                //     rightChard = the value from deck[leftIndex]
                var rightCard = deck[leftIndex];
                //     deck[rightIndex] = rightChard
                deck[rightIndex] = rightCard;
                //     deck[leftIndex] = leftCard
                deck[leftIndex] = leftCard;
            }

            var dealtCard = deck[0];
            Console.WriteLine($"{dealtCard.Rank} of {dealtCard.Suit}");


            // Match the cards to values.
            // Two = 2
            // Three = 3
            // Four = 4
            // Five = 5
            // Six = 6
            // Seven = 7
            // Eight = 8
            // Nine = 9
            // Ten = 10 
            // Jack = 10
            // Queen = 10
            // King = 10
            // Ace = 11
            // Dealing two cards.
            // Keeping each card in Player hand.
            // Keeping each card in Dealer hand.
            // Keep Dealer cards hidden until the game is complete.
            // Show player cards to player.
            // Ask play if the want to hit or stand.
            // If player hit, add another card to hand.
            // Else stand.
            // If stand, Dealer reveals hand and hits until 17 or more.
            // If Dealer goes over 21, then Dealer loses.
            // If Player goes over 21, Bust and Dealer Wins.
            // If neither values are over 21, then whoever closest to 21 is the winner.
            // If values are the same then the ties go to the dealer.
            // Ask if player, they want to play again, if yes, begin again with new deck of cards. If not, quit app and say goodbye.



        }
    }
}
