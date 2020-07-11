using System;
using System.Threading;

namespace asynawaitdemo
{

    class Step1
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("How to call an asyncronous method from a main thread and wait till the results comes from async method");
            Console.WriteLine("Synchronous programming: Each function will wait tilll the execution of previous functions");

            Factory program = new Factory();

            program.Task1();

            string result1 = program.Task2();

            int result2 = program.Task3();


            Console.WriteLine("Message at the end");

            Console.ReadKey();

        }

    }

    class Factory
    {
        public void Task1()
        {
            Console.WriteLine("Task1 completed");
        }
        public string Task2()
        {
            Console.WriteLine("Task2 Satrted at: {0}", DateTime.Now);
            Thread.Sleep(5000);
            Console.WriteLine("Task2 end at: {0}", DateTime.Now);
            return "Outted from task2";
        }
        public int Task3()
        {
            Console.WriteLine("Task3 completed");
            return 10;
        }
    }
}
