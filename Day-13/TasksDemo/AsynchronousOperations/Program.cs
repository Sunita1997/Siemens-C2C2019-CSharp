using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchronousOperations
{
    class Program
    {
        static async Task<string> Run(Func<string> del)
        {
            //Func<string> op = () => "hello";
            //Thread.Sleep(1000);
            //return await Task<string>.Run<string>(op);
            return await Task<string>.Run(del);
        }
        static void Main()
        {
            Task<string> task = Run(() => "hello");
            Console.WriteLine(task.Result);
            Console.WriteLine($"doing my job");


            task.ContinueWith((t) => Task.Run(()=>"hi"));
        }
    }
}
