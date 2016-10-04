namespace Section2
{
    public class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;

        public static double SumOfAllAges;
        public static int Counter;
        //sum of all ages divided by number of people
        //Person.SumOfAllAges +=p1.Age

        public static double AverageAge()
        {

            return Person.SumOfAllAges / Person.Counter;

        }


        public void PersonInfo()
        {
            System.Console.Write("Enter Your First Name:   ");
            FirstName = System.Console.ReadLine();

            System.Console.Write("Enter Your Last Name:    ");
            LastName = System.Console.ReadLine();

            System.Console.Write("Enter Your Age:          ");
            Age = int.Parse(System.Console.ReadLine());

            Person.Counter++;
            Person.SumOfAllAges += Age;
        }

        public void SpouseInfo()
        {
           
            System.Console.Write("Spouse Name:  ");
            Spouse.FirstName = System.Console.ReadLine();

            System.Console.Write("Spouse Age:   ");
            Spouse.Age = int.Parse(System.Console.ReadLine());

            Person.Counter++;
            Person.SumOfAllAges += Spouse.Age;
        }


        public string GetFullName()
        {
            return LastName + ", " + FirstName;

        }

        public string GetSpouseFullName()
        {
            return Spouse.FirstName + ", " + this.LastName;
        }


        public void PrintNameAndAge()
        {
            System.Console.WriteLine(GetFullName() + "  "  + "(" + this.Age + ")");
            System.Console.WriteLine(GetSpouseFullName() + "  " + "(" + this.Spouse.Age + ")");

        }

        

    }
}
