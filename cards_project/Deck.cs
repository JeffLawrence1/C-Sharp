using System;
using System.Collections.Generic;

namespace cards_project{
    class Deck{
        public List<Card> cards { get; set; }
        public Deck(){
            Reset();
            Shuffle();
        }
            public void Reset(){
                 cards = new List<Card>();
            string[] suits = {"diamonds", "hearts", "clubs", "spades"};
            for (int i = 1; i < 14; i++){
                foreach (string s in suits){
                    cards.Add(new Card(i, s));
                    
                }
            }
        }
        public void Shuffle(){
            Random rand = new Random();
            for (int i = 0; i < cards.Count; i++){
                int idx1 = rand.Next(0, cards.Count);
                // int idx2 = rand.Next(0, cards.Count);
                Card temp = cards[i];
                cards[i] = cards[idx1];
                cards[idx1] = temp;
            }
        }
        public Card Deal(){
            Card dealt;
            if (cards.Count > 0){
                dealt = cards[0];
            }
            else{
                return null;
            }
            cards.RemoveAt(0);
            return dealt;
        }
     }
 }
