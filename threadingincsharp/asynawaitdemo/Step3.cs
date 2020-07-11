using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace asynawaitdemo
{
    class Step3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn How to call a long running method on a different thread, do not bother about the worker thread response");

            Console.WriteLine("async and await are code markers from where code should start executing after a method is called on a different thread or in asyncronous way");

            Console.WriteLine("Main thread Started");

            Metod();

            Console.WriteLine("Main thread do not wait for worker thread to be completed");

            Console.ReadKey();

        }

        public static async void Metod()
        {
            Console.WriteLine("New Thread started at: {0}", DateTime.Now);

            await Task.Run(new Action(LongTask));

            Console.WriteLine("New Thread end at: {0}", DateTime.Now);

        }
        public static void LongTask()
        {
            Console.WriteLine("Long running method is processing.....");

            Thread.Sleep(5000);
            Console.WriteLine("Long running method is processing completed");

        }
    }
}
