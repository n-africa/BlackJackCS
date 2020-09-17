using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJackCS
{
    class Cards
    {
        public string Suit { get; set; }
        public string Rank { get; set; }

        public int Value()
        {
            int answer = 0;

            switch (Rank)
            {
                case "Two":
                    answer = 2;
                    break;

                case "Three":
                    answer = 3;
                    break;

                case "Four":
                    answer = 4;
                    break;

                case "Five":
                    answer = 5;
                    break;

                case "Six":
                    answer = 6;
                    break;

                case "Seven":
                    answer = 7;
                    break;

                case "Eight":
                    answer = 8;
                    break;

                case "Nine":
                    answer = 9;
                    break;

                case "Ten":
                    answer = 10;
                    break;

                case "Jack":
                    answer = 10;
                    break;

                case "Queen":
                    answer = 10;
                    break;

                case "King":
                    answer = 10;
                    break;

                case "Ace":
                    answer = 11;
                    break;

            }

            return answer;

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
        }
    }
    class Hands
    {
        public List<Cards> Card = new List<Cards>();


        public void AddCardToHand(Cards cardAddedToHand)
        {
            Card.Add(cardAddedToHand);
        }


        public int HandValue()
        {
            var total = 0;
            foreach (var card in Card)
            {
                total = total + card.Value();
            }

            return total;
        }
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




            // Dealing two cards.
            // Make the Player hand.
            var playerHand = new Hands();

            // Make the Dealer hand.
            var dealerHand = new Hands();

            // Take the first card from the deck.
            var playerFirstCard = deck[0];

            // Take card card out of the deck.
            deck.Remove(playerFirstCard);

            // Add card to the hand.

            playerHand.AddCardToHand(playerFirstCard);

            // Repeat for the second card and the dealer
            var playerSecondCard = deck[0];
            deck.Remove(playerSecondCard);
            playerHand.AddCardToHand(playerSecondCard);

            var dealerFirstCard = deck[0];
            deck.Remove(dealerFirstCard);
            dealerHand.AddCardToHand(dealerFirstCard);

            var dealerSecondCard = deck[0];
            deck.Remove(dealerSecondCard);
            dealerHand.AddCardToHand(dealerSecondCard);

            // Show player cards. DO NOT SHOW DEALER CARDS!
            // Create values for the cards
            var additionalCard = deck[0];


            var playersChoice = "";


            while (playersChoice != "STAND" && playerHand.HandValue() < 21)
            {

                var total = 0;

                foreach (var card in playerHand.Card)
                {
                    Console.WriteLine($"You have the {card.Rank} of {card.Suit}.");

                    // Match the cards to values.
                    total = total + card.Value();
                }

                Console.WriteLine($"You have a total of {total}.");

                Console.Write("HIT OR STAND?  ");
                playersChoice = Console.ReadLine().ToUpper();

                if (playersChoice == "HIT")
                {
                    deck.Remove(additionalCard);
                    playerHand.AddCardToHand(additionalCard);

                }
                if (playerHand.HandValue() > 21)
                {
                    Console.WriteLine("BUST! DEALER WINS!! 💸💸");
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
            }
            if (playerHand.HandValue() == 21)
            {
                Console.WriteLine("BLACKJACK!! YOU WIN!!!! 🎉🎉🎉🎉");
            }
            while (playersChoice == "STAND" && dealerHand.HandValue() <= 21)
            {

                deck.Remove(additionalCard);
                dealerHand.AddCardToHand(additionalCard);

                if (dealerHand.HandValue() < playerHand.HandValue())
                {
                    Console.WriteLine($"Dealers total is {dealerHand.HandValue()}");
                    Console.WriteLine("DEALER WINS!! 💸💸");
                }

                if (dealerHand.HandValue() > playerHand.HandValue())
                {
                    Console.WriteLine($"Dealers total is {dealerHand.HandValue()}");
                    Console.WriteLine("YOU BEAT THE DEALER! YOU WIN!! 🎉🎉");
                }

                if (dealerHand.HandValue() == 21)
                {
                    Console.WriteLine($"Dealers total is {dealerHand.HandValue()}");
                    Console.WriteLine("DEALER GOT BLACKJACK! DEALER WINS!! 💸💸");
                }
            }

            if (dealerHand.HandValue() > 21)
            {
                Console.WriteLine($"Dealers total is {dealerHand.HandValue()}");
                Console.WriteLine("DEALER BUSTED! YOU WIN!! 🎉🎉");
            }

        }
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

