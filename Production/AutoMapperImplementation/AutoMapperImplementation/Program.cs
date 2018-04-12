using System;
using DomainLayer;
using BusinessLayer;
namespace AutoMapperImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentDTO studentDTOobject = new StudentDTO() { idNumber = 3164, name = "BHARATH", Tobj = new TeacherDTO() { teacherId = 1234, teacherName = "SAI" } };
            Class1 businessobject = new Class1(studentDTOobject);
            businessobject.Run();
            Console.ReadKey();
        }
    }
}
