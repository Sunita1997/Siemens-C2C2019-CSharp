using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace THreadSync_Lock
{
    class CriticalSectionType
    {
        public void ChangeValue(int value, string threadName)
        {
            //Monitor.Enter(this);
            lock (this)
            {
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine($"Value for {threadName}: {value++}");
                }
            }
            //Monitor.Exit(this);
        }
    }
    class ThreadType
    {
        private static CriticalSectionType type = new CriticalSectionType();
        public void Print(object obj)
        {
            type.ChangeValue((int)obj, Thread.CurrentThread.Name);
        }
    }
    class Program
    {
        static void Main()
        {
            ThreadType threadType = new ThreadType();

            Thread printThreadFirst = new Thread(threadType.Print);

            Thread printThreadSecond = new Thread(threadType.Print);

            printThreadFirst.Name = "First Print Thread";
            printThreadSecond.Name = "Second Print Thread";

            printThreadFirst.Start(5);
            printThreadSecond.Start(10);
        }
    }
}
