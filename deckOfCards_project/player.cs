using System.Collections.Generic;

namespace deckOfCards_project{
    public class Player {
        public string name;
        public List<Card> hand;

        public Player(string nam) {
            hand = new List<Card>();
            name = nam;
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