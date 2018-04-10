using System;

namespace wizNinSam_project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Wizard curly = new Wizard("Curly", 3, 3);
            Samurai fred = new Samurai("Fred", 45, 4, 34);
            Samurai fredy = new Samurai("Fred", 45, 4, 34);
            Samurai fredyyy = new Samurai("Fred", 45, 4, 34);
            Ninja sample = new Ninja("Sample", 15, 45, 12);
            curly.heal();
            fred.death_blow(sample);
            sample.steal();
            sample.getAway();
            curly.Fireball(sample);
            curly.Fireball(fred);
            fred.meditate();
            Samurai.how_many();
            curly.Fireball(fred);
            curly.Fireball(fred);
            curly.Fireball(fred);
            curly.Fireball(fred);
            curly.Fireball(fred);
        }
    }
}
