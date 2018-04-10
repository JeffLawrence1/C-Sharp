using System;
using System.Collections.Generic;

namespace collections_practice_project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int[] myArr = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            string[] sArr = {"Tim", "Martin", "Nikki", "Sara"};
            bool[] bArr = new bool[10];
            for(int i = 0; i < bArr.Length; i+=2){
                bArr[i] = true;
            }
            Console.WriteLine(string.Join(",", myArr));
            Console.WriteLine(string.Join(",", sArr));
            Console.WriteLine(string.Join(",", bArr));

            // multiplication table
            int[,] table = GenerateTT(10);
            DisplayTT(table);

            // list of flavors
            string[] flav = {"Chocolate", "Vanilla", "Strawberry", "Oreo", "Chocolate Chip Mint"};
            Console.WriteLine(flav.Length);
            Console.WriteLine(flav[2]);
            string[] newFlav = new string[flav.Length];        
            for(var i = 0; i < flav.Length; i++){
                if(flav[i] == flav[2]){
                    continue;
                }
                else{  
                    newFlav[i] = flav[i];
                }
                Console.WriteLine(string.Join(",", newFlav));
                
            }
            // user info dictionary
            Dictionary<string,string> profile = new Dictionary<string,string>();
            profile.Add("Tim", "null");
            profile.Add("Martin", "null");
            profile.Add("Nikki", "null");
            profile.Add("Sara", "null");
            profile["Tim"] = "Chocolate";
            profile["Martin"] = "Strawberry";
            profile["Nikki"] = "Chocolate Chip Mint";
            profile["Sara"] = "Oreo";
            foreach (var entry in profile)
            {
            Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }
        public static int[,] GenerateTT(int size){
            int[,] table = new int[size, size];
            for(int i = 0; i< size; i++){
                for(int j=0; j<size; j++){
                    table[i, j] = (i+1) * (j+1);
                }
            }
            return table;
        }
        public static void DisplayTT(int[,] table){
            for (int i = 0; i < table.GetLength(0); i++)      
                {      
                for (int j = 0; j < table.GetLength(1); j++)      
                 {      
                    Console.Write("{0}\t", table[i, j]);     
                    }      
                        Console.WriteLine("\n");      
                    } 
            }
        
    }
}
