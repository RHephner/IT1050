
namespace Section5
{
    class Board
    {
        public int Size;
        public string[][] Grid;

        public Board(int size)
        {
            this.Size = size;
            this.Grid = new string[size][];

            for (int i=0; i < size; i++)
            {
                this.Grid[i] = new string[size];
            }
        }

        public void Fill()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    this.Grid[i][j] = "X ";
                }
            }    
        }

        //public void RemoveExtra()
        //{
        //    for (int i = 2; i <= 5; i++)
        //    {
        //        for (int j = 0; j < 8; j++)
        //        {
        //            this.Grid[i][j] = "  ";
        //        }
        //    }
        //}

        public void Print()
        {
            foreach (string[] row in Grid)
            {
               
                System.Console.WriteLine();
               
                System.Console.WriteLine("+---+---+---+---+---+---+---+---+");
                foreach (string stringValue in row)
                {
                    
                    System.Console.Write("| ");
                    System.Console.Write(stringValue);
                   
                }

                System.Console.Write("|");
                
                
            }
            System.Console.WriteLine();
            System.Console.WriteLine("+---+---+---+---+---+---+---+---+");
        }

    }
}
