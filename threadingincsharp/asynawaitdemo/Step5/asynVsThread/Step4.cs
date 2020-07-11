﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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
            Console.WriteLine("Main Thread started.....Thread Id: {0}", Thread.CurrentThread.ManagedThreadId);
            SomeMethod();
            Console.WriteLine("Main Thread code end, does not wait");
            Console.ReadKey();
        }
        static async void SomeMethod()
        {
            Console.WriteLine("Asyn code  running... 5 secsThread Id: {0}", Thread.CurrentThread.ManagedThreadId);
            await Task.Delay(5000); // This code runs on the main thred
            Console.WriteLine("Asyn code finished...Thread Id: {0}",Thread.CurrentThread.ManagedThreadId ); //Becuase syncrhronisation context is not present in console app this code will run on a different thread, But in windows forms, wpf it will not work. It is just a call back thread
        }
    }
}
