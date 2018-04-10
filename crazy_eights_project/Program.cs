using System;
using System.Collections.Generic;

namespace crazy_eights_project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            List<string> names = new List<string>();
            names.Add("Jeff");
            names.Add("Jason");
            names.Add("Carson");
            names.Add("Fred");
            Crazy craz = new Crazy(names);
            craz.StartGame();

        }
    }
}
