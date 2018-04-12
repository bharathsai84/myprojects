namespace DataAccess
{
    public class Student
    {
        public int idNumber { get; set; }
        public string name { get; set; }
        public Teacher Tobj { get; set; }
    }
    public class Teacher
    {
        public int teacherId { get; set; }
        public string teacherName { get; set; }
    }
}
