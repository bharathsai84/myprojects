using System;
namespace IsandAsImplementation
{
    /// <summary>
    /// This class shows as impelmentation.
    /// </summary>
    internal class AsImplementation
    {
        /// <summary>
        /// This function checks string and object's as implementation.
        /// </summary>
        public void asImplmentation()
        {
            string str = "ASIMPLEMENTATION";
            object obj = new object();
            if (str.GetType().BaseType.Equals(obj.GetType()))
            {
                Console.WriteLine(str.GetType().BaseType);
                Console.Write(str);
            }
            else
            {
                Console.WriteLine("null");
            }
            Console.ReadLine();
        }
    }
}