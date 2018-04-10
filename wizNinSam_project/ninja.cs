using System;

namespace wizNinSam_project{
        public class Ninja: Human{
        public Ninja(
            string name,
            int strength,            
            int health,
            int intelligence,
            int dexterity = 175) : base(name, strength, intelligence, dexterity, health){
                
            }
            public void steal(){
                health += 10;
                Console.WriteLine($"health now at {health}");
            }
            public void getAway(){
                health -= 15;
                Console.WriteLine($"health now at {health}");
            }
        }
}