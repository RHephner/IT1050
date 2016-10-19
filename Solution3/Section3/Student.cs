
namespace Section3
{
    class Student
    {

        private string Name;
        private int Grade;
        private Instructor Teacher;

    public Student(string name,Instructor teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
        }
     public Student()
        {
        Grade = 0;

        }
  
     public int SetGrade()
        {
          return this.Grade;
        }

     public void Print()
        {

        }


    }
}
