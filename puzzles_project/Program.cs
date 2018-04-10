using System;
using System.Collections.Generic;

namespace puzzles_project
{
    class Program
    {

        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            randomArr(10);
            tossCoin();
            tossCoin2(5);
            names();
        }
        public static int[] randomArr(int num){
            Random rand = new Random();
            int[] tempArr = new int[num];
            int max = tempArr[0];
            int min = tempArr[0];
            int sum = 0;
            for(int i = 0; i <= num-1; i++){
                int randonum = rand.Next(5, 25);
                tempArr[i] = randonum;
                if(max < tempArr[i]){
                    max = tempArr[i];
                }
                if(min > tempArr[i]){
                    min = tempArr[i];
                }
                sum += tempArr[i];
            }
            Console.WriteLine(string.Join(",", tempArr));
            Console.WriteLine($"max: {max} min: {min} sum: {sum}");
            return tempArr;
        }
        public static string tossCoin(){
            Console.WriteLine("Tossing a Coin!");
            Random rand = new Random();
            int cToss = rand.Next(0,2);
            if(cToss == 0){
               Console.WriteLine("Heads!"); 
            }
            if(cToss == 1){
                Console.WriteLine("Tails!");
            }
            string o = cToss.ToString();
            return o;
        }
        public static double tossCoin2(int num){
            Random rand = new Random();
            
            double count = 0;
            for(int i = 0; i <= num; i++){
                int cToss = rand.Next(0,2);
                if(cToss == 0){
                Console.WriteLine("Heads!"); 
                count += 1;
                }
                if(cToss == 1){
                Console.WriteLine("Tails!");
                }
                // int o = cToss;
                // double x = o;
                
            }
            Console.WriteLine(count/num);
            return count/num;
        }
        public static string[] names(){
            string[] tempArr = {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            string[] temArr = new string[tempArr.Length];
            
            temArr[0] = tempArr[2];
            temArr[1] = tempArr[4];
            temArr[2] = tempArr[1];
            temArr[3] = tempArr[0];
            temArr[4] = tempArr[3];
            Console.WriteLine(string.Join(",", temArr));

            List<string> nameList = new List<string>();
            foreach(var name in tempArr){
                nameList.Add(name);
            }
            return nameList.ToArray();
            
            }
        
    }
}
