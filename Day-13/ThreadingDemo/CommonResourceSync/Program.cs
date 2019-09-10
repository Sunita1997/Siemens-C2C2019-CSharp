using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CommonResourceSync
{
    class CommonResourceType
    {
        public static int commonData = 0;
        public static Mutex Mutex = new Mutex();
    }
    class Incrementer
    {
        public void Increment(object count)
        {
            CommonResourceType.Mutex.WaitOne();

            Console.WriteLine($"Id of Thread: {Thread.CurrentThread.Name} is {Thread.CurrentThread.ManagedThreadId}");
            for (int i = 0; i < (int)count; i++)
            {
                Thread.Sleep(1000);
                CommonResourceType.commonData++;
                Console.WriteLine($"{Thread.CurrentThread.Name} has increased value to {CommonResourceType.commonData}");
            }

            CommonResourceType.Mutex.ReleaseMutex();
        }
    }
    class Decrementer
    {
        public void Decrement(object count)
        {
            CommonResourceType.Mutex.WaitOne();

            Console.WriteLine($"Id of Thread: {Thread.CurrentThread.Name} is {Thread.CurrentThread.ManagedThreadId}");
            for (int i = 0; i < (int)count; i++)
            {
                Thread.Sleep(1000);
                CommonResourceType.commonData--;
                Console.WriteLine($"{Thread.CurrentThread.Name} has decreased value to {CommonResourceType.commonData}");
            }

            CommonResourceType.Mutex.ReleaseMutex();
        }
    }
    class Program
    {
        static void Main()
        {
            ParameterizedThreadStart incrementDelegate =
                new ParameterizedThreadStart(new Incrementer().Increment);
            Thread incrementThread = new Thread(incrementDelegate);
            incrementThread.Name = $"{(typeof(Incrementer).GetMethod("Increment").Name)} Thread";

            ParameterizedThreadStart decrementDelegate =
                new ParameterizedThreadStart(new Decrementer().Decrement);
            Thread decrementThread = new Thread(decrementDelegate);
            decrementThread.Name = $"{(typeof(Decrementer).GetMethod("Decrement").Name)} Thread";

            incrementThread.Start(5);
            //incrementThread.Join();
            decrementThread.Start(5);
            //decrementThread.Join();
        }
    }
}
