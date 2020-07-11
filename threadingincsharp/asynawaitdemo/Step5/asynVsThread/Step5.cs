using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace asynawaitdemo.Step5.asynVsThread
{
    class Step5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Take away: async await, does not create new threads...");
            Console.WriteLine("Main Thread started.....Thread Id: {0}", Thread.CurrentThread.ManagedThreadId);
            Thread workerThread = new Thread(SomeMethod);
            workerThread.Name = "MyThread";
            workerThread.Start(); //new thread started
            Console.WriteLine("Main Thread code end, does not wait");
            Console.ReadKey();
        }
        static async void SomeMethod()
        {
            Console.WriteLine("Asyn code  running... 5 secsThread Id: {0}", Thread.CurrentThread.ManagedThreadId);
            await Task.Delay(5000); //sleep the thread which running this method for 5 secs
            Console.WriteLine("Asyn code finished...");
        }
    }
}
