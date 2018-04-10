using System;

namespace deckOfCards_project
{
    class Program
    {
        static void Main(string[] args)
        {

            Deck d1 = new Deck();
            Player p1 = new Player("Sample");
            Player p2 = new Player("Fred");
            Console.WriteLine(d1);
            d1.Shuffle();
            Console.WriteLine(d1);
            p1.Draw(d1);
            p2.Draw(d1);
            p1.Draw(d1);
            p2.Draw(d1);
            p1.Draw(d1);
            p2.Draw(d1);
            p1.Draw(d1);
            p2.Draw(d1);
            p1.Draw(d1);
            p2.Draw(d1);
            Console.WriteLine("-------");
            Console.WriteLine(p1.name);
            Console.WriteLine(string.Join(",", p1.hand));
            Console.WriteLine(p2.name);
            Console.WriteLine(string.Join(",", p2.hand));
            p1.Discard(0);
            p1.Discard(2);
            p1.Draw(d1);
            p1.Draw(d1);
            Console.WriteLine(p1.name);
            Console.WriteLine(string.Join(",", p1.hand));
            d1.Reset();
            Console.WriteLine(d1);
            d1.Shuffle();
            Console.WriteLine(d1);
            // p1.Draw(d1);
            // p2.Draw(d1);
            // p1.Draw(d1);
            // p2.Draw(d1);
            // p1.Draw(d1);
            // p2.Draw(d1);
            // p1.Draw(d1);
            // p2.Draw(d1);
            // p1.Draw(d1);
            // p2.Draw(d1);
            // Console.WriteLine("-------");
            // Console.WriteLine(p1.name);
            // Console.WriteLine(string.Join(",", p1.hand));
            // Console.WriteLine(p2.name);
            // Console.WriteLine(string.Join(",", p2.hand));
        }
    }
}
