using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace asynawaitdemo.Step5.ConcurancyVsParallelism
{
    class Step4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We will see how we can run this downloading files in backround on dirrent cores and improve te performace.");

            Console.WriteLine("Main thread...");

            Task.Factory.StartNew(Metod1);
            Task.Factory.StartNew(Metod2);


            Console.WriteLine("Main thread does not wait for long running methods...");
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
            Console.WriteLine("Do you think it is user friendly Andmore faster ? Yes.");

            Console.WriteLine("We have seen how we are not blcoking the ui, by running long running tasks on a different context using async await key words and running on a different worker thread...");

            Console.WriteLine("I am improving the performance by running long running codes on different processors using task parallel library");

            Console.WriteLine("In order to improve performamce in task library, we have to have two different methods which does not require to communicate. Otherwise it will be under useage of task parallal library");

        }
    }
}
