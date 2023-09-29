namespace Day_1.Models
{

    public static class StudentList
    {
        public static List<Student> Students;

        static StudentList()
        {
            Console.WriteLine("Constructor Invoked");
            Students = new List<Student>();
            Students.Add(new Student() { ID= 1, Name= "Mohamed", Address="Anything", Image=""});
            Students.Add(new Student() { ID= 2, Name= "Ibrahim", Address="Anything", Image=""});
            Students.Add(new Student() { ID= 3, Name= "Mohamed", Address="Anything2", Image=""});
            Students.Add(new Student() { ID= 4, Name= "Ahmed", Address="Anything", Image=""});
        }

    }
}
