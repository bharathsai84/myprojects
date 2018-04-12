using System;
using System.Diagnostics;
namespace StaticAcorssMultipleProcesses
{
    class Program
    {
        public static int temp = 1;
        static void Main(string[] args)
        {
            Process process1, process2;
            process1 = new Process();
            process1.StartInfo.FileName = @"C:\Users\saibharath.gudimella\Documents\Visual Studio 2015\Projects\StaticVariablesCheck\StaticVariablesCheck\bin\Debug\StaticVariablesCheck.exe";
            process1.Start();
            process2 = new Process();
            process2.StartInfo.FileName = @"C:\Users\saibharath.gudimella\Documents\Visual Studio 2015\Projects\StaticVariablesCheck\StaticVariablesCheck\bin\Debug\StaticVariablesCheck.exe";
            process2.Start();
            Console.WriteLine("The value in main method:" + temp);
            Console.ReadLine();
        }
    }
}
