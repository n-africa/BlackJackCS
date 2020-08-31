using System;
using System.Collections.Generic;

namespace BlackJackCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var deck = new List<string>();
            var suits = new List<string>() { "Hearts", "Diamonds", "Spades", "Clubs" };
            var ranks = new List<string>() { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };

            foreach (var suit in suits) ;
            foreach (var rank in ranks) ;

            Console.WriteLine($"Plucked this card: {ranks} of {suits}");



        }
    }
}
