using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace asynawaitdemo.Step5.ConcurancyVsParallelism
{
    class Step3
    {

        static void Main(string[] args)
        {
            Console.WriteLine("We will see how we can run this downloading files in backround and improve the useability.");
            Console.WriteLine("We will see how we can run this downloading files in backround and improve the useability.");

            Console.WriteLine("Main thread...");

            Metod1();
            Metod2();

            Console.WriteLine("Main thread dows not wait for long running methods...");
            Console.WriteLine("Start data input");

            string str = Console.ReadLine();
            Console.WriteLine("You have entered data: {0}", str);


            Console.ReadKey();
        }

        public static async void Metod1()
        {
            Console.WriteLine("Downloading file-1 in background on a different thread");
            Console.WriteLine("........");

            await Task.Delay(5000);
            Console.WriteLine("Download file-1 Completed");

        }

        public static async void Metod2()
        {
            Console.WriteLine("Downloading file-2 in background");
            Console.WriteLine("........");
            await Task.Delay(5000);
            Console.WriteLine("Download file-2 Completed");

            Learnings();

        }

        public static void Learnings()
        {
            Console.WriteLine("Do you think it is user friendly now ? Yes.");

            Console.WriteLine("We have seen how we are not blcoking the ui, by running long running tasks on a different thread using async await key words...");

            Console.WriteLine("I am not running my code on different processors but I am running on  different thread to improve the useability");

        }

    }
}
