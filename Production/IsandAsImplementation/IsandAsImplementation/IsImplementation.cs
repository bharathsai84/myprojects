using System;
namespace IsandAsImplementation
{
    /// <summary>
    /// This class checks for is 
    /// implentation in interger and double types.
    /// </summary>
    internal class IsImplementation
    {
        /// <summary>
        /// This function checks integer and double's is implementation.
        /// </summary>
        public void isImplmentation()
        {
            bool flag = true;
            while (flag)
            {

                int choice;
                Console.WriteLine("1.For Integer Types\n2.For Double Types");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("Enter an integer value");
                            int temp = int.Parse(Console.ReadLine());
                            string str1 = temp.GetType().ToString();
                            //Console.WriteLine(s);
                            if (str1 == "System.Int32")
                            {
                                Console.WriteLine(true);
                            }
                        }
                        catch
                        {
                            Console.WriteLine(false);
                        }
                        break;
                    case 2:
                        try
                        {

                            double temp1 = Convert.ToDouble(Console.ReadLine());
                            string str2 = temp1.GetType().ToString();
                            if (str2 == "System.Double")
                            {
                                Console.WriteLine(true);
                            }
                        }
                        catch
                        {
                            Console.WriteLine(false);
                        }
                        break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        flag = false;
                        break;

                }
            }
        }
    }
}