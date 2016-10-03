namespace Section2
{
    public class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;

        public static double SumOfAllAges;
        
            //sum of all ages divided by number of people
            //Person.SumOfAllAges +=p1.Age
            //Github work already..
        
        public string GetFullName()
        {
            return FirstName + " " + LastName;

        }


               
        public void PrintNameAndAge()
        {
            System.Console.WriteLine(GetFullName() + "  "  + "{" + this.Age + "}");
            System.Console.WriteLine(Spouse.GetFullName() + "  " + "{" + this.Spouse.Age + "}");


        }
    }
}
