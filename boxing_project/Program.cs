using System;
using System.Collections.Generic;

namespace boxing_project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            List<object> nList = new List<object>();
            nList.Add(7);
            nList.Add(28);
            nList.Add(-1);
            nList.Add(true);
            nList.Add("chair");
            for(int i = 0; i < nList.Count; i++){
                if(nList[i] is int){
                    Console.WriteLine("{0} is int", nList[i]);
                }
                if(nList[i] is string){
                    Console.WriteLine("{0} is string", nList[i]);
                }
                if(nList[i] is bool){
                    Console.WriteLine("{0} is bool", nList[i]);
                }
            }
            int sum = 0;
            // int temp = 0;
            for(int i = 0; i < nList.Count; i++){
                if(nList[i] is int){

                    int o = (int)nList[i];
                    // i = (int)o;
                    sum += o;
                }                
        }
        Console.WriteLine(sum);
    }
}
}
