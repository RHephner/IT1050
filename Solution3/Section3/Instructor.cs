
namespace Section3
{
    class Instructor
    {
        private string Name;
        private string CourseName;

        public Instructor(string InstructorName, string InstructorCourseName)
        {
            this.Name = InstructorName;
            this.CourseName = InstructorCourseName;


        }

        public void SetStudentGrade(Student student, int grade)
        {
            student.SetGrade(grade);

        }

        public void Print()
        {
            string output = Name;
            
            output += " ";
            output += CourseName;

            System.Console.WriteLine(output);

        }
    }
}
