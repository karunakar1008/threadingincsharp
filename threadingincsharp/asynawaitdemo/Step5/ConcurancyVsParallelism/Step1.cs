using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace asynawaitdemo.Step5.ConcurancyVsParallelism
{
    class Step1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Concurancy(async or await): ------------------------Differences---------------------------------: Parallel library");

            Console.WriteLine("Runing multiple tasks parallely on a single core-------------------------------Runing multiple tasks parallely on multple cores");
            Console.WriteLine("It is just a feel of parallel execution but really context switiching-------- -It is a real Parallel execution of multiple tasks");
            Console.WriteLine("Intention: Useability or non blocking ui during long running methods-----------To utilize te performance of system");
            Console.WriteLine("Concurant applications are undeterministic------------------------------- out put can be deterministic");
            Console.WriteLine("We can improve usability------------------------------------------------------------- Improper use leads to low performanace(implement only when functions does not communicate each other)");

            Console.WriteLine("It is all about how the different functions communicate each other------------------------------- It is all about improve the f=performance");

            Console.WriteLine("It is all about Software design how the different computations communicate,copoerate  each other------------------------------- Hard ware utilization: It is all about improve the performance");


            Console.WriteLine("Concurancy: ------------------------Differences---------------------------------: Parallel library");

            Console.WriteLine("Mixing both with leads to bad design some times");


        }

      
    }
}
