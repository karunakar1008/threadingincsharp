using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace asynawaitdemo.Step5.asynVsThread
{
    class Step4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Take away: async await, does not create new threads...");
            Console.WriteLine("Main Thread started.....");
            Thread workerThread = new Thread(SomeMethod);
            workerThread.Name = "MyThread";
            workerThread.Start(); //new thread started
            Console.WriteLine("Main Thread code end, does not wait");
            Console.ReadKey();
        }
        static async void SomeMethod()
        {
            Console.WriteLine("Asyn code  running... 5 secs");
            await Task.Delay(5000); //Suspend the thread which running this method for 5 secs
            Console.WriteLine("Asyn code finished...");
        }
    }
}
