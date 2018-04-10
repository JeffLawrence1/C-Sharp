using System;

namespace crazy_eights_project{
     public class Card{
        public string stringVal {
            get {
                if(val > 1 && val < 11){
                    return val.ToString();
                }
                else if (val == 11){
                    return "Jack";
                }
                else if (val == 12){
                    return "Queen";
                }
                else if (val == 13){
                    return "King";
                }
                else{
                    return "Ace";
                }
            }
        }
        public string suit;
        public int val;

        public Card(string csuit, int cnum){
            suit = csuit;
            val = cnum;
        }
        public override string ToString(){
            return stringVal + " of " + suit;
        }
    }
}