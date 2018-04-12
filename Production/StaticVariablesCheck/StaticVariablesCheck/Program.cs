using System;
namespace StaticVariablesCheck
{
    public class Program
    {
        static int CheckVariable()
        {
            StaticAcorssMultipleProcesses.Program.i++;
            return StaticAcorssMultipleProcesses.Program.i;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CheckVariable());
            Console.ReadLine();
        }
    }
}
