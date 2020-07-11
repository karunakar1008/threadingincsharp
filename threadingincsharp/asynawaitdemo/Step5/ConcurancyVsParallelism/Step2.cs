using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace asynawaitdemo.Step5.ConcurancyVsParallelism
{
    class Step2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Downloading file-1");
            Console.WriteLine("........");


            Task.Delay(5000).Wait();
            Console.WriteLine("Download file-1 Completed");

            Task.Delay(1000).Wait();

            Console.WriteLine("Downloading file-2");
            Console.WriteLine("........");


            Task.Delay(5000).Wait();

            Console.WriteLine("Download file-2 Completed");

            Console.WriteLine("Start data input");

            string str = Console.ReadLine();
            Console.WriteLine("You have entered data: {0}",str);

            Console.WriteLine("Do you think it is user friendly, blocking the user till the files gets downloaded? Obviously No.");

            Console.WriteLine("We will see in next example how we will improve thr usability of the application...");

            Console.ReadKey();


        }
    }
}
