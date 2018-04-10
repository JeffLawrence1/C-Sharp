using System;

namespace cars_project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Truck Ford400 = new Truck(4, "Ford", "400", 1995, 132000, "cloth");
            Console.WriteLine(Ford400.drive(50));
            Console.WriteLine(Ford400.carWashCost(10.44));
            Car Mercedes = new Car(4, "Mercedes", "SL", 2011, 45000, "Leather");
            Console.WriteLine(Mercedes.drive(100));
            Console.WriteLine(Mercedes.carWashCost(9.44));
            SportsCar Acura = new SportsCar(4, "Acura", "Integra", 2005, 89000, "Leather");
            Console.WriteLine(Acura.drive(200));
            Console.WriteLine(Acura.carWashCost(7.44));
            Car Ford300 = new Truck(4, "Ford", "400", 1995, 132000, "cloth");
            Console.WriteLine(Ford300.drive(80));
            Console.WriteLine(Ford300.carWashCost(6.44));
            if(Ford300 is Truck){
                Console.WriteLine("Truck");
            }
            if(Ford300 is SportsCar){
                Console.WriteLine("Not Truck");
            }
        }
    }
}
