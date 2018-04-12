using System;
namespace ObjectMethodsImplemetation
{
    internal class Democlass2 : Democlass1
    {
        /// <summary>
        /// This class inherits the democlass1 methods.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool DemoEquals(object obj)
        {
            if (this == obj)
                return true;
            else
                return false;
        }
        public static new bool DemoEquals(object objA, object objB)
        {
            if (objA == objB)
            {
                return true;
            }
            if (objA == null || objB == null)
            {
                return false;
            }
            return objA.Equals(objB);
        }

        public static new bool DemoReferenceEquals(object objA, object objB)
        {
            return objA == objB;
        }
    }
}