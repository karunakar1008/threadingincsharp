using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace asynawaitdemo.Step4
{
    
    class Customer
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Main thread Started");

            GetAllCustomertails();
            Console.WriteLine("Main thread do not wait for worker thread to be completed");

            Console.ReadKey();

        }

        public static async void GetAllCustomertails()
        {
            Console.WriteLine("Fetch Employee Details one by one");

            for (int i = 1; i <= 4; i++)
            {
                await RunMetodOnDifferentThread(i);
            }

            Console.WriteLine("All employee details are fetced successfully!");
        }

        public static async Task RunMetodOnDifferentThread(int index)
        {

            Console.WriteLine("New Thread started at: {0}", DateTime.Now);

            //await Task.Run(new Action(()=>GetCustomerDetails(index)));

            await Task.Run(() => GetCustomerDetails(index));
            await Task.Run(() => ProcessCustomer());

            Console.WriteLine("New Thread end at: {0}", DateTime.Now);

        }
        public static void GetCustomerDetails(int customerId)
        {
            Console.WriteLine("Database call long processsing ");
            Thread.Sleep(5000);
            Console.WriteLine("Customer Id: {0}", customerId);

        }

        public static void ProcessCustomer()
        {
            Thread.Sleep(2000);

        }
    }

}
