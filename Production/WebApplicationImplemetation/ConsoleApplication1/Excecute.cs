using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// This class helps in selecting the operations to be performed.
    /// </summary>
    internal class Execute
    {
        public void Run()
        {
            int temp1 = 0, temp2 = 0;
            Implementation implementobject;
            Console.WriteLine("Select an option");
            Console.WriteLine("1.GET\n2.POST");
            temp1 = Int32.Parse(Console.ReadLine());
            switch (temp1)
            {
                case 1:
                    {
                        Console.WriteLine("Select an option");
                        Console.WriteLine("1.STUDENT\n2.GROUP");
                        temp2 = int.Parse(Console.ReadLine());
                        switch (temp2)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Enter Student Id(id|0):");
                                    int id = Convert.ToInt32(Console.ReadLine());
                                    if (id == 0)
                                    {
                                        implementobject = new Implementation("http://localhost:53864/api/values/GetStudents", "application/json");
                                        Task<IEnumerable<Student>> ls = implementobject.Get<Student>();
                                        foreach (Student s in ls.Result)
                                        {
                                            Console.WriteLine("StudentId:" + s.StudentId);
                                            Console.WriteLine("StudentName:" + s.StudentName);
                                        }
                                    }
                                    else
                                    {
                                        implementobject = new Implementation("http://localhost:53864/api/values/GetStudentbyId", "application/json");
                                        Task<Student> s = implementobject.Get<Student>(id.ToString());
                                        Student st = s.Result;
                                        Console.WriteLine("StudentId:" + st.StudentId);
                                        Console.WriteLine("StudentName:" + st.StudentName);
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine("Enter Group Id(id|0):");
                                    int id = Convert.ToInt32(Console.ReadLine());
                                    if (id == 0)
                                    {
                                        implementobject = new Implementation("http://localhost:53864/api/values/GetGroups", "application/json");
                                        Task<IEnumerable<Group>> ls = implementobject.Get<Group>();
                                        foreach (Group g in ls.Result)
                                        {
                                            Console.WriteLine("GroupId:" + g.GroupId);
                                            Console.WriteLine("GroupName:" + g.GroupName);
                                        }
                                    }
                                    else
                                    {
                                        implementobject = new Implementation("http://localhost:53864/api/values/GetGroupbyId", "application/json");
                                        Task<Group> g = implementobject.Get<Group>(id.ToString());
                                        Group gp = g.Result;
                                        Console.WriteLine("GroupId:" + gp.GroupId);
                                        Console.WriteLine("GroupName:" + gp.GroupName);
                                    }
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Wrong option");
                                    break;
                                }
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Select an option\n");
                        Console.WriteLine("1.STUDENT\n2.GROUP");
                        temp2 = Int32.Parse(Console.ReadLine());
                        switch (temp2)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Enter Student Name:");
                                    string name = Console.ReadLine();
                                    Console.WriteLine("Enter Student Id:");
                                    int id = Convert.ToInt32(Console.ReadLine());
                                    Student sObj = new Student() { StudentId = id, StudentName = name };
                                    implementobject = new Implementation("http://localhost:53864/api/values/AddStudent", "application/json");
                                    Task<string> str = implementobject.Post<Student>(sObj);
                                    string response = str.Result;
                                    Console.WriteLine("Status:" + response);
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine("Enter Group Name:");
                                    string name = Console.ReadLine();
                                    Console.WriteLine("Enter Group Id:");
                                    int id = Convert.ToInt32(Console.ReadLine());
                                    Group gObj = new Group() { GroupId = id, GroupName = name };
                                    implementobject = new Implementation("http://localhost:53864/api/values/AddGroup", "application/json");
                                    Task<string> str = implementobject.Post<Group>(gObj);
                                    string response = str.Result;
                                    Console.WriteLine("Status:" + response);
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Wrong option");
                                    break;
                                }
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Wrong option");
                        break;
                    }
            }
        }
    }
}