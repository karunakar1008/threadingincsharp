using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace asynawaitdemo.Step4
{

    class Employee
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Main thread Started");

            GetAllEmployeeetails();
            Console.WriteLine("Main thread do not wait for worker thread to be completed");

            Console.ReadKey();

        }

        public static async void GetAllEmployeeetails()
        {
            for (int i = 1; i <= 4; i++)
            {
              await  RunMetodOnDifferentThread(i);
            }

        }

        public static async Task  RunMetodOnDifferentThread(int index)
        {
            Console.WriteLine("Database call No : {0}", index);

            Console.WriteLine("New Thread started at: {0}", DateTime.Now);

            await Task.Run(new Action(GetEmployeeDetails));

            Console.WriteLine("New Thread end at: {0}", DateTime.Now);

        }
        public static void GetEmployeeDetails()
        {
            Console.WriteLine("Long running method to get employee details and it will run on a single thread is processing.....");

            Thread.Sleep(5000);
            Console.WriteLine("Long running method is processing completed");


        }
    }
}
