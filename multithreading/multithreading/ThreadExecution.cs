using System;
using System.Threading;
namespace multithreading
{
    internal class ThreadExecution
    {
        /// <summary>
        /// This method shows implementation using out parameter.
        /// </summary>
        /// <param name="temp"></param>
        public void OutMethod(out int temp)
        {
            Console.WriteLine("Now you are in out method");
            Thread.Sleep(100);
            temp = 100;
            Console.WriteLine("The value after intilization in out is:" + temp);
        }
    }
}