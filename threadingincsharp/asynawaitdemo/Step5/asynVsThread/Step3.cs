using System;
using System.Threading;
using System.Threading.Tasks;

namespace asynawaitdemo.Step5.asynVsThread
{
    class Step3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Take away: async await, does not create new threads...");
            Console.WriteLine("Main Thread started.....");
            SomeMethod();
            Console.WriteLine("Main Thread code end, does not wait");
            Console.ReadKey();
        }
        static async void SomeMethod()
        {
            Console.WriteLine("Asyn code  running... 5 secs");
            await Task.Delay(5000); //This does not create new thread
            //Thread.Sleep(5000); //above line same as this, It will sleep main thread for 5 secs
            Console.WriteLine("Asyn code finished...");
        }
    }
}
