using System;

namespace human_project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Human p1 = new Human("Sample");
            Human p2= new Human("Fred");
            p1.Attack(p2);
            Console.WriteLine($"{p1.Name} attacked {p2.Name}, {p2.Name}'s health is reduced to {p2.Health}");
            Human p3 = new Human("Frank");
            p3.Attack(p2);
            Console.WriteLine($"{p3.Name} attacked {p2.Name}, {p2.Name}'s health is reduced to {p2.Health}");
        }
    }
}
