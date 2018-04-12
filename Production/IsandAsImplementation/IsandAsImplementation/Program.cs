using System;
namespace IsandAsImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("1.Is Implmentation\n2.As Implemetation");
            choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    IsImplementation obj = new IsImplementation();
                    obj.isImplmentation();
                    break;
                case 2:
                    AsImplementation obj1 = new AsImplementation();
                    obj1.asImplmentation();
                    break;
                default:
                    Console.WriteLine("wrong choice");
                    break;
            }
            Console.ReadKey();
        }
    }
}
