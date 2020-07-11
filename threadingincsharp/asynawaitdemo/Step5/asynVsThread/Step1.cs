using System;
using System.Collections.Generic;
using System.Text;

namespace asynawaitdemo.Step5.asynVsThread
{
    class Step1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aync(async or await): ------------------------Differences---------------------------------: Threads");

            Console.WriteLine("Asyncronous code does not use threads-------------------------------Runing multiple tasks parallely on multple threads to run multiple tasks");
         
            Console.WriteLine("Async all about  improve usability but not about improving the performance");

            Console.WriteLine("It is all about how the different functions communicate each other------------------------------");

            Console.WriteLine("It is all about ensuring main thread is non blocking-------------------------------");


            Console.WriteLine("Aync(async or await): ------------------------Differences---------------------------------: Threads");


            Console.WriteLine("Mixing both with leads to bad design some times");


        }
    }
}
