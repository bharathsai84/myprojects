using System;
namespace ObjectMethodsImplemetation
{
    /// <summary>
    /// This class contains the methods of the object class.
    /// </summary>
    internal class Democlass1
    {
        public virtual bool DemoEquals(object obj)
        {
            if (this == obj)
                return true;
            else
                return false;
        }
        public static bool DemoEquals(object objA, object objB)
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

        public static bool DemoReferenceEquals(object objA, object objB)
        {
            return objA == objB;
        }
    }
}