namespace DomainLayer
{
    public class StudentDTO
    {
        public int idNumber { get; set; }
        public string name { get; set; }
        public TeacherDTO Tobj { get; set; }
    }
    public class TeacherDTO
    {
        public int teacherId { get; set; }
        public string teacherName { get; set; }
    }
}
