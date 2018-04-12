using System;
namespace GenericSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            Execute exeobject = new Execute();
            exeobject.Run();
            Console.ReadKey();
        }
    }
}
