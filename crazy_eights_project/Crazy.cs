using System;
using System.Collections.Generic;

namespace crazy_eights_project{
    public class Crazy{
    private int users = 0;
    private Player p1;
    private Player p2;
    private Player p3;
    private Player p4;

    private List<Player> players = new List<Player>();
    public Crazy(List<string> names){
        users = names.Count;
        
        p1 = new Player(names[0]);
        p2 = new Player(names[1]);
        if(users > 2){
            p3 = new Player(names[2]);
        }
        if(users > 3){
            p4 = new Player(names[3]);
        }
      
        players.Add(p1);
        players.Add(p2);
        players.Add(p3);
        players.Add(p4);
    }
        public void StartGame(){
            if(users == 4){
                Console.WriteLine($"Players: {p1.Name}, {p2.Name}, {p3.Name}, {p4.Name}");
            }
            else{
                Console.WriteLine("Something went wrong, need 4 players");
                return;
            }
            Deck d1 = new Deck();
            
            for(int i = 0; i < 5; i++){
                p1.Draw(d1);
                p2.Draw(d1);
                p3.Draw(d1);
                p4.Draw(d1);
            }
            // Console.WriteLine(string.Join(",", p1.hand));
            // Console.WriteLine(string.Join(",", p2.hand));
            // Console.WriteLine(string.Join(",", p3.hand));
            // Console.WriteLine(string.Join(",", p4.hand));
            Card topCard = d1.Deal();
            // Console.WriteLine($"Top card: {topCard}");

            bool endGame = false;
            while(!endGame) {

                foreach(Player player in players) {
                    bool turnCompleted = false;
                    while(!turnCompleted){
                        Console.WriteLine($"Top Card: {topCard}");                
                        Console.WriteLine(player.Name);
                        for(int i = 0; i < player.hand.Count; i++){
                            Console.WriteLine($"{i}: {player.hand[i]}");
                        }
                        // foreach(Card c in p1.hand)
                        // Console.WriteLine(string.Join(",", p1.hand));
                        Console.WriteLine("Press 1 to play card, 2 to draw");
                        string inputLine = Console.ReadLine();
                        if(inputLine == "1"){
                            Card newCard = Play(topCard, player);
                            if(player.hand.Count == 0) {
                                endGame = true;
                                Console.WriteLine($"Congratulations {player.Name} is the winner!!!!");
                                break;
                            }
                            if(newCard != null){
                                topCard = newCard;
                                turnCompleted = true;
                                continue;
                            }
                            else {
                                player.Draw(d1);
                            }
                        }
                        else if(inputLine == "2"){
                            player.Draw(d1);
                            
                        }
                        else{
                            player.Draw(d1);
                            
                        }
                        
                    }

                    if(endGame){
                        break;
                    }
                }
            }

        }

        public Card Play(Card topCard, Player player){
            Card ppC = null;
            
            Console.WriteLine("type in number of card to play");
            string playedCard = Console.ReadLine();
            // double playCard = Convert.ToDouble(playedCard);
            // int pC = Convert.ToInt32(playedCard);                
            int pC = 0;
            if (Int32.TryParse(playedCard, out pC)) {
                ppC = player.hand[pC];

                if(ppC.suit == topCard.suit || ppC.val == topCard.val || ppC.val == 8){
                    Console.WriteLine($"{ppC} works");
                    player.hand.RemoveAt(pC);
                }
                else{
                    Console.WriteLine("Stop trying to cheat!!!");
                    ppC = null;                
                }
            }

            return ppC;
        }    
    }
}