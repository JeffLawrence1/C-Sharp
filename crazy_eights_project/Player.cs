using System;
using System.Collections.Generic;

namespace crazy_eights_project{
        public class Player {
        public string Name { get; set; }
        public List<Card> hand;

        public Player(string name) {
            hand = new List<Card>();
            this.Name = name;
        }

        public void Draw(Deck currentDeck) {
            hand.Add(currentDeck.Deal());
        }
        
        public Card Discard(int i) {
            Card temp = hand[i];
            hand.RemoveAt(i);
            return temp;
        }
    }
}