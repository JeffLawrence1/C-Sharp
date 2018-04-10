using System;

namespace fundamentals_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // for(int i = 0; i <= 255; i++){
            //     Console.WriteLine(i);
            // }
            // for(int x = 1; x <= 100; x++){
            //     if(x % 3 == 0 && x % 5 != 0){
            //         Console.WriteLine("3: {0}", x);
            //     }
            //     else if (x % 5 == 0 && x % 3 != 0){
            //         Console.WriteLine("5: {0}", x);
            //     }
            
                for(int x = 1; x <= 100; x++){
                if(x % 3 == 0 && x % 5 != 0){
                    Console.WriteLine("3: {0}, {1}", x, "Fizz");
                }
                else if (x % 5 == 0 && x % 3 != 0){
                    Console.WriteLine("5: {0}, {1}", x, "Buzz");
                }
                else if(x % 5 == 0 && x % 3 == 0){
                    Console.WriteLine("FizzBuzz");
                }
                
            }
            Random rand = new Random();
            for(int val = 0; val < 10; val++){
                int num = rand.Next(0, 100);
                if(num % 3 == 0 && num % 5 != 0){
                    Console.WriteLine("3: {0}, {1}", num, "Fizz");
                }
                else if (num % 5 == 0 && num % 3 != 0){
                    Console.WriteLine("5: {0}, {1}", num, "Buzz");
            }
                else if(num % 5 == 0 && num % 3 == 0){
                    Console.WriteLine("FizzBuzz");
        }
                else{
                    Console.WriteLine(num);
                }
            }
    }
}
}
