
namespace Section5
{
    class Program
    {
        static void Main(string[] args)
        {
            Board b = new Board(8);
            b.Fill();
            b.Print();
            System.Console.ReadKey();
        }
    }
}
