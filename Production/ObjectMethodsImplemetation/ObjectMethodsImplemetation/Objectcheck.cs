using System;
namespace ObjectMethodsImplemetation
{
    /// <summary>
    /// This method checks various cases for various class objects.
    /// </summary>
    internal class Objectcheck : Democlass2
    {
        public void Check()
        {

            int temp1 = 10, temp2 = 10;
            byte temp3 = 10;
            long temp4 = 10;
            int choice = 0;
            Democlass1 objA = new Democlass1();
            Democlass2 objB = new Democlass2();
            Objectcheck objC = new Objectcheck();
            do
            {
                Console.WriteLine("MENU\n1.Reference Equals\n2.Equals(1 instance)\n3.Equals(2 instances)\n4.Exit");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("objA==objB\t");
                        Console.WriteLine(DemoReferenceEquals(objA, objB));
                        Console.Write("objB==objB\t");
                        Console.WriteLine(DemoReferenceEquals(objB, objB));
                        Console.Write("objB==objC\t");
                        Console.WriteLine(DemoReferenceEquals(objC, objC));
                        break;
                    case 3:
                        Console.Write("objA==objB\t");
                        Console.WriteLine(DemoEquals(objA, objB));
                        Console.Write("objB==objB\t");
                        Console.WriteLine(DemoEquals(objB, objB));
                        Console.WriteLine("long to int compatabilitycheck");
                        Console.WriteLine(DemoEquals(temp4, temp1));
                        break;
                    case 2:
                        Console.Write("temp1==temp2");
                        Console.WriteLine(temp1.Equals(temp2));
                        Console.Write("temp1==temp3");
                        Console.WriteLine(temp1.Equals(temp3));
                        Console.Write("temp1==temp4");
                        Console.WriteLine(temp1.Equals(temp4));
                        break;
                    case 4:
                        choice = 4;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        choice = 4;
                        break;
                }
            } while (choice != 4);
        }
    }
}