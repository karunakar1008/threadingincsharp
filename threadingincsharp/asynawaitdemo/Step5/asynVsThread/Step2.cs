using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace asynawaitdemo.Step5.asynVsThread
{
    class Step2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread started.....");
            SomeMethod();
            Console.WriteLine("Main Thread code end");

        }
        static void SomeMethod()
        {
            Console.WriteLine("Main thread suspended for 5 secs");
            Task.Delay(5000).Wait();
        }
    }
}
