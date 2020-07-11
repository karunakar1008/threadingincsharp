using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace asynawaitdemo.Threading
{
    class Step1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is Threading really utilizing  my computer hardware capacity  Or it is just a time slicing or switiching between threads");


            Console.WriteLine("Main thread Started");

            Thread thread1 = new Thread(RunMillionIterations); 
            thread1.Start(); //Start new thread to process RunMillionIterations function.

            //Parallel.For(0, 1000000, x=>RunMillionIterations()); //Get full benefit of hardware cpu, thread pooling is done automatically by task parallel ,ibrary

            Console.WriteLine("Main thread do not wait for worker thread to be completed");

            Console.ReadKey();

        }

       //It runs lonnger time , it is good to run this method on a different thread without blicking UI thread.
        public static void RunMillionIterations()
        {
            Console.WriteLine("Long running method is processing.....");

            for (int i = 0; i < 1000000; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Long running method is processing completed");

        }
    }
}

