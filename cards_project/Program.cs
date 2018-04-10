using System;

namespace cards_project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Deck newDeck = new Deck();
            // foreach (Card c in newDeck.cards){
            //     Console.WriteLine(c);
            // Card drawn = newDeck.Deal();
            // Console.WriteLine(drawn);
            Player henry = new Player("Henry");
            Player erik = new Player("Erik");
           for(int i = 0; i < 5; i++){
            henry.Draw(newDeck).Draw(newDeck);
            erik.Draw(newDeck);
            }
            henry.ShowHand();
            erik.ShowHand();
        }
    }
}
