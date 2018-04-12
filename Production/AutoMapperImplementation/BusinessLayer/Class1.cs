using ConsoleRepository;
namespace BusinessLayer
{
    public class Class1
    {
        Repository repoobject;
        public Class1(object o)
        {
            repoobject = new Repository(o);
        }
        public void Run()
        {
            repoobject.Execute();
            repoobject.Print();
        }
    }
}
