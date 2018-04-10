using System;
using System.Collections.Generic;

namespace cards_project{
    class Player{
        public string username { get; set; }
        public double money { get; set; }
        public List<Card> hand { get; set; }
        public Player (string name) {
            username = name;
            money = 1000;
            hand = new List<Card>();
        }
        public Player Draw(Deck d){
            Card drawnCard = d.Deal();
            hand.Add(drawnCard);
            return this;
        }
        public void ShowHand(){
            for (int i = 0; i < hand.Count; i++){
                Console.WriteLine($"{i} - {hand[i]}");
            }
        }
        public Card Discard(int i){
            Card c = hand[i];
            hand.RemoveAt(i);
            return c;
        }
    }
}