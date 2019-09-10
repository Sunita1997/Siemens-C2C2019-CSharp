using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadingDemo
{
    class Program
    {
        static void Run()
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} Id: {Thread.CurrentThread.ManagedThreadId}");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Run Thread. Value: {i}");
            }
        }
        static void Main()
        {
            Console.WriteLine($"Main Thread Id: {Thread.CurrentThread.ManagedThreadId}");
            ThreadStart runDelegate = new ThreadStart(Run);
            Thread runThread = new Thread(runDelegate);
            runThread.Name = $"{nameof(Run)} Thread";
            runThread.Start();
            runThread.Join();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Main Thread. Value: {i}");
            }
        }
    }
}
