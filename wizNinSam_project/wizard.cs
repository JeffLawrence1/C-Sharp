using System;
using System.Collections.Generic;

namespace wizNinSam_project{
    public class Wizard: Human{
        Random rand = new Random();
        public Wizard(
            string name,
            int strength,
            int dexterity,
            int health = 50,
            int intelligence = 25) : base(name, strength, intelligence, dexterity, health){
                
            }

        public void heal(){
                health += 10 * intelligence;
                Console.WriteLine($"health now at {health}");
            }

            public void Fireball(Human enemy){
                
                int blast = rand.Next(20, 50);
                enemy.health -= blast;
                Console.WriteLine($"{enemy.name} health reduced by {blast}");
            }
    }
}