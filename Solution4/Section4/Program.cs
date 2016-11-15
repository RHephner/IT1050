
namespace Section4
{
    class Program
    {
        static void Main(string[] args)
        {
            //P = Ticket + Concession - Discount

            System.Console.WriteLine("Thank you for choosing the Cinemamark Theater!");
            System.Console.WriteLine("You're our favorite customer.");
            System.Console.WriteLine("Our current film is Tommy Wiseau's The Room...");
            System.Console.Write("Will you be attending a Matinee or Evening Showtime: ");
            string time = System.Console.ReadLine().ToLower();

            if (time != "matinee" & time != "evening")
            {
                System.Console.WriteLine("Ha Ha, What a Story. That isnt a showtime!");
                System.Console.Read();
                return;
            }

            System.Console.WriteLine("Great. How many Adult tickets?:");
            int ticketReg = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("OK, how many Child tickets?:");
            int ticketJr = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Excellent, and how many Senior tickets?:");
            int ticketSr = int.Parse(System.Console.ReadLine());

            decimal totalPrice = 0;

            if (time == "matinee")
            {
                totalPrice += (ticketReg * 5.99m);
                totalPrice += (ticketJr * 3.99m);
                totalPrice += (ticketSr * 4.50m);
            }
            else
            {
                totalPrice += (ticketReg * 10.99m);
                totalPrice += (ticketJr * 6.99m);
                totalPrice += (ticketSr * 8.50m);
            }

                System.Console.WriteLine("Here are your tickets. How many small sodas?");
                int sodaS = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine("OK, how many large sodas:");
                int sodaL = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine("Great, how many hotdogs would you like:");
                int hotDog = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine("How many popcorns would you like:");
                int popCorn = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine("Excellent, and how many Candies?:");
                int candy = int.Parse(System.Console.ReadLine());

                totalPrice += (sodaS * 3.50m);
                totalPrice += (sodaL * 5.99m);
                totalPrice += (hotDog * 3.99m);
                totalPrice += (popCorn * 4.50m);
                totalPrice += (candy * 1.99m);


           //Only 1 discount per ticket, discount is smallest of 3 numbers * $2.00
            int ticketCount = ticketReg + ticketJr + ticketSr;

            int lesserAmount = System.Math.Min(sodaL, popCorn);
            int ticketDiscount = System.Math.Min(lesserAmount, ticketCount);

            if (ticketDiscount >= 1)
                {
                totalPrice -= (ticketDiscount * 2.00m);
                }



            //if 3 or more tickets for evening time and 1 popcorn, subtract $4.50
            int popcornDiscount = 0;
            if (ticketCount >= 3)
            {
                if (time == "evening")

                {
                    if (popCorn >=1)
                    {
                        totalPrice -= 4.50m;
                        popcornDiscount = 1;
                    }
                }

            }

            


            //for each 4 candies purchased, remove $1.99 from total 
            int candyDiscount = candy / 4;
            if (candyDiscount >= 1)
            {
                totalPrice -= (candyDiscount * 1.99m);
            }


            int numberOfDiscounts = ticketDiscount + candyDiscount + popcornDiscount;

            System.Console.WriteLine("You applied for " + numberOfDiscounts + " Discounts!!");
            System.Console.WriteLine("===========================");
            System.Console.WriteLine("Your total cost is: $" + totalPrice);
            System.Console.WriteLine("Thank you for visiting CinemaMark Theater!");
            System.Console.WriteLine("Buh-bye!");
            System.Console.ReadKey();
        }
    }
    }

