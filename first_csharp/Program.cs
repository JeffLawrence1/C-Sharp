using System;

namespace first_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // loop from 1 to 5 including 5
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}
// loop from 1 to 5 excluding 5
for (int i = 1; i < 5; i++)
{
    Console.WriteLine(i);
}
int start = 0;
int end = 5;
// loop from start to end including end
for (int i = start; i <= end; i++)
{
    Console.WriteLine(i);
}
// loop from start to end excluding end
for (int i = start; i < end; i++)
{
    Console.WriteLine(i);
}
for (int i = 1; i < 6; i = i + 1)
{
    Console.WriteLine(i);
}
int x = 1;
while (x < 6)
{
    Console.WriteLine(x);
    x = x + 1;
}
        }
    }
}
