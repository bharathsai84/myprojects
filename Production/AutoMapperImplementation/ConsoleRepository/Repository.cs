using System;
using DataAccess;
namespace ConsoleRepository
{
    /// <summary>
    /// This class replicates the functionality of an AutoMapper.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="U"></typeparam>
    public class Mapper<T, U> where T : class where U : class
    {
        public U Map(T src, U dest)
        {
            var source = src.GetType();
            var destination = dest.GetType();
            foreach (var sourcePropertyInfo in source.GetProperties())
            {
                var destinationPropertyInfo = destination.GetProperty(sourcePropertyInfo.Name);
                object destinationobj, sourceobj;
                if (destinationPropertyInfo.PropertyType.IsClass && destinationPropertyInfo.PropertyType.Name != "String") //Checks if the destinationpropertyinfo is a class or not.
                {

                    sourceobj = sourcePropertyInfo.GetValue(src);
                    destinationobj = Activator.CreateInstance(destinationPropertyInfo.PropertyType);
                    destinationobj = Map((T)sourceobj, (U)destinationobj);
                    destinationPropertyInfo.SetValue(dest, destinationobj);
                }
                else
                {
                    destinationPropertyInfo.SetValue(dest, sourcePropertyInfo.GetValue(src));
                }
            }
            return dest;
        }
    }
    public class Repository
    {
        Student studentobject = new Student();
        object referenceobject;
        public Repository(object o)
        {
            referenceobject = o;
        }
        /// <summary>
        /// This method is used for creating a mapper object and call the map function.
        /// </summary>
        public void Execute()
        {
            Mapper<object, object> mapperobject = new Mapper<object, object>();
            mapperobject.Map(referenceobject, studentobject);
        }
        /// <summary>
        /// This method prints the values at the Destination.
        /// </summary>
        public void Print()
        {
            Console.WriteLine("Student properties");
            Console.WriteLine(studentobject.idNumber);
            Console.WriteLine(studentobject.name);
            Console.WriteLine("Teacher Properties");
            Console.WriteLine(studentobject.Tobj.teacherId);
            Console.WriteLine(studentobject.Tobj.teacherName);
        }
    }
}
