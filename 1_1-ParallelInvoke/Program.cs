using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1_1_ParallelInvoke
{
    class Program
    {
        static void Task1()
        {
            Console.WriteLine("Starting Task 1...");
            Thread.Sleep(2000);
            Console.WriteLine("Finishing Task 1...");
        }

        static void Task2()
        {
            Console.WriteLine("Starting Task 2...");
            Thread.Sleep(1000);
            Console.WriteLine("Finishing Task 2...");
        }

        static void Main(string[] args)
        {
            Parallel.Invoke(() => Task1(), () => Task2());
            Console.WriteLine("Both Tasks finished.");
            Console.ReadKey();
        }
    }
}
