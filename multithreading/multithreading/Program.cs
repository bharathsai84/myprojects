using System;
using System.Threading;
namespace multithreading
{
    class Program
    {
        public static void Main()
        {
            int temp1 = 0;
            ThreadExecution obj = new ThreadExecution();
            Thread thread1 = new Thread(() => obj.OutMethod(out temp1));
            Console.WriteLine("Some thing in the main will be excecuted");
            thread1.Start();
            Thread.Sleep(100);
            Console.WriteLine("The value passed in out is:" + temp1);
            Console.ReadLine();
        }

    }
}
