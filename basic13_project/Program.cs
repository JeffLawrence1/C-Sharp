using System;

namespace basic13_project
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1-255
            for(int i = 1; i <= 255; i++){
                Console.WriteLine(i);
            }
            // 1-255 odd
            for(int i = 1; i <= 255; i+=2){
                Console.WriteLine(i);
            }
            // print sum
            int sum = 0;
            for(int i = 1; i <= 255; i++){
                sum += i;
                Console.WriteLine("New number: {0} Sum: {1}", i, sum);
            }
            // iterate through array\
            int[] myArr = {1,3,5,7,9,13};
            foreach(int myInt in myArr){
                Console.WriteLine(myInt);
            }
            // find max
            int max = myArr[0];
            for(int i = 0; i < myArr.Length; i++){
                if(max < myArr[i]){
                    max = myArr[i];
                } 
            }
            Console.WriteLine(max);

            // get average
            sum = myArr[0];
            for(int i = 0; i < myArr.Length; i++){
                sum += myArr[i];
            }
            Console.WriteLine($"Average equals {sum/myArr.Length}");
            Console.WriteLine("Average equals {0}", sum/myArr.Length);

            // Array with odd numbers
            int totalnum = 255;
            int remainder = 255 % 2;
            int length = totalnum/2 + remainder;
            int[] intArr = new int[length];
            int j = 1;
            for(int i = 0; i < intArr.Length; i++){
                intArr[i] = j;
                j += 2;
            }
            Console.WriteLine(string.Join(",", intArr));

            // greater than Y
            // int count = 0;
            // int Y = 7;
            // foreach(int myInt in myArr){
            //     if(myInt > Y){
            //         count += 1;
            //     }
            // }
            // Console.WriteLine(count);
            greaterThanY(myArr, 7);
            Console.WriteLine(string.Join(",", squareVal(myArr)));
            int[] nyArr = {-2, 4, 5, -7, 8, -9};
            int[] tArr = negVal(nyArr);
            Console.WriteLine(string.Join(",", tArr));
            minMax(myArr);
            Console.WriteLine(string.Join(",", shift(myArr)));
            Console.WriteLine(string.Join(",", numString(nyArr)));

        }
        
        public static int greaterThanY(int[] myArr, int Y){
          int count = 0;
            foreach(int myInt in myArr){
                if(myInt > Y){
                    count += 1;
                }
            }
            Console.WriteLine(count);
            return count;
        }
        public static int[] squareVal(int[] myArr){
            int[] newArr = new int[myArr.Length];
            for(int i = 0; i < myArr.Length; i++){
                newArr[i] = myArr[i] * myArr[i];
            }
            return newArr;
        }
        // eliminate negatives
        public static int[] negVal(int[] nyArr){
            int[] tempArr = new int[nyArr.Length];
            for(int i = 0; i < nyArr.Length; i++){
                if(nyArr[i] < 0){
                    tempArr[i] = 0;
                }
                else{
                    tempArr[i] = nyArr[i];
                }
            }
            return tempArr;
        }
        // min max avg
        public static void minMax(int[] myArr){
            int max = myArr[0];
            int min = myArr[0];
            int sum = 0;
            for(int i =1; i < myArr.Length; i++){
                if(max < myArr[i]){
                    max = myArr[i];
                }
                if(min > myArr[i]){
                    min = myArr[i];
                }
                sum += myArr[i];
            }
            Console.WriteLine("max: {0} min: {1} avg: {2}", max, min, sum/myArr.Length);
        }
        public static int[] shift(int[] myArr){
            int[] tempArr = new int[myArr.Length];
            for(int i = 0; i < myArr.Length-1; i++){
                tempArr[i] = myArr[i+1];
            }
            return tempArr;
        }
        public static object[] numString(int[] nyArr){
            object[] tempArr = new object[nyArr.Length];
            for(int i = 0; i < nyArr.Length; i++){
                if(nyArr[i] < 0){
                    tempArr[i] = "Dojo";
                }
                else{
                    tempArr[i] = nyArr[i];
                }
            }
            return tempArr;
        }
    }
}
