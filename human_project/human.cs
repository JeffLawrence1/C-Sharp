using System;

namespace human_project{
    public class Human{
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Dexterity { get; set; }
        public int Health { get; set; }

        public Human(string name, int strength = 3, int intelligence = 3, int dexterity = 3, int health = 100){
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Health = health;
        }
        public Human(string name){
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;
        }
        // public void Attack(Human enemy){
        //     enemy.Health -= 5 * Strength;
        // }
        public void Attack(object target){
            Human enemy = target as Human;
            if(enemy != null){
                enemy.Health -= 5 * Strength;
            }
        }
    }
}