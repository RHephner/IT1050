
namespace Section3
{
    class Program
    {
        static void Main(string[] args)
        {

            Instructor John = new Instructor("John Henry","English");
            Instructor Mike = new Instructor("Mike Mulligan", "Math");

            Student Jane = new Student("Jane Smith", John);
            Student Joe = new Student("Joe Johnson", John);
            Student Melissa = new Student("Melissa Williams", Mike);
            Student Matt = new Student("Matt Monahugh", Mike);

            John.SetStudentGrade(Jane, 95);
            John.SetStudentGrade(Joe, 85);
            Mike.SetStudentGrade(Melissa, 90);
            Mike.SetStudentGrade(Matt, 92);

            Jane.PrintStudent();
            Joe.PrintStudent();
            Melissa.PrintStudent();
            Matt.PrintStudent();
            System.Console.Read();
        }
    }
}
