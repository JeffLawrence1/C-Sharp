using System;

namespace wizNinSam_project{
    public class Samurai: Human{
        public static int count = 0;
        public Samurai(
            
            string name,
            int strength,                        
            int intelligence,
            int dexterity,
            int health = 200) : base(name, strength, intelligence, dexterity, health){
            count++;
            }
            public void death_blow(Human enemy){
                if(enemy.health < 50){
                    enemy.health = 0;
                    Console.WriteLine($"{enemy.name} is dead!");
                }
            }
            public void meditate(){
                health = 200;
                Console.WriteLine($"health now at {health}");
            }
            public static void how_many() {
            Console.WriteLine(count);
            }
    }
}