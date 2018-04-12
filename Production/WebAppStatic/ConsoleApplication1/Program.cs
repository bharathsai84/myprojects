using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Implementation
    {
        Student sobj = new Student();
        Group gobj=new Group();
        public async Task Get<T>()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:53864/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            string serviceURL;
            if(typeof(T).Name=="Student")
            {
                serviceURL = "GetStudents";
            }
            else
            {
                serviceURL = "GetGroups";
            }
            HttpResponseMessage response = client.PostAsJsonAsync(serviceURL, sobj).Result;
            string result = await response.Content.ReadAsStringAsync();
        }
        public async Task Post<T>()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:53864/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            string serviceURL;
            if(typeof(T).Name == "Student")
            {
                Student sobj = new Student();
                sobj.StudentId = Int32.Parse(Console.ReadLine());
                sobj.StudentName = Console.ReadLine();
                serviceURL = "AddStudent";
                HttpResponseMessage response = client.PostAsJsonAsync(serviceURL, sobj).Result;
                Console.WriteLine(response.StatusCode);
            }
            else
            {
                Group gobj = new Group();
                gobj.GroupId = Int32.Parse(Console.ReadLine());
                gobj.GroupName = Console.ReadLine();
                serviceURL = "AddGroup";
                HttpResponseMessage response = client.PostAsJsonAsync(serviceURL, gobj).Result;

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:53864/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            Implementation impobj = new Implementation();
            Console.WriteLine("GET or POST");
            string opt = Console.ReadLine();
            switch (opt)
            {
                case "get":
                    {
                        Console.WriteLine("STUDENT or GROUP");
                        string sel = Console.ReadLine();
                        switch (sel)
                        {
                            case "stduent":
                                {
                                    impobj.Get<Student>();
                                    break;
                                }
                            case "group":
                                {
                                    impobj.Get<Group>();
                                    break;
                                }
                            case "default":
                                {
                                    Console.WriteLine("Wrong option");
                                    break;
                                }
                        }
                        break;
                    }
                case "put":
                    {
                        Console.WriteLine("Student or group");
                        string sel = Console.ReadLine();
                        switch (sel)
                        {
                            case "stduent":
                                {
                                    impobj.Post<Student>();
                                    break;
                                }
                            case "group":
                                {
                                    impobj.Post<Group>();
                                    break;
                                }
                            case "default":
                                {
                                    Console.WriteLine("Wrong option");
                                    break;
                                }
                        }
                        break;
                    }
                case "default":
                    {
                        Console.WriteLine("Wrong option");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
