using System;
using System.Collections.Generic;

namespace crazy_eights_project{
        public class Deck {
        public List<Card> cards;

        public Deck() {
            Reset();
            Shuffle();
        }

        public Card Deal() {
            if(cards.Count > 0) {
                Card temp = cards[0];
                cards.RemoveAt(0);
                return temp;
            }
            else{
                Reset();
                Shuffle();
                Card temp = cards[0];
                cards.RemoveAt(0);
                Console.WriteLine("Shuffling..............");
                Console.WriteLine("Shuffling..............");
                Console.WriteLine("Shuffling..............");
                Console.WriteLine("Shuffling..............");
                Console.WriteLine("Shuffling..............");
                Console.WriteLine("Shuffling..............");
                Console.WriteLine("Shuffling..............");
                Console.WriteLine("Shuffling..............");
                Console.WriteLine("Shuffling..............");
                Console.WriteLine("Shuffling..............");
                return temp;
            }
           
        }

        public Deck Shuffle() {
            Random rand = new Random();
            for(int i = cards.Count - 1; i > 0; i--) {
                int rando = rand.Next(i);
                Card temp = cards[rando];
                cards[rando] = cards[i];
                cards[i] = temp;
            }
            return this;
        }

        public Deck Reset() {
            cards = new List<Card>();
            string[] suits = new string[4] {"Hearts","Clubs","Spades","Diamonds"};
            foreach(string suit in suits) {
                for(int val = 1; val <= 13; val++) {
                    cards.Add(new Card(suit, val));
                }
            }
            return this;
        }

        public override string ToString() {
            string info = "";
            foreach(Card card in cards) {
                info += card + "\n";
            }
            return info;
        }
    }
}
