namespace Section1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string middleInitial;
            string lastName;
            string fullName;
            int age;
            bool isCitizen;
            bool canVote;
            int heightFeet;
            double heightInches;
            double totalHeightCM;


            System.Console.Write("What is your first name?");
            firstName = System.Console.ReadLine();

            System.Console.Write("What is your middle initial?");
            middleInitial = System.Console.ReadLine();

            System.Console.Write("What is your last name?");
            lastName = System.Console.ReadLine();


            fullName = firstName + " " + middleInitial + ". " + lastName;

            System.Console.Write("What is height in feet? (4, 5, 6 etc...)");
            heightFeet = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many inches are you beyond your base height in feet?");
            heightInches = double.Parse(System.Console.ReadLine());

            totalHeightCM = ((heightFeet * 12) + heightInches) * 2.54;

            System.Console.Write("What is your age?");
            age = int.Parse(System.Console.ReadLine());

            System.Console.Write("True or false: are you a citizen of this country?");
            isCitizen = bool.Parse(System.Console.ReadLine());

            canVote = age >= 18 && isCitizen;

            System.Console.WriteLine("Hello, " + fullName);
            System.Console.WriteLine("Your Height is: " + totalHeightCM);
            System.Console.WriteLine("It is " + canVote + " that you are eligible to vote");
            System.Console.ReadKey();

        }
    }
}
